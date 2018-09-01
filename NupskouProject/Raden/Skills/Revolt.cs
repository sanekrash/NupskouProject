using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Bullets;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class Revolt : Entity {

        public override void Update (int t) {
            if (t % 60 != 0) return;

//            The.Assets.Pjiu.Play (0.5f, -0.75f, 0.0f);
            The.Assets.Pjiu.Play ();

            var world = The.World;
            Fire2Gsom (new XY (300, 250), -t * 0.01f - Mathf.PI / 6);
            Fire2Gsom (new XY (300, 250), +t * 0.01f - Mathf.PI / 1.2f);

            if (t % 180 != 0) return;

            var random = The.Random;
            foreach (var v in Danmaku.Shotgun (new XY (-Mathf.PI / 24).Rotated90CW (), Mathf.PI / 12, 2, 6, 30)) {
                world.Spawn (new RedStar (new XY (600, 750), v, random.Angle (), -0.05f));
            }
            foreach (var v in Danmaku.Shotgun (new XY (Mathf.PI / 24).Rotated90CW (), Mathf.PI / 12, 2, 6, 30)) {
                world.Spawn (new RedStar (new XY (0, 750), v, random.Angle (), 0.05f));
            }
        }


        private static void Fire2Gsom (XY center, float angle) {
            var xOffset = 40 * new XY (angle);
            var yOffset = 20 * new XY (angle).Rotated90CW ();
            The.World.Spawn (new GsomRay (center + xOffset + yOffset, angle));
            The.World.Spawn (new GsomRay (center + xOffset - yOffset, angle));
        }

    }


    public class RedStar : Entity {

        private readonly XY    _p0;
        private readonly XY    _v0;
        private readonly float _a0;
        private readonly float _av;


        private XY    _p;
        private float _a;


        public RedStar (XY p0, XY v0, float a0, float av) {
            _p0 = _p = p0;
            _v0 = v0;
            _a0 = _a = a0;
            _av = av;
        }


        public override void Update (int t) {
            _p = _p0 + t * _v0 + t * t * new XY (0, 0.01f);
            _a = _a0 + t * _av;
            if (_p.Y > 780) Despawn ();
        }


        public override void Render () {
            The.Renderer.BulletsBack.DrawStar (_p, _a, Color.Red,                 20);
            The.Renderer.BulletsBack.DrawStar (_p, _a, new Color (255, 128, 128), 14);
            The.Renderer.BulletsBack.DrawCircle (_p, Color.White, 10);
        }

    }

}