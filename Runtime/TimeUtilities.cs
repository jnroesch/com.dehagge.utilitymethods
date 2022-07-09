using System.Collections.Generic;
using UnityEngine;

namespace Packages.com.dehagge.utilitymethods.Runtime
{
    public static class TimeUtilities
    {
        private static readonly Dictionary<float, WaitForSeconds> waitDictionary = new Dictionary<float, WaitForSeconds>();

        public static WaitForSeconds GetWait(float time)
        {
            if (waitDictionary.TryGetValue(time, out var wait)) return wait;
            
            waitDictionary[time] = new WaitForSeconds(time);
            return waitDictionary[time];
        }
    }
}