namespace _3106
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Panel();
            this.input = new System.Windows.Forms.Panel();
            this.in_button = new System.Windows.Forms.Button();
            this.in_label2 = new System.Windows.Forms.Label();
            this.in_textBox2 = new System.Windows.Forms.TextBox();
            this.in_textBox1 = new System.Windows.Forms.TextBox();
            this.in_label1 = new System.Windows.Forms.Label();
            this.in_title = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Panel();
            this.out_plain = new System.Windows.Forms.Label();
            this.out_label2 = new System.Windows.Forms.Label();
            this.out_cipher = new System.Windows.Forms.Label();
            this.out_label1 = new System.Windows.Forms.Label();
            this.out_button = new System.Windows.Forms.Button();
            this.subtext = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.start.SuspendLayout();
            this.input.SuspendLayout();
            this.output.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button.Location = new System.Drawing.Point(350, 320);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(200, 60);
            this.button.TabIndex = 0;
            this.button.Text = "암호화 하기";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("돋움", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.Color.Snow;
            this.title.Location = new System.Drawing.Point(136, 177);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(628, 60);
            this.title.TabIndex = 1;
            this.title.Text = "다중 문자 치환 암호화";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // start
            // 
            this.start.BackgroundImage = global::_3106.Properties.Resources.main;
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Controls.Add(this.button);
            this.start.Controls.Add(this.title);
            this.start.Location = new System.Drawing.Point(0, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(900, 600);
            this.start.TabIndex = 2;
            this.start.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.IndianRed;
            this.input.Controls.Add(this.in_button);
            this.input.Controls.Add(this.in_label2);
            this.input.Controls.Add(this.in_textBox2);
            this.input.Controls.Add(this.in_textBox1);
            this.input.Controls.Add(this.in_label1);
            this.input.Controls.Add(this.in_title);
            this.input.Location = new System.Drawing.Point(0, 0);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(900, 600);
            this.input.TabIndex = 2;
            this.input.Visible = false;
            this.input.Paint += new System.Windows.Forms.PaintEventHandler(this.input_Paint);
            // 
            // in_button
            // 
            this.in_button.BackColor = System.Drawing.SystemColors.Control;
            this.in_button.Font = new System.Drawing.Font("돋움", 16.2F, System.Drawing.FontStyle.Bold);
            this.in_button.Location = new System.Drawing.Point(341, 359);
            this.in_button.Name = "in_button";
            this.in_button.Size = new System.Drawing.Size(175, 50);
            this.in_button.TabIndex = 11;
            this.in_button.Text = "암호화 하기";
            this.in_button.UseVisualStyleBackColor = false;
            this.in_button.Click += new System.EventHandler(this.in_button_Click);
            // 
            // in_label2
            // 
            this.in_label2.AutoSize = true;
            this.in_label2.Location = new System.Drawing.Point(200, 289);
            this.in_label2.Name = "in_label2";
            this.in_label2.Size = new System.Drawing.Size(37, 15);
            this.in_label2.TabIndex = 9;
            this.in_label2.Text = "평문";
            // 
            // in_textBox2
            // 
            this.in_textBox2.Location = new System.Drawing.Point(414, 289);
            this.in_textBox2.Name = "in_textBox2";
            this.in_textBox2.Size = new System.Drawing.Size(281, 25);
            this.in_textBox2.TabIndex = 8;
            this.in_textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // in_textBox1
            // 
            this.in_textBox1.Location = new System.Drawing.Point(430, 240);
            this.in_textBox1.Name = "in_textBox1";
            this.in_textBox1.Size = new System.Drawing.Size(281, 25);
            this.in_textBox1.TabIndex = 7;
            // 
            // in_label1
            // 
            this.in_label1.AutoSize = true;
            this.in_label1.Location = new System.Drawing.Point(209, 250);
            this.in_label1.Name = "in_label1";
            this.in_label1.Size = new System.Drawing.Size(52, 15);
            this.in_label1.TabIndex = 6;
            this.in_label1.Text = "암호키";
            // 
            // in_title
            // 
            this.in_title.AutoSize = true;
            this.in_title.BackColor = System.Drawing.Color.Transparent;
            this.in_title.Font = new System.Drawing.Font("돋움", 36F, System.Drawing.FontStyle.Bold);
            this.in_title.Location = new System.Drawing.Point(120, 101);
            this.in_title.Name = "in_title";
            this.in_title.Size = new System.Drawing.Size(628, 60);
            this.in_title.TabIndex = 10;
            this.in_title.Text = "다중 문자 치환 암호화";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.Cornsilk;
            this.output.Controls.Add(this.out_plain);
            this.output.Controls.Add(this.out_label2);
            this.output.Controls.Add(this.out_cipher);
            this.output.Controls.Add(this.out_label1);
            this.output.Controls.Add(this.out_button);
            this.output.Controls.Add(this.subtext);
            this.output.Controls.Add(this.tableLayoutPanel);
            this.output.Location = new System.Drawing.Point(0, 0);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(900, 600);
            this.output.TabIndex = 0;
            this.output.Paint += new System.Windows.Forms.PaintEventHandler(this.output_Paint);
            // 
            // out_plain
            // 
            this.out_plain.AutoSize = true;
            this.out_plain.Location = new System.Drawing.Point(599, 268);
            this.out_plain.Name = "out_plain";
            this.out_plain.Size = new System.Drawing.Size(55, 15);
            this.out_plain.TabIndex = 6;
            this.out_plain.Text = "ABCDE";
            // 
            // out_label2
            // 
            this.out_label2.AutoSize = true;
            this.out_label2.Location = new System.Drawing.Point(508, 268);
            this.out_label2.Name = "out_label2";
            this.out_label2.Size = new System.Drawing.Size(52, 15);
            this.out_label2.TabIndex = 5;
            this.out_label2.Text = "복호문";
            // 
            // out_cipher
            // 
            this.out_cipher.AutoSize = true;
            this.out_cipher.Location = new System.Drawing.Point(599, 192);
            this.out_cipher.Name = "out_cipher";
            this.out_cipher.Size = new System.Drawing.Size(55, 15);
            this.out_cipher.TabIndex = 4;
            this.out_cipher.Text = "ABCDE";
            // 
            // out_label1
            // 
            this.out_label1.AutoSize = true;
            this.out_label1.Location = new System.Drawing.Point(508, 192);
            this.out_label1.Name = "out_label1";
            this.out_label1.Size = new System.Drawing.Size(52, 15);
            this.out_label1.TabIndex = 3;
            this.out_label1.Text = "암호문";
            // 
            // out_button
            // 
            this.out_button.Location = new System.Drawing.Point(731, 413);
            this.out_button.Name = "out_button";
            this.out_button.Size = new System.Drawing.Size(75, 23);
            this.out_button.TabIndex = 2;
            this.out_button.Text = "처음으로";
            this.out_button.UseVisualStyleBackColor = true;
            this.out_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // subtext
            // 
            this.subtext.AutoSize = true;
            this.subtext.Location = new System.Drawing.Point(56, 57);
            this.subtext.Name = "subtext";
            this.subtext.Size = new System.Drawing.Size(52, 15);
            this.subtext.TabIndex = 1;
            this.subtext.Text = "암호판";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.label25, 4, 4);
            this.tableLayoutPanel.Controls.Add(this.label24, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.label23, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.label22, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.label21, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.label20, 4, 3);
            this.tableLayoutPanel.Controls.Add(this.label19, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.label18, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.label17, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.label15, 4, 2);
            this.tableLayoutPanel.Controls.Add(this.label14, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.label13, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.label12, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.label10, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.label9, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(56, 78);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(368, 358);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(296, 313);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 15);
            this.label25.TabIndex = 24;
            this.label25.Text = "A";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(223, 313);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 15);
            this.label24.TabIndex = 23;
            this.label24.Text = "A";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(150, 313);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 15);
            this.label23.TabIndex = 22;
            this.label23.Text = "A";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(77, 313);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(66, 15);
            this.label22.TabIndex = 21;
            this.label22.Text = "A";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 313);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 15);
            this.label21.TabIndex = 20;
            this.label21.Text = "A";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(296, 241);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 15);
            this.label20.TabIndex = 19;
            this.label20.Text = "A";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(223, 241);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "A";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(150, 241);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 15);
            this.label18.TabIndex = 17;
            this.label18.Text = "A";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(77, 241);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "A";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "A";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(296, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 14;
            this.label15.Text = "A";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "A";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "A";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "A";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "A";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "A";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "A";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "A";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "A";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.start);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "3106";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.start.ResumeLayout(false);
            this.start.PerformLayout();
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.output.ResumeLayout(false);
            this.output.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel start;
        private System.Windows.Forms.Panel input;
        private System.Windows.Forms.Panel output;
        private System.Windows.Forms.Button in_button;
        private System.Windows.Forms.Label in_title;
        private System.Windows.Forms.Label in_label2;
        private System.Windows.Forms.TextBox in_textBox2;
        private System.Windows.Forms.TextBox in_textBox1;
        private System.Windows.Forms.Label in_label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label subtext;
        private System.Windows.Forms.Button out_button;
        private System.Windows.Forms.Label out_plain;
        private System.Windows.Forms.Label out_label2;
        private System.Windows.Forms.Label out_cipher;
        private System.Windows.Forms.Label out_label1;
    }
}

