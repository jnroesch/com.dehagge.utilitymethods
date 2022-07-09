using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class CameraUtilities
    {
        private static Camera _camera;

        public static Camera Camera
        {
            get
            {
                if (_camera == null) _camera = Camera.main;
                return _camera;
            }
        }
        
    }
}