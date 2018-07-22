namespace NupskouProject.Math {

    public struct Circle {

        public XY    Center;
        public float Radius;


        public Circle (XY o, float r) {
            Center = o;
            Radius = r;
        }


        public Circle (float x, float y, float r) : this (new XY (x, y), r) {}

    }

}