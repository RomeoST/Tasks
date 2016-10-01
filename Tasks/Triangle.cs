using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            int sum = 0;
            int num = 0;
            string result = "";
            foreach(var item in FileManager.list)
            {
                if (item.listNum != null)
                {
                    num = item.listNum.Count > 1 ? item.listNum[item.listNum.Count - 2]
                                                     : item.listNum.Count > 0
                                                     ? item.listNum.Last()
                                                     : 0;
                    sum += num;
                    result += string.Format(" + {0}", num);
                }
            }
            Console.WriteLine(string.Format("{0} = {1}", result.Remove(0, 3), sum));
        }
    }
}
