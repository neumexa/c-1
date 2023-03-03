using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Money
    {
   
        int denomination;
        int count;
        public Money(int denomination, int count)
        {
            this.denomination = denomination;
            this.count = count;
        }
        public void Show()
        {
            Console.WriteLine("Номинал купюры = {0}, количество купюр = {1}", denomination, count);
        }
        public string Summa(int sum)
        {
            if (denomination * count > sum)
                return "Хватит";
            return "Не хватит";
        }
        public int Product_count(int product_price)
        {
            return (int)((denomination * count) / product_price);
        }
        public int Denomination
        {
            set { denomination = value; }
            get { return denomination; }
        }

        public int Count
        {
            set { count = value; }
            get { return count; }
        }
        public int Total { get { return denomination * count; } }
    }
