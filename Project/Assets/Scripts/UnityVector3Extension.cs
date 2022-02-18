using UnityEngine;

namespace ExtensionMethods
{
    public static class Vector3Extension
    {
        public static Vector2 GetXZ(this Vector3 pos)
        {
            return new Vector2(pos.x, pos.z);
        }

        public static void SetXZ(this Vector3 pos, Vector2 pos2)
        {
            pos.x = pos2.x;
            pos.z = pos2.y;
        }
    }
}