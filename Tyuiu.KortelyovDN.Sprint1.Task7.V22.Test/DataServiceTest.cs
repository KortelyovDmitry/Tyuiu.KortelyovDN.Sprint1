using Tyuiu.KortelyovDN.Sprint1.Task7.V22.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = -7.47495024556639;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}