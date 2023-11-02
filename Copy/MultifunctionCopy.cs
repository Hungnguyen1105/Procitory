using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public class MultifunctionCopy : AbstractCopy
    {
        public MultifunctionCopy()
        {
        }

        public override double Copy(double selectpaper2) {
            double time = 0;
                time = ((selectpaper2 * 2) / 20) * 60;
                return Math.Abs(time); 
                         

        }
        public override double Scan(double selectpaper1, double papersize)
        {
            double time = 0;
            //(8.27 x 11.69 inch) * (200 dpi) / (20ppm) = (A4 = 97; ) [(11.69 x 16.54 inch) * (200 dpi) = (A3 = 195)
            time = (papersize / 20) * (selectpaper1 * 2);
            
            return Math.Abs(time);
            //(11.69 x 16.54 inch) * (200 dpi) / (20ppm) {195 inch^2 / 20 ppm}\
            
        }

        public override double Fax(double faxnumber)
        {
            return faxnumber;
        }

        public override string ToString() {
            return Name + Feature;
        }
        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
