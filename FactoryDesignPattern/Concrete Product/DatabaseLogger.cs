using FactoryDesignPattern.Abstruct_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Concrete_Product
{
    public class DatabaseLogger:ILogger
    {
        private string _databaseLogger;

        public DatabaseLogger(string databaseLogger)
        {
            _databaseLogger = databaseLogger;
        }

        public void Log(string message)
        {
           Console.WriteLine("DatabaseLogger " +message );
        }
    }
}
