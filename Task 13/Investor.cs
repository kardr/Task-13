using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    public class Investor : Client
    {
        public string Famil;
        public DateTime Date;
        public double  prozent;
        public decimal razmer;
        public Investor (string famil, DateTime ddate, decimal rrazmer, double pprozent)
        {
            Famil = famil;
            Date = ddate;
            razmer = rrazmer;
            prozent = pprozent;
        }
        public override void Print()
        {
            Console.WriteLine("Фамилия:  " + Famil);
            Console.WriteLine("Дата открытия вклада:  " + Date);
            Console.WriteLine("Размер вклада:  " + razmer);
            Console.WriteLine("Процент по вкладу: " + prozent);
        }
        public override bool Quest(DateTime date)
        {
            if (Date == date)
                return true;
            return false;
        }
    }
}
