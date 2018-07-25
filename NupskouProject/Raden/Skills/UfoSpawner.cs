using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Raden.Enemies;


namespace NupskouProject.Raden.Skills {

    public class UfoSpawner : Entity {

        public override void Update (int t) {
            if (t % 60 == 0) {
                The.World.Spawn (new Ufo (Color.Red));
            }
        }

    }

}