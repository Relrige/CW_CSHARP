using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_INT
{
    class Card:ISecure
    {
        private int pin;
        private int id;
        protected int amount;
        public Card(int id,int amount,int pin = 111)
        {
            this.id = id;
            this.amount = amount;
            this.pin = pin;
        }

        public int Balance
        {

            get => amount;
            set
            {
                //if (CheckAcess())
                //{
                    if (value >= 0)
                        amount = value;
                    else
                        throw new Exception("Error");
                //}
                //else
                //    Console.WriteLine("\tAcess is denied");
            }
        }

        public bool CheckAcess()
        {
            int userPin;
            Console.WriteLine("\tEnter pin code : ");
            userPin= int.Parse(Console.ReadLine());
            return userPin == pin;
        }

        public virtual void Pay(int amount)
        {
            if ((this as ISecure).CheckAcess())
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine("\tPayment is successfull");
                }
                else
                    Console.WriteLine("\tError payment: not enough money");
            }
            else
                Console.WriteLine("\tAcess is denied");
        }

        public override string ToString()
        {
            return $"Card ID {id,-5} Amount : {amount,-5} ";
        }

        void IPay.Pay(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
