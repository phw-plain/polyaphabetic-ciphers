using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3106
{
    public partial class input : Form
    {
        public input()
        {
            InitializeComponent();
            title.Left = (this.ClientSize.Width - title.Width) / 2;
            title.Top = ((this.ClientSize.Height - title.Height) / 2) - 100;

            label1.Left = ((this.ClientSize.Width - label1.Width) / 2) - 150;
            label1.Top = ((this.ClientSize.Height - label1.Height) / 2) - 15;

            label2.Left = ((this.ClientSize.Width - label2.Width) / 2) - 150;
            label2.Top = ((this.ClientSize.Height - label2.Height) / 2) + 20;

            textBox1.Left = ((this.ClientSize.Width - textBox1.Width) / 2) + 50;
            textBox1.Top = ((this.ClientSize.Height - textBox1.Height) / 2) - 15;

            textBox2.Left = ((this.ClientSize.Width - textBox2.Width) / 2) + 50;
            textBox2.Top = ((this.ClientSize.Height - textBox2.Height) / 2) + 20;

            button.Left = (this.ClientSize.Width - button.Width) / 2;
            button.Top = ((this.ClientSize.Height - button.Height) / 2) + 100;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;      
            output frm = new output();    
            frm.Show();          
        }
    }
}
