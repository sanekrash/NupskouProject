using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class DigitSpawner : Entity {

        private int _t0;

        public override void OnSpawn () { _t0 = The.World.Time; }


        public override void Update () {
            int t        = The.World.Time - _t0;
            var worldBox = World.Box;
            var random   = The.Random;
            if (t % 10 == 0) {
                SpawnDigits ();
            }
        }


        private static void SpawnDigits () {
            var ar = new bool[20];
            for (int i = 0; i < 5; i++) {
                ar[i] = true;
            }
            ar.Shuffle (The.Random);
            for (int i = 0; i < 20; i++) {
                The.World.Spawn (new Digit (ar[i], i, 10));
            }
        }

    }


}