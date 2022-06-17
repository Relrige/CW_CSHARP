using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_INT
{
    interface IPay
    {
        void Pay(int amount);

        int Balance { get;  set; }
    }
}
