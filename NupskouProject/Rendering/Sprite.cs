using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Rendering {

    public class Sprite {

        private Texture2D _texture;
        private Vector2   _position;
        private Rectangle _sourceRectangle;
        private Color     _color;
        private float     _rotation;
        private Vector2   _origin;
        private Vector2   _scale;


        public Sprite (
            Texture2D texture2D,
            Vector2 position,
            Rectangle sourceRectangle,
            Color color,
            float rotation,
            Vector2 origin,
            Vector2 scale
        ) {
            _texture         = texture2D;
            _position        = position;
            _sourceRectangle = sourceRectangle;
            _color           = color;
            _rotation        = rotation;
            _origin          = origin;
            _scale           = scale;
        }


        public static Sprite Circle (XY center, Color color, float radius) =>
        new Sprite (
            The.Assets.Circle,
            center,
            new Rectangle (0, 0, 128, 128),
            color,
            0,
            new Vector2 (64),
            new Vector2 (radius / 40)
        );


        public static Sprite Petal (XY center, float rotation, Color color, float size) =>
        new Sprite (
            The.Assets.Petal,
            center,
            new Rectangle (0, 0, 128, 128),
            color,
            rotation,
            new Vector2 (64),
            new Vector2 (size / 32)
        );


        public static Sprite Ray (XY origin, float rotation, Color color, float width, float length) =>
        new Sprite (
            The.Assets.Square,
            origin,
            new Rectangle (0, 0, 64, 64),
            color,
            rotation,
            new Vector2 (0, 32),
            new Vector2 (length, width) / 64
        );


        public static Sprite Star (XY center, float rotation, Color color, float size) =>
        new Sprite (
            The.Assets.Star,
            center,
            new Rectangle (0, 0, 256, 256),
            color,
            rotation,
            new Vector2 (128),
            new Vector2 (size / 80)
        );



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