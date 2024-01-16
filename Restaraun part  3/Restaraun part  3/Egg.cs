using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    sealed class Egg: CookedFood, IDisposable
    {
        public override void Obtain() { }
        public void Crack() { }
        public void DiscardShell() { }
        public override void Cook() { }
        public override void Serve() { }
        public override void Prepare()
        {
            Obtain();
            Crack();
            Cook();
        }
        public void Dispose()
        {
            DiscardShell();
        }
    }
}
