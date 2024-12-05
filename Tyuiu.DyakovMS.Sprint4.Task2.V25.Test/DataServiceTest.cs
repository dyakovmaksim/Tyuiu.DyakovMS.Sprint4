using Tyuiu.DyakovMS.Sprint4.Task2.V25.Lib;

namespace Tyuiu.DyakovMS.Sprint4.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 7, 8, 5, 3, 9, 6, 5, 6, 4, 8 };

            int res = ds.Calculate(numsArray);
            int wait = 73728;

            Assert.AreEqual(wait, res);
        }
    }
}