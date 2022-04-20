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
using System.IO;

namespace _3106
{
    public partial class main : Form
    {

        public main()
        {
            this.MaximizeBox = false;

            InitializeComponent();
        }

        // 암호화 하기 버튼
        private void en_btn_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = false;
            en_input.Visible = true;
            de_input.Visible = false;
            en_output.Visible = false;
            de_output.Visible = false;

            en_in_textBox1.Text = "";
            en_in_textBox2.Text = "";
        }

        // 복호화 하기 버튼
        private void de_btn_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = false;
            en_input.Visible = false;
            de_input.Visible = true;
            en_output.Visible = false;
            de_output.Visible = false;

            de_in_textBox1.Text = "";
            de_in_textBox2.Text = "";
        }
        
        private void en_in_button_Click(object sender, EventArgs e)
        {
            bool result1 = Regex.IsMatch(en_in_textBox1.Text.Replace(" ", ""), @"^[a-zA-Z]+$");
            bool result2 = Regex.IsMatch(en_in_textBox2.Text.Replace(" ", ""), @"^[a-zA-Z]+$");

            if (en_in_textBox1.Text == "")
            {
                MessageBox.Show("암호키가 입력되지 않았습니다.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!result1)
            {
                MessageBox.Show("1영문자만 입력해 주세요.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (en_in_textBox2.Text == "")
            {
                MessageBox.Show("평문이 입력되지 않았습니다.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!result2)
            {
                MessageBox.Show("2영문자만 입력해 주세요.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // 화면 전환
                en_input.Visible = false;
                en_output.Visible = true;

                // 암호화에 필요한 정보 저장하기
                String ciphertext = en_in_textBox1.Text;    // 암호키
                String plaintext = en_in_textBox2.Text;     // 평문

                ciphertext = ciphertext.ToLower();
                plaintext = plaintext.ToLower();

                // 암호화 하기
                cipher.ci.Encryption(ciphertext, plaintext);

                // ZCheck 문자열 저장하기 (암호문 zCheck)
                StreamWriter sw = File.AppendText("encryption.txt");
                sw.WriteLine(cipher.ci.encryption + " " + cipher.ci.zCheck);
                sw.Close();

                // 암호화 된 값 불러오기
                en_out_cipher.Text = ciphertext;
                en_out_encryptionTrim.Text = cipher.ci.encryption_trim;
                en_out_encryption.Text = cipher.ci.encryption;
            }
        }

        private void de_in_button_Click(object sender, EventArgs e)
        {
            bool result1 = Regex.IsMatch(de_in_textBox1.Text.Replace(" ", ""), @"^[a-zA-Z]+$");
            bool result2 = Regex.IsMatch(de_in_textBox2.Text.Replace(" ", ""), @"^[a-zA-Z]+$");

            if (de_in_textBox1.Text == "")
            {
                MessageBox.Show("암호키가 입력되지 않았습니다.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!result1)
            {
                MessageBox.Show("영문자만 입력해 주세요.", "3106", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (de_in_textBox2.Text == "")
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
                de_input.Visible = false;
                de_output.Visible = true;

                // 복호화에 필요한 정보 저장하기
                String ciphertext = de_in_textBox1.Text;    // 암호키
                String encryptiontext = de_in_textBox2.Text;     // 평문

                ciphertext = ciphertext.ToLower();
                encryptiontext = encryptiontext.ToLower();

                // ZCheck 문자열 가져오기


                // 암호화 하기
                cipher.ci.Decryption(ciphertext, encryptiontext);

                // 암호화 된 값 불러오기
                de_cipher.Text = ciphertext;
                de_plain.Text = cipher.ci.decryption;
            }
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)  // 메인 화면
        {
            // GUI setting
            start.Visible = true;
            
            title.Left = (this.ClientSize.Width - title.Width) / 2;
            title.Top = ((this.ClientSize.Height - title.Height) / 2) - 100;

            en_btn.Left = (this.ClientSize.Width - en_btn.Width) / 2;
            en_btn.Top = ((this.ClientSize.Height - en_btn.Height) / 2) + 10;

            de_btn.Left = (this.ClientSize.Width - en_btn.Width) / 2;
            de_btn.Top = ((this.ClientSize.Height - en_btn.Height) / 2) + 100;

            //버튼 테두리 없애기
            en_btn.TabStop = false;
            en_btn.FlatStyle = FlatStyle.Flat;
            en_btn.FlatAppearance.BorderSize = 0;

            de_btn.TabStop = false;
            de_btn.FlatStyle = FlatStyle.Flat;
            de_btn.FlatAppearance.BorderSize = 0;

        }

        private void en_input_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            en_in_title.Left = ((this.ClientSize.Width - title.Width) / 2) + 90;
            en_in_title.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;

            en_in_label1.Left = ((this.ClientSize.Width - title.Width) / 2 ) + 70;
            en_in_label1.Top = ((this.ClientSize.Height - title.Height) / 2) - 5;

            en_in_textBox1.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            en_in_textBox1.Top = ((this.ClientSize.Height - title.Height) / 2) - 10;

            en_in_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 70;
            en_in_label2.Top = ((this.ClientSize.Height - title.Height) / 2) + 40;

            en_in_textBox2.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            en_in_textBox2.Top = ((this.ClientSize.Height - title.Height) / 2) + 35;

            en_in_button.Left = ((this.ClientSize.Width - en_btn.Width) / 2) + 15;
            en_in_button.Top = ((this.ClientSize.Height - en_btn.Height) / 2) + 120;

            //버튼 테두리 없애기
            en_in_button.TabStop = false;
            en_in_button.FlatStyle = FlatStyle.Flat;
            en_in_button.FlatAppearance.BorderSize = 0;
        }

        private void de_input_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            de_in_title.Left = ((this.ClientSize.Width - title.Width) / 2) + 90;
            de_in_title.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;

            de_in_label1.Left = ((this.ClientSize.Width - title.Width) / 2) + 70;
            de_in_label1.Top = ((this.ClientSize.Height - title.Height) / 2) - 5;

            de_in_textBox1.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            de_in_textBox1.Top = ((this.ClientSize.Height - title.Height) / 2) - 10;

            de_in_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 70;
            de_in_label2.Top = ((this.ClientSize.Height - title.Height) / 2) + 40;

            de_in_textBox2.Left = ((this.ClientSize.Width - title.Width) / 2) + 200;
            de_in_textBox2.Top = ((this.ClientSize.Height - title.Height) / 2) + 35;

            de_in_button.Left = ((this.ClientSize.Width - en_btn.Width) / 2) + 15;
            de_in_button.Top = ((this.ClientSize.Height - en_btn.Height) / 2) + 120;

            //버튼 테두리 없애기
            de_in_button.TabStop = false;
            de_in_button.FlatStyle = FlatStyle.Flat;
            de_in_button.FlatAppearance.BorderSize = 0;
        }

        private void en_output_Paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            subtext.Left = ((this.ClientSize.Width - title.Width) / 2) - 50;
            subtext.Top = ((this.ClientSize.Height - title.Height) / 2) - 140;

            tableLayoutPanel.Left = ((this.ClientSize.Width - title.Width) / 2) - 50;
            tableLayoutPanel.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;

            en_out_label1.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            en_out_label1.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;
            en_out_cipher.Left = ((this.ClientSize.Width - title.Width) / 2) + 430;
            en_out_cipher.Top = ((this.ClientSize.Height - title.Height) / 2) - 120;
            en_out_cipher.MaximumSize = new Size(170, 0);
            en_out_cipher.AutoSize = true;

            en_out_label2.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            en_out_label2.Top = ((this.ClientSize.Height - title.Height) / 2) - 50;
            en_out_encryptionTrim.Left = ((this.ClientSize.Width - title.Width) / 2) + 430;
            en_out_encryptionTrim.Top = ((this.ClientSize.Height - title.Height) / 2) - 50;
            en_out_encryptionTrim.MaximumSize = new Size(170, 0);
            en_out_encryptionTrim.AutoSize = true;

            en_out_label3.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            en_out_label3.Top = ((this.ClientSize.Height - title.Height) / 2) + 20;
            en_out_encryption.Left = ((this.ClientSize.Width - title.Width) / 2) + 430;
            en_out_encryption.Top = ((this.ClientSize.Height - title.Height) / 2) + 15;

            en_out_button.Left = ((this.ClientSize.Width - title.Width) / 2) + 350;
            en_out_button.Top = ((this.ClientSize.Height - title.Height) / 2) + 100;

            //버튼 테두리 없애기
            en_out_button.TabStop = false;
            en_out_button.FlatStyle = FlatStyle.Flat;
            en_out_button.FlatAppearance.BorderSize = 0;

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

        private void de_out_paint(object sender, PaintEventArgs e)
        {
            // GUI setting
            de_out_title.Left = ((this.ClientSize.Width - title.Width) / 2) + 185;
            de_out_title.Top = ((this.ClientSize.Height - title.Height) / 2) - 140;

            de_out_cipher.Left = ((this.ClientSize.Width - title.Width) / 2) + 120;
            de_out_cipher.Top = ((this.ClientSize.Height - title.Height) / 2) - 60;
            de_cipher.Left = ((this.ClientSize.Width - title.Width) / 2) + 270;
            de_cipher.Top = ((this.ClientSize.Height - title.Height) / 2) - 60;
            de_cipher.MaximumSize = new Size(170, 0);
            de_cipher.AutoSize = true;

            de_out_plain.Left = ((this.ClientSize.Width - title.Width) / 2) + 120;
            de_out_plain.Top = ((this.ClientSize.Height - title.Height) / 2) + 10;
            de_plain.Left = ((this.ClientSize.Width - title.Width) / 2) + 270;
            de_plain.Top = ((this.ClientSize.Height - title.Height) / 2) + 10;
            de_plain.MaximumSize = new Size(170, 0);
            de_plain.AutoSize = true;


            //버튼 테두리 없애기
            de_outbtn.TabStop = false;
            de_outbtn.FlatStyle = FlatStyle.Flat;
            de_outbtn.FlatAppearance.BorderSize = 0;
        }

        // 홈 버튼
        private void home1_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = true;
            en_input.Visible = false;
            de_input.Visible = false;
            en_output.Visible = false;
            de_output.Visible = false;
        }
        private void home2_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = true;
            en_input.Visible = false;
            de_input.Visible = false;
            en_output.Visible = false;
            de_output.Visible = false;

        }
        private void en_outbtn_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = true;
            en_input.Visible = false;
            en_output.Visible = false;
        }
        private void de_outbtn_Click(object sender, EventArgs e)
        {
            // 화면 전환
            start.Visible = true;
            en_input.Visible = false;
            de_input.Visible = false;
            en_output.Visible = false;
            de_output.Visible = false;
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

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void out_label1_Click(object sender, EventArgs e)
        {

        }

        private void out_label2_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

       

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
