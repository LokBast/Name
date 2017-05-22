using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Halyava
{
    public partial class Window3 : Form
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            Hide();
        }
        private void Window3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == "Enter your email address")
            {
                TextBoxLogin.Text = "";
                TextBoxLogin.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == "")
            {
                TextBoxLogin.Text = "Enter your email address";
                TextBoxLogin.ForeColor = SystemColors.ControlDark;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your passvord")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter your passvord";
                textBox2.ForeColor = SystemColors.ControlDark;
                textBox2.PasswordChar = '\0';
            }
        }

        private void ButtonLogin(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KAPRIMA\SQLSERVER;Initial Catalog=Baza;Integrated Security=True");
            SqlCommand com = new SqlCommand("SELECT * FROM [dbo].[User]", con);
            SqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();
            bool Result = false;

            while (reader.Read())
            {
                if (TextBoxLogin.Text == reader["Email"].ToString() && textBox2.Text == reader["Password"].ToString())
                {
                    if ("R" == reader["RoleId"].ToString())
                    {
                        Result = true;
                        Window7 w7 = new Window7();
                        w7.Show();
                        this.Hide();
                    }                    
                    else if ("A" == reader["RoleId"].ToString())
                    {
                        Result = true;
                        Window15 w15 = new Window15();
                        w15.Show();
                        this.Hide();
                    }
                    else if ("C" == reader["RoleId"].ToString())
                    {
                        Result = true;
                        Window14 w14 = new Window14();
                        w14.Show();
                        this.Hide();
                    }
                }
            }
            if (Result == false)
            {
                MessageBox.Show("Логин или пароль введены неверно!", "Ошибка входа!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBox2.Text = "Enter your passvord";
                textBox2.ForeColor = SystemColors.ControlDark;
                textBox2.PasswordChar = '\0';

            }
        }

        private void ButtonCancel(object sender, EventArgs e)
        {
            TextBoxLogin.Text = "Enter your email address";
            TextBoxLogin.ForeColor = SystemColors.ControlDark;

            textBox2.Text = "Enter your passvord";
            textBox2.ForeColor = SystemColors.ControlDark;
            textBox2.PasswordChar = '\0';

        }
    }
}
