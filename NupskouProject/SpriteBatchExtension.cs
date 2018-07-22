using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace NupskouProject {

    public static class SpriteBatchExtension {

 /*       public static void DrawCircle (
            this SpriteBatch batch,
            XY center,
            Color color,
            float size,
            float drawOrder
        ) {
            batch.Draw (
                The.Assets.Circle,
                center,
                new Rectangle (0, 0, 256, 256),
                color,
                0,
                new Vector2 (128, 128),
                size / 128f,
                SpriteEffects.None,
                drawOrder
            );
        }
*/
        public static void DrawRoundBullet (
            this SpriteBatch batch,
            XY center,
            Color color,
            float size,
            float drawOrder
        ) {
            batch.Draw (
                The.Assets.RoundBullet,
                center,
                new Rectangle (0, 0, 256, 256),
                color,
                0,
                new Vector2 (128, 128),
                size / 128f,
                SpriteEffects.None,
                drawOrder
            );
        }
    }

}

