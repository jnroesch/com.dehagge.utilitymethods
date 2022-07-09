using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class VectorUtilities
    {
        public static Vector3 GetRandomPositionWithinRectangle(float xMin, float xMax, float yMin, float yMax) {
            return new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        }

        public static Vector3 GetRandomPositionWithinRectangle(Vector3 lowerLeft, Vector3 upperRight) {
            return new Vector3(Random.Range(lowerLeft.x, upperRight.x), Random.Range(lowerLeft.y, upperRight.y));
        }
        
        public static Vector3 GetVectorFromAngle(int angle) {
            // angle = 0 -> 360
            return GetVectorFromAngle((float) angle);
        }
        
        public static Vector3 GetVectorFromAngle(float angle) {
            // angle = 0 -> 360
            var angleRad = angle * (Mathf.PI/180f);
            return new Vector3(Mathf.Cos(angleRad), Mathf.Sin(angleRad));
        }
    }
}