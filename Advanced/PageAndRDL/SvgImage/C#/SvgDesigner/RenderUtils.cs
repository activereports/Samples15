using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapeCity.ActiveReports.Samples.Svg
{
    public static class RenderUtils
    {
        private static Bitmap _refBitmap = new Bitmap(1, 1);
        public static Graphics CreateReferenceGraphics()
        {
            return Graphics.FromImage(_refBitmap);
        }
    }
}
