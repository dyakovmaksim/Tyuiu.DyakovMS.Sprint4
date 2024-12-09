using Tyuiu.DyakovMS.Sprint4.Task6.V6.Lib;
namespace Tyuiu.DyakovMS.Sprint4.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Класс Array                                                             *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Дьяков Максим Сергеевич | ИИПБ-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            Console.WriteLine("*Дан строковый массив данных, используя класс Array, выведите элементы    *");
            Console.WriteLine("*массива,длина которых равна 5 символам.                                  *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string[] inputArray = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string[] result = ds.Calculate(inputArray);
            Console.WriteLine("Элементы массива длиной 5 символов:");
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}