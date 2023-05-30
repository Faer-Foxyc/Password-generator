namespace Password_generator
{
    partial class StartFr
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
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.SymbolscheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LengthPasswlabel = new System.Windows.Forms.Label();
            this.ResultTB = new System.Windows.Forms.TextBox();
            this.ExitBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(6, 70);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 0;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // SymbolscheckBox
            // 
            this.SymbolscheckBox.AutoSize = true;
            this.SymbolscheckBox.Location = new System.Drawing.Point(162, 10);
            this.SymbolscheckBox.Name = "SymbolscheckBox";
            this.SymbolscheckBox.Size = new System.Drawing.Size(65, 17);
            this.SymbolscheckBox.TabIndex = 2;
            this.SymbolscheckBox.Text = "Symbols";
            this.SymbolscheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(110, 7);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(36, 20);
            this.PasswordTB.TabIndex = 4;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // LengthPasswlabel
            // 
            this.LengthPasswlabel.AutoSize = true;
            this.LengthPasswlabel.Location = new System.Drawing.Point(9, 10);
            this.LengthPasswlabel.Name = "LengthPasswlabel";
            this.LengthPasswlabel.Size = new System.Drawing.Size(95, 13);
            this.LengthPasswlabel.TabIndex = 5;
            this.LengthPasswlabel.Text = "Length Password: ";
            // 
            // ResultTB
            // 
            this.ResultTB.Location = new System.Drawing.Point(6, 44);
            this.ResultTB.Name = "ResultTB";
            this.ResultTB.Size = new System.Drawing.Size(221, 20);
            this.ResultTB.TabIndex = 6;
            // 
            // ExitBt
            // 
            this.ExitBt.Location = new System.Drawing.Point(152, 70);
            this.ExitBt.Name = "ExitBt";
            this.ExitBt.Size = new System.Drawing.Size(75, 23);
            this.ExitBt.TabIndex = 7;
            this.ExitBt.Text = "Exit";
            this.ExitBt.UseVisualStyleBackColor = true;
            this.ExitBt.Click += new System.EventHandler(this.ExitBt_Click);
            // 
            // StartFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 102);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBt);
            this.Controls.Add(this.ResultTB);
            this.Controls.Add(this.LengthPasswlabel);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.SymbolscheckBox);
            this.Controls.Add(this.GenerateBtn);
            this.Name = "StartFr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.CheckBox SymbolscheckBox;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label LengthPasswlabel;
        private System.Windows.Forms.TextBox ResultTB;
        private System.Windows.Forms.Button ExitBt;
    }
}

