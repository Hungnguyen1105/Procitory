using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2_1651
{
    public interface AbstractFactoryPrint
    {
        public AbstractPrint CreatePrint();

        public AbstractCopy CreateCopy();
    }
}
