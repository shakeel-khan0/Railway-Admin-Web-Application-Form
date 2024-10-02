namespace Assinmnt
{
    partial class Updatetrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updatetrain));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            minbtn = new Button();
            closebtn = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            trainid = new ComboBox();
            trainnamecombo = new ComboBox();
            label5 = new Label();
            label9 = new Label();
            deptimecombo = new ComboBox();
            label6 = new Label();
            arivtimcombo = new ComboBox();
            label8 = new Label();
            destinationcombo = new ComboBox();
            sourcecombo = new ComboBox();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            updttrain = new Button();
            label13 = new Label();
            label2 = new Label();
            backbtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 211, 66);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 80);
            panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(471, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 40, 41);
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(1150, 10);
            panel3.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 211, 66);
            panel1.Controls.Add(minbtn);
            panel1.Controls.Add(closebtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 42);
            panel1.TabIndex = 10;
            // 
            // minbtn
            // 
            minbtn.FlatAppearance.BorderSize = 0;
            minbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 150);
            minbtn.FlatStyle = FlatStyle.Flat;
            minbtn.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            minbtn.ForeColor = Color.FromArgb(41, 40, 28);
            minbtn.Location = new Point(1070, 4);
            minbtn.Name = "minbtn";
            minbtn.Size = new Size(35, 35);
            minbtn.TabIndex = 1;
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
            closebtn.Location = new Point(1111, 4);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(35, 35);
            closebtn.TabIndex = 0;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(1150, 586);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 40, 38);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(backbtn);
            panel5.Controls.Add(trainid);
            panel5.Controls.Add(trainnamecombo);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(deptimecombo);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(arivtimcombo);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(destinationcombo);
            panel5.Controls.Add(sourcecombo);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(updttrain);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(91, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 474);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // trainid
            // 
            trainid.FormattingEnabled = true;
            trainid.Location = new Point(227, 108);
            trainid.Name = "trainid";
            trainid.Size = new Size(224, 33);
            trainid.TabIndex = 62;
            // 
            // trainnamecombo
            // 
            trainnamecombo.ForeColor = Color.Black;
            trainnamecombo.FormattingEnabled = true;
            trainnamecombo.Items.AddRange(new object[] { "Safari Train", "Express Train", "Bullet Train", "Khyber Train" });
            trainnamecombo.Location = new Point(697, 108);
            trainnamecombo.Name = "trainnamecombo";
            trainnamecombo.Size = new Size(224, 33);
            trainnamecombo.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(526, 116);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 60;
            label5.Text = "Train Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(527, 19);
            label9.Name = "label9";
            label9.Size = new Size(102, 32);
            label9.TabIndex = 59;
            label9.Text = "Details";
            // 
            // deptimecombo
            // 
            deptimecombo.ForeColor = Color.Black;
            deptimecombo.FormattingEnabled = true;
            deptimecombo.Items.AddRange(new object[] { "05:00 AM", "07:20 AM", "04:30 PM", "08:00 PM", "10:40 PM", "03:00 AM" });
            deptimecombo.Location = new Point(227, 285);
            deptimecombo.Name = "deptimecombo";
            deptimecombo.Size = new Size(224, 33);
            deptimecombo.TabIndex = 58;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(56, 293);
            label6.Name = "label6";
            label6.Size = new Size(147, 25);
            label6.TabIndex = 56;
            label6.Text = "Departure Time";
            // 
            // arivtimcombo
            // 
            arivtimcombo.ForeColor = Color.Black;
            arivtimcombo.FormattingEnabled = true;
            arivtimcombo.Items.AddRange(new object[] { "07:15 PM", "10:00 PM", "06:40 PM", "04:30 AM", "09:55 AM", "12:00 AM" });
            arivtimcombo.Location = new Point(697, 277);
            arivtimcombo.Name = "arivtimcombo";
            arivtimcombo.Size = new Size(224, 33);
            arivtimcombo.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10F);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(532, 285);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 53;
            label8.Text = "Arival Time";
            // 
            // destinationcombo
            // 
            destinationcombo.ForeColor = Color.Black;
            destinationcombo.FormattingEnabled = true;
            destinationcombo.Items.AddRange(new object[] { "Bahawalpur", "Quetta", "Attock", "Gwadar", "Heydrabad", "Gujrat", "Rawalpindi" });
            destinationcombo.Location = new Point(697, 187);
            destinationcombo.Name = "destinationcombo";
            destinationcombo.Size = new Size(224, 33);
            destinationcombo.TabIndex = 52;
            // 
            // sourcecombo
            // 
            sourcecombo.ForeColor = Color.Black;
            sourcecombo.FormattingEnabled = true;
            sourcecombo.Items.AddRange(new object[] { "Rawalpindi", "Gujrat", "Heydrabad", "Gwadar", "Attock", "Quetta", "Bahawalpur" });
            sourcecombo.Location = new Point(227, 195);
            sourcecombo.Name = "sourcecombo";
            sourcecombo.Size = new Size(224, 33);
            sourcecombo.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(532, 195);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 48;
            label4.Text = "Destination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(56, 203);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 46;
            label1.Text = "Source";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(56, 116);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 42;
            label3.Text = "Train ID";
            // 
            // updttrain
            // 
            updttrain.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            updttrain.FlatAppearance.BorderSize = 2;
            updttrain.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            updttrain.FlatStyle = FlatStyle.Flat;
            updttrain.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            updttrain.ForeColor = Color.White;
            updttrain.Location = new Point(406, 383);
            updttrain.Name = "updttrain";
            updttrain.Size = new Size(157, 51);
            updttrain.TabIndex = 38;
            updttrain.Text = "Update";
            updttrain.UseVisualStyleBackColor = true;
            updttrain.Click += updttrain_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14F);
            label13.ForeColor = Color.FromArgb(212, 175, 55);
            label13.Location = new Point(453, 19);
            label13.Name = "label13";
            label13.Size = new Size(79, 32);
            label13.TabIndex = 33;
            label13.Text = "Train";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(352, 19);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 10;
            label2.Text = "Update";
            // 
            // backbtn
            // 
            backbtn.FlatAppearance.BorderSize = 0;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Image = (Image)resources.GetObject("backbtn.Image");
            backbtn.Location = new Point(3, -1);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(50, 40);
            backbtn.TabIndex = 63;
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // Updatetrain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Updatetrain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel1;
        private Button minbtn;
        private Button closebtn;
        private Panel panel4;
        private Panel panel5;
        private ComboBox deptimecombo;
        private Label label6;
        private ComboBox arivtimcombo;
        private Label label8;
        private ComboBox destinationcombo;
        private ComboBox sourcecombo;
        private Label label4;
        private Label label1;
        private Label label3;
        private Button updttrain;
        private Label label13;
        private Label label2;
        private Label label9;
        private ComboBox trainnamecombo;
        private Label label5;
        private ComboBox trainid;
        private Button backbtn;
    }
}