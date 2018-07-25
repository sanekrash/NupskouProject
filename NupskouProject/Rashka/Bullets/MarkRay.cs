using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using NupskouProject.Core;
using NupskouProject.Math;

namespace NupskouProject.Rashka.Bullets {

    public class MarkRay : Entity {

        private readonly XY _p;
        private readonly float _rotation;

        private int _t0;
        private float _w;
        private Color _color;
        
        
        public MarkRay (XY p, float rotation, float w, Color color) {
            _p = p;
            _rotation = rotation;
            _w = w;
            _color = color;
        }


        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t = The.World.Time - _t0;
            const int duration = 60;
            if (t >= duration) {
                Despawn ();
            }
        }
        
        public override void OnDespawn () {
            The.World.Spawn (new RayCast (_p,_rotation , _w, Color.Purple));
        }



        public override void Render () {
            var renderer = The.Renderer;
            
            renderer.Bullets.DrawCircle (_p, _color, 1);
            renderer.Bullets.DrawRay (_p, _rotation, _color, 1 * 2, 1000);
            renderer.BulletsFront.DrawCircle (_p, Color.White, 1 / 2);
            renderer.BulletsFront.DrawRay (_p, _rotation, Color.White, 1, 1000);
        }

    }

}