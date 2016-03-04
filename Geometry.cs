using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics {
    public static class Geometry {

        private const float compactnessK = (4 * (float)Math.PI);
        /// <summary>
        /// Returns bigger values for more compact polygons.
        /// Return value approaches 1, while input polygon approaches a perfect circle.
        /// </summary>
        /// <param name="corners"></param>
        /// <returns></returns>
        public static float compactness(IList<Vector2> corners) {
            if(corners.Count <= 0) {
                return 0;
            }


            var perimeter = perimeterOfPolygon(corners);
            var area = areaOfPolygone(corners);

            // a * pi * r^2 / (4 * pi * pi * r^2) = 1
            // a = 4 * pi
            return compactness(area, perimeter);

        }
        /// <summary>
        /// Returns the same value as in other compactness methods.
        /// <seealso cref="compactness(IList{Vector2})"/>
        /// </summary>
        /// <param name="area"></param>
        /// <param name="perimeter"></param>
        /// <returns></returns>
        public static float compactness(float area, float perimeter) {
            return compactnessK * area / (perimeter * perimeter);
        }

        public static Vector2 centroid(IList<Vector2> corners, out float area) {

            var prevIndex = corners.Count - 1;
            Vector2 center = new Vector2();
            area = 0;
            for (int i = 0; i < corners.Count; i++) {
                var corner = corners[i];
                var prevCorner = corners[prevIndex];
                prevIndex = i;
                var a = (prevCorner.x * corner.y - corner.x * prevCorner.y);
                var c = (prevCorner + corner);
                center += c * a;
                area += a;
            }
            var result = center * (1 / (3 * area));
            area = Math.Abs(area * 0.5f);
            return result;

        }

        public static bool contains(IList<Vector2> polygon, Vector2 point) {


            int prevI = polygon.Count - 1;
            bool intersects = false;
            for (int i = 0; i < polygon.Count; i++) {
                var top = polygon[i];
                var bottom = polygon[prevI];
                prevI = i;

                if ((top.y > point.y) != (bottom.y <= point.y)) {
                    continue;
                }
                if (top.y < bottom.y) {
                    var temp = top;
                    top = bottom;
                    bottom = temp;
                }


                if ((top.x - point.x) * (top.y - bottom.y) < (top.x - bottom.x) * (top.y - point.y))
                    intersects = !intersects;

            }
            return intersects;

        }

        public static float perimeterOfPolygon(IList<Vector2> corners) {


            var prevIndex = corners.Count - 1;
            float perimeter = 0;
            for (int i = 0; i < corners.Count; i++) {
                var corner = corners[i];
                var prevCorner = corners[prevIndex];
                perimeter += (prevCorner - corner).magnitude;
                prevIndex = i;
            }

            return perimeter;
        }
        public static float areaOfPolygone(IList<Vector2> corners) {
            
            var prevI = corners.Count - 1;
            float area = 0;
            for (int i = 0; i < corners.Count; i++) {
                var corner = corners[i];
                var prevCorner = corners[prevI];
                area += prevCorner.x * corner.y - prevCorner.y * corner.x;
                prevI = i;
            }

            return Math.Abs(area * 0.5f);
        }

        public static float areOfTriangleWhomThirdCornerIsCenter(Vector2 p1, Vector2 p2) {
            
            return (p1.x * p2.y - p1.y * p2.x) * 0.5f;
        }
    }


}
