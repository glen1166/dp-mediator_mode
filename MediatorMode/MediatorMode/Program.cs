using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMediator mediator = new Mediator();
            Console.WriteLine("------采购人员采购电脑--------");
            Purchase purchase = new Purchase(mediator);
            purchase.buyComputer(100);
            Console.WriteLine("\n------ 销售人员销售电脑--------");
            Sale sale = new Sale(mediator);
            sale.sellComputer(1);
            Console.WriteLine("\n------ 库房管理人员清库处理--------");
            Stock stock = new Stock(mediator);
            stock.clearStock();
        }
    }
}
