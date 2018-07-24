using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject {

    public class Renderer {

        public Layer Background = new Layer ();
        public Layer Foreground = new Layer ();


        public void Clear () {
            Background.Clear ();
            Foreground.Clear ();
        }


        public void Render (SpriteBatch spriteBatch) {
            spriteBatch.Begin ();
            Background.Render (spriteBatch);
            Foreground.Render (spriteBatch);
            spriteBatch.End ();
        }

    }


    public class Layer {

        private List <Sprite> _sprites;


        public void Clear () {
            _sprites.Clear ();
        }


        public void Render (SpriteBatch spriteBatch) {
            foreach (var sprite in _sprites) {
                sprite.Render (spriteBatch);
            }
        }

    }


    public class Sprite {

        private Texture2D _texture;
        private Vector2   _position;
        private Rectangle _sourceRectangle;
        private Color     _color;
        private float     _rotation;
        private Vector2   _origin;
        private Vector2   _scale;


        public void Render (SpriteBatch spriteBatch) {
            spriteBatch.Draw (
                _texture,
                _position,
                _sourceRectangle,
                _color,
                _rotation,
                _origin,
                _scale,
                SpriteEffects.None,
                0
            );
        }

    }

}