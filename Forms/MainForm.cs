using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulaSolver
{
    public partial class MainForm : Form
    {
        private List<Formula> formulas = new List<Formula>();
        public MainForm()
        {
            Logger.Log("-------START OF CURRENT SESSION-------");
            InitializeComponent();
        }

        private void BtnAddFormula_Click(object sender, EventArgs e)
        {
            InputFormulaForm inputFormulaForm = new InputFormulaForm();
            var result = inputFormulaForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                formulas.Add(inputFormulaForm.ReturnFormula);
                Logger.Log(inputFormulaForm.ReturnFormula);
            }
            BindingList<Formula> lis = new BindingList<Formula>(formulas);
            listBoxFormula.DataSource = lis;
        }

        private void BtnRmv_Click(object sender, EventArgs e)//undone
        {
            if(listBoxFormula.Items.Count != 0)
            {
                Logger.Log("Removed formula at index " + listBoxFormula.SelectedIndex + " It was " + listBoxFormula.SelectedItem.ToString());
                formulas.RemoveAt(listBoxFormula.SelectedIndex);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Log("-------END OF CURRENT SESSION-------");
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxFormula.Items.Count != 0)
            {
                Logger.Log("Changed formula at index " + listBoxFormula.SelectedIndex + " It was " + listBoxFormula.SelectedItem.ToString());
                InputFormulaForm inputFormulaForm = new InputFormulaForm(formulas[listBoxFormula.SelectedIndex]);
                var result = inputFormulaForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formulas[listBoxFormula.SelectedIndex] = inputFormulaForm.ReturnFormula;
                    Logger.Log(inputFormulaForm.ReturnFormula);
                }
                BindingList<Formula> lis = new BindingList<Formula>(formulas);
                listBoxFormula.DataSource = lis;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            string fileName = "Results.txt";
            var api = new APIWolframAlfa();
            string toWrite = "";
            foreach(var formula in formulas)
            {
                toWrite += formula.m_toFind + " = " + api.Solve(formula) + "[" + formula.m_units + "]" + Environment.NewLine;
            }
            MessageBox.Show(toWrite, "Results");
            if (checkBoxAppend.Checked)
                FileWorker.AppendToFile(toWrite, fileName);
            else
                FileWorker.WriteToFile(toWrite, fileName);
        }
    }
}
