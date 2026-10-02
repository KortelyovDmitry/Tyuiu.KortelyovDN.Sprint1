using Tyuiu.KortelyovDN.Sprint1.Task6.V10.Lib;
namespace Tyuiu.KortelyovDN.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "123";
            DataService ds = new DataService();
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "13";
            Assert.AreEqual(wait, res);
        }
    }
}