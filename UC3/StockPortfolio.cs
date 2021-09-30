using System;
using System.Collections.Generic;
using System.Text;

namespace Stock_Account_Management
{
    class StockPortfolio
    {
        internal static double StockValue(double SharePrice, int NoOfShares)
        {
            double result = SharePrice * NoOfShares;
            return result;
        }
    }
}
