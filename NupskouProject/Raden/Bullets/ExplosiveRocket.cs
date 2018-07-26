using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;
using NupskouProject.Raden.Skills;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Bullets {

    public class ExplosiveRocket : Entity {

        private int   _tExplosion;
        private XY    _p0, _p;
        private XY    _target;
        private Color _color, _smokeColor;
        private float _rotation;


        public ExplosiveRocket (XY p0, int tExplosion, XY target, Color color) {
            _p          = _p0 = p0;
            _tExplosion = tExplosion;
//            _v          = (target - p0).WithLength (v);
            _target     = target;
//            _tExplosion = Mathf.CeilToInt ((target - p0).Length / v);
            _smokeColor = (_color = color) * 0.2f;
            _rotation = XY.DirectionAngle (_p0, _target);
        }


        public override void Update (int t) {
            The.World.Spawn (new Smoke (_p - new XY (_rotation) * 5, _smokeColor, The.Random.Float (5, 10)));
//            _p = _p0 + t * _v;
            _p = XY.Lerp (_p0, _target, t / (float) _tExplosion);
            if (t >= _tExplosion) Explode ();
        }


        public override void Render () {
            The.Renderer.Bullets.DrawRocket (_p, _rotation, _color, 7);
        }


        private void Explode () {
            Despawn ();

            int ringSize = 20;
            int lineSize = 2;

            foreach (var v in Danmaku.Ring (XY.Up, ringSize))
            foreach (var w in Danmaku.Line (v, 1f, 1.5f, lineSize)) {
                The.World.Spawn (new PetalBullet (_target, w, Color.Yellow));
            }
        }

    }

}