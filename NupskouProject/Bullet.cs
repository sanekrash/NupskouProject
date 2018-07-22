﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace NupskouProject {

    public class Bullet : Entity {
        private readonly XY _p0;
        //private readonly XY _v;

        //private int _t0;
        private XY _p;
        
        public Bullet (XY p0/*, XY v*/) {
            _p = _p0 = p0;
            //_v = v;
        }
/*
        public override void OnSpawn () {
        }
        public override void OnDespawn () {}*/
        public override void Update () 
            {  /* 
               _p = _p0 + (The.Time - _t0) * _v;
            if (!Geom.CircleOverBox (new Circle (_p, 4), World.Box)) {
                Despawn ();
            }*/
            }

        public override void Render () {
            The.SpriteBatch.DrawRoundBullet (_p, Color.Black, 8f, DrawOrder.BulletBG); 
            The.SpriteBatch.DrawRoundBullet (_p, Color.White, 6f, DrawOrder.Bullet); 
        }
    }

}