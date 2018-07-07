using Shape;
using System;

namespace CylinderVolume
{
    public static class CylinderExtension
    {
        public static decimal Volume(this Cyclinder cylinder)
        {
            try
            {
                if (cylinder != null)
                    return cylinder.Height * cylinder.Radius;
                return 0;
            }
            catch (Exception) { throw; }
        }
    }
}
