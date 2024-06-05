using FactoryDesignPattern.Abstruct_Product;
using FactoryDesignPattern.Concrete_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory_Product
{
    public static class LoggerFactory
    {
        public static ILogger CreateLogger(string loggerName)
        {
            switch (loggerName.ToLower())
            {
                case "console":
                    return new ConsoleLogger();
                case "file":
                    return new FileLogger("log.txt");
                case "database":
                    return new DatabaseLogger("data");
                default:
                    throw new NotImplementedException("Invalid Logger Type");

            }
        }
    }
}
