using Tyuiu.KortelyovDN.Sprint1.Task4.V6.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("abs(y ^ 2 - x) / (x * y) = " + ds.Calculate(x, y));

            Console.ReadKey();

        }
    }
}