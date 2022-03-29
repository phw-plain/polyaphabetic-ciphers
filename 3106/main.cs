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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.label1.Text = "암호화 하기";
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;       // 현재 폼 안보이게 하기
            input frm = new input();    // 새 폼 생성
            frm.Show();           // 새 폼 보여주기 
        }
    }
}
