using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    class ChickenOrder:Order
    {
        public ChickenOrder(int quantity): base(quantity)
        { }

        void CutUp()
        { }

        protected override void Cook()
        { }

        public override void Prepare()
        {
            for (int i = 0; i < this.GetQuantity(); i++)
            {
                this.CutUp();
                this.SubtractQuantity();
            }
            Cook();
        }
    }
}
