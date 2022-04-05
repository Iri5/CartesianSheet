using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
namespace Cartesian_Sheet
{
    internal class FileData
    {
        public void SaveInput(string from, string to, string step, string param)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(fileName, from + Environment.NewLine + to 
                + Environment.NewLine + step + Environment.NewLine  + param);
           
            MessageBox.Show("Файл сохранен");
        }
        public void SaveResults(string from, string to, string step, string param, List<FunctionArg> list)
        {
            string[] strParam = new string[4];
            strParam[0] = "From:" + from;
            strParam[1] = "To: " + to;
            strParam[2] = "Step:" + step;
            strParam[3] = "Parameter:" + param;
            string x = "";
            string y = "";
            string[] strTable = new string[list.Count];
            for (int i = 0; i < list.Count; i++)
                {
                    x = (list[i].X).ToString();
                    y = (list[i].Y).ToString();
                    strTable[i] = x + ": " + y;
                }
            string[] all = strParam.Concat(strTable).ToArray();
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string fileName = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllLines(fileName, all);
            MessageBox.Show("Файл сохранен");
        }
    }
}
