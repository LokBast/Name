﻿using System;
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
    public partial class Window3 : Form
    {
        public Window3()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 w1 = new Form1();
            w1.Show();
            Hide();
        }
        private void Window3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void label6_Click_1(object sender, EventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {

        }
        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        private void label9_Click_1(object sender, EventArgs e)
        {

        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        private void label8_Click_1(object sender, EventArgs e)
        {

        }
        private void label10_Click_1(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }//и
        private void label10_Click(object sender, EventArgs e)
        {

        }//до старта марафона
        private void label3_Click(object sender, EventArgs e)
        {

        }//дни
        private void label4_Click(object sender, EventArgs e)
        {

        }//часы
        private void label5_Click(object sender, EventArgs e)
        {

        }//минуты
        private void label6_Click(object sender, EventArgs e)
        {

        }//падежи дней
        private void label7_Click(object sender, EventArgs e)
        {

        }//падежи часов
        private void label8_Click(object sender, EventArgs e)
        {

        }//падежи минут

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

        private void positionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.positionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bazaDataSet);

        }
    }
}
