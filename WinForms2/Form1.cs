using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class FormMain : Form
    {
        public FormMain()
        { 
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            
                int s = 0;
            int r = 0;
            int d = 0;
                if (checkBox1.Checked)
                    s = s + 639;
                if (checkBox2.Checked)
                    s = s + 449;
                if (checkBox3.Checked)
                    s = s + 539;
                if (checkBox4.Checked)
                    r = r + 179;
                if (checkBox5.Checked)
                    r = r + 349;
                if (checkBox6.Checked)
                    r = r + 279;
                if (checkBox7.Checked)
                    d = d + 179;
                if (checkBox8.Checked)
                    d = d + 129;
                if (checkBox9.Checked)
                    d = d + 89;
                if (checkBox10.Checked)
                    s = s + 95;
                if (checkBox11.Checked)
                    s = s + 95;
                if (checkBox12.Checked)
                    s = s + 55;
            if (checkBox13.Checked)
                r = r - ((10 * r) / 100);
            if (checkBox14.Checked)
                d = d - ((20 * d) / 100);
            if (s + r + d == 0)
            {
                MessageBox.Show("Вы ничего не выбрали", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (s + r + d != 0)
            {
                MessageBox.Show(Convert.ToString(s + r + d) + "₽", "Оплата прошла успешно",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp f2 = new FormHelp();
            f2.Show();
        }
        private void buttonSum_Click(object sender, EventArgs e)
        {
            int s = 0;
            int r = 0;
            int d = 0;
            if (checkBox1.Checked)
                s = s + 639;
            if (checkBox2.Checked)
                s = s + 449;
            if (checkBox3.Checked)
                s = s + 539;
            if (checkBox4.Checked)
                r = r + 179;
            if (checkBox5.Checked)
                r = r + 349;
            if (checkBox6.Checked)
                r = r + 279;
            if (checkBox7.Checked)
                d = d + 179;
            if (checkBox8.Checked)
                d = d + 129;
            if (checkBox9.Checked)
                d = d + 89;
            if (checkBox10.Checked)
                s = s + 95;
            if (checkBox11.Checked)
                s = s + 95;
            if (checkBox12.Checked)
                s = s + 55;
            if (checkBox13.Checked)
                r = r - ((10 * r) / 100);
            if (checkBox14.Checked)
                d = d - ((20 * d) / 100);
            if (s + r + d == 0)
            {
                textBox1.Text = "0 ₽";
                MessageBox.Show("Вы ничего не выбрали", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (s + r + d != 0)
            {
                textBox1.Text = Convert.ToString(s + r + d) + "₽";
            }
        }

        private void buttonToSendTheComment_Click(object sender, EventArgs e)
        {
            FormToSendTheComment f3 = new FormToSendTheComment();
            f3.Show();
        }
    }
}
