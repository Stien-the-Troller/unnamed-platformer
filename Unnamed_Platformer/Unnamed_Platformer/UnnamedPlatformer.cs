using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Unnamed_Platformer.GameStates;

namespace Unnamed_Platformer
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class UnnamedPlatformer : GameEnvironment
    {
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen = new Point(800, 550);
            ApplyResolutionSettings();

            // TODO: use this.Content to load your game content here
            GameStateManager.AddGameState("playingstate", new PlayingState());
            GameStateManager.AddGameState("gameover", new GameOver());
            GameStateManager.AddGameState("titlescreen", new Titlescreen());
            GameStateManager.AddGameState("victory", new Victory());
            gameStateManager.SwitchTo("playingstate");
        }
    }
}
