using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NupskouProject.Core;


namespace NupskouProject.Raden.Skills {

    public class Digit : Entity {

        private readonly bool _one;
        private          int  _x;
        private readonly int  _y;
        private readonly int  _tUpdate;
        private          int  _t0;


        public Digit (bool one, int y, int tUpdate) {
            _one     = one;
            _x       = 31;
            _y       = y;
            _tUpdate = tUpdate;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            _x = 31 - (The.World.Time - _t0) / _tUpdate;
            if (_x < 0) Despawn ();
        }


        public override void Render () {
            The.SpriteBatch.Draw (
                The.Assets.Digits,
                new Vector2(_x * 600f / 32, _y * 750f / 20),
                new Rectangle(_one ? 128 : 0, 0, 128, 256),
                Color.White,
                0,
                Vector2.Zero, 
                75f / 512,
                SpriteEffects.None,
                0
            );
        }

    }

}