using System;
using System.Collections.Generic;
using System.Text;

namespace StockAccountManagement
{
    public class Stock
    {
        public int totalshare = 0;
        public int totalPrice = 0;
        public void Stockvalue(int p, int q, string r)
        {
            int stockPrice = p * q;
            Console.WriteLine("The Price for stock " + r + " shares is :  " + stockPrice);
            totalPrice += (p * q);

        }
    }
}
