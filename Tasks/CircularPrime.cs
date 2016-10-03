using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class CircularPrime
    {
        private const int LIMIT = 1000000;

        private SortedSet<int> list;
        public CircularPrime()
        {
            Console.WriteLine("Circular Prime");
        }

        public void Show()
        {
            // Медленный алгоритм
            /*int num, i, count, y;
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
            Console.WriteLine("Всього чисел: " + (count-1) + " до "+ num);*/

            // Более быстрый и оптимизированый вариант
            // Получается удаляет квадрат чисел + сдвиг (0 - не простое, 1 - простое)
            // Это алгоритм Эратосфена, что бы не придумывать велосипед
            int n = 1000000;
            List<int> S = new List<int>(n);
            for(int i = 0; i < n; i++)
                S.Add(i);
            S[1] = 0; // по дефолту 1 не простое число

            for (int k = 2; k <= n-1; k++)
                S[k] = 1;
            for (int z = 2; z * z <= n; z++)
            {
                // если k - простое
                if (S[z] == 1)
                {
                    // то вычеркнем кратные k
                    for (int l = z * z; l <= n-1; l += z)
                    {
                        S[l] = 0;
                    }
                }
            }

            for(int i = 0; i < n;i++)
            {
                if (S[i] == 1)
                    Console.Write(i+"\t");
            }
        }
    }
}
