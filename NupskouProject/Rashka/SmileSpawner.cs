using Microsoft.Xna.Framework;
using NupskouProject.Core;
using NupskouProject.Math;
using NupskouProject.Raden.Enemies;
using NupskouProject.Rashka.Bullets;

namespace NupskouProject.Rashka
{
    public class SmileSpawner : Entity
    {
        
        public override void Update (int t) {

            The.World.Spawn (new VerticalBounceBullet (new XY(100,100), XY.Left, Color.Blue));
        }
    }
}