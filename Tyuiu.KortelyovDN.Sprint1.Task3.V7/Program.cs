using Tyuiu.KortelyovDN.Sprint1.Task3.V7.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 100;
            Console.WriteLine("Расстояние в верстах - " + a);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Расстояние в километрах - " + Math.Round(ds.VerstsToKilometers(a), 3));

            Console.ReadKey();

        }
    }
}