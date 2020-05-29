using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    public class Creditor: Client 
    {
        public string Famil;
        public DateTime Date;
        public double prozent;
        public decimal razmer, osta;
        public Creditor(string famil, DateTime ddate, decimal rrazmer, double pprozent, decimal oosta)
        {
            Famil = famil;
            Date = ddate;
            razmer = rrazmer;
            prozent = pprozent;
            osta = oosta;
        }
        public override void Print()
        {
            Console.WriteLine("Фамилия:  " + Famil);
            Console.WriteLine("Дата открытия вклада:  " + Date);
            Console.WriteLine("Размер вклада:  " + razmer);
            Console.WriteLine("Процент по вкладу:  " + prozent);
            Console.WriteLine("Остаток долга: {0}", osta);
        }
        public override bool Quest(DateTime date)
        {
            if (Date == date)
                return true;
            return false;
        }
    }
}
