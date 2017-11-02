using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public class Purchase : AbstractColleague
    {
        public Purchase(AbstractMediator _mediator): base(_mediator)
        {

        }

        public void buyComputer(int number)
        {
            this.mediator.execute("purchase.buy");
        }
        public void refuseBuyIBM()
        {
            Console.WriteLine("不再采购IBM电脑");
        }

    }
}
