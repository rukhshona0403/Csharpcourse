using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt_3
{
    public class Cook
    {
        private object request;

        public void Process(TableRequests table)
        {
            if (request.requestStatus == "ordered")
            {
                IMenuItem[] chickenRequest = [new Chicken()];
                IMenuItem[] eggRequest = [new Egg()];

                foreach(Chicken chicken in chickenRequest)
                {
                    chicken.CutUp();
                    chicken.Cook();
                }

                foreach(Egg egg in eggRequest)
                {
                    egg.Crack();
                    egg.Cook();
                    egg.Dispose();
                }
                request.requestStatus = "cooked";

            }
            else if (request.requesStatus == "cooked")
            {
                throw new Exception("Food is already cooked!!");
            }
            else if (request.requesStatus == "none")
            {
                throw new Exception("You didn't oreder");
            }
            else if (request.requesStatus == "servered")
            {
                throw new Exception("The order is already servered");
            }
        }
    }
}
