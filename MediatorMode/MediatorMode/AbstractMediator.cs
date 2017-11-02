using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMode
{
    public abstract class AbstractMediator
    {
        protected Purchase purchase;
        protected Sale sale;
        protected Stock stock;
        public AbstractMediator()
        {
            purchase = new Purchase(this);
            sale = new Sale(this);
            stock = new Stock(this);
        }

        public abstract void execute(String str);
    }
}
