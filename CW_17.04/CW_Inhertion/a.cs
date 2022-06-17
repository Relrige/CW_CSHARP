using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Inhertion
{
    public class Animal
    {

        public string Nick { get; set; }
        public int Age{ get; set; }
        public Animal(string nick,int age)
        {
            Nick = nick;
            Age = age;
        }
        public virtual string Voice => "UNown sound";
        public void Move()
        {
            Console.WriteLine($"Animal {Nick} is movimg");
        }
        internal virtual void Eat()
        {
            Console.WriteLine($"Animal {Nick} like  some food");
        }
        public override string ToString()
        {
            return $"{this.GetType()} Nick {Nick,-10} Age {Age, -7}";
        }
    }
}
