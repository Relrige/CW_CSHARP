using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Inhertion
{
    class Cat: Animal
    {
        public string Color { get; set; }
        public Cat(string nick="Noname",int age=0,string color="White")
            :base(nick,age)
        { Color = color; }

        public override string Voice => "Meow";
        public override void Eat()
        {
            Console.WriteLine($"Cat {Nick} like meat, fish");
        }
        public new void Move()
        {
            Console.WriteLine($"Cat {Nick} is moving");
        }
        public override string ToString()
        {
            return $"{base.ToString()} Color :{Color}";
        }
    }
}
