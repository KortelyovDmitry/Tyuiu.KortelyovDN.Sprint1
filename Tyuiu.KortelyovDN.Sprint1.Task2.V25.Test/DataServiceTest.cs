using Tyuiu.KortelyovDN.Sprint1.Task2.V25.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(57.296, res);
        }
    }
}
