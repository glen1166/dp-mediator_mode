using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Sale : AbstractColleague
    {
        public Sale(AbstractMediator _mediator): base(_mediator)
        {

        }

        public void sellComputer(int number)
        {
            this.mediator.execute("sale.sell");
        }

        public void offSale()
        {
            this.mediator.execute("sale.offsell");   
        }

        public int getSaleStatus()
        {
            Random rand = new Random();
            int saleStatus = rand.Next(100);
            Console.WriteLine("IBM电脑的销售情况为：" + saleStatus);
            return saleStatus;
        }

    }
}
