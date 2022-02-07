using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Unpack
{
    public static class Strings
    {
        private static string ex_vref = ".vref";
        private static string ex_vlut = ".vlut";
        private static string ex_vdat = ".vdat";
        private static string ex_vgpu = ".vgpu";

        public static string GetCaffExtension(int i)
        {
            switch (i)
            {
                case 0:
                    return ex_vref;
                case 1:
                    return ex_vlut;
                case 2:
                    return ex_vdat;
                case 3:
                    return ex_vgpu;
            }
            return null;
        }
    }
}
