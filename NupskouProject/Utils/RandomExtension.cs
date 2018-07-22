using System;
using NupskouProject.Math;


namespace NupskouProject.Utils {

    public static class RandomExtension {

        public static float Float (this Random r)                   => (float) r.NextDouble ();
        public static float SignedFloat (this Random r)             => r.Float () - 0.5f;
        public static float Angle (this Random r)                   => r.Float () * 2 * Mathf.PI;
        public static float Float (this Random r, int min, int max) => Mathf.LerpUnclamped (min, max, r.Float ());

    }

}