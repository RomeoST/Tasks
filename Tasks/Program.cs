using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        enum NumTask
        {
            eTRIANGLE = 1,
            eCIRCULAR
        }

        [STAThread]
        static void Main(string[] args)
        {
            StartTask();

            for (;;) ;
        }

        public static void StartTask()
        {
            int num;
            Console.WriteLine("Обрати номер завдання <1-2>(Triangle/Circular)");
            if (!int.TryParse(Console.ReadLine(), out num))
                StartTask();

            switch ((NumTask)num)
            {
                case NumTask.eTRIANGLE:
                    {
                        new Triangle().Show();
                    }
                    break;
                case NumTask.eCIRCULAR:
                    {
                        new CircularPrime().Show();
                    }
                    break;
                default:break;
            }
        }
    }
}
