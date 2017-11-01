using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Sale
    {
        public void sellIBMComputer(int number)
        {
            Stock stock = new Stock();
            Purchase purchase = new Purchase();
            if (stock.getStockNumber() < number)
            {
                purchase.buyIBMcomputer(number);
            }

            Console.WriteLine("销售IBM电脑" + number + " 台");
            stock.decrease(number);
        }

        public int getSaleStatus()
        {
            Random rand = new Random();
            int saleStatus = rand.Next(100);
            Console.WriteLine("IBM电脑的销售情况为：" + saleStatus);
            return saleStatus;
        }

        public void offSale()
        {
            Stock stock = new Stock();
            Console.WriteLine("折价销售IBM电脑" + stock.getStockNumber() + "台");
        }

    }
}
