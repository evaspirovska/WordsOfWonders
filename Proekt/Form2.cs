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
using Proekt.Properties;

namespace Proekt
{
    public partial class Form2 : Form
    {
        public string imageName { get; set; }
        public int count { get; set; }
        public int category { get; set; }
        Game game;
        private int timeOut;
        private static int maxTime = 600;
        private bool OnOff;

        public Form2(int c)
        {
            InitializeComponent();
            this.category = c;
            OnOff = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(221, 160, 221);
            Words.BackColor = Color.FromArgb(224, 205, 255);
            tbGuess.BackColor = Color.FromArgb(100, 242, 239);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game = new Game(this.category);
            this.count = 0;
            this.timeOut = 0;
            btnStart.Enabled = false;
            btnGuess.Enabled = true;
            Object obj = Properties.Resources.ResourceManager.GetObject(game.show());
            Bitmap myImage = (Bitmap)obj;
            Image image = myImage;
            pictureBox1.Image = image;
            lbCount.Text = "0/10";
            timer1.Start();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess();
        }

        private void endGame(int tmp)
        {
            btnGuess.Enabled = false;
            Words.Items.Clear();
            tbGuess.Text = "";
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (tmp == 1)
            {
                timer1.Stop();
                var result = MessageBox.Show("Congrats!", "You're winner!", MessageBoxButtons.OK);
                if (DialogResult.OK == result)
                    this.Close();
            }
            else
            {
                var result = MessageBox.Show("New Game?", "GameOver!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DialogResult.Yes == result)
                {
                    btnStart.Enabled = true;
                    pictureBox1.Image = null;
                }
                else
                {
                    this.Close();
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateTime();
            if (timeOut == maxTime)
            {
                timer1.Stop();
                label1.Text = "00:00";
                endGame(2);
            }
        }

        private void updateTime()
        {
            timeOut++;
            int time = maxTime - timeOut;
            int minutes = time / 60;
            int seconds = time % 60;
            label1.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }


        private void guess()
        {
            errorProvider2.Clear();
            errorProvider1.Clear();
            if (tbGuess.Text == "")
            {
                errorProvider1.SetError(tbGuess, "внесете збор");
            }
            else
            {
                bool tmp = game.guessW(tbGuess.Text);
                if (tmp == true)
                {
                    count++;
                    lbCount.Text = count + "/10";
                    Words.Items.Add(tbGuess.Text);
                    if (count == 10)
                        endGame(1);
                }
                else
                {
                    errorProvider2.SetError(btnGuess, "внесениот збор е погрешен или веќе погоден");
                }
                tbGuess.Text = "";
            }
        }

      

    }
}
