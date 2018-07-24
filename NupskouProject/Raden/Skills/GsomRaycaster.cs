using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;
using NupskouProject.Rashka.Bullets;


namespace NupskouProject.Raden.Skills {

    public class GsomRaycaster : Entity {

        private XY  _p;
        private int _t0;


        public GsomRaycaster (XY p) {
            _p = p;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            var   world = The.World;
            int   t     = world.Time - _t0;
            float angle = t * Mathf.PI / 30;
            world.Spawn (new GsomRay (_p + 15 * new XY(angle).Rotated90CW (), angle));
            world.Spawn (new GsomRay (_p - 15 * new XY(angle).Rotated90CW (), angle));
        }

    }

}