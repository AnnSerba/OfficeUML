using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeConnsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "";
            string name = "";
            do
            {
                Console.WriteLine("Кто вы? (1. Юрист, 2. Секретарь, 3. Бухгалтер)");
                type = Console.ReadLine();
                if (type == "1" || type == "2" || type == "3")
                {
                    Console.WriteLine("Введите своё имя");
                    name = Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                }
            } while (true);

            Register register = new Register();
            if (type == "1")
            {
                Lawyer lawyer = new Lawyer(name, register);
            }
            else if (type == "2")
            {
                Secretary secretary = new Secretary(name, register);
            }
            else
            {
                Accountant accountant = new Accountant(name, register);
            }
        }
    }
}
