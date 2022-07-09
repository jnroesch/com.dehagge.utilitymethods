using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class UiUtilities
    {
        // Is Mouse over a UI Element? Used for ignoring World clicks through UI
        public static bool IsPointerOverUI()
        {
            if (EventSystem.current.IsPointerOverGameObject()) {
                return true;
            }

            var pe = new PointerEventData(EventSystem.current) {position = Input.mousePosition};
            var hits = new List<RaycastResult>();
            EventSystem.current.RaycastAll( pe, hits );
            return hits.Count > 0;
        }

        //use this to match any 3d object in the world to the position of a canvas ui element
        public static Vector2 GetWorldPositionOfCanvasElement(RectTransform element)
        {
            RectTransformUtility.ScreenPointToWorldPointInRectangle(element, element.position, CameraUtilities.Camera,
                out var result);
            return result;
        }
    }
}