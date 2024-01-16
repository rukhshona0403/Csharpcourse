using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    sealed class Chicken:CookedFood
    {
        public override void Obtain() { }
        public void CutUp() { }
        public override void Cook() { }
        public override void Serve() { }
        public override void Prepare()
        {
            Obtain();
            CutUp();
            Cook();
        }
    }
}
