using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Rendering;


namespace NupskouProject.Raden.Bullets {

    public class SunflowerRay : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;

        private XY _p;


        public SunflowerRay (XY p0, XY v) {
            _p        = _p0 = p0;
            _v        = v;
            _rotation = _v.Angle;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 120), World.Box)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.Renderer.BulletsBack.Draw (
                new Sprite (
                    The.Assets.BigBullet,
                    _p,
                    new Rectangle (0, 0, 512, 128),
                    Color.Yellow,
                    _rotation,
                    new Vector2 (256, 64),
                    new Vector2 (0.25f)
                )
            );
            The.Renderer.BulletsBack.Draw (
                new Sprite (
                    The.Assets.BigBullet,
                    _p,
                    new Rectangle (0, 0, 512, 128),
                    Color.White,
                    _rotation,
                    new Vector2 (256,   64),
                    new Vector2 (0.25f, 0.15f)
                )
            );
        }

    }

}