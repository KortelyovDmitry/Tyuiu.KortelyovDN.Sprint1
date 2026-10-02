using Tyuiu.KortelyovDN.Sprint1.Task4.V6.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 0.125;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
