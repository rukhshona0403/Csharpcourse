using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    class EggOrder:Order
    {
        int quality;

        public EggOrder(int Quantity):base(Quantity)
        {
            Random rnd = new Random();
            quality = rnd.Next(25, 101);
        }

        public int GetQuality()
        {
            return quality;
        }

        void Crack()
        { }

        void DiscardShell()
        { }

        protected override void Cook()
        { }

        public override void Prepare()
        {
            for (int i = 0; i < this.GetQuantity(); i++)
            {
                try
                {
                    this.Crack();
                    this.SubtractQuantity();
                }
                finally
                {
                    this.DiscardShell();
                }
            }
            Cook();
        }
    }
}
