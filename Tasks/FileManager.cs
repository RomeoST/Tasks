using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tasks.Model;

namespace Tasks
{
    public static class FileManager
    {
        public static List<TriangleModel> list;
        public static void OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = new StreamReader(File.Open(dialog.FileName, FileMode.Open)))
                {
                    list = new List<TriangleModel>();
                    string line;
                    while((line = stream.ReadLine()) != null)
                    {
                        TriangleModel model = new TriangleModel();
                        model.listNum = new List<int>();

                        var mass = line.Split(new char[] { ' ' }).ToArray();
                        int num;
                        foreach (var item in mass)
                            if (int.TryParse(item, out num))
                                model.listNum.Add(num);

                        list.Add(model);
                    }
                }
            }
        }
    }
}
