using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_part_1
{
    class ChickenOrder
    {
        int quantity;
        bool One = true;
        public  ChickenOrder(int quantity)
        {
            this.quantity = quantity;
        }
        public int  GetQuantity()
        {
            return quantity;
        }
        public void CutUp()
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