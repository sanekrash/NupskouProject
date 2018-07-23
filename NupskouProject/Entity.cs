namespace NupskouProject {

    public abstract class Entity {
        
        public bool Despawned { get; private set; }
        

        public virtual void OnSpawn () {}
        public virtual void OnDespawn () {}
        public virtual void Update () {}
        public virtual void Render () {}


        public void Despawn () {
            if (Despawned) return;
            Despawned = true;
            OnDespawn ();
        }

    }


}