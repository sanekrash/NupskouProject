using System.Collections.Generic;
using NupskouProject.Math;
using NupskouProject.Raden;


namespace NupskouProject {

    public class World {
        
        public static Box Box => new Box(0, 0, 600, 750);

        public bool Paused;
        public int Time = -1;

        private List <Entity> _entities = new List <Entity> ();
//        private EntityList _entities = new EntityList();


        public void Spawn (Entity entity) {
            _entities.Add (entity);
            entity.OnSpawn ();
        }


        public void Update () {
            if (Paused) return;
            
            Time++;

            if (Time == 0) {
                Spawn (new Spawner (Box.Center));
            }
            
            for (int i = 0; i < _entities.Count; i++) {
                var entity = _entities[i];
                if (entity.Despawned) continue;
                entity.Update ();
            }
            _entities.RemoveAll (e => e.Despawned);
//            foreach (var entity in _entities) {
//                entity.Update ();
//            }
//            _entities.ClearDespawned ();
        }


        public void Render () {
            for (int i = 0; i < _entities.Count; i++) {
                _entities[i].Render ();
            }
//            foreach (var entity in _entities) {
//                entity.Render ();
//            }
        }

    }

}