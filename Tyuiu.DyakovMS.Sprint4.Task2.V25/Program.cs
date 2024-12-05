using Tyuiu.DyakovMS.Sprint4.Task2.V25.Lib;
namespace Tyuiu.DyakovMS.Sprint4.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы (генератор случайных чисел)                          *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 11 элементов заполненный случайным*");
            Console.WriteLine("*ми в диапазоне от 3 до 9 подсчитать произведение четных элементов массива*");
            Console.WriteLine("*а.                                                                       *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rand = new Random();
            int len = 11;

            int[] numsArray = new int[len];

            for (int i = 0; i <= len - 1; i++)
            {
                numsArray[i] = rand.Next(3, 10);
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++) 
            {
                Console.WriteLine(numsArray[i] + "\t");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(numsArray);
            Console.WriteLine("Произведение четных элементов массива = " + result);
            Console.ReadKey();
        }
    }
}