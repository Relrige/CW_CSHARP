using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_INT
{
    interface ISecure :IPay
    {
        bool CheckAcess();
    }
}
