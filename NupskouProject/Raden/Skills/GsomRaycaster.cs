using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;
using NupskouProject.Rashka.Bullets;


namespace NupskouProject.Raden.Skills {

    public class GsomRaycaster : Entity {

        private XY _p;


        public GsomRaycaster (XY p) {
            _p = p;
        }


        public override void Update (int t) {
            float angle = t * Mathf.PI / 30;
            The.World.Spawn (new GsomRay (_p + 15 * new XY (angle).Rotated90CW (), angle));
            The.World.Spawn (new GsomRay (_p - 15 * new XY (angle).Rotated90CW (), angle));
        }

    }

}