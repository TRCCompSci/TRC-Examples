using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Timers;


namespace Bricks
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SpriteFont font;

        Texture2D imgBall;

        Vector2 ballPosition;
        Vector2 ballMovement;

        Timer keytime = new Timer();
        bool key = false;

        bool ballInMotion = false;

        public double Magnitude(Vector2 vector)
        {
            double value = 0;

            //perform your vector calculation here
            //Math.Pow(x,2) and Math.Sqrt(x) can raise to power of 2 & find square root

            return value;
        }

        public Vector2 Scale(Vector2 vector, float scalar)
        {
            //perform your calculation to scalar the vector passed

            return vector;
        }

        public Vector2 Add(Vector2 vector1, Vector2 vector2)
        {
            Vector2 newVector = new Vector2(0, 0);

            //perform your calculation so that newVector = vector1 + vector2

            return newVector;
        }

        public Vector2 Subtract(Vector2 vector1, Vector2 vector2)
        {
            Vector2 newVector = new Vector2(0, 0);

            //perform your calculation so that newVector = vector1 - vector2

            return newVector;
        }

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 400;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

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

            // TODO: use this.Content to load your game content here
            imgBall = Content.Load<Texture2D>("Ball");
            font = Content.Load<SpriteFont>("Italic");
            keytime.Enabled = false;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            keytime.Enabled= false;
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

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !keytime.Enabled)
            {
                keytime.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                keytime.Interval = 500;
                keytime.Enabled = true;

                if (!ballInMotion)
                {
                    ballInMotion = true;
                    //set this vector to serve the ball
                    ballMovement = new Vector2(10, 10);
                }
                else
                {
                    ballInMotion = false;
                    //set this vector to serve the ball
                    ballMovement = new Vector2(0, 0);
                }
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.A) && ballInMotion)
            {
                //Scale vector up
                ballMovement = Scale(ballMovement, 1.5f);
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.S) && ballInMotion)
            {
                //Scale vector down
                ballMovement = Scale(ballMovement, 0.5f);
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.D) && ballInMotion)
            {
                //Add to current ball movement vector
                ballMovement = Add(ballMovement, new Vector2(1,1));
            }

            else if (Keyboard.GetState().IsKeyDown(Keys.F) && ballInMotion)
            {
                //Subtract from current ball movement vector
                ballMovement = Subtract(ballMovement, new Vector2(1, 1));
            }

            if (!ballInMotion)
                //set this vector for the starting position of the ball
                //this is currently the centre of the screen
                ballPosition = new Vector2((graphics.PreferredBackBufferWidth/2)-(imgBall.Width/2),
                    (graphics.PreferredBackBufferHeight / 2) - (imgBall.Height / 2));
            else
                ballPosition += ballMovement;

            //check for bounce off the walls
            if (ballPosition.X <= 0 || ballPosition.X >= graphics.PreferredBackBufferWidth - imgBall.Width)
                ballMovement = new Vector2(-(ballMovement.X), ballMovement.Y);
            if (ballPosition.Y <= 0 || ballPosition.Y >= graphics.PreferredBackBufferHeight - imgBall.Height)
                ballMovement = new Vector2(ballMovement.X, -(ballMovement.Y));

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(imgBall, ballPosition);
            if (ballInMotion)
            {
                spriteBatch.DrawString(font, "Magnitude: " + Magnitude(ballMovement), new Vector2(5, 0), Color.Black);
                spriteBatch.DrawString(font, "Ball Vector: " + ballMovement, new Vector2(5, 100), Color.Black);
            }
            else
            {
                spriteBatch.DrawString(font, "Press space to serve", new Vector2(5, 0), Color.Black);
                spriteBatch.DrawString(font, "Press A to Scale UP", new Vector2(5, 40), Color.Black);
                spriteBatch.DrawString(font, "Press S to Scale Down", new Vector2(5, 80), Color.Black);
                spriteBatch.DrawString(font, "Press D to Add (1,1)", new Vector2(5, 120), Color.Black);
                spriteBatch.DrawString(font, "Press F to Subtract (1,1)", new Vector2(5, 160), Color.Black);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
