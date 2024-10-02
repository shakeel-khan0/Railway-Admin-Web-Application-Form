namespace Assinmnt
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            panel1 = new Panel();
            minbtn = new Button();
            closebtn = new Button();
            panel2 = new Panel();
            mngtrainbtn = new Button();
            mngbookbtn = new Button();
            bookbtn = new Button();
            logoutbtn = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            srchtranbtn = new Button();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 211, 66);
            panel1.Controls.Add(minbtn);
            panel1.Controls.Add(closebtn);
            panel1.Location = new Point(1, 1);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 34);
            panel1.TabIndex = 0;
            // 
            // minbtn
            // 
            minbtn.FlatAppearance.BorderSize = 0;
            minbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 150);
            minbtn.FlatStyle = FlatStyle.Flat;
            minbtn.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            minbtn.ForeColor = Color.FromArgb(41, 40, 28);
            minbtn.Location = new Point(856, 3);
            minbtn.Margin = new Padding(2, 2, 2, 2);
            minbtn.Name = "minbtn";
            minbtn.Size = new Size(28, 28);
            minbtn.TabIndex = 3;
            minbtn.Text = "-";
            minbtn.TextAlign = ContentAlignment.TopCenter;
            minbtn.UseVisualStyleBackColor = true;
            minbtn.Click += minbtn_Click;
            // 
            // closebtn
            // 
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 40, 28);
            closebtn.Location = new Point(889, 3);
            closebtn.Margin = new Padding(2, 2, 2, 2);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(28, 28);
            closebtn.TabIndex = 2;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 211, 66);
            panel2.Controls.Add(mngtrainbtn);
            panel2.Controls.Add(mngbookbtn);
            panel2.Controls.Add(bookbtn);
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(2, 43);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 64);
            panel2.TabIndex = 4;
            // 
            // mngtrainbtn
            // 
            mngtrainbtn.DialogResult = DialogResult.Continue;
            mngtrainbtn.FlatAppearance.BorderColor = Color.Black;
            mngtrainbtn.FlatAppearance.BorderSize = 0;
            mngtrainbtn.FlatStyle = FlatStyle.Flat;
            mngtrainbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            mngtrainbtn.ForeColor = Color.FromArgb(38, 28, 29);
            mngtrainbtn.Location = new Point(192, 9);
            mngtrainbtn.Margin = new Padding(2, 2, 2, 2);
            mngtrainbtn.Name = "mngtrainbtn";
            mngtrainbtn.Size = new Size(92, 44);
            mngtrainbtn.TabIndex = 8;
            mngtrainbtn.Text = "Manage Trains";
            mngtrainbtn.UseVisualStyleBackColor = true;
            mngtrainbtn.Click += mngtrainbtn_Click;
            // 
            // mngbookbtn
            // 
            mngbookbtn.DialogResult = DialogResult.Continue;
            mngbookbtn.FlatAppearance.BorderColor = Color.Black;
            mngbookbtn.FlatAppearance.BorderSize = 0;
            mngbookbtn.FlatStyle = FlatStyle.Flat;
            mngbookbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            mngbookbtn.ForeColor = Color.FromArgb(38, 28, 29);
            mngbookbtn.Location = new Point(98, 9);
            mngbookbtn.Margin = new Padding(2, 2, 2, 2);
            mngbookbtn.Name = "mngbookbtn";
            mngbookbtn.Size = new Size(81, 44);
            mngbookbtn.TabIndex = 6;
            mngbookbtn.Text = "Manage Bookings";
            mngbookbtn.UseVisualStyleBackColor = true;
            mngbookbtn.Click += mngbookbtn_Click;
            // 
            // bookbtn
            // 
            bookbtn.DialogResult = DialogResult.Continue;
            bookbtn.FlatAppearance.BorderColor = Color.Black;
            bookbtn.FlatAppearance.BorderSize = 0;
            bookbtn.FlatStyle = FlatStyle.Flat;
            bookbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            bookbtn.ForeColor = Color.FromArgb(38, 28, 29);
            bookbtn.Location = new Point(4, 9);
            bookbtn.Margin = new Padding(2, 2, 2, 2);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(82, 44);
            bookbtn.TabIndex = 4;
            bookbtn.Text = "Ticket Booking";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.FlatAppearance.BorderColor = Color.Black;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            logoutbtn.ForeColor = Color.FromArgb(38, 28, 29);
            logoutbtn.Location = new Point(829, 13);
            logoutbtn.Margin = new Padding(2, 2, 2, 2);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(78, 36);
            logoutbtn.TabIndex = 2;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(377, -15);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 40, 41);
            panel3.Location = new Point(1, 35);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 8);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 102);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(919, 496);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(595, 106);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(24, 36);
            label4.TabIndex = 4;
            label4.Text = "!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(249, 211, 66);
            label5.Location = new Point(335, 104);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(307, 36);
            label5.TabIndex = 3;
            label5.Text = "BOOK YOUR TRAIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(389, 67);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 36);
            label3.TabIndex = 1;
            label3.Text = "WELCOME ";
            label3.Click += label3_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(srchtranbtn);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(96, 166);
            panel5.Margin = new Padding(2, 2, 2, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(740, 194);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 10F);
            comboBox2.ForeColor = Color.Black;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Karachi", "Lahore", "Rawalpindi", "Faisalabad", "Multan", "Hyderabad", "Quetta", "Peshawar", "Gujranwala", "Sialkot", "Abbottabad", "Bahawalpur", "Sukkur", "Sargodha" });
            comboBox2.Location = new Point(429, 87);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(189, 28);
            comboBox2.TabIndex = 12;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 10F);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Karachi", "Lahore", "Rawalpindi", "Faisalabad", "Multan", "Hyderabad", "Quetta", "Peshawar", "Gujranwala", "Sialkot", "Abbottabad", "Bahawalpur", "Sukkur", "Sargodha" });
            comboBox1.Location = new Point(150, 87);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(141, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(454, 25);
            label2.TabIndex = 10;
            label2.Text = "Find the best and affordable train routes in Pakistan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(249, 211, 66);
            label1.Location = new Point(287, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 9;
            label1.Text = "Search for Train";
            // 
            // srchtranbtn
            // 
            srchtranbtn.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            srchtranbtn.FlatAppearance.BorderSize = 2;
            srchtranbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            srchtranbtn.FlatStyle = FlatStyle.Flat;
            srchtranbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            srchtranbtn.ForeColor = Color.White;
            srchtranbtn.Location = new Point(321, 148);
            srchtranbtn.Margin = new Padding(2, 2, 2, 2);
            srchtranbtn.Name = "srchtranbtn";
            srchtranbtn.Size = new Size(90, 27);
            srchtranbtn.TabIndex = 7;
            srchtranbtn.Text = "Search";
            srchtranbtn.UseVisualStyleBackColor = true;
            srchtranbtn.Click += srchtranbtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(383, 87);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 87);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 40, 41);
            ClientSize = new Size(920, 560);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += home_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button minbtn;
        private Button closebtn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button logoutbtn;
        private Button bookbtn;
        private Panel panel5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button srchtranbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button mngbookbtn;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button mngtrainbtn;
    }
}