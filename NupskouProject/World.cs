using System.Collections.Generic;
using System.Threading;


namespace NupskouProject {

    public class World {
        
        public static int Time = -1;
        private List <Entity> _entities = new List <Entity> ();


        public World () {
            Spawn (new Bullet (new XY (100, 100)));
        }


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