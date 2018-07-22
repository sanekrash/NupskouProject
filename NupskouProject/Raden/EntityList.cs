using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace NupskouProject.Raden {
    
    public class EntityList : List <Entity> {

        public EntityList () : base () {}
        public EntityList (int capacity) : base (capacity) {}
        public EntityList (IEnumerable <Entity> collection) : base (collection) {}

        public new IEnumerator <Entity> GetEnumerator () => new EntityListEnumerator (this);


        public void ClearDespawned () {
            RemoveAll (e => e.Despawned);
        }

    }
    

    public class EntityListEnumerator : IEnumerator <Entity> {

        private IList <Entity> _list;
        private int            i = -1;

        public Entity      Current => _list[i];
        object IEnumerator.Current => Current;


        public EntityListEnumerator (IList <Entity> list) { _list = list; }


        public bool MoveNext () {
            while (++i < _list.Count) {
                if (!_list[i].Despawned) return true;
            }
            return false;
        }


        public void Reset ()   => i = -1;
        public void Dispose () {}

    }

}