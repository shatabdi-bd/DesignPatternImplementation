using FactoryDesignPattern.Abstruct_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Concrete_Product
{
    public class FileLogger:ILogger
    {
        private string _fileName;
        public FileLogger(string fileName)
        {
            _fileName = fileName;
        }
        public void Log(string message)
        {
           File.AppendAllText(_fileName, "File " +message + Environment.NewLine);
        }
    }
}
