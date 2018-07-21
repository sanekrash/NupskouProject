using System.Collections.Generic;


namespace NupskouProject {

    public class World {

        private List <Entity> _entities;


        public void Spawn (Entity entity) {
            _entities.Add (entity);
            // _entity.OnSpawn ();
        }


        public void Update () {
            for (int i = 0; i < _entities.Count; i++) {
                _entities[i].Update ();
            }
        }


        public void Render () {
            for (int i = 0; i < _entities.Count; i++) {
                _entities[i].Render ();
            }
        }

    }

}