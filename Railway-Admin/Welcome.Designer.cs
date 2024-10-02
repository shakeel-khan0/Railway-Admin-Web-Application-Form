namespace Assinmnt
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            loginwel = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            minbtn = new Button();
            closebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1045, 649);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 40, 38);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(loginwel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(292, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 509);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(141, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginwel
            // 
            loginwel.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            loginwel.FlatAppearance.BorderSize = 2;
            loginwel.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            loginwel.FlatStyle = FlatStyle.Flat;
            loginwel.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginwel.ForeColor = Color.White;
            loginwel.Location = new Point(148, 369);
            loginwel.Name = "loginwel";
            loginwel.Size = new Size(166, 44);
            loginwel.TabIndex = 2;
            loginwel.Text = "Login Here";
            loginwel.UseVisualStyleBackColor = true;
            loginwel.Click += loginwel_Click;
            loginwel.KeyDown += loginwel_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F);
            label2.ForeColor = Color.FromArgb(249, 211, 66);
            label2.Location = new Point(28, 271);
            label2.Name = "label2";
            label2.Size = new Size(406, 43);
            label2.TabIndex = 1;
            label2.Text = "Railway Management";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 210);
            label1.Name = "label1";
            label1.Size = new Size(234, 43);
            label1.TabIndex = 0;
            label1.Text = "Welcome to";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 211, 66);
            panel2.Controls.Add(minbtn);
            panel2.Controls.Add(closebtn);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1040, 42);
            panel2.TabIndex = 2;
            // 
            // minbtn
            // 
            minbtn.FlatAppearance.BorderSize = 0;
            minbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 150);
            minbtn.FlatStyle = FlatStyle.Flat;
            minbtn.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            minbtn.ForeColor = Color.FromArgb(41, 40, 28);
            minbtn.Location = new Point(963, 3);
            minbtn.Name = "minbtn";
            minbtn.Size = new Size(35, 35);
            minbtn.TabIndex = 5;
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
            closebtn.Location = new Point(1004, 3);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(35, 35);
            closebtn.TabIndex = 4;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 690);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button loginwel;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button minbtn;
        private Button closebtn;
    }
}
