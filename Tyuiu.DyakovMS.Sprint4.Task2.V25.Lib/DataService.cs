using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyakovMS.Sprint4.Task2.V25.Lib
{
    public class DataService : ISprint4Task2V25
    {
        public int Calculate(int[] array)
        {
            int product = 1;

            foreach (int i in array)
            {
                if (i % 2 == 0)
                {
                    product *= i;
                }
            }
            return product;
        }
    }
}
