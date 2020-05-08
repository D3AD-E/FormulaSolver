using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaSolver
{
    class Logger
    {
        public static void Log(string text)
        {
            string timeStamp = DateTime.Now.ToString();
            text = timeStamp + " " + text +Environment.NewLine;
            FileWorker.AppendToFile(text, "Log.txt");
        }

        public static void Log(Formula formula)
        {
            string text = DateTime.Now.ToString() + " Got formula: ";
            text += formula.StringInfo() +Environment.NewLine;
            FileWorker.AppendToFile(text, "Log.txt");
        }
    }
}
