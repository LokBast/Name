using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Halyava
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Window8 w8 = new Window8();
            w8.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Show();
            Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LabelAnd(object sender, EventArgs e)
        {

        }//и
        private void LabelStartMarafon(object sender, EventArgs e)
        {

        }//до старта марафона
        private void LabelDay(object sender, EventArgs e)
        {

        }//дни
        private void LabelСlock(object sender, EventArgs e)
        {

        }//часы
        private void LabelMinutes(object sender, EventArgs e)
        {

        }//минуты
        private void LabelCaseDay(object sender, EventArgs e)
        {

        }//падежи дней
        private void LabelCaseClock(object sender, EventArgs e)
        {

        }//падежи часов
        private void LabelCaseMinutes(object sender, EventArgs e)
        {

        }//падежи минут
     
        private void TimerRemaining(object sender, EventArgs e)
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Show();
            Hide();
        }

        private void менюБегунаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window7 w7 = new Window7();
            w7.Show();
            Hide();
        }

        private void подробнаяИнформайияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window8 w8 = new Window8();
            w8.Show();
            Hide();
        }

        private void менюКоординатораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window14 w14 = new Window14();
            w14.Show();
            Hide();
        }

        private void менюАдминаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window15 w15 = new Window15();
            w15.Show();
            Hide();
        }

        private void bMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window23 w23 = new Window23();
            w23.Show();
            Hide();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Show();
            Hide();
        }
    }
}
