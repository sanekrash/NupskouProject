using System;
using NupskouProject.MathUtils;


namespace NupskouProject {

    public static class RandomExtension {

        public static float Float (this Random r) {
            return (float) r.NextDouble ();
        }


        public static float SignedFloat (this Random r) {
            return r.Float () - 0.5f;
        }


        public static float Angle (this Random r) {
            return r.Float () * 2f * Mathf.PI;
        }


        public static float Float (this Random r, int min, int max) {
            return Mathf.LerpUnclamped (min, max, r.Float ());
        }

    }

}