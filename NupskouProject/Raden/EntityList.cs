using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace NupskouProject.Raden {

    public class EntityList : IEnumerable <Entity> {

        private List <Entity> _entities;

        public IEnumerator <Entity> GetEnumerator () => new EntityListEnumerator (_entities);
        IEnumerator IEnumerable.    GetEnumerator () => GetEnumerator ();


        public void Add (Entity entity) {
            _entities.Add (entity);
        }


        public void ClearDespawned () {
            _entities = _entities.Where (e => !e.Despawned).ToList ();
        }


        public void Clear () {
            _entities.Clear ();
        }

    }


    public class EntityListEnumerator : IEnumerator <Entity> {

        private List <Entity> _list;
        private int           i = -1;

        public Entity      Current => _list[i];
        object IEnumerator.Current => Current;


        public EntityListEnumerator (List <Entity> list) { _list = list; }


        public bool MoveNext () {
            while (++i < _list.Count) {
                if (!Current.Despawned) return true;
            }
            return false;
        }


        public void Reset ()   => i = -1;
        public void Dispose () {}

    }

}