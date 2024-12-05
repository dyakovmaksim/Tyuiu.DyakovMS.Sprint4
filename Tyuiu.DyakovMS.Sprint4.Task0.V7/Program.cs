using Tyuiu.DyakovMS.Sprint4.Task0.V7.Lib;
namespace Tyuiu.DyakovMS.Sprint4.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Обработка структурных типов                                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                            *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный статическ*");
            Console.WriteLine("*кими значениями в диапазоне от 0 до 9 подсчитать произведение нечетных эл*");
            Console.WriteLine("*лементов массива.  {9, 8, 7, 9, 5, 4, 3, 2, 3, 7}                        *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetMultOddArrEl(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}