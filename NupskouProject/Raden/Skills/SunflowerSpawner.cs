using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class SunflowerSpawner : Entity {

        private int _t0;

        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t = The.World.Time - _t0;
            var worldBox = World.Box;
            var random = The.Random;
            if (t % 120 == 0) {
                The.World.Spawn (
                    new Sunflower (
                        new XY (
                            Mathf.Lerp (worldBox.Left, worldBox.Right, random.Float(0.2f, 0.8f)),
                            Mathf.Lerp (worldBox.Top, worldBox.Bottom, random.Float(0.1f, 0.5f))
                        )
                    )
                );
            }
        }

    }


}