using Microsoft.Xna.Framework;
using NupskouProject.Bullets;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Skills;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Bullets {

    public class ExplosiveRocket : Entity {

        private int   _t0;
        private int   _tExplosion;
        private XY    _p0, _p, _v;
        private XY    _target;
        private Color _color, _smokeColor;


        public ExplosiveRocket (XY p0, float v, XY target, Color color) {
            _p          = _p0 = p0;
            _v          = (target - p0).WithLength (v);
            _target     = target;
            _tExplosion = Mathf.CeilToInt ((target - p0).Length / v);
            _smokeColor = (_color = color) * 0.2f;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void OnDespawn () {}


        public override void Update () {
            The.World.Spawn (new Smoke (_p - new XY (_v.Angle) * 5, _smokeColor, The.Random.Float (5, 10)));
            int t = The.World.Time - _t0;
            _p = _p0 + t * _v;
            if (t >= _tExplosion) Explode ();
        }


        public override void Render () {
            The.Renderer.Bullets.DrawRocket (_p, _v.Angle, _color, 7);
        }


        private void Explode () {
            Despawn ();

            // 1 16 3  48
            // 2 16 2  64
            // 2 12 3  72
            // 2 16 3  96

            int ringSize = 20; //The.Difficulty == Difficulty.Hard ? 12 : 16;
            int lineSize = 2;  //The.Difficulty == Difficulty.Normal ? 2 : 3;

            foreach (var v in Danmaku.Ring (XY.Up, ringSize))
            foreach (var w in Danmaku.Line (v, 1f, 1.5f, lineSize)) {
                The.World.Spawn (new PetalBullet (_target, w, Color.Yellow));
            }
        }

    }

}