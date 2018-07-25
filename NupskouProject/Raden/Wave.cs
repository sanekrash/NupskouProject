using System.Collections;
using System.Collections.Generic;
using NupskouProject.Core;


namespace NupskouProject.Raden {

    public class Wave : Entity {

        private IList <Entity> _entities;
        private int            _interval;
        private int            _current;


        public Wave (IList <Entity> entities, int interval) {
            _entities = entities;
            _interval = interval;
        }


        public override void Update (int t) {
            if (t % _interval != 0) return;
            t /= _interval;
            The.World.Spawn (_entities[t]);
            if (++t >= _entities.Count) Despawn ();
        }

    }

}