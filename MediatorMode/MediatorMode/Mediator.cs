using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Mediator : AbstractMediator
    {
        override public void execute(string str)
        {
            if (str.Equals("purchase.buy"))
            {
                
            }
            else if (str.Equals("sale.sell"))
            {

            }
            else if (str.Equals("sale.offsell"))
            {

            }
            else if (str.Equals("stock.clear"))
            {

            }
        }

        private void buyComputer(int number)
        {
            
        }

        private void sellComputer(int number)
        {
            
        }

        private void offSale()
        {
            
        }

        private void clear()
        {

        }
    }
}
