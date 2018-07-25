using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Raden.Enemies;


namespace NupskouProject.Stages {

    public class Stage1 : Entity {

        public override void Update (int t) {
            if (t == 60)  The.World.Spawn (new Ufo (Color.Red));
            if (t == 120) The.World.Spawn (new Ufo (Color.Red));
            if (t == 180) The.World.Spawn (new Ufo (Color.Red));
        }

    }

}