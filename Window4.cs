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
    public partial class Window4 : Form
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void Window4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baza.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.baza.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baza.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.baza.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.Country". При необходимости она может быть перемещена или удалена.
            // this.countryTableAdapter.Fill(this.bazaDataSet1.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.Gender". При необходимости она может быть перемещена или удалена.
            //this.genderTableAdapter.Fill(this.bazaDataSet1.Gender);
        }
        private void Window4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == "Email")
            {
                TextBoxLogin.Text = "";
                TextBoxLogin.ForeColor = Color.Black;
            }
        }
        private void TextBoxLogin_Leave(object sender, EventArgs e)
        {
            if (TextBoxLogin.Text == "")
            {
                TextBoxLogin.Text = "Email";
                TextBoxLogin.ForeColor = SystemColors.ControlDark;
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "Пароль")
            {
                TextBoxPassword.Text = "";
                TextBoxPassword.PasswordChar = '*';
                TextBoxPassword.ForeColor = Color.Black;
            }
        }
        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "")
            {
                TextBoxPassword.Text = "Пароль";
                TextBoxPassword.ForeColor = SystemColors.ControlDark;
                TextBoxPassword.PasswordChar = '\0';
            }
        }

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (TextBoxFirstName.Text == "Имя")
            {
                TextBoxFirstName.Text = "";
                TextBoxFirstName.ForeColor = Color.Black;
            }
        }
        private void TextBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (TextBoxFirstName.Text == "")
            {
                TextBoxFirstName.Text = "Имя";
                TextBoxFirstName.ForeColor = SystemColors.ControlDark;
            }
        }

        private void TextBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxLastName_Enter(object sender, EventArgs e)
        {
            if (TextBoxLastName.Text == "Фамилия")
            {
                TextBoxLastName.Text = "";
                TextBoxLastName.ForeColor = Color.Black;
            }
        }
        private void TextBoxLastName_Leave(object sender, EventArgs e)
        {
            if (TextBoxLastName.Text == "")
            {
                TextBoxLastName.Text = "Фамилия";
                TextBoxLastName.ForeColor = SystemColors.ControlDark;
            }
        }

        private void TextBoxFoto_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxFoto_Enter(object sender, EventArgs e)
        {
            if (TextBoxFoto.Text == "Photo_logo.jpg")
            {
                TextBoxFoto.Text = "";
                TextBoxFoto.ForeColor = Color.Black;
            }
        }
        private void TextBoxFoto_Leave(object sender, EventArgs e)
        {
            if (TextBoxFoto.Text == "")
            {
                TextBoxFoto.Text = "Photo_logo.jpg";
                TextBoxFoto.ForeColor = SystemColors.ControlDark;
            }
        }

        private void ComboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=KAPRIMA\SQLSERVER;Initial Catalog=Baza;Integrated Security=True");
            SqlCommand com = new SqlCommand("SELECT * FROM [dbo].[User]", con);
            SqlDataReader reader;
            con.Open();
            reader = com.ExecuteReader();

            bool boolPassword = true;
            bool boolLogin = true;
            bool result = false;
            
            while (reader.Read())
            {               
                if (TextBoxLogin.Text != "Email" && TextBoxPassword.Text != "Пароль" && TextBoxRepeatPassword.Text != "Повторите пароль" && TextBoxFirstName.Text != "Имя" && TextBoxLastName.Text != "Фамилия")
                {
                    result = true;

                    if (TextBoxLogin.Text == reader["Email"].ToString())
                    {
                        boolLogin = false;
                        label20.Visible = true;
                        label20.Text = "Email уже используется";                     
                    }

                    if (TextBoxPassword.Text != TextBoxRepeatPassword.Text)
                    {
                        label21.Text = "Пароль не совпадает";
                        label21.Visible = true; 
                        boolPassword = false;
                        TextBoxPassword.Text = "Пароль";
                        TextBoxRepeatPassword.Text = "";
                    }
                }
            }
            if (result == true)
            {
                Window6 w6 = new Window6();
                w6.Show();
                Hide();
            }
        }

        private void TextBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBoxRepeatPassword_Enter(object sender, EventArgs e)
        {
            if (TextBoxRepeatPassword.Text == "Повторите пароль")
            {
                TextBoxRepeatPassword.Text = "";
                TextBoxRepeatPassword.PasswordChar = '*';
                TextBoxRepeatPassword.ForeColor = Color.Black;
            }
        }
        private void TextBoxRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (TextBoxRepeatPassword.Text == "")
            {
                TextBoxRepeatPassword.Text = "Повторите пароль";
                TextBoxRepeatPassword.ForeColor = SystemColors.ControlDark;
                TextBoxRepeatPassword.PasswordChar = '\0';
            }
        }





        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxLogin_Click(object sender, EventArgs e)
        {
            label20.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            Hide();
        }
    }
}
