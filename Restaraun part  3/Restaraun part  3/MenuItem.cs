using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    abstract class MenuItem: IMenuItem
    {
        public abstract void Obtain();
        public abstract void Serve();
    }
}
