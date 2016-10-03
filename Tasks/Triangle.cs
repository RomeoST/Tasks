using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
    Знаю, можно было сделать через массивы =) Но захотелось через листы 
*/

namespace Tasks
{
    class Triangle
    {
        public Triangle()
        {
            Console.WriteLine("Triangle");
        }

        public void Show()
        {
            FileManager.OpenFile();
            if (FileManager.list == null || FileManager.list.Count == 0)
                return;
            // Начинаем с предпоследнего
            int sum = FindMax(FileManager.list.Count - 2);
            
            Console.WriteLine("Result : "+sum);
        }

        public int FindMax(int count)
        {
            for (int i = 0; i < FileManager.list[count].listNum.Count;i++)
                FileManager.list[count].listNum[i] += Math.Max(FileManager.list[count + 1].listNum[i], FileManager.list[count + 1].listNum[i + 1]);
            if (FileManager.list[count].listNum.Count == 1)
                return FileManager.list[count].listNum[0];
            else
                return FindMax(count - 1);
        }
    }
}
