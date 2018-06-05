using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brincando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
  
            InitializeComponent();
            label1.Text = "Nome :";
            label1.ForeColor = Color.Orange;
            label2.Text = "Data de Nascimento :";
            label2.ForeColor = Color.Orange;
            label3.Text = "Idade :";
            label3.ForeColor = Color.Orange;
            label4.Text = "De acordo com sua idade você pode votar ?";
            label4.ForeColor = Color.Orange;
            label7.Text = "Seu nome :";
            label7.ForeColor = Color.Orange;
            label6.Text = "Data de Nascimento :";
            label6.ForeColor = Color.Orange;
            label5.Text = "Sua Idade :";
            label5.ForeColor = Color.Orange;
            label8.Text = "Qual sua cor preferida ?";
            label8.ForeColor = Color.Orange;
            button1.Text = "Enviar";
            label9.Text = "Digite seus Dados :";
            label9.ForeColor = Color.Orange;
            label10.Text = "Seus dados digitados :";
            label10.ForeColor = Color.Orange;
            checkBox1.Text = "Azul";
            checkBox1.ForeColor = Color.Orange;
            checkBox2.Text = "Vermelho";
            checkBox2.ForeColor = Color.Orange;
            checkBox3.Text = "Amarelo";
            checkBox3.ForeColor = Color.Orange;
            checkBox4.Text = "Verde";
            checkBox4.ForeColor = Color.Orange;



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Text = textBox1.Text;
            maskedTextBox2.Text = maskedTextBox1.Text;
            textBox5.Text = textBox3.Text;

            if (int.Parse(textBox3.Text) <= 15)
            {
                textBox4.Text = "Não";
            }
            else
            {
                textBox4.Text = "Sim";
            }

            if (checkBox1.Enabled == true)
            {
                textBox7.ForeColor = Color.Blue;
                textBox5.ForeColor = Color.Blue;
                textBox7.BackColor = Color.LightGray;
                textBox5.BackColor = Color.LightGray;
            }
            if (checkBox2.Enabled == true)
            {
                textBox7.ForeColor = Color.Red;
                textBox5.ForeColor = Color.Red;
                textBox7.BackColor = Color.LightGray;
                textBox5.BackColor = Color.LightGray;
            }
            if (checkBox3.Enabled == true)
            {
                textBox7.ForeColor = Color.Yellow;
                textBox5.ForeColor = Color.Yellow;
                textBox7.BackColor = Color.LightGray;
                textBox5.BackColor = Color.LightGray;
            }
            if (checkBox4.Enabled == true)
            {
                textBox7.ForeColor = Color.Green;
                textBox5.ForeColor = Color.Green;
                textBox7.BackColor = Color.LightGray;
                textBox5.BackColor = Color.LightGray;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true) {

                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            if (checkBox1.CheckState == 0)
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
            {

                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
            }
            if (checkBox2.CheckState == 0)
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Enabled == true)
            {

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
            }
            if (checkBox3.CheckState == 0)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Enabled == true)
            {

                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            if (checkBox4.CheckState == 0)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }
    }
}
