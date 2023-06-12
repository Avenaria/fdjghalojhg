using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdjghalojhg
{
    abstract class Human
    {
        public abstract string Firstname { get; set; }
        public abstract string Lastname { get; set; }

        public override string ToString()
        {
            return $" Фамилия {Lastname}, имя {Firstname}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public string Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $" Должность {Position}, зарплата {Salary}";
        }

    }
    interface IWoker
    {
        bool IsWorking { get; }
        string Work();
    }
    interface IManager
    {
        List<IWoker> ListOfW { get; set; }
        void oRG();
        void Make();
        void Control();
    }
    class Direktor : Employee, IManager
    {

       

    public override string Firstname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string Lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IWoker> ListOfW { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Control()
    {
        Console.WriteLine("Контроль работы ");
    }

    public void Make()
    {
        Console.WriteLine("Бюджет");
    }

    public void oRG()
    {
        Console.WriteLine("Работа");
    }
}







}

    
    



