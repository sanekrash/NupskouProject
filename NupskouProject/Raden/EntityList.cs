using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace NupskouProject.Raden {

    public class EntityList : IList <Entity> {

        private List <Entity> _entities;


        public EntityList ()                                { _entities = new List <Entity> (); }
        public EntityList (int capacity)                    { _entities = new List <Entity> (capacity); }
        public EntityList (IEnumerable <Entity> collection) { _entities = new List <Entity> (collection); }


        public IEnumerator <Entity> GetEnumerator () => new EntityListEnumerator (_entities);
        IEnumerator IEnumerable.    GetEnumerator () => GetEnumerator ();

        
        public void Add (Entity item)                       { _entities.Add (item); }
        public void Clear ()                                { _entities.Clear (); }
        public bool Contains (Entity item)                  => _entities.Contains (item);
        public void CopyTo (Entity[] array, int arrayIndex) { _entities.CopyTo (array, arrayIndex); }
        public bool Remove (Entity item)                    => _entities.Remove (item);


        public int Count => _entities.Count;


        public bool IsReadOnly => false;


        public int  IndexOf (Entity item)           => _entities.IndexOf (item);
        public void Insert (int index, Entity item) { _entities.Insert (index, item); }
        public void RemoveAt (int index)            { _entities.RemoveAt (index); }


        public Entity this [int index] {
            get { return _entities[index]; }
            set { _entities[index] = value; }
        }


        public void ClearDespawned () { _entities = _entities.Where (e => !e.Despawned).ToList (); }

    }


    public class EntityListEnumerator : IEnumerator <Entity> {

        private IList <Entity> _list;
        private int            i = -1;

        public Entity      Current => _list[i];
        object IEnumerator.Current => Current;


        public EntityListEnumerator (IList <Entity> list) { _list = list; }


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