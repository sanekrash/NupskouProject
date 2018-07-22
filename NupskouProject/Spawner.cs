using System;


namespace NupskouProject {

    public class Spawner : Entity {

        private XY  _p;
        private int _t0;


        public Spawner (XY p) {
            _p = p;
        }


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            var world = The.World;
            int dt = world.Time - _t0 + 256;
            float angle = (dt * dt + dt) * Mathf.PI / 512;
//            float angle = dt / 20f;
            world.Spawn (new Bullet (_p, new XY(angle)));
        }

    }

}