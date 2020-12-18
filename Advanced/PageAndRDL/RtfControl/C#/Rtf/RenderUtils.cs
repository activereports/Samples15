using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCity.ActiveReports.Samples.Rtf
{
    public static class RenderUtils
    {
        private static Bitmap _refBitmap = new Bitmap(1, 1);

        public static float HorizontalResolution => _refBitmap.HorizontalResolution;
        
        public static float VerticalResolution =>_refBitmap.VerticalResolution;
        
    }
}
