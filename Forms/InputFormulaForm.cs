using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaSolver
{
    public partial class InputFormulaForm : Form
    {
        public Formula ReturnFormula { get; set; }

        private Dictionary<string, string> constants = new Dictionary<string, string>();

        public InputFormulaForm()
        {
            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count == 0)
            {
                Console.WriteLine("AppSettings is empty.");
            }
            else
            {
                foreach (var key in appSettings.AllKeys)
                {
                    constants.Add(key, appSettings[key]);
                }
            }
            InitializeComponent();
            foreach (var instance in constants)
            {
                string[] keyvalue = instance.Value.Split('e');
                DataGridConstants.Rows.Add(instance.Key, keyvalue[0], keyvalue[1]);
            }
            textBoxBody.Focus();
            //textBoxBody.Focus;
        }

        public InputFormulaForm(Formula input)
        {
            InitializeComponent();
            foreach (var key in input.m_constants.Keys)
            {
                constants.Add(key, input.m_constants[key]);
            }
            foreach (var instance in constants)
            {
                string[] keyvalue = instance.Value.Split('e');
                DataGridConstants.Rows.Add(instance.Key, keyvalue[0], keyvalue[1]);
            }
            textBoxBody.Text = input.m_body;
            textBoxFind.Text = input.m_toFind;
            textBoxUnits.Text = input.m_units;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int check = CheckBrackets();
            if(check == -1)
            {
                constants.Clear();
                for (int i = 0; i < DataGridConstants.Rows.Count - 1; i++)
                {
                    if (DataGridConstants.Rows[i].Cells[2].Value == null)
                        constants.Add(DataGridConstants.Rows[i].Cells[0].Value.ToString(), DataGridConstants.Rows[i].Cells[1].Value.ToString()); // undone
                    else
                        constants.Add(DataGridConstants.Rows[i].Cells[0].Value.ToString(), DataGridConstants.Rows[i].Cells[1].Value.ToString() + "e" + DataGridConstants.Rows[i].Cells[2].Value.ToString()); // undone
                }
                check = CheckConstants();
                if(check == -1)
                {
                    Formula formula = new Formula(textBoxBody.Text, textBoxFind.Text, textBoxUnits.Text, constants);
                    this.ReturnFormula = formula;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    GotError(check, "Unknown variable " + textBoxBody.Text[check] + " at " + check.ToString());
                }
            }
            else
            {
                GotError(check, "Unclosed bracket at " + check.ToString());
            }
        }

        private int CheckConstants()
        {
            string body = textBoxBody.Text;
            body = body.ToLower();
            body = body.Replace("sqrt", "0000");
            body = body.Replace("sin", "000");
            body = body.Replace("cos", "000");
            body = body.Replace("tg", "00");
            body = body.Replace("ctg", "000");
            var constantsDict = constants;
            int size = 0;
            foreach (var value in constantsDict)
            {
                if (value.Key.Length > size)
                    size = value.Key.Length;
            }
            while (size != 0)
            {
                foreach (var value in constantsDict)
                {
                    if (value.Key.Length == size)
                    {
                        string toAdd = "";
                        for (int i = 0; i < size; i++)
                            toAdd += "0";
                        body = body.Replace(value.Key, toAdd);
                    }
                }
                size--;
            }
            return body.IndexOfAny("qwertyuiopasdfghjklzxcvbnm".ToCharArray());
        }

        private void GotError(int place, string errorText)
        {
            textBoxBody.Focus();
            textBoxBody.SelectionStart = place;
            textBoxBody.SelectionLength = 1;
            labelError.Text = errorText;
        }
        private int CheckBrackets()
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i <textBoxBody.TextLength; i++)
            {
                if (textBoxBody.Text[i] == '(')
                {
                    stack.Push('(');
                }
                else if (textBoxBody.Text[i]== ')')
                {
                    if (stack.Count == 0)
                        return i;
                    if (stack.Pop() != '(')
                    {
                        return i;
                    }
                }
            }
            if (stack.Count != 0)
                return textBoxBody.Text.IndexOf('(');
            return -1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void DataGridConstants_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            
        }

        private void DataGridConstants_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
