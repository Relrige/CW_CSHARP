using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_INT
{
    class GoldCard:Card
    {
        int percent;

        public GoldCard(int id,int amount,int pin,int percent =5)
            :base(id,amount,pin)    
        {
            this.percent = percent;
        }
        public override void Pay(int amount)
        {
            base.Pay(amount);

            this.amount +=(int)(amount *percent/100.0);
        }
    }
}
