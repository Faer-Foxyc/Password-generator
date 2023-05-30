using Password_generator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_generator
{
    public partial class StartFr : Form
    {
        public StartFr()
        {
            InitializeComponent();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int passwordLengt = Convert.ToInt32(PasswordTB.Text);
                bool symbols = SymbolscheckBox.Checked;

                PasswordGeneratorClass password = new PasswordGeneratorClass(symbols, passwordLengt);
                string answer = password.Generate();

                ResultTB.Text = answer;
            }
            catch (Exception)
            {
                string errorText = "The field: length password is not filled";
                MessageBox.Show($"{errorText}");
            }
        }

        public void CheckLengthSymbols()
        {
            try
            {
                int numbLength = Convert.ToInt32(PasswordTB.Text);

                if (numbLength > 30)
                {
                    MessageBox.Show("password length cannot be more 30 symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GenerateBtn.Visible = false;
                }
                else
                {
                    GenerateBtn.Visible = true;
                }
            }
            catch (Exception)
            {
                PasswordTB.Text = string.Empty;
            }
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            CheckLengthSymbols();
        }
    }
}
