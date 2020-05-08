namespace FormulaSolver
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRmv = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.listBoxFormula = new System.Windows.Forms.ListBox();
            this.checkBoxAppend = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(634, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(154, 42);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAddFormula_Click);
            // 
            // BtnRmv
            // 
            this.BtnRmv.Location = new System.Drawing.Point(634, 60);
            this.BtnRmv.Name = "BtnRmv";
            this.BtnRmv.Size = new System.Drawing.Size(154, 41);
            this.BtnRmv.TabIndex = 2;
            this.BtnRmv.Text = "Remove";
            this.BtnRmv.UseVisualStyleBackColor = true;
            this.BtnRmv.Click += new System.EventHandler(this.BtnRmv_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(634, 370);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(154, 41);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Calculate";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(634, 323);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSettings.Size = new System.Drawing.Size(154, 41);
            this.BtnSettings.TabIndex = 4;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(634, 107);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(154, 41);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // listBoxFormula
            // 
            this.listBoxFormula.FormattingEnabled = true;
            this.listBoxFormula.Location = new System.Drawing.Point(12, 9);
            this.listBoxFormula.Name = "listBoxFormula";
            this.listBoxFormula.Size = new System.Drawing.Size(616, 394);
            this.listBoxFormula.TabIndex = 6;
            // 
            // checkBoxAppend
            // 
            this.checkBoxAppend.AutoSize = true;
            this.checkBoxAppend.Location = new System.Drawing.Point(634, 154);
            this.checkBoxAppend.Name = "checkBoxAppend";
            this.checkBoxAppend.Size = new System.Drawing.Size(124, 17);
            this.checkBoxAppend.TabIndex = 7;
            this.checkBoxAppend.Text = "Append results to file";
            this.checkBoxAppend.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 419);
            this.Controls.Add(this.checkBoxAppend);
            this.Controls.Add(this.listBoxFormula);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnRmv);
            this.Controls.Add(this.BtnAdd);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRmv;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ListBox listBoxFormula;
        private System.Windows.Forms.CheckBox checkBoxAppend;
    }
}

