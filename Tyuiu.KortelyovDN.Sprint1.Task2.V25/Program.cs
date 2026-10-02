using Tyuiu.KortelyovDN.Sprint1.Task2.V25.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            Console.WriteLine("Введите угол в радианах");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Угол в градусах = " + ds.ConvertRadsToDegrees(x));

            Console.ReadLine();
        }
    }
}