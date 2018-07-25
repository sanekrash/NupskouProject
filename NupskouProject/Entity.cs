namespace NupskouProject {

    public abstract class Entity {


        public int T0;
        
        
        public bool Despawned { get; private set; }


        public virtual void OnSpawn () {}
        public virtual void OnDespawn () {}
        public virtual void Update (int t) {}
        public virtual void Render () {}


        public void Despawn () {
            if (Despawned) return;
            Despawned = true;
            OnDespawn ();
        }

    }


}