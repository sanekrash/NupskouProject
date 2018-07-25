using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Bullets {

    public class GsomRay : Entity {

        private readonly XY _p;
        private readonly float _rotation;

        private float _w;
        
        
        public GsomRay (XY p, float rotation) {
            _p = p;
            _rotation = rotation;
            _w = 40;
        }


        public override void Update (int t) {
            const int duration = 60;
            if (t >= duration) {
                Despawn ();
                return;
            }
            _w = 40f * (duration - t) / duration;
        }


        public override void Render () {
            var renderer = The.Renderer;
            
            renderer.Bullets.DrawCircle (_p, Color.Lime, _w);
            renderer.Bullets.DrawRay (_p, _rotation, Color.Lime, _w * 2, 1000);
            renderer.BulletsFront.DrawCircle (_p, Color.White, _w / 2);
            renderer.BulletsFront.DrawRay (_p, _rotation, Color.White, _w, 1000);
        }

    }

}