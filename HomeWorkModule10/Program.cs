using HomeWorkModule10;
using System;
using System.Runtime.CompilerServices;

namespace InterfacePracticesInCore

{
    class Program
    {
        static ILogger Logger { get; set; }      
        static void Main(string[] args)
        {         
            Logger = new Logger();
            BaseCalculator calculator = new BaseCalculator(Logger);        

            try
            {
                Console.WriteLine("Введите первое значения для получения суммы из 2-х");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе значения для получения суммы из 2-х");
                int b = Convert.ToInt32(Console.ReadLine());
                calculator.Sum(a, b);
            }
            catch (FormatException ex) 
            {
                Logger.Error("Ошибка");                
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
      
    public interface ICalculator
    {       
        void Sum(int numberOne, int numberTwo);
    }
}
