using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    abstract class CookedFood: MenuItem
    {
        public abstract void Cook();
        public abstract void Prepare();
    }
}
