using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "X" && textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                label1.Text = "X WON";
            if (textBox1.Text == "X" && textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "" && textBox4.Text != "" && textBox7.Text != "")
                label1.Text = "X WON";
            if (textBox1.Text == "X" && textBox1.Text == textBox5.Text && textBox5.Text == textBox9.Text && textBox1.Text != "" && textBox5.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";

            if (textBox1.Text == "O" && textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                label1.Text = "O WON";
            if (textBox1.Text == "O" && textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "" && textBox4.Text != "" && textBox7.Text != "")
                label1.Text = "O WON";
            if (textBox1.Text == "O" && textBox1.Text == textBox5.Text && textBox5.Text == textBox9.Text && textBox1.Text != "" && textBox5.Text != "" && textBox9.Text != "")
                label1.Text = "O WON";

            if (textBox1.Text == "")
                label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "X" && textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                label1.Text = "X WON";
            if (textBox2.Text == "X" && textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "" && textBox5.Text != "" && textBox8.Text != "")
                label1.Text = "X WON";

            if (textBox1.Text == "O" && textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                label1.Text = "O WON";
            if (textBox2.Text == "O" && textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "" && textBox5.Text != "" && textBox8.Text != "")
                label1.Text = "O WON";

            if (textBox2.Text == "")
                label1.Text = "";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "X" && textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                label1.Text = "X WON";
            if (textBox3.Text == "X" && textBox3.Text == textBox6.Text && textBox6.Text == textBox9.Text && textBox3.Text != "" && textBox6.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";
            if (textBox3.Text == "X" && textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "")
                label1.Text = "X WON";

            if (textBox1.Text == "O" && textBox1.Text == textBox2.Text && textBox2.Text == textBox3.Text && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                label1.Text = "O WON";
            if (textBox3.Text == "O" && textBox3.Text == textBox6.Text && textBox6.Text == textBox9.Text && textBox3.Text != "" && textBox6.Text != "" && textBox9.Text != "")
                label1.Text = "O WON";
            if (textBox3.Text == "O" && textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "")
                label1.Text = "O WON";

            if (textBox3.Text == "")
                label1.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "X" && textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                label1.Text = "X WON";
            if (textBox1.Text == "X" && textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "" && textBox4.Text != "" && textBox7.Text != "")
                label1.Text = "X WON";

            if (textBox4.Text == "O" && textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                label1.Text = "O WON";
            if (textBox1.Text == "O" && textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "" && textBox4.Text != "" && textBox7.Text != "")
                label1.Text = "O WON";

            if (textBox4.Text == "")
                label1.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "X" && textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                label1.Text = "X WON";
            if (textBox2.Text == "X" && textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "" && textBox5.Text != "" && textBox8.Text != "")
                label1.Text = "X WON";
            if (textBox3.Text == "X" && textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "")
                label1.Text = "X WON";

            if (textBox4.Text == "O" && textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                label1.Text = "O WON";
            if (textBox2.Text == "O" && textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "" && textBox5.Text != "" && textBox8.Text != "")
                label1.Text = "O WON";
            if (textBox3.Text == "O" && textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "")
                label1.Text = "O WON";

            if (textBox5.Text == "")
                label1.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "X" && textBox3.Text == textBox6.Text && textBox6.Text == textBox9.Text && textBox3.Text != "" && textBox6.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";
            if (textBox4.Text == "X" && textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                label1.Text = "X WON";

            if (textBox3.Text == "O" && textBox3.Text == textBox6.Text && textBox6.Text == textBox9.Text && textBox3.Text != "" && textBox6.Text != "" && textBox9.Text != "")
                label1.Text = "O WON";
            if (textBox4.Text == "O" && textBox4.Text == textBox5.Text && textBox5.Text == textBox6.Text && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                label1.Text = "O WON";

            if (textBox6.Text == "")
                label1.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "X" && textBox7.Text == textBox8.Text && textBox8.Text == textBox9.Text && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";
            if (textBox1.Text == "X" && textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "" && textBox4.Text != "" && textBox7.Text != "")
                label1.Text = "X WON";
            if (textBox3.Text == "X" && textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "")
                label1.Text = "X WON";

            if (textBox7.Text == "O" && textBox7.Text == textBox8.Text && textBox8.Text == textBox9.Text && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                label1.Text = "O WON";
            if (textBox1.Text == "O" && textBox1.Text == textBox4.Text && textBox4.Text == textBox7.Text && textBox1.Text != "" && textBox4.Text != "" && textBox7.Text != "")
                label1.Text = "O WON";
            if (textBox3.Text == "O" && textBox3.Text == textBox5.Text && textBox5.Text == textBox7.Text && textBox3.Text != "" && textBox5.Text != "" && textBox7.Text != "")
                label1.Text = "O WON";

            if (textBox7.Text == "")
                label1.Text = "";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "X" && textBox7.Text == textBox8.Text && textBox8.Text == textBox9.Text && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";
            if (textBox2.Text == "X" && textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "" && textBox5.Text != "" && textBox8.Text != "")
                label1.Text = "X WON";

            if (textBox7.Text == "O" && textBox7.Text == textBox8.Text && textBox8.Text == textBox9.Text && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                label1.Text = "O WON";
            if (textBox2.Text == "O" && textBox2.Text == textBox5.Text && textBox5.Text == textBox8.Text && textBox2.Text != "" && textBox5.Text != "" && textBox8.Text != "")
                label1.Text = "O WON";

            if (textBox8.Text == "")
                label1.Text = "";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "X" && textBox7.Text == textBox8.Text && textBox8.Text == textBox9.Text && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";
            if (textBox3.Text == "X" && textBox3.Text == textBox6.Text && textBox6.Text == textBox9.Text && textBox3.Text != "" && textBox6.Text != "" && textBox9.Text != "")
                label1.Text = "X WON";
            if (textBox1.Text == "O" && textBox1.Text == textBox5.Text && textBox5.Text == textBox9.Text && textBox1.Text != "" && textBox5.Text != "" && textBox9.Text != "")
                label1.Text = "O WON";

            if (textBox9.Text == "")
                label1.Text = "";
        }
    }
}
