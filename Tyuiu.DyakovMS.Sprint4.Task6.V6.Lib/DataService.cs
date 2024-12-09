using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DyakovMS.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            return array.Where(item => item.Length == 5).ToArray();
        }
    }
}
