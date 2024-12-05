using Tyuiu.DyakovMS.Sprint4.Task1.V6.Lib;
namespace Tyuiu.DyakovMS.Sprint4.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Одномерные массивы                                                      *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный значениям*");
            Console.WriteLine("*ми с клавиатуры в диапазоне от 2 до 7 подсчитать произведение четных элем*");
            Console.WriteLine("*ментов массива.  С клавиатуры: 2, 4, 4, 7, 2, 5, 4, 3, 3, 4              *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[10];
            Console.WriteLine("Введите 10 целых чисел от 2 до 7:");
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out array[i]) && array[i] >= 2 && array[i] <= 7)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Введите число от 2 до 7.");
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(array);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}