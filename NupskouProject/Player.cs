using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject {

    public class Player : Entity {

        private XY  _p;
        private int _t0;


        public Player (XY p) { _p = p; }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {}


        public override void Render () {
            The.SpriteBatch.Draw (
                The.Assets.Raden,
                _p,
                null,
                Color.White,
                0,
                new Vector2 (64, 128),
                0.3f,
                SpriteEffects.None,
                0
            );
        }

    }

}