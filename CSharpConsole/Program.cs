using CLRInteropLib;

namespace CSharpConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Class1 c1 = new Class1();
            int num = c1.GetNum;
        }
    }
}