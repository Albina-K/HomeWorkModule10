using InterfacePracticesInCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkModule10
{
    public class BaseCalculator : ICalculator
    {
        ILogger Logger { get; }
        public BaseCalculator(ILogger logger)
        {
            Logger = logger;
        }
        public void Sum(int numberOne, int numberTwo)
        {
            Logger.Event("Сумма");
            var sum = numberOne + numberTwo;
            Console.WriteLine(sum);

        }
    }
}
