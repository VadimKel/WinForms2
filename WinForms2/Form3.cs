using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class FormToSendTheComment : Form
    {
        public FormToSendTheComment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (InputText.Text == "")
            {
                MessageBox.Show("Введите отзыв в  текстовое окно и повтрите попытку");
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
