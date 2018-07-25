using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;


namespace NupskouProject.Raden.Stages {

    public class Stage1 : Entity {

        private int _t0;


        public override void OnSpawn () {
            _t0 = The.World.Time;
        }


        public override void Update () {
            int t = The.World.Time - _t0;
            switch (t) {
                case 120:
                    The.World.Spawn (
                        new ClockEntity (
                            i => {
                                The.World.Spawn (
                                    new Bullet (World.BossPlace, 2 * new XY (i * Mathf.phiAngle), Color.Lime)
                                );
                                return i == 100;
                            },
                            1
                        )
                    );
                    break;
                default:
                    return;
            }
        }

    }

}