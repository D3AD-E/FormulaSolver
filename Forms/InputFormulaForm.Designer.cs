namespace FormulaSolver
{
    partial class InputFormulaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LabelWhatToFind = new System.Windows.Forms.Label();
            this.LabelFormula = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridConstants = new System.Windows.Forms.DataGridView();
            this.Constant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConstants)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(12, 397);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(143, 41);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(208, 397);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(143, 41);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LabelWhatToFind
            // 
            this.LabelWhatToFind.AutoSize = true;
            this.LabelWhatToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWhatToFind.Location = new System.Drawing.Point(12, 72);
            this.LabelWhatToFind.Name = "LabelWhatToFind";
            this.LabelWhatToFind.Size = new System.Drawing.Size(48, 24);
            this.LabelWhatToFind.TabIndex = 2;
            this.LabelWhatToFind.Text = "Find";
            // 
            // LabelFormula
            // 
            this.LabelFormula.AutoSize = true;
            this.LabelFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFormula.Location = new System.Drawing.Point(12, 9);
            this.LabelFormula.Name = "LabelFormula";
            this.LabelFormula.Size = new System.Drawing.Size(80, 24);
            this.LabelFormula.TabIndex = 3;
            this.LabelFormula.Text = "Formula";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(16, 36);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(772, 20);
            this.textBoxBody.TabIndex = 4;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(16, 99);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(335, 20);
            this.textBoxFind.TabIndex = 5;
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnits.Location = new System.Drawing.Point(12, 122);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(51, 24);
            this.labelUnits.TabIndex = 6;
            this.labelUnits.Text = "Units";
            // 
            // textBoxUnits
            // 
            this.textBoxUnits.Location = new System.Drawing.Point(16, 149);
            this.textBoxUnits.Name = "textBoxUnits";
            this.textBoxUnits.Size = new System.Drawing.Size(335, 20);
            this.textBoxUnits.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(525, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Constants";
            // 
            // DataGridConstants
            // 
            this.DataGridConstants.AllowUserToResizeRows = false;
            this.DataGridConstants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridConstants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridConstants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Constant,
            this.Value,
            this.Power});
            this.DataGridConstants.Location = new System.Drawing.Point(357, 99);
            this.DataGridConstants.Name = "DataGridConstants";
            this.DataGridConstants.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridConstants.ShowCellToolTips = false;
            this.DataGridConstants.Size = new System.Drawing.Size(431, 339);
            this.DataGridConstants.TabIndex = 9;
            this.DataGridConstants.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridConstants_UserAddedRow);
            this.DataGridConstants.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridConstants_UserDeletedRow);
            // 
            // Constant
            // 
            this.Constant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Constant.HeaderText = "Name";
            this.Constant.Name = "Constant";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // Power
            // 
            this.Power.HeaderText = "Power";
            this.Power.Name = "Power";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(13, 59);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(80, 13);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "No errors found";
            // 
            // InputFormulaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.DataGridConstants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUnits);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.LabelFormula);
            this.Controls.Add(this.LabelWhatToFind);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Name = "InputFormulaForm";
            this.Text = "InputFormulaForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridConstants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabelWhatToFind;
        private System.Windows.Forms.Label LabelFormula;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DataGridConstants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Constant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.Label labelError;
    }
}