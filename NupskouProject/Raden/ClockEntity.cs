using System;
using NupskouProject.Core;
using NupskouProject.Raden.Utils;


namespace NupskouProject.Raden {

    public class ClockEntity : Entity {

        private Clock _clock;
        private int   _t0;


        public ClockEntity (Func <int, bool> f, int interval) {
            _clock = new Clock (
                t => {
                    if (f (t)) Despawn ();
                },
                interval
            );
        }


        public override void OnSpawn () { _t0 = The.World.Time; }
        public override void Update ()  { _clock.Update (The.World.Time - _t0); }

    }

}