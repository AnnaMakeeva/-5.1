using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задаем массив из 7 чисел
            int[] my_array = new int[7];

            int result;
            Console.Write("Введите семь цифр:");
            
            for (int j = 0; j <= 6; j++)
            {
                my_array[j] = Convert.ToInt32(Console.ReadLine());
            }


            //для суммы заводим переменную за пределами цикла. проинициализирую ее нулем
            int S = 0;

            for (int i = 0; i <my_array.Length; i++)
            {
               
              // буду накапливать сумму
                S += my_array[i];


            }

            result = S / my_array.Length;

            //выводим в строчку {0}-форматированный вывод 
            Console.Write("Средняя арифметическая={0}", result);



            Console.ReadKey();


        }
    }
    
}
