using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class CircularPrime
    {
        private const int LIMIT = 1000000;
        public CircularPrime()
        {
            Console.WriteLine("Circular Prime");
        }

        public void Show()
        {
            int num, i, count, y;
            i = 3;

            if (!int.TryParse(Console.ReadLine(), out num) && num >= 1)
            {
                Console.WriteLine("Не вірні дані");
                return;
            }
            Console.WriteLine("----\nОбчислення...\n");

            // Перебір наших основних чисел
            for(count = 2; count <= LIMIT;)
            {
                // Перевірка числа, на що він може ділитись націло
                for(y = 2; y < i; y++)
                {
                    if (i % y == 0)
                        break;
                }
                // Останній цикл дійшов до кінця - true
                if(y==i)
                {
                    //Console.WriteLine(i);
                    count++;
                }
                i++;
                if (i == num)
                    break;
            }
            Console.WriteLine("Всього чисел: " + (count-1) + " до "+ num);
        }
    }
}
