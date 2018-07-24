using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Utils {

    public static class SpriteBatchExtension {

        public static void DrawCircle (
            this SpriteBatch batch,
            XY center,
            Color color,
            float radius
        ) {
            batch.Draw (
                The.Assets.RoundBullet,
                center,
                new Rectangle (0, 0, 128, 128),
                color,
                0,
                new Vector2 (64, 64),
                radius / 40f,
                SpriteEffects.None,
                0
            );
        }

        
        public static void DrawPetal (
            this SpriteBatch batch,
            XY center,
            float rotation,
            Color color,
            float size
        ) {
            batch.Draw (
                The.Assets.PetalBullet,
                center,
                new Rectangle (0, 0, 128, 128),
                color,
                rotation,
                new Vector2 (64, 64),
                size / 32f,
                SpriteEffects.None,
                0
            );
        }


        public static void DrawRocket (
            this SpriteBatch batch,
            XY center,
            float rotation,
            Color color,
            float size
        ) {
            batch.Draw (
                The.Assets.Rocket,
                center,
                new Rectangle (0, 0, 256, 128),
                color,
                rotation,
                new Vector2 (128, 64),
                size / 40f,
                SpriteEffects.None,
                0
            );
            batch.Draw (
                The.Assets.Rocket,
                center,
                new Rectangle (0, 128, 256, 128),
                Color.White,
                rotation,
                new Vector2 (128, 64),
                size / 40f,
                SpriteEffects.None,
                0
            );
        }


        public static void DrawRay (
            this SpriteBatch batch,
            XY origin,
            float rotation,
            Color color,
            float width,
            float length
        ) {
            batch.Draw (
                The.Assets.Square,
                origin,
                new Rectangle (0, 0, 64, 64),
                color,
                rotation,
                new Vector2 (0, 32),
                new Vector2 (length, width) / 64, 
                SpriteEffects.None,
                0
            );
        }


        [Obsolete]
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