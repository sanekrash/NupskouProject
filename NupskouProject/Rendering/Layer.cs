using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Rendering {

    public partial class Layer {

        private List <Sprite> _sprites = new List <Sprite> ();


        public void Clear () {
            _sprites.Clear ();
        }


        public void Draw (Sprite sprite) {
            _sprites.Add (sprite);
        }


        public void DrawCircle (XY center, Color color, float radius) {
            _sprites.Add (Sprite.Circle (center, color, radius));
        }


        public void DrawPetal (XY center, float rotation, Color color, float size) {
            _sprites.Add (Sprite.Petal (center, rotation, color, size));
        }


        public void DrawRay (XY origin, float rotation, Color color, float width, float length) {
            _sprites.Add (Sprite.Ray (origin, rotation, color, width, length));
        }


        public void DrawRocket (XY center, float rotation, Color color, float size) {
            _sprites.Add (
                new Sprite (
                    The.Assets.Rocket,
                    center,
                    new Rectangle (0, 0, 256, 128),
                    color,
                    rotation,
                    new Vector2 (128, 64),
                    new Vector2 (size / 40f)
                )
            );
            _sprites.Add (
                new Sprite (
                    The.Assets.Rocket,
                    center,
                    new Rectangle (0, 128, 256, 128),
                    Color.White,
                    rotation,
                    new Vector2 (128, 64),
                    new Vector2 (size / 40f)
                )
            );
        }
        
        public void DrawArrow (XY center,float rotation,Color color, float size)
        {
            _sprites.Add (
                new Sprite (
                    The.Assets.Arrow,
                    center,
                    new Rectangle (0, 0, 384, 128),
                    color,
                    rotation,
                    new Vector2 (128, 64),
                    new Vector2 (size / 40f)
                )
            );
            _sprites.Add (
                new Sprite (
                    The.Assets.Arrow,
                    center,
                    new Rectangle (0, 128, 384, 128),
                    Color.White,
                    rotation,
                    new Vector2 (128, 64),
                    new Vector2 (size / 40f)
                )
            );
        }




        public void Render (SpriteBatch spriteBatch) {
            foreach (var sprite in _sprites) {
                sprite.Render (spriteBatch);
            }
        }

    }

}