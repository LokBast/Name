using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halyava
{
    public partial class Window23 : Form
    {
        public Window23()
        {
            InitializeComponent();
        }
        private void Window23_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Window8 w8 = new Window8();
            w8.Show();
            Hide();
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label20_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LabelDay(object sender, EventArgs e)
        {

        }
        private void LabelCaseDay(object sender, EventArgs e)
        {

        }
        private void LabelСlock(object sender, EventArgs e)
        {

        }
        private void LabelCaseClock(object sender, EventArgs e)
        {

        }
        private void LabelAnd(object sender, EventArgs e)
        {

        }
        private void LabelMinutes(object sender, EventArgs e)
        {

        }
        private void LabelCaseMinutes(object sender, EventArgs e)
        {

        }
        private void LabelStartMarafon(object sender, EventArgs e)
        {

        }

        private void TimerRemaining(object sender, EventArgs e)
        {
            {
                DateTime dateLocal = DateTime.Now;//локальная дата,время
                DateTime startTime = new DateTime(2017, 11, 24, 6, 0, 0);//дата марафона
                TimeSpan daysLeft = startTime - dateLocal;
                {
                    label3.Text = daysLeft.Days.ToString();
                    label4.Text = daysLeft.Hours.ToString();
                    label5.Text = daysLeft.Minutes.ToString();

                    int intLable3;
                    intLable3 = Convert.ToInt32(label3.Text);
                    intLable3 = int.Parse(label3.Text);
                    {
                        string den = "день", dnya = "дня", dnei = "дней";
                        float i = intLable3 % 10, r = intLable3 % 100;

                        if (r == 11 || r == 12 || r == 13 || r == 14)
                        {
                            label6.Text = dnei;
                        }
                        else if (i == 1)
                        {
                            label6.Text = den;
                        }
                        else if (i == 2 || i == 3 || i == 4)
                        {
                            label6.Text = dnya;
                        }
                        else
                        {
                            label6.Text = dnei;
                        }
                    }

                    int intLable4;
                    intLable4 = Convert.ToInt32(label4.Text);
                    intLable4 = int.Parse(label4.Text);
                    {
                        string chas = "час", chasa = "часа", chasov = "часов";
                        float i = intLable4 % 10, r = intLable4 % 100;

                        if (r == 11 || r == 12 || r == 13 || r == 14)
                        {
                            label7.Text = chasov;
                        }
                        else if (i == 1)
                        {
                            label7.Text = chas;
                        }
                        else if (i == 2 || i == 3 || i == 4)
                        {
                            label7.Text = chasa;
                        }
                        else
                        {
                            label7.Text = chasov;
                        }
                    }

                    int intLable5;
                    intLable5 = Convert.ToInt32(label5.Text);
                    intLable5 = int.Parse(label5.Text);
                    {
                        string minuta = "минута", minuti = "минуты", minut = "минут";
                        float i = intLable5 % 10, r = intLable5 % 100;

                        if (r == 11 || r == 12 || r == 13 || r == 14)
                        {
                            label8.Text = minut;
                        }
                        else if (i == 1)
                        {
                            label8.Text = minuta;
                        }
                        else if (i == 2 || i == 3 || i == 4)
                        {
                            label8.Text = minuti;
                        }
                        else
                        {
                            label8.Text = minut;
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && (button1.FlatAppearance.BorderSize == 3 || button2.FlatAppearance.BorderSize == 3))
            {
                double doubleTextBox1 = Convert.ToDouble(textBox1.Text);
                double doubleTextBox2 = Convert.ToDouble(textBox2.Text);
                doubleTextBox1 /= 100;
                double BMI = Math.Round((doubleTextBox2 / (doubleTextBox1 * doubleTextBox1)), 1);
                double BMIdouble = BMI % 10;
                label20.Text = Convert.ToString(BMI);


                if (BMI < 18.5)
                {
                    double BMImotus = (BMI * 10) / 2;
                    int intBMImotus = Convert.ToInt32(BMImotus);
                    int useMotus = 383 + intBMImotus;
                    pictureBox3.Image = global::Halyava.Properties.Resources.недостаточный;

                    if (useMotus < 360)
                    {
                        panel1.Location = new System.Drawing.Point(361 - 31, 442);
                    }
                    else if (useMotus > 582)
                    {
                        panel1.Location = new System.Drawing.Point(581 - 31, 442);
                    }
                    else
                    {
                        panel1.Location = new System.Drawing.Point(useMotus - 31, 442);
                    }
                }//Inadequate             

                if (BMI >= 18.5 && BMI <= 24.9)
                {
                    double BMImotus = ((BMI - 18.5) * 10) * 2;
                    int intBMImotus = Convert.ToInt32(BMImotus);
                    int useMotus = 468 + intBMImotus;
                    pictureBox3.Image = global::Halyava.Properties.Resources.здоровый;

                    if (useMotus < 475)
                    {
                        panel1.Location = new System.Drawing.Point(475 - 31, 442);
                    }
                    else if (useMotus > 583)
                    {
                        panel1.Location = new System.Drawing.Point(589 - 31, 442);
                    }
                    else
                    {
                        panel1.Location = new System.Drawing.Point(useMotus - 31, 442);
                    }
                }//normal

                if (BMI >= 25 && BMI <= 29.9)


                {
                    double BMImotus = ((BMI - 25) * 10) * 3;
                    int intBMImotus = Convert.ToInt32(BMImotus);
                    int useMotus = 588 + intBMImotus;
                    pictureBox3.Image = global::Halyava.Properties.Resources.избыточный;

                    if (useMotus < 588)
                    {
                        panel1.Location = new System.Drawing.Point(589 - 31, 442);
                    }
                    else if (useMotus > 703)
                    {
                        panel1.Location = new System.Drawing.Point(702 - 31, 442);
                    }
                    else
                    {
                        panel1.Location = new System.Drawing.Point(useMotus - 31, 442);
                    }
                }//excess

                if (BMI >= 30)
                {
                    double BMImotus = ((BMI - 30) * 10) * 3;
                    int intBMImotus = Convert.ToInt32(BMImotus);
                    int useMotus = 704 + intBMImotus;
                    pictureBox3.Image = global::Halyava.Properties.Resources.ожирение;

                    if (useMotus < 704)
                    {
                        panel1.Location = new System.Drawing.Point(705 - 31, 442);
                    }
                    else if (useMotus > 820)
                    {
                        panel1.Location = new System.Drawing.Point(819 - 31, 442);
                    }
                    else
                    {
                        panel1.Location = new System.Drawing.Point(useMotus - 31, 442);
                    }
                }//obesity
            }
        }//расчеты

        private void Window23_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label11, "BMI обозначает индекс массы тела. Он используется, чтобы дать вам представление о том,\r\nявляется ли Ваш вес - избыточным или идеальным для вашего роста.");
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label20.Text = ""; 
            panel1.Location = new System.Drawing.Point(330 , 442);
            pictureBox3.Image = null;
            button1.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.BorderSize = 1;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button3.PerformClick();
                }
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    button3.PerformClick();
                }
            }
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 1;
            button1.FlatAppearance.BorderSize = 3;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.BorderSize = 1;
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
