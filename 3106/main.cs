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
            title.Left = (this.ClientSize.Width - title.Width) / 2;
            title.Top = ((this.ClientSize.Height - title.Height) / 2)-50;

            button.Left = (this.ClientSize.Width - button.Width) / 2;
            button.Top = ((this.ClientSize.Height - button.Height) / 2)+50;

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
