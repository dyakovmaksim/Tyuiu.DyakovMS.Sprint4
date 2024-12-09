using Tyuiu.DyakovMS.Sprint4.Task6.V6.Lib;

namespace Tyuiu.DyakovMS.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string[] inputArray = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            string[] result = ds.Calculate(inputArray);

            string[] wait = { "Борис", "Ирина" };
            CollectionAssert.AreEqual(wait, result);
        }
    }
}