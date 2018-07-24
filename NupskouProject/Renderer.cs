using System.Collections.Generic;
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
                sprite.Render ();
            }
        }

    }


    public class Sprite {

        public void Render () {}

    }

}