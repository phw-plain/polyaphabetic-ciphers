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
using System.Text.RegularExpressions;

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
            bool result1 = Regex.IsMatch(in_textBox1.Text, @"^[a-zA-Z]+$");
            bool result2 = Regex.IsMatch(in_textBox1.Text, @"^[a-zA-Z]+$");

            if (in_textBox1.Text == "")
            {
                MessageBox.Show("암호문이 입력되지 않았습니다.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!result1)
            {
                MessageBox.Show("영문자만 입력해 주세요.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (in_textBox2.Text == "")
            {
                MessageBox.Show("복호문이 입력되지 않았습니다.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!result2)
            {
                MessageBox.Show("영문자만 입력해 주세요.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // 화면 전환
                start.Visible = false;
                input.Visible = false;
                output.Visible = true;

                // 암호화에 필요한 정보 저장하기
                String ciphertext = in_textBox1.Text;
                String plaintext = in_textBox2.Text;

                ciphertext = ciphertext.ToLower();
                plaintext = plaintext.ToLower();

                // 암호화 하기
                cipher.ci.getCipher(ciphertext, plaintext);

                // 암호화 된 값 불러오기
                out_cipher.Text = cipher.ci.encryption_trim;
                out_plain.Text = cipher.ci.decryption;
            }
            
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

            //버튼 테두리 없애기
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

        }
        private void input_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            in_title.Left = ((this.ClientSize.Width - title.Width) / 2) + 90;
            in_title.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;

            in_label1.Left = ((this.ClientSize.Width - title.Width) / 2 ) + 70;
            in_label1.Top = ((this.ClientSize.Height - title.Height) / 2) - 5;

            in_textBox1.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            in_textBox1.Top = ((this.ClientSize.Height - title.Height) / 2) - 10;

            in_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 70;
            in_label2.Top = ((this.ClientSize.Height - title.Height) / 2) + 40;

            in_textBox2.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            in_textBox2.Top = ((this.ClientSize.Height - title.Height) / 2) + 35;

            in_button.Left = ((this.ClientSize.Width - button.Width) / 2) + 15;
            in_button.Top = ((this.ClientSize.Height - button.Height) / 2) + 120;

            //버튼 테두리 없애기
            in_button.TabStop = false;
            in_button.FlatStyle = FlatStyle.Flat;
            in_button.FlatAppearance.BorderSize = 0;
        }
        private void output_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            subtext.Left = ((this.ClientSize.Width - title.Width) / 2) - 50;
            subtext.Top = ((this.ClientSize.Height - title.Height) / 2) - 140;

            tableLayoutPanel.Left = ((this.ClientSize.Width - title.Width) / 2) - 50;
            tableLayoutPanel.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;

            out_label1.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            out_label1.Top = ((this.ClientSize.Height - title.Height) / 2) - 60;

            out_cipher.Left = ((this.ClientSize.Width - title.Width) / 2) + 430;
            out_cipher.Top = ((this.ClientSize.Height - title.Height) / 2) - 60;

            out_cipher.MaximumSize = new Size(170, 0);
            out_cipher.AutoSize = true;

            out_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            out_label2.Top = ((this.ClientSize.Height - title.Height) / 2) + 20;

            out_plain.Left = ((this.ClientSize.Width - title.Width) / 2) + 430;
            out_plain.Top = ((this.ClientSize.Height - title.Height) / 2) + 20;

            out_plain.MaximumSize = new Size(170, 0);
            out_plain.AutoSize = true;

            out_button.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            out_button.Top = ((this.ClientSize.Height - title.Height) / 2) + 100;

            //버튼 테두리 없애기
            out_button.TabStop = false;
            out_button.FlatStyle = FlatStyle.Flat;
            out_button.FlatAppearance.BorderSize = 0;

            //label1.Text = ?; ~ label25.Text = ?;
            label1.Text = cipher.alpha[0, 0];
            label2.Text = cipher.alpha[0, 1];
            label3.Text = cipher.alpha[0, 2];
            label4.Text = cipher.alpha[0, 3];
            label5.Text = cipher.alpha[0, 4];

            label6.Text = cipher.alpha[1, 0];
            label7.Text = cipher.alpha[1, 1];
            label8.Text = cipher.alpha[1, 2];
            label9.Text = cipher.alpha[1, 3];
            label10.Text = cipher.alpha[1, 4];

            label11.Text = cipher.alpha[2, 0];
            label12.Text = cipher.alpha[2, 1];
            label13.Text = cipher.alpha[2, 2];
            label14.Text = cipher.alpha[2, 3];
            label15.Text = cipher.alpha[2, 4];

            label16.Text = cipher.alpha[3, 0];
            label17.Text = cipher.alpha[3, 1];
            label18.Text = cipher.alpha[3, 2];
            label19.Text = cipher.alpha[3, 3];
            label20.Text = cipher.alpha[3, 4];

            label21.Text = cipher.alpha[4, 0];
            label22.Text = cipher.alpha[4, 1];
            label23.Text = cipher.alpha[4, 2];
            label24.Text = cipher.alpha[4, 3];
            label25.Text = cipher.alpha[4, 4];

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = true;
            input.Visible = false;
            output.Visible = false;
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

        private void in_title_Click(object sender, EventArgs e)
        {

        }

        private void in_label1_Click(object sender, EventArgs e)
        {

        }

        private void out_plain_Click(object sender, EventArgs e)
        {

        }
    }
}
