using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public class MultifunctionPrint : AbstractPrint
    {
        public MultifunctionPrint()
        {
        }

        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }
        public override double ScanDocument(double selectpaper1, double papersize1)
        {
            //(8.27 x 11.69 inch) * (300 dpi) / (30ppm) = (96) [(11.69 x 16.54 inch) * (300 dpi) = (A3 = 192)
            double time = 0;         
            time = (papersize1 / 30) * (selectpaper1 * 2);
            return Math.Abs(time);
        }
        public override double SidedPrint(double selectpaper2, double papersize2)
        {
            //(8.27 x 11.69 inch) * (300 dpi) / (30ppm) = (A4 = 96; ) [(11.69 x 16.54 inch) * (300 dpi) = (A3 = 192)
            double time = 0;
            time = (papersize2 / 30) * (selectpaper2 * 2);
            return Math.Abs(time); ;
        
        }
    }
}

