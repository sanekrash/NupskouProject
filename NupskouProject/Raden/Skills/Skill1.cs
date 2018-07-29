using System.Collections;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;


namespace NupskouProject.Raden.Skills {

    public class Skill1 : Entity {

        private XY[] _spawns;


        public Skill1 (params XY[] spawns) {
            _spawns = spawns;
        }


        public override void Update (int t) {
//            if (t % 60 >= 15) return;
            if (t % 6 != 0) return;
            var v = new XY (t * Mathf.phiAngle / 180);
            foreach (var spawn in _spawns)
            foreach (var w in Danmaku.Line (v, 1, 2, 2)) {
                The.World.Spawn (new Bullet (spawn, w, Color.Blue));
            }
        }

    }

}