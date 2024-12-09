using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyakovMS.Sprint4.Task3.V23.Lib
{
    public class DataService : ISprint4Task3V23
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            foreach (var item in array) 
            {
                sum += item;
            }
            return sum;
        }
    }
}
