
using Tyuiu.KortelyovDN.Sprint1.Task6.V10.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку");
            string value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.DeleteMiddleLetter(value);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

