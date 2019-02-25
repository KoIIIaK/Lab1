using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Global
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int YearOpen { get; set; }

        public void Print()
        {
            Console.WriteLine("Название " + Name + "Адрес " + Address + "Год открытия " + YearOpen);
        }

        public void Read()
        {
            Console.WriteLine("Введите название библиотеки");
            Name = Console.ReadLine();
            Console.WriteLine("Введите адрес библиотеки");
            Address = Console.ReadLine();
            Console.WriteLine("Введите год открытия библиотеки");
            YearOpen = Convert.ToInt16(Console.ReadLine());
        }

        public Global()
        {
            Name = "";
            Address = "";
            YearOpen = 0;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
