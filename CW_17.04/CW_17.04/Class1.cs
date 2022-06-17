using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_17._04
{
    class MyArray
    {
        private int[] array = new int[0];

        public void Add(int data)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length-1] = data;
        }
        public override string ToString()
        {
            return String.Join(", ",array);
        }
        public int Length =>array.Length;
        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

    }
}
