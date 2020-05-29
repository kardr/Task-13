using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clientList = new List<Client>();
            StreamReader sr = new StreamReader(@"C:\Users\KDroz\OneDrive\Рабочий стол\Практика\Неделя 4\Задание 13\1.txt", Encoding.Default);
            while (!sr.EndOfStream)
            {
                string[] s = sr.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (s.Length == 5)
                {
                    clientList.Add(new Creditor(s[0], Convert.ToDateTime(s[1]), Convert.ToDecimal(s[2]),
                                                      Convert.ToDouble(s[3]), Convert.ToDecimal(s[4])));
                }
                if (s.Length == 4)
                {
                    int number;
                    if (Int32.TryParse(s[2], out number))
                    {
                        clientList.Add(new Organization(s[0], Convert.ToDateTime(s[1]),
                                                     number, Convert.ToDecimal(s[3])));
                    }
                    else
                    {
                        clientList.Add(new Investor(s[0], Convert.ToDateTime(s[1]),
                                  Convert.ToDecimal(s[2]), Convert.ToDouble(s[3])));
                    }
                }
            }
            sr.Close();

            foreach (Client client in clientList)
            {
                client.Print();
                Console.WriteLine();
            }

            Console.WriteLine("\nПоиск клиентов, начавших сотрудничать с банком в заданную дату:");

            DateTime askDate = new DateTime(2017, 12, 13);
            int foundClients = 0;

            foreach (Client client in clientList)
            {
                if (client.Quest(askDate))
                {
                    client.Print();
                    foundClients++;
                    Console.WriteLine();
                }
            }
            if (foundClients == 0)
            {
                Console.WriteLine("Клиенты по данной дате не найдены");
            }
            Console.ReadLine();
        }
    }
}
