using Tyuiu.KortelyovDN.Sprint1.Task5.V4.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int x = 3600;
            DataService ds = new DataService();
            double res = ds.SecondsToHours(x);

            int result = Convert.ToInt32(res);

            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}
