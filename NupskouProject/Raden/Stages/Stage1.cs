using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Entities;
using NupskouProject.Math;


namespace NupskouProject.Raden.Stages {

    public class Stage1 : Entity {


        public override void Update (int t) {
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