using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using NupskouProject.Core;
using NupskouProject.Math;


namespace NupskouProject {

    public class Player : Entity {

        private XY  _p;
        private int _t0;


        public Player (XY p) { _p = p; }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        
        public override void Update () {
            var  keyboard = Keyboard.GetState ();
            bool shift    = keyboard.IsKeyDown (Keys.LeftShift);

            // if arrows pressed, move (shift - slowly)
            int x =
                (keyboard.IsKeyDown (Keys.Right) ? 1 : 0) -
                (keyboard.IsKeyDown (Keys.Left) ? 1 : 0);
            int y =
                (keyboard.IsKeyDown (Keys.Down) ? 1 : 0) -
                (keyboard.IsKeyDown (Keys.Up) ? 1 : 0);

            _p+= new XY (x, y) * (shift ? 2 : 4);

            // if z pressed, shoot (shift - 2nd mode)
            /* if (keyboard.IsKeyDown (Keys.Z)) {
                if (shift) {
                    ShootShift ();
                }
                else {
                    Shoot ();
                }*/
            }



        public override void Render () {
            The.SpriteBatch.Draw (
                The.Assets.Raden,
                _p,
                null,
                Color.White,
                0,
                new Vector2 (64, 128),
                0.3f,
                SpriteEffects.None,
                0
            );
        }

    }

}