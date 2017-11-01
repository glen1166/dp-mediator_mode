using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Purchase
    {
        public void buyIBMcomputer(int number)
        {
            Stock stock = new Stock();
            Sale sale = new Sale();
            int saleStatus = sale.getSaleStatus();
            if (saleStatus > 80)
            {
                Console.WriteLine("采购IBM电脑:" + number + "台");
                stock.increase(number);
            }
            else
            {
                int buyNumber = number / 2;
                Console.WriteLine("采购IBM电脑：" + buyNumber + "台");
            }
        }
        public void refuseBuyIBM()
        {
            Console.WriteLine("不再采购IBM电脑");
        }

    }
}
