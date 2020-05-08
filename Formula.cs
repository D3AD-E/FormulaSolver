using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaSolver
{
    public class Formula
    {
        public string m_body { get; set; }
        public string m_toFind { get; set; }
        public string m_units { get; set; }
        public Dictionary<string, string> m_constants;

        public Formula(string body, string toFind, string units, Dictionary<string,string> constants)
        {
            m_body = body;
            m_constants = constants;
            m_toFind = toFind;
            m_units = units;
        }

        public override string ToString()
        {
            return m_body;
        }

        public string StringInfo()
        {
            string toreturn = "Function is " + m_body + "; ";
            toreturn += "Where: ";
            foreach(var value in m_constants)
            {
                toreturn += value.Key + " is " + value.Value + "; ";
            }

            toreturn += "Find " + m_toFind + "; ";
            toreturn += "In units " + m_units + "; ";
            return toreturn;
        }

        bool CheckConstants()//undone
        {
            return true;
        }
    }
}
