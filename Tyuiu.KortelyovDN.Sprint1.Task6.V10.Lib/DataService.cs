using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KortelyovDN.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            int len = value.Length;
            if (len % 2 != 0)
            {
                int mid = len / 2;
                return value.Remove(mid, 1);
            }
            return value;
        }
    }
}