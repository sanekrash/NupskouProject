using NupskouProject.Math;


namespace NupskouProject.Raden.Enemies {

    public class Enemy : Entity {

        public XY P;
        private bool _spawned;

        public EntityComponent Movement;
        public EntityComponent Attack;
        public EntityRenderer  Sprite;


        public override void OnSpawn () {
            _spawned = true;
        }


        public override void Update (int t) {
            Movement.Update (t - Movement.T0);
            Attack.Update (t - Attack.T0);
        }


        public override void Render () {
            Sprite.Render ();
        }

    }


    public class EntityComponent {

        public int T0;

        public virtual void Update (int i) {}

    }


    public class EntityRenderer {

        public virtual void Render () {}

    }

}