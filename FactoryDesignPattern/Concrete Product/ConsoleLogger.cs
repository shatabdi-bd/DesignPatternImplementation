using FactoryDesignPattern.Abstruct_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Concrete_Product
{
    public class ConsoleLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Console: "+ message);
        }
    }
}
