using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(221, 160, 221);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkPeople.Checked == false && checkFood.Checked == false && checkOther.Checked == false)
            {
                errorProvider1.SetError(btnPlay, "изберете категорија");
            }
            else
            {
                errorProvider1.Clear();
                int check = 0;
                if (checkPeople.Checked == true)
                {
                    check = 2;
                    checkPeople.Checked = false;
                }
                else if (checkFood.Checked == true)
                {
                    check = 1;
                    checkFood.Checked = false;
                }
                else if (checkOther.Checked == true)
                {
                    check = 3;
                    checkOther.Checked = false;
                }
                Form2 form2 = new Form2(check);
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }

        private void checkFood_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFood.Checked == true)
            {
                checkPeople.Checked = false;
                checkOther.Checked = false;
            }
        }

        private void checkPeople_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPeople.Checked == true)
            {
                checkFood.Checked = false;
                checkOther.Checked = false;
            }
        }

        private void checkOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOther.Checked == true)
            {
                checkPeople.Checked = false;
                checkFood.Checked = false;
            }
        }

        
    }
}
