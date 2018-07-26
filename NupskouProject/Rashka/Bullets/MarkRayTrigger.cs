using System.Runtime.Remoting.Metadata.W3cXsd2001;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject.Rashka.Bullets {

    public class MarkRayTrigger : Entity {

        private readonly XY    _p;
        private readonly float _rotation;

        private float _wRay;
        private float _w;
        private Color _color;


        public MarkRayTrigger (XY p, float rotation, float wRay, Color color) {
            _p        = p;
            _rotation = rotation;
            _wRay     = wRay;
            _color    = color;
            _w        = 1;
        }


        public override void Update (int t) {
            const int duration = 120;
            if (t >= duration) {
                Despawn ();
                The.World.Spawn (new RayCast (_p, _rotation, _wRay, _color));
            }
           // _w = _wRay * t / duration;
        }


        public override void Render () {
            var renderer = The.Renderer;
            renderer.BulletsBack.DrawCircle (_p, _color, _w);
            renderer.BulletsBack.DrawRay (_p, _rotation, _color, _w * 2, 1000);
        }

    }

}