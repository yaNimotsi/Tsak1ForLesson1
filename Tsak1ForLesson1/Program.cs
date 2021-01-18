using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsak1ForLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dToday = DateTime.Now.ToString("D");

            Console.Write("Укажите свое имя: ");
            var userName = Console.ReadLine();

            Console.WriteLine("Привет {0}, сегодня {1}", userName, dToday);
            Console.WriteLine($"Привет {userName}, сегодня {dToday}");

            Console.ReadLine();
        }
    }
}
