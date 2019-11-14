using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_11
{
    public partial class Form1 : Form
    {
        Random R;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.A)
                {
                    richTextBox1.BackColor = Color.Aqua;
                }
                else if (e.KeyCode == Keys.B)
                {
                    richTextBox1.BackColor = Color.Bisque;
                }
                else if (e.KeyCode == Keys.C)
                {
                    richTextBox1.BackColor = Color.CadetBlue;
                }
                else if (e.KeyCode == Keys.D)
                {
                    richTextBox1.BackColor = Color.DarkBlue;
                }
                else if (e.KeyCode == Keys.E)
                {
                    richTextBox1.BackColor = Color.Empty;
                }
                else if (e.KeyCode == Keys.F)
                {
                    DialogResult result = MessageBox.Show("We can't find a color on this letter,but we can install " +
                        "a new color.\n Do you want change back color to black", "Question", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                }
                else if (e.KeyCode == Keys.G)
                {
                    richTextBox1.BackColor = Color.Gold;
                }
                else if (e.KeyCode == Keys.H)
                {
                    richTextBox1.BackColor = Color.HotPink;
                }
                else if (e.KeyCode == Keys.I)
                {
                    richTextBox1.BackColor = Color.Indigo;
                }
                else if (e.KeyCode == Keys.J)
                {
                    DialogResult result = MessageBox.Show("We can't find a color on this letter,but we can install " +
                        "a new color.\n Do you want change back color to black", "Question", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                }
                else if (e.KeyCode == Keys.K)
                {
                    richTextBox1.BackColor = Color.Khaki;
                }
                else if (e.KeyCode == Keys.L)
                {
                    richTextBox1.BackColor = Color.LawnGreen;
                }
                else if (e.KeyCode == Keys.M)
                {
                    richTextBox1.BackColor = Color.Maroon;
                }
                else if (e.KeyCode == Keys.N)
                {
                    richTextBox1.BackColor = Color.Navy;
                }
                else if (e.KeyCode == Keys.O)
                {
                    richTextBox1.BackColor = Color.Olive;
                }
                else if (e.KeyCode == Keys.P)
                {
                    richTextBox1.BackColor = Color.PaleGreen;
                }
                else if (e.KeyCode == Keys.Q)
                {
                    DialogResult result = MessageBox.Show("We can't find a color on this letter,but we can install " +
                        "a new color.\n Do you want change back color to black", "Question", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                }
                else if (e.KeyCode == Keys.R)
                {
                    richTextBox1.BackColor = Color.Red;
                }
                else if (e.KeyCode == Keys.S)
                {
                    richTextBox1.BackColor = Color.Salmon;
                }
                else if (e.KeyCode == Keys.T)
                {
                    richTextBox1.BackColor = Color.Teal;
                }
                else if (e.KeyCode == Keys.U)
                {
                    DialogResult result = MessageBox.Show("We can't find a color on this letter,but we can install " +
                        "a new color.\n Do you want change back color to black", "Question", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                }
                else if (e.KeyCode == Keys.V)
                {
                    richTextBox1.BackColor = Color.Violet;
                }
                else if (e.KeyCode == Keys.W)
                {
                    richTextBox1.BackColor = Color.White;
                }
                else if (e.KeyCode == Keys.X)
                {
                    DialogResult result = MessageBox.Show("We can't find a color on this letter,but we can install " +
                        "a new color.\n Do you want change back color to black", "Question", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                }
                else if (e.KeyCode == Keys.Y)
                {
                    richTextBox1.BackColor = Color.YellowGreen;
                }
                else if (e.KeyCode == Keys.Z)
                {
                    DialogResult result = MessageBox.Show("We can't find a color on this letter,but we can install " +
                        "a new color.\n Do you want change back color to black", "Question", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        richTextBox1.BackColor = Color.Black;
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (timer1.Enabled == false)
                    {
                        timer1.Enabled = true;
                    }
                    else if (timer1.Enabled = true)
                    {
                        timer1.Enabled = false;
                        richTextBox1.BackColor = Color.White;
                    }
                }
                else if (e.KeyData == Keys.PageUp)
                {
                    timer1.Interval -= 10;
                }
                else if (e.KeyData == Keys.PageDown)
                {
                    timer1.Interval += 10;
                }
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            R = new Random();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         richTextBox1.BackColor = Color.FromArgb(R.Next(0, 256), R.Next(0, 256), R.Next(0, 256));
         this.BackColor = Color.FromArgb(R.Next(0, 256), R.Next(0, 256), R.Next(0, 256));
        }
    }
}
