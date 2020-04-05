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
    /// Interface representing the a sprite to be drawn with a spritebatch
    /// </summary>
    public interface ISprite
    {
        /// <summary>
        /// Draws the ISprite. This method should be invoked between calls to 
        /// SpriteBatch.Begin() and SpriteBatch.End() with the supplied SpriteBatch
        /// </summary>
        /// <param name="spriteBatch">The SpriteBatch to draw with</param>
        /// <param name="gameTime">The Gametime Object</param>
        void Draw(SpriteBatch spriteBatch, GameTime gameTime);
    }

    public class StaticSprite : ISprite
    {
        /// <summary>
        /// The sprite's position
        /// </summary>
        public Vector2 position = Vector2.Zero;

        /// <summary>
        /// The texture of this sprite
        /// </summary>
        Texture2D texture;

        /// <summary>
        /// Creates a new static sprite
        /// </summary>
        /// <param name="texture">the texture to use</param>
        public StaticSprite(Texture2D texture)
        {
            this.texture = texture;
        }

        /// <summary>
        /// Creates a new static sprite
        /// </summary>
        /// <param name="texture">the texture to use</param>
        /// <param name="position">the upper left hand corner of the sprite</param>
        public StaticSprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }

}
