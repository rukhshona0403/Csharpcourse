using System.Collections.Generic;
using System.Linq;

namespace Restaraunt_3
{
    public class TableRequestsBase
    {

        public void Add(int customer, IMenuItem menuItem)
        {
            int counter;
            if (!isCustomerExist(customer)) //false
            {
                counter = tableRequest.Count();
                if (counter == 8)
                {
                    ///
                }
                tableRequest[customer] = new List<IMenuItem>() { menuItem };
            }
            else
            {
                tableRequest[customer].Add(menuItem);
                // throw new Exception("This customer has already ordered!");
            }
            requestStatus = "ordered";
        }
    }
}