using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FormulaSolver
{
    class APIWolframAlfa
    {
        private string link;

        public APIWolframAlfa()
        {
            link = "http://api.wolframalpha.com/v2/query?input={0};&appid=" + FileWorker.readID()+ "&includepodid=Result&format=plaintext";
        }
        public static void Test()
        {
            /*
            var client = new HttpClient();
            var response = client.GetAsync(link).Result;
            client.Dispose();
            string resultContent = response.Content.ReadAsStringAsync().Result;
            var xml = new XmlDocument();
            xml.LoadXml(resultContent);
            XmlNodeList elemList = xml.GetElementsByTagName("plaintext");
            //Logger.Log(resultContent);
            string innerText = elemList[0].InnerText;
            Logger.Log("Got " + innerText);
            Logger.Log("Result " + innerText.Split('≈')[1]);*/
        }

        public string Parse(Formula formula)
        {
            string body = formula.m_body;
            body = body.ToLower();
            body = body.Replace(" ", "");
            body = body.Replace("sqrt", "0_");
            body = body.Replace("sin", "1_");
            body = body.Replace("cos", "2_");
            body = body.Replace("tg", "3_");
            body = body.Replace("ctg", "4_");
            var constantsDict = formula.m_constants;
            int size = 0;
            foreach (var value in constantsDict)
            {
                if (value.Key.Length > size)
                    size = value.Key.Length;
            }
            while (size!=0)
            {
                foreach (var value in constantsDict)
                {
                    if (value.Key.Length == size)
                        body = body.Replace(value.Key, value.Value);
                }
                size--;
            }
            body = body.Replace("0_", "sqrt");
            body = body.Replace("1_", "sin");
            body = body.Replace("2_", "cos");
            body = body.Replace("3_", "tg");
            body = body.Replace("4_", "ctg");
            string toreturn = string.Format(link, body);
            return toreturn;
        }

        public string Solve(Formula formula)
        {
            var client = new HttpClient();
            string link = Parse(formula);
            var response = client.GetAsync(link).Result;
            client.Dispose();
            string resultContent = response.Content.ReadAsStringAsync().Result;
            Logger.Log(link);
            Logger.Log(resultContent);
            var xml = new XmlDocument();
            xml.LoadXml(resultContent);
            XmlNodeList elemList = xml.GetElementsByTagName("plaintext");
            string innerText = elemList[0].InnerText;
            Logger.Log(formula);
            Logger.Log("Got " + innerText);
            return innerText.Replace("...", "");
        }
    }
}
