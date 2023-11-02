 using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public abstract class AbstractPrint
    {
        private string feature;
        private double paper;
        private string color;
        private string name;

        public string Feature
        {
            get
            {
                return feature;
            }
            set
            {
                this.feature = value;
            }

        }
        public double Paper
        {
            get
            {
                return paper;
            }
            set
            {
                this.paper = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }
        public abstract string ShowInfo();
        public abstract double SidedPrint(double selectpaper2, double papersize2);
        public abstract double ScanDocument(double selectpaper1, double papersize1);
    }
}
