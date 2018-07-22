using System;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.MathUtils;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Enemies {

    public class Ufo : Entity {

        private XY    _p0, _v0;
        private float _a;
        private Color _color;

        private int _t0;
        private XY  _p;


        public Ufo (Color color) {
            _color = color;
            
            var random   = The.Random;
            var worldBox = World.Box;
            switch (random.Next (5)) {
                case 0:
                    // горизонтально вправо
                    Init (
                        new XY (
                            worldBox.Left,
                            Mathf.Lerp (worldBox.Top, worldBox.Bottom, random.Float (0.1f, 0.6f))
                        ),
                        new XY (random.Float (2, 3), 0),
                        0
                    );
                    break;
                case 1:
                    // горизонтально влево
                    Init (
                        new XY (
                            worldBox.Right,
                            Mathf.Lerp (worldBox.Top, worldBox.Bottom, random.Float (0.1f, 0.6f))
                        ),
                        new XY (-random.Float (2, 3), 0),
                        0
                    );
                    break;
                case 2:
                    // пикировать вправо
                    Init (
                        new XY (
                            worldBox.Left,
                            Mathf.Lerp (worldBox.Top, worldBox.Bottom, random.Float (0, 0.4f))
                        ),
                        new XY (random.Float (2, 3), random.Float(1.5f, 2.5f)),
                        -0.02f
                    );
                    break;
                case 3:
                    // пикировать влево
                    Init (
                        new XY (
                            worldBox.Right,
                            Mathf.Lerp (worldBox.Top, worldBox.Bottom, random.Float (0, 0.4f))
                        ),
                        new XY (-random.Float (2, 3), random.Float(1.5f, 2.5f)),
                        -0.02f
                    );
                    break;
                case 4:
                    // зависнуть неподвижно
                    Init (
                        new XY (
                            Mathf.Lerp (worldBox.Left, worldBox.Right, random.Float (0.1f, 0.8f)),
                            worldBox.Top
                        ),
                        new XY (0, random.Float(2, 3)),
                        -0.02f
                    );
                    break;
            }
        }


        public void Init (XY p0, XY v0, float a) {
            _p     = _p0 = p0;
            _v0    = v0;
            _a     = a;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            int t = The.World.Time - _t0;
            _p = _p0 + t * _v0 + new XY (0, t * t * _a * 0.5f);
            
            if (t > 0 && !World.Box.ContainsPoint (_p)) {
                Despawn ();
            }
        }


        public override void Render () {
            The.SpriteBatch.DrawCircle (_p, _color,      20);
            The.SpriteBatch.DrawCircle (_p, Color.White, 16);
        }

    }

}