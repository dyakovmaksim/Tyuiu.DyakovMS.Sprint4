using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyakovMS.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int sumOfEvens = 0;
            foreach (var num in matrix)
            {
                if (num % 2 == 0)
                {
                    sumOfEvens += num;
                }
            }

            return sumOfEvens;
        }
    }
}
