using NupskouProject.Math;


namespace NupskouProject.MathUtils {

    public static class Geom {

        public static bool CircleOverCircle (Circle c1, Circle c2) {
            float d2 = XY.SqrDistance (c1.Center, c2.Center);
            float rr = c1.Radius + c2.Radius;
            return d2 <= rr;
        }


        public static bool CircleOverBox (Circle c, Box b) {
            var p = c.Center.Clamped (b);
            return XY.SqrDistance (p, c.Center) <= c.Radius * c.Radius;
        }

    }

}