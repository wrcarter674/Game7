using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input; 

namespace ParallaxStarter
{
    /// <summary>
    /// Class representing a single parallax layer
    /// </summary>
    public class ParallaxLayer : DrawableGameComponent
    {
        /// <summary>
        /// Lisr of ISprites that compose this parallax layer
        /// </summary>
        public List<ISprite> Sprites = new List<ISprite>();

        // <summary>
        /// The SpriteBatch to use to draw the layer
        /// </summary>
        SpriteBatch spriteBatch;

        /// <summary>
        /// Constructs the ParallaxLayer instance 
        /// </summary>
        /// <param name="game">The game this layer belongs to</param>
        public ParallaxLayer(Game game) : base(game)
        {
            spriteBatch = new SpriteBatch(game.GraphicsDevice);
        }

        /// <summary>
        /// Draws the Parallax layer
        /// </summary>
        /// <param name="gameTime">The GameTime object</param>
        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, ScrollController.Transform);
            foreach (var sprite in Sprites)
            {
                sprite.Draw(spriteBatch, gameTime);
            }
            spriteBatch.End();
        }

        /// <summary>
        /// The controller for this scroll layer
        /// </summary>
        public IScrollController ScrollController { get; set; } = new AutoScrollController();

        /// <summary>
        /// Updates the ParallaxLayer
        /// </summary>
        /// <param name="gameTime">the GameTime object</param>
        public override void Update(GameTime gameTime)
        {
            ScrollController.Update(gameTime);
        }

    }
}
