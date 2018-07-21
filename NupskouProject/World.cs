using System.Collections.Generic;


namespace NupskouProject {

    public class World {

        private List <Entity> _entities;


        public void Spawn (Entity entity) {
            _entities.Add (entity);
            // _entities.OnSpawn ();
        }

        
        public void Render () {}
        public void Update () {}

    }

}