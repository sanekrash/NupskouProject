using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Bullets {

    public class RecursiveBullet : Entity {

        private readonly XY    _p0;
        private readonly XY    _v;
        private readonly float _rotation;
        private readonly Color _color;
        private readonly int   _rank;

        private int _t0;
        private XY  _p;


        public RecursiveBullet (XY p0, XY v, Color color, int rank) {
            _p        = _p0 = p0;
            _v        = v;
            _color    = color;
            _rank     = rank;
            _rotation = _v.Angle;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            int t = The.World.Time - _t0;
            _p = _p0 + t * _v;
            if (_rank > 1 && t == 40) {
                Split ();
            }
            else if (_rank == 1 && !Geom.CircleOverBox (new Circle (_p, 6), World.Box)) {
                Despawn ();
            }
        }


        private void Split () {
            Despawn ();
            foreach (var v in Danmaku.Spray (_v, 2 * Mathf.PI - Mathf.phiAngle, _rank)) {
                The.World.Spawn (new RecursiveBullet (_p, v, _color, _rank - 1));
            }
        }


        public override void Render () {
            The.SpriteBatch.DrawPetal (_p, _rotation, _color,      4);
            The.SpriteBatch.DrawPetal (_p, _rotation, Color.White, 2.5f);
//            if (_rank == 1) {
//                The.SpriteBatch.DrawRay (_p, _rotation, _color, 3, 1000);
//            }
        }


    }

}