using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public class SinglePrintFactory : AbstractFactoryPrint
    {
        public AbstractPrint CreatePrint()
        {
            return new SinglePrint();
        }

        public AbstractCopy CreateCopy()
        {
            return new SingleCopy();
        }
    }
}
