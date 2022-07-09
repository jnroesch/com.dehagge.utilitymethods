using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class MouseUtilities
    {
        public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera) {
            var worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
            return worldPosition;
        }
    }
}