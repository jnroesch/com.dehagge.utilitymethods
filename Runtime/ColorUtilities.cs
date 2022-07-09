using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class ColorUtilities
    {
        public static Color TintColor(this Color baseColor, Color tint) {
            // Apply tint
            baseColor.r = tint.r * baseColor.r;
            baseColor.g = tint.g * baseColor.g;
            baseColor.b = tint.b * baseColor.b;

            return baseColor;
        }

        public static bool IsSimilar255(this Color colorA, Color colorB, int maxDiff) {
            return IsSimilar(colorA, colorB, maxDiff / 255f);
        }

        public static bool IsSimilar(this Color colorA, Color colorB, float maxDiff) {
            var rDiff = Mathf.Abs(colorA.r - colorB.r);
            var gDiff = Mathf.Abs(colorA.g - colorB.g);
            var bDiff = Mathf.Abs(colorA.b - colorB.b);
            var aDiff = Mathf.Abs(colorA.a - colorB.a);

            var totalDiff = rDiff + gDiff + bDiff + aDiff;
            return totalDiff < maxDiff;
        }

        public static float GetColorDifference(Color colorA, Color colorB) {
            var rDiff = Mathf.Abs(colorA.r - colorB.r);
            var gDiff = Mathf.Abs(colorA.g - colorB.g);
            var bDiff = Mathf.Abs(colorA.b - colorB.b);
            var aDiff = Mathf.Abs(colorA.a - colorB.a);

            var totalDiff = rDiff + gDiff + bDiff + aDiff;
            return totalDiff;
        }
        
        public static Color GetColor255(float red, float green, float blue, float alpha = 255f) {
            return new Color(red / 255f, green / 255f, blue / 255f, alpha / 255f);
        }
        
        // Return a color going from Red to Yellow to Green, like a heat map
        public static Color GetHeatMapColor(float value) {
            var r = 0f;
            var g = 0f;
            if (value <= .5f) {
                r = 1f;
                g = value * 2f;
            } else {
                g = 1f;
                r = 1f - (value - .5f) * 2f;
            }
            return new Color(r, g, 0f, 1f);
        }
    }
}