using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public enum Category { None,Pizza,ColdDrink,HotDrink,Soup,Meat,Confectioner}
    struct Dish
    {
        public string Name { get; set; }
        public int Energy{ get; set; }
        Category category;
        public Category Category
        {
            get => category;
            set
            {
                if (Enum.IsDefined<Category>(value))
                    category = value;
                //else
                //    category = Category.None;
            }
        }
        public Dish(string name,Category c,int energy =0)
            :this()
        {
            Category = c;
            Name = name;
            Energy = energy;
        }
        public int CompareTo(object obj)
        {
            if (obj is Dish)
            {
                return this.Category.CompareTo(((Dish)obj).Category);
            }
            else
                Console.WriteLine("error");
        }
        public override string ToString()
        {
            return $"Dish '{Name}'  Category is {Category} Energy {Energy}";
        }
    }
}
