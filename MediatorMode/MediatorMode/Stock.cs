using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Stock : AbstractColleague
    {
        public Stock(AbstractMediator _mediator) : base(_mediator)
        {

        }

        private static int COMPUTER_NUMBER = 100;
        public void increase(int number)
        {
            COMPUTER_NUMBER = COMPUTER_NUMBER + number;
            Console.WriteLine("库存数量为：" + COMPUTER_NUMBER);
        }

        public void decrease(int number)
        {
            COMPUTER_NUMBER = COMPUTER_NUMBER - number;
            Console.WriteLine("库存数量为：" + COMPUTER_NUMBER);
        }

        public int getStockNumber()
        {
            return COMPUTER_NUMBER;
        }

        public void clearStock()
        {
            this.mediator.execute("stock.clear");
        }

    }
}
