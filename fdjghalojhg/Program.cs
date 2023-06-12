using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdjghalojhg
{
    internal class Program
    {
        //либо публичный но чаще всего
        public interface IResearcher
        {
            void Inverstigate();
            void Invent();
             string str { get; set; }
        }
        static void Main(string[] args)
        {

            Direktor direktor = new Direktor
            {
                Lastname = "Иванов",
                Firstname = "Иванов  ",
                Position = "Директор  ",
                Salary = " 120"

            };
            Console.WriteLine($"Зарплата директора { (direktor.Lastname)},{direktor.Salary}");
            

        }
    }
}
