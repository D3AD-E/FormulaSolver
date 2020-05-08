using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaSolver
{
    class FileWorker
    {
        public static void WriteToFile(string text, string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(text);
            }
        }

        public static void AppendToFile(string text, string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.Write(text);
            }
        }

        public Dictionary<string,string> ReadFromFileDict(string path)
        {
            Dictionary<string, string> toreturn = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(path))
            {
                string _line;
                while ((_line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = _line.Split('|');
                    if (keyvalue.Length == 2)
                    {
                        toreturn.Add(keyvalue[0], keyvalue[1]);
                    }
                }
                return toreturn;
            }
        }
        public string Convert(Dictionary<string, string> dict)
        {
            string toreturn = "";
                foreach (var entry in dict)
                    toreturn+= entry.Key + "|" + entry.Value + "\n";
            return toreturn;
        }

        public static string readID()
        {
            using (StreamReader sr = new StreamReader("appID.txt"))
            {
                return sr.ReadLine();
            }
        }
    }
}
