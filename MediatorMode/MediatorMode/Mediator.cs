using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Mediator : AbstractMediator
    {
        public override void execute(string str)
        {
            var para = 1;
            if (str.Equals("purchase.buy"))
            {
                buyComputer(para);
            }
            else if (str.Equals("sale.sell"))
            {
                sellComputer(para);
            }
            else if (str.Equals("sale.offsell"))
            {
                offSale();
            }
            else if (str.Equals("stock.clear"))
            {
                clear();
            }
        }

        private void buyComputer(int number)
        {
            int saleStatus = sale.getSaleStatus();
            if(saleStatus > 80){
                Console.WriteLine($"{number} computer purchased.");
                stock.increase(number);
            }
            else{
                int buyNumber = number/2;
                Console.WriteLine($"{buyNumber}  computer purchased.");
                stock.increase(buyNumber);
            }
        }

        private void sellComputer(int number)
        {
            if(stock.getStockNumber()<number){
                purchase.buyComputer(number);
            }
        }

        private void offSale()
        {
            Console.WriteLine($"sell computer with cut {stock.getStockNumber()}");
        }

        private void clear()
        {
            sale.offSale();
            purchase.refuseBuyIBM();
        }
    }
}
