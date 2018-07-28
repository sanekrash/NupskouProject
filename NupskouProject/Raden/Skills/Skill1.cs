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
            if (t % 60 >= 15) return;
            var v = new XY (t * Mathf.phiAngle / 60);
            foreach (var spawn in _spawns) {
                The.World.Spawn (new PetalBullet (spawn, v, Color.Blue));
                The.World.Spawn (new PetalBullet (spawn, v * 1.5f, Color.Blue));
            }
        }

    }

}