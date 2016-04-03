using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Threading;

namespace DungeonCrwl
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D smileyImage;
        Vector2 smileyPosition;

        Thread mainThread;
        DungeonCrwlMain.DungeonCrwlMain main;
        MonoResponder responder;

        public Color BackgroundColor { get; set; } = Color.GreenYellow;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Set the starting position
            //smileyPosition = new Vector2(0.0f, 0.0f);
            smileyPosition = Vector2.Zero;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Loads the Smiley.png into the smileyImage variable
            smileyImage = Content.Load<Texture2D>("Smiley");

            main = new DungeonCrwlMain.DungeonCrwlMain();
            responder = new MonoResponder(this);
            mainThread = new Thread(new ThreadStart(mainThreadStart));
            mainThread.Start();
        }

        void mainThreadStart()
        {
            main.Run(responder);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 1000.0f;
            float moveAmount = speed * time;
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.Down))
            {
                //smileyPosition.Y = smileyPosition.Y + 1000.0f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                smileyPosition.Y += moveAmount;
            }
            if (state.IsKeyDown(Keys.Up))
            {
                //smileyPosition.Y = smileyPosition.Y - 1000.0f * (float)gameTime.ElapsedGameTime.TotalSeconds;
                smileyPosition.Y -= moveAmount;
            }
            if (state.IsKeyDown(Keys.Left))
            {
                smileyPosition.X -= moveAmount;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                smileyPosition.X += moveAmount;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(BackgroundColor);

            // Draw our sprite
            spriteBatch.Begin();
            spriteBatch.Draw(smileyImage, smileyPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
