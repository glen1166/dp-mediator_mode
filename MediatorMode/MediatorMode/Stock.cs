using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Stock
    {
        private static int COMPUTER_NUMBER = 100; 
            public void increase( int number){
            COMPUTER_NUMBER = COMPUTER_NUMBER + number;
            Console.WriteLine("库存数量为：" + COMPUTER_NUMBER);
        }

        public void decrease( int number)
        {
            COMPUTER_NUMBER = COMPUTER_NUMBER - number;
            Console.WriteLine("库存数量为："+ COMPUTER_NUMBER);
        }

        public int getStockNumber()
        {
            return COMPUTER_NUMBER;
        }

        public void clearStock()
        {
            Purchase purchase = new Purchase();
            Sale sale = new Sale();
            Console.WriteLine("清理存货数量为："+ COMPUTER_NUMBER);
            sale.offSale();
            purchase.refuseBuyIBM();
        }

    }
}
