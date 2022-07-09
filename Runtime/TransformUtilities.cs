using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class TransformUtilities
    {
        public static void DestroyChildren(this Transform parent) {
            foreach (Transform transform in parent)
                GameObject.Destroy(transform.gameObject);
        }
    }
}