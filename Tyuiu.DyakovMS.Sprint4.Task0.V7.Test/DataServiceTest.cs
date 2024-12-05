using Tyuiu.DyakovMS.Sprint4.Task0.V7.Lib;

namespace Tyuiu.DyakovMS.Sprint4.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            int wait = 178605;

            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}