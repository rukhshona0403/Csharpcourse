using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt_3
{
    public enum FoodStatus
    {
        None,
        Ordered,
        Prepared,
        Served
    }
    public class TableRequests
    {
        string requestStatus = "none";
        Dictionary<int, List<IMenuItem>> tableRequest = new Dictionary<int, List<IMenuItem>>();

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

        public List<IMenuItem> this[int customerNumber]
        {
            get
            {
                return tableRequest[customerNumber];
            }
        }

        private bool isCustomerExist(int customerId)
        {
            return tableRequest.ContainsKey(customerId);
        }

        internal int GetCustomerNumbers()
        {
            throw new NotImplementedException();
        }
    }
}
