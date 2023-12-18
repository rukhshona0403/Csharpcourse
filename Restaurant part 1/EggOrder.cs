using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_part_1
{
    class EggOrder
    {
        int quantity;
        int quality;
        static int countOrder = 0;
        bool One =  true;

        public EggOrder(int quantity)
        {
            this.quantity = quantity;
            Random rand = new Random();
            quality = rand.Next(1, 101);
            countOrder++;

        }

        public int GetQuantity()
        {
            return this.quantity;
        }
        public int? GetQuality()
        {
           
            if (countOrder % 2 == 0)
            {
                return null;
            }
            else
            {
                return quality;
            }
        }
        public void Crack()
        {
            if (quality < 25)
            {
                throw new Exception("This egg is a rotten!");
            }
        }
        public void DiscardShell()
        { }

        public void Cook()
        {

            if (One)
            {
                One = false;
            }
            else
                throw new Exception("Call only one!");
        }
    }
}