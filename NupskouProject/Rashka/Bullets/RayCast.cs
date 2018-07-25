using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Rashka.Bullets {

    public class RayCast : Entity {

        private readonly XY    _p;
        private readonly float _rotation;

        private float _w;
        private Color _color;


        public RayCast (XY p, float rotation, float w, Color color) {
            _p        = p;
            _rotation = rotation;
            _w        = w;
            _color    = color;
        }


        public override void Update (int t) {
            const int duration = 60;
            if (t >= duration) {
                Despawn ();
                return;
            }
            _w = _w * (duration - t) / duration;
        }


        public override void Render () {
            var renderer = The.Renderer;

            renderer.BulletsBack.DrawCircle (_p, _color, _w);
            renderer.BulletsBack.DrawRay (_p, _rotation, _color, _w * 2, 1000);
            renderer.Bullets.DrawCircle (_p, Color.White, _w / 2);
            renderer.Bullets.DrawRay (_p, _rotation, Color.White, _w, 1000);
        }

    }

}