using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Rashka.Bullets {

    public class DeathRay : Entity {

        private readonly XY    _p;
        private readonly float _rotation;

        private float _w;
        private Color _color;


        public DeathRay (XY p, float rotation, float w, Color color) {
            _p        = p;
            _rotation = rotation;
            _w        = w;
            _color    = color;
        }


        public override void Update (int t) {
            const int duration = 2;
            if (t >= duration) {
                Despawn ();
            }
        }


        public override void Render () {
            var renderer = The.Renderer;

            renderer.BulletsBack.DrawCircle (_p, _color, _w);
            renderer.BulletsBack.DrawRay (_p, _rotation, _color, _w, 1000);
        }

    }

}