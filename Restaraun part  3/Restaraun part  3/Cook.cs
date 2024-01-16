using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    public class Cook
    {
        public void Process(TableRequest request)
        {
            if (request.requestStatus == "ordered")
            {
                IMenuItem[] chickenRequest = request[new Chicken()];
                IMenuItem[] eggRequest = request[new Egg()];

                foreach (Chicken chicken in chickenRequest)
                {
                    chicken.CutUp();
                    chicken.Cook();
                }

                foreach (Egg egg in eggRequest)
                {
                    egg.Crack();
                    egg.Cook();
                    egg.Dispose();
                }
                request.requestStatus = "cooked";

            }
            else if (request.requestStatus == "cooked")
            {
                throw new Exception("Food is already cooked!!");
            }
            else if (request.requestStatus == "none")
            {
                throw new Exception("You didn't oreder");
            }
            else if (request.requestStatus == "servered")
            {
                throw new Exception("The order is already servered");
            }
        }
    }
}
