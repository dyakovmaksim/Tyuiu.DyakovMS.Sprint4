using Tyuiu.DyakovMS.Sprint4.Task7.V25.Lib;

namespace Tyuiu.DyakovMS.Sprint4.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string input = "348561792486";

            int result = ds.Calculate(4, 3, input);
            int wait = 38;

            Assert.AreEqual(wait, result);
        }
    }
}