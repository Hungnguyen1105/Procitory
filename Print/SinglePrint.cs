using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    internal class SinglePrint : AbstractPrint
    {
        public SinglePrint()
        {
        }

        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }
        public override double ScanDocument(double selectpaper1, double papersize1)
        {
            //(8.27 x 11.69 inch) * (300 dpi) / (20ppm) = (97) [(11.69 x 16.54 inch) * (300 dpi) / (20ppm)= (A3 = 195)
            double time = 0;
            time = (papersize1 / 20) * (selectpaper1 * 2);
            return Math.Abs(time);
        }
        public override double SidedPrint(double selectpaper2, double papersize2) {
            double time = 0;
            time = (papersize2 / 20) * (selectpaper2 * 2);
            return Math.Abs(time);
        }

    }
}
