using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public abstract class AbstractCopy
    {
        private string feature;
        private double paper;
        private string name;
        private string color;

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
        public abstract string ShowInfo();
        public abstract double Copy(double selectpaper2);
        public abstract double Scan(double selectpaper1, double papersize);
        public abstract double Fax(double faxnumber);
    }
}
