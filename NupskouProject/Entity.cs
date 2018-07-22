namespace NupskouProject {

    public abstract class Entity {

        public virtual void OnSpawn () {}
        public virtual void OnDespawn () {}
        public virtual void Update () {}
        public virtual void Render () {}

    }


}