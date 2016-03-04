using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics {

    



    public struct Bounds2D {
        public Vector2 min;
        public Vector2 max;
        public Bounds2D(Vector2 min, Vector2 max) {
            this.min = min;
            this.max = max;
        }
    }
    public struct Bounds {
        public Vector3 min;
        public Vector3 max;
        public Bounds(Vector3 min, Vector3 max) {
            this.min = min;
            this.max = max;
        }
    }
    public struct Vector3 {
        public float x, y, z;
        public Vector3(float x, float y, float z) {
            this.x = x; this.y = y; this.z = z;
        }
        public static Vector3 operator +(Vector3 a, Vector3 b) {
            a.x += b.x;
            a.y += b.y;
            a.z += b.z;
            return a;
        }
        public static Vector3 operator -(Vector3 a, Vector3 b) {
            a.x -= b.x;
            a.y -= b.y;
            a.z -= b.z;
            return a;
        }
        public static Vector3 operator *(Vector3 a, float b) {
            a.x *= b;
            a.y *= b;
            a.z *= b;
            return a;
        }
        public static Vector3 operator *(float b, Vector3 a) {
            a.x *= b;
            a.y *= b;
            a.z *= b;
            return a;
        }
        public static Vector3 operator /(Vector3 a, float b) {
            a.x /= b;
            a.y /= b;
            a.z /= b;
            return a;
        }
        public static Vector3 operator -(Vector3 a) {
            a.x = -a.x;
            a.y = -a.y;
            a.z = -a.z;
            return a;
        }

        public static Vector3 operator +(Vector3 a) {
            return a;
        }

        public float magnitude {
            get {
                return (float)Math.Sqrt(sqrMagnitude);
            }
        }

        public static Vector3 From(double[] v) {
            return new Vector3((float)v[0], (float)v[1], (float)v[2]);
        }

        public float sqrMagnitude {
            get {
                return x * x + y * y + z * z;
            }
        }

        public void normalize() {
            this /= magnitude;
        }
        public static Vector3 cross(Vector3 a, Vector3 b) {
            return new Vector3(
                a.y * b.z - a.z * b.y,
                a.z * b.x - a.x * b.z,
                a.x * b.y - a.y * b.x
                );
        }
        public static implicit operator Vector3(Vector2 a) {
            return new Vector3(a.x, a.y, 0);
        }
    }
    public struct Vector2 {
        public float x, y;

        public Vector2(float x, float y) {
            this.x = x; this.y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b) {
            a.x += b.x;
            a.y += b.y;
            return a;
        }
        public static implicit operator Vector2(Vector3 a) {
            return new Vector3(a.x, a.y, 0);
        }
        public static Vector2 operator -(Vector2 a, Vector2 b) {
            a.x -= b.x;
            a.y -= b.y;
            return a;
        }
        public static Vector2 operator *(Vector2 a, float b) {
            a.x *= b;
            a.y *= b;
            return a;
        }
        public static Vector2 operator *(float b, Vector2 a) {
            a.x *= b;
            a.y *= b;
            return a;
        }
        public static Vector2 operator -(Vector2 a) {
            a.x = -a.x;
            a.y = -a.y;
            return a;
        }

        public static Vector2 operator +(Vector2 a) {
            return a;
        }

        public float magnitude {
            get {
                return (float)Math.Sqrt(sqrMagnitude);
            }
        }
        public float sqrMagnitude {
            get {
                return x * x + y * y;
            }
        }
        public static float Dot(Vector2 a, Vector2 b) {
            return a.x * b.x + a.y * b.y;
        }

    }

    public struct Ray {
        public Vector3 point;
        public Vector3 direction;
        public Ray(Vector3 point, Vector3 direction) {
            this.point = point;
            this.direction = direction;
        }
    }
}
