using System;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Utils;


namespace NupskouProject.Raden.Skills {

    public class SunflowerSpawner : Entity {

        private XY  _prevSpawn = World.PlayerPlace;


        private static readonly Box spawnBox = new Box (
            Mathf.LerpUnclamped (World.Box.Left, World.Box.Right,  0.2f),
            Mathf.LerpUnclamped (World.Box.Top,  World.Box.Bottom, 0.1f),
            Mathf.LerpUnclamped (World.Box.Left, World.Box.Right,  0.8f),
            Mathf.LerpUnclamped (World.Box.Top,  World.Box.Bottom, 0.5f)
        );


        public override void Update (int t) {
            int interval = The.Difficulty.Choose (180, 150, 120, 90);

            if (t % interval == 0) {
                var a = The.Random.Point (spawnBox);
                var b = The.Random.Point (spawnBox);
                _prevSpawn = XY.SqrDistance (a, _prevSpawn) > XY.SqrDistance (b, _prevSpawn) ? a : b;
                The.World.Spawn (new Sunflower (_prevSpawn));
            }
        }

    }


}