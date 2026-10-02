using Tyuiu.KortelyovDN.Sprint1.Task7.V22.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("                 ctg x                                           ");
            Console.WriteLine("* z = (1 - tan x)      + cos(x - y)                                                  *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("*Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}