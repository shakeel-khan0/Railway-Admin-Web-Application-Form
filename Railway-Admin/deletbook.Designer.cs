namespace Assinmnt
{
    partial class deletbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deletbook));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            closebtn = new Button();
            delettrainbtn = new Button();
            label9 = new Label();
            label13 = new Label();
            label2 = new Label();
            trainid = new ComboBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 211, 66);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 90);
            panel2.TabIndex = 70;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(241, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 128);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 40, 41);
            panel3.Location = new Point(-1, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(699, 22);
            panel3.TabIndex = 71;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 211, 66);
            panel1.Controls.Add(closebtn);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 54);
            panel1.TabIndex = 69;
            // 
            // closebtn
            // 
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 40, 28);
            closebtn.Location = new Point(654, 1);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(35, 35);
            closebtn.TabIndex = 0;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // delettrainbtn
            // 
            delettrainbtn.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            delettrainbtn.FlatAppearance.BorderSize = 2;
            delettrainbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            delettrainbtn.FlatStyle = FlatStyle.Flat;
            delettrainbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            delettrainbtn.ForeColor = Color.White;
            delettrainbtn.Location = new Point(272, 490);
            delettrainbtn.Name = "delettrainbtn";
            delettrainbtn.Size = new Size(157, 51);
            delettrainbtn.TabIndex = 77;
            delettrainbtn.Text = "Cancel";
            delettrainbtn.UseVisualStyleBackColor = true;
            delettrainbtn.Click += delettrainbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(407, 232);
            label9.Name = "label9";
            label9.Size = new Size(102, 32);
            label9.TabIndex = 76;
            label9.Text = "Details";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 14F);
            label13.ForeColor = Color.FromArgb(212, 175, 55);
            label13.Location = new Point(296, 232);
            label13.Name = "label13";
            label13.Size = new Size(118, 32);
            label13.TabIndex = 75;
            label13.Text = "Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(207, 232);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 74;
            label2.Text = "Cancel";
            // 
            // trainid
            // 
            trainid.FormattingEnabled = true;
            trainid.Location = new Point(308, 349);
            trainid.Name = "trainid";
            trainid.Size = new Size(224, 33);
            trainid.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(137, 357);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 72;
            label3.Text = "Booking ID";
            // 
            // deletbook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 40, 38);
            ClientSize = new Size(697, 585);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(delettrainbtn);
            Controls.Add(label9);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(trainid);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "deletbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel1;
        private Button closebtn;
        private Button delettrainbtn;
        private Label label9;
        private Label label13;
        private Label label2;
        private ComboBox trainid;
        private Label label3;
    }
}