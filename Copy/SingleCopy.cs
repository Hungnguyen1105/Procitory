using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public class SingleCopy : AbstractCopy
    {

        public SingleCopy() { }

        public override string ToString()
        {
            return Name + Feature;
        }
        public override string ShowInfo() { return "";
        }

        public override double Copy(double selectpaper2) {
            // 10ppm
            double time = ((selectpaper2 * 2) / 10) * 60;
            return Math.Abs(time);
        }
        public override double Scan(double selectpaper1, double papersize)
        {
            double time = 0;
            //(8.27 x 11.69 inch) * (200 dpi) / (10ppm) = (100) ; [(11.69 x 16.54 inch) * (200 dpi) = (A3 = 200)
            time = (papersize / 10) * (selectpaper1 * 2);
            return Math.Abs(time);
        }
        public override double Fax(double faxnumber)
        {

            return 0;
        }
    }
}
