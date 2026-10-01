using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class HelpfullClass
    {
        public static decimal CountDiscount(int price, int discountPercent)
        {
            return price * discountPercent;
        }
    }
}
