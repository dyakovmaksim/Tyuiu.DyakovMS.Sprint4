using Tyuiu.DyakovMS.Sprint4.Task5.V29.Lib;
namespace Tyuiu.DyakovMS.Sprint4.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Двумерные массивы (генератор случайных чисел)                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайны*");
            Console.WriteLine("*ыми значениями в диапазоне от -9 до 9. Найти количество положительных эле*");
            Console.WriteLine("*ементов.                                                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rand = new Random();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Сгенерированный массив:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(matrix);
            Console.WriteLine("Количество положительных элементов в массиве: " + result);
            Console.ReadKey();
        }
    }
}