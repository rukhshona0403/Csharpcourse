using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    class Server
    {
        Cook cook = new Cook();
        public int count = 0;
        public int i = 0;
        string result = "";
        MenuItem[][] menuItems = new MenuItem[8][];
        public void Request(int quantityCh, int quantityEg, string Drink)
        {
            result = "";
            if (count < 8)
            {
                menuItems[count] = new MenuItem[quantityCh + quantityEg + 1];
                for (int i = 0; i < quantityCh; i++)
                {
                    menuItems[count][i] = MenuItem.Chicken;
                }
                for (int j = quantityCh; j < quantityEg + quantityCh; j++)
                {
                    menuItems[count][j] = MenuItem.Egg;
                }
                for (var v = MenuItem.NoDrink; v <= MenuItem.Pepsi; v++)
                {
                    if (v.ToString() == Drink)
                    { menuItems[count][quantityCh + quantityEg] = v; }
                }
                count++;
            }
            else 
                throw new Exception("Request from one table should be less 8!");
        }

        public string Inspect()
        {
            if (prepapredEgg != null)
            {
                return prepapredEgg.GetQuality().ToString();
            }
            return " No Inspection!";
        }



        public void Send()
        {
            int quanCh = 0;
           int  quanEgg = 0;
            for (i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i] == null)
                    break;
                for (int j = 0; j < menuItems[i].Length; j++)
                {
                    if (menuItems[i][j] == MenuItem.Chicken)
                    {
                        quanCh++;
                    }
                    else if (menuItems[i][j] == MenuItem.Egg)
                    {
                        quanEgg++;
                    }
                }
            }

            var chicken = cook.Submit(MenuItem.Chicken, quanCh);
            cook.Prepare(chicken);
            prepapredChicken = chicken as ChickenOrder;
            var egg = cook.Submit(MenuItem.Egg, quanEgg);
            cook.Prepare(egg);
            prepapredEgg = egg as EggOrder;
        }
        
        ChickenOrder prepapredChicken = null;
        EggOrder prepapredEgg = null;


        public string Serve()
        {
            int quanCh = 0;
            int quanEgg = 0;
           
            for (i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i] == null)
                    break;
                for (int j = 0; j < menuItems[i].Length; j++)
                {
                    if (menuItems[i][j] == MenuItem.Chicken)
                    {
                        quanCh++;
                    }
                    else if (menuItems[i][j] == MenuItem.Egg)
                    {
                        quanEgg++;
                    }
                }
                result += "Customer  " + i + " is served, " + quanCh + " chicken, " + quanEgg + "  egg. " + menuItems[menuItems.Length - 1];
            }

            //int ch = 0, eg = 0;
            //for (int j = 0; j < menuItems[i].Length; j++)
            //{
            //    if (menuItems[i][j] == MenuItem.Chicken)
            //    {
            //        ch++;
            //    }
            //    else if (menuItems[i][j] == MenuItem.Egg)
            //    {
            //        eg++;
            //    }
            //}
            prepapredChicken = null;
            prepapredEgg = null;
            return result;
        }

     }
}
    