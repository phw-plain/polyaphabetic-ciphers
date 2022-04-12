using _3106.Resources;
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
            this.MaximizeBox = false;


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = false;
            input.Visible = true;
            output.Visible = false;

            in_textBox1.Text = "";
            in_textBox2.Text = "";
        }
        private void in_button_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = false;
            input.Visible = false;
            output.Visible = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = true;
            input.Visible = false;
            output.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            start.Visible = true;
            
            title.Left = (this.ClientSize.Width - title.Width) / 2;
            title.Top = ((this.ClientSize.Height - title.Height) / 2) - 50;

            button.Left = (this.ClientSize.Width - button.Width) / 2;
            button.Top = ((this.ClientSize.Height - button.Height) / 2) + 50;
        }
        private void input_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            in_title.Left = (this.ClientSize.Width - title.Width) / 2;
            in_title.Top = ((this.ClientSize.Height - title.Height) / 2) - 100;

            in_label1.Left = ((this.ClientSize.Width - title.Width) / 2 ) + 70;
            in_label1.Top = ((this.ClientSize.Height - title.Height) / 2) + 5;

            in_textBox1.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            in_textBox1.Top = (this.ClientSize.Height - title.Height) / 2;

            in_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 70;
            in_label2.Top = ((this.ClientSize.Height - title.Height) / 2) + 55;

            in_textBox2.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            in_textBox2.Top = ((this.ClientSize.Height - title.Height) / 2) + 50;

            in_button.Left = (this.ClientSize.Width - button.Width) / 2;
            in_button.Top = ((this.ClientSize.Height - button.Height) / 2) + 120;
        }
        private void output_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            subtext.Left = ((this.ClientSize.Width - title.Width) / 2) - 80;
            subtext.Top = ((this.ClientSize.Height - title.Height) / 2) - 140;

            tableLayoutPanel.Left = ((this.ClientSize.Width - title.Width) / 2) - 80;
            tableLayoutPanel.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;

            out_label1.Left = ((this.ClientSize.Width - title.Width) / 2) + 300;
            out_label1.Top = ((this.ClientSize.Height - title.Height) / 2) - 30;

            out_cipher.Left = ((this.ClientSize.Width - title.Width) / 2) + 380;
            out_cipher.Top = ((this.ClientSize.Height - title.Height) / 2) - 30;

            out_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 300;
            out_label2.Top = ((this.ClientSize.Height - title.Height) / 2) + 30;

            out_plain.Left = ((this.ClientSize.Width - title.Width) / 2) + 380;
            out_plain.Top = ((this.ClientSize.Height - title.Height) / 2) + 30;

            out_button.Left = ((this.ClientSize.Width - title.Width) / 2) + 530;
            out_button.Top = ((this.ClientSize.Height - title.Height) / 2) + 150;

            // 암호화에 필요한 정보 저장하기
            String ciphertext = in_textBox1.Text;
            String plaintext = in_textBox2.Text;

            // 암호화 하기
            cipher.ci.getCipher(ciphertext, plaintext);

            // 암호화 된 값 불러오기

            out_cipher.Text = cipher.ci.encryption_trim;
            out_plain.Text = cipher.ci.decryption;

            //label1.Text = ?; ~ label25.Text = ?;
            label1.Text = cipher.alphabetBoard[0, 0].ToString();
            label2.Text = cipher.alphabetBoard[0, 1].ToString();
            label3.Text = cipher.alphabetBoard[0, 2].ToString();
            label4.Text = cipher.alphabetBoard[0, 3].ToString();
            label5.Text = cipher.alphabetBoard[0, 4].ToString();

            label6.Text = cipher.alphabetBoard[1, 0].ToString();
            label7.Text = cipher.alphabetBoard[1, 1].ToString();
            label8.Text = cipher.alphabetBoard[1, 2].ToString();
            label9.Text = cipher.alphabetBoard[1, 3].ToString();
            label10.Text = cipher.alphabetBoard[1, 4].ToString();

            label11.Text = cipher.alphabetBoard[2, 0].ToString();
            label12.Text = cipher.alphabetBoard[2, 1].ToString();
            label13.Text = cipher.alphabetBoard[2, 2].ToString();
            label14.Text = cipher.alphabetBoard[2, 3].ToString();
            label15.Text = cipher.alphabetBoard[2, 4].ToString();

            label16.Text = cipher.alphabetBoard[3, 0].ToString();
            label17.Text = cipher.alphabetBoard[3, 1].ToString();
            label18.Text = cipher.alphabetBoard[3, 2].ToString();
            label19.Text = cipher.alphabetBoard[3, 3].ToString();
            label20.Text = cipher.alphabetBoard[3, 4].ToString();

            label21.Text = cipher.alphabetBoard[4, 0].ToString();
            label22.Text = cipher.alphabetBoard[4, 1].ToString();
            label23.Text = cipher.alphabetBoard[4, 2].ToString();
            label24.Text = cipher.alphabetBoard[4, 3].ToString();
            label25.Text = cipher.alphabetBoard[4, 4].ToString();

        }

        private void label1_Click(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
