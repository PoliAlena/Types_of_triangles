using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(first.Text) || string.IsNullOrWhiteSpace(second.Text) || string.IsNullOrWhiteSpace(third.Text))
            {
                MessageBox.Show("Введите значения!!!");
                return;
            }
            else
            {
                int a = Convert.ToInt32(first.Text);
                int b = Convert.ToInt32(second.Text);
                int c = Convert.ToInt32(third.Text);

                if (a + b > c && b + c > a && c + a > b)
                {
                    first.Visible = false;
                    second.Visible = false;
                    third.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;

                    if (a == b && b == c && c == a)
                    {
                        label1.Text = "Полученный тругольник равносторонний";
                    }
                    if (a != b && b != c && c != a)
                    {
                        label1.Text = "Полученный тругольник разносторонний";
                    }
                    if ((a == b) && a != c || (b == c) && b != a || (c == a) && c != b)
                    {
                        label1.Text = "Полученный тругольник равнобедренный";
                    }

                }
                else
                {
                    label1.Text = "Такой треугольник не может существовать";
                    first.Visible = false;
                    second.Visible = false;
                    third.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;
                }
            }
        }

        private void first_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int(e);
        }

        private void second_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int(e);
        }

        private void third_KeyPress(object sender, KeyPressEventArgs e)
        {
            Int(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            first.Visible = true;
            second.Visible = true;
            third.Visible = true;
            button1.Visible = true;
            button2.Visible = false;
            label1.Text = "Введите длины сторон треугольника";
            first.Clear();
            second.Clear();
            third.Clear();
        }

        private void first_TextChanged(object sender, EventArgs e)
        {
            Null(first);
        }

        private void second_TextChanged(object sender, EventArgs e)
        {
            Null(second);
        }

        private void third_TextChanged(object sender, EventArgs e)
        {
            Null(third);
        }

        private void Null(System.Windows.Forms.TextBox text_b)
        {
            if (string.IsNullOrWhiteSpace(text_b.Text))
            {
                return;
            }
            if (Convert.ToInt32(text_b.Text) < 1)
            {
                MessageBox.Show("Значение не может быть равно 0");
                text_b.Clear();
                return;
            }
        }

        private void Int(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            { e.Handled = true; }
            else return;
        }
    }
}
