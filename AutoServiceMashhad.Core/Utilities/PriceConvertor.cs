using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMashhad.Core.Utilities
{
    public static class PriceConvertor
    {
        public static string ToToman(this double value)
        {
            return value.ToString("#,0 تومان");
        }
    }
}
