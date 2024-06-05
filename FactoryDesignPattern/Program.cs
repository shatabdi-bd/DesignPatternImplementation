using FactoryDesignPattern.Abstruct_Product;
using FactoryDesignPattern.Factory_Product;

public class Program
{
    public static void Main()
    {
        ILogger logger;
        logger = LoggerFactory.CreateLogger("Console");
        logger.Log("This is a console log!");

        logger = LoggerFactory.CreateLogger("File");
        logger.Log("This message is written to a file.");

        Console.ReadKey();  

    }
}