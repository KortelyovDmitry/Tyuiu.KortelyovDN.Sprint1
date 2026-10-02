using Tyuiu.KortelyovDN.Sprint1.Task3.V7.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 100;
            double wait = 106.86;
            var res = ds.VerstsToKilometers(x);
            Assert.AreEqual(wait, res); 
        }
    }
}
