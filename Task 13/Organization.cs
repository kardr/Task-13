using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    public class Organization: Client
    {
        public string name;
        public DateTime Date;
        public double number;
        public decimal sum;
        public Organization(string nname, DateTime ddate,  double nnumber, decimal ssum)
        {
            name = nname;
            Date = ddate;
            number = nnumber;
            sum = ssum;
        }
        public override void Print()
        {
            Console.WriteLine("Hазвание:  " + name);
            Console.WriteLine("Дата открытия счета:  " + Date);
            Console.WriteLine("Номер счета:  " + number);
            Console.WriteLine("Cумма на счету: {0}", sum);
        }
        public override bool Quest(DateTime date)
        {
            if (Date == date)
                return true;
            return false;
        }
    }
}
