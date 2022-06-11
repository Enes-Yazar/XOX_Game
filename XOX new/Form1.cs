using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOX_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (label1.Text == "X")
            {

                button.Text = "X";
                button.Enabled = false;
                label1.Text = "O";
            }

            else
            {
                button.Text = "O";
                button.Enabled = false;
                label1.Text = "X";
            }
            // OX 1
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Oyunu : X  Kazandı", "XOX System");
                OyunSonu();
            }


            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }
            // OX 2
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("Oyunu : X  Kazandı", "XOX System");
                OyunSonu();
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }
            // OX 3
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }

            //OX4
            if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Oyunu : X  Kazandı", "XOX System");
                OyunSonu();
            }

            if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }
            //OX5
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("Oyunu : X  Kazandı", "XOX System");
                OyunSonu();
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }

            //OX6
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Oyunu : X  Kazandı", "XOX System");
                OyunSonu();
            }


            if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }
            // OX 7

            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("Oyunu : X  Kazandı", "XOX System");
                OyunSonu();
            }

            if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Oyunu : O  Kazandı", "XOX System");
                OyunSonu();
            }
            //OX8

            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Oyunu kazanan : X", "XOX System");
                OyunSonu();
            }

            if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Oyunu kazanan : O", "XOX System");
                OyunSonu();
            }
            if (button1.Text != "" && button2.Text != ""&& button3.Text != "" && button4.Text !="" && button5.Text != "" &&
                button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                DialogResult dialog = new DialogResult();

                dialog = MessageBox.Show("Oyunu Kimse kazanamadı. Tekrar denemek ister misiniz?", "XOX System", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Retry)
                {
                    MessageBox.Show("Oyun yeniden başlatılıyor, Bekleyiniz...", "XOX System");
                    OyunSonu();
                }

                else
                {
                    MessageBox.Show("Oyun kapatılıyor...", "XOX System");
                    this.Close();
                }
            }
        }
        private void OyunSonu()
        {
            label1.Text = "X";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }
    }
}
