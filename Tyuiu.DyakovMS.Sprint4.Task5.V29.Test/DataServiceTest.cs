using Tyuiu.DyakovMS.Sprint4.Task5.V29.Lib;

namespace Tyuiu.DyakovMS.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1, -2, 3, 4, -5 },
                { -6, 7, -8, 9, 10 },
                { 11, -12, 13, -14, 15 },
                { -16, 17, -18, 19, 20 },
                { 21, -22, 23, -24, 25 }
            };
            int result = ds.Calculate(matrix);
            int wait = 15;
            Assert.AreEqual(wait, result);
        }
    }
}