using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraun_part__3
{
    public class Server
    {
        internal int customerCounter;
        TableRequest tableRequest = new TableRequest();
        private object singleRequest;
        private object drinType;

        public void ReceiveRequest(int customerId, int chickenQuantity, int eggQuantity, string drinkType)
        {
            MenuItem[] singlOrder = new MenuItem[chickenQuantity + eggQuantity + 1];
            for (int i = 0; i < chickenQuantity; i++)
            {
                tableRequest.Add(customerId, new Chicken());
            }

            for (int j = 0; j < eggQuantity; j++)
            {
                tableRequest.Add(customerId, new Egg());
            }

            switch (drinkType)
            {
                case "Tea":
                    tableRequest.Add(customerId, new Tea());
                    break;
                case "CocaCola":
                    tableRequest.Add(customerId, new CocaCola());
                    break;
                case "Pepsi":
                    tableRequest.Add(customerId, new Pepsi());
                    break;
                case "NoDrink":
                    tableRequest.Add(customerId, new NoDrink());
                    break;

            }
            int customerCounter = 0;
            customerCounter++;

            tableRequest.requestStatus = "ordered";
            if (chickenQuantity == 0 && eggQuantity == 0 && drinkType == "NoDrink")
                throw new Exception("You didnt ordered anything , please choose menu items ");
            if (tableRequest.GetCustomerNumbers() > 8)
                throw new Exception("Request from one table should be 8");

            if (chickenQuantity == 0 && eggQuantity == 0 && drinkType == "NoDrink")
                throw new Exception("You havent oredred yet , please choose menu Items ");
        }


        public void Send(TableRequest request)
        {
            Cook cook = new Cook();
            cook.Process(request);
        }

        public object GetSingleRequest()
        {
            return singleRequest;
        }

        public string Serve()
        {
            string result = "";

            if (tableRequest.requestStatus == "cooked ")
            {
                int customerNumbers = tableRequest.GetCustomerNumbers();

                for (int customerId = 0; customerId < customerNumbers; customerId++)
                {
                    int chickenQuantity = 0;
                    int eggQuantity = 0;

                    singleRequest = tableRequest[customerId];


                    foreach (IMenuItem item in singleRequest)
                    {
                        if (item is Chicken)
                        {
                            chickenQuantity++;
                        }
                        else if (item is Egg)
                        {
                            eggQuantity++;
                        }
                        else
                        {
                            item.Obtain();
                        }
                        item.Serve();
                    }


                    result += $"Customer {customerId}is oredered" +
                    $"{chickenQuantity}chickens, " +
                    $"{eggQuantity}eggs" +
                    $"{drinType}.Enjoy your meal!";

                }
                tableRequest.requestStatus = "servered";

            }
            else
            {
                result = "No order to serve ";
            }
            return result;

        }

        internal void ReceiveRequest(object customerCounter, int chickenQuantity, int eggQuantity, string drink)
        {
            throw new NotImplementedException();
        }

        internal void Send()
        {
            throw new NotImplementedException();
        }
    }
}
