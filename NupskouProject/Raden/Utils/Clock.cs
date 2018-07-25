using System;


namespace NupskouProject.Raden.Utils {

    public class Clock {

        private readonly Action <int> _f;
        private readonly int          _interval;


        public Clock (Action <int> f, int interval) {
            _f = f;
            _interval = interval;
        }


        public void Update (int t) {
            if (t % _interval != 0) return;
            t /= _interval;
            _f (t);
        }

    }

}