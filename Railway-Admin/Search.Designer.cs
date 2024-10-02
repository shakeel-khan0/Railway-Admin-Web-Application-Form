namespace Assinmnt
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel1 = new Panel();
            closebtn = new Button();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 211, 66);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 90);
            panel2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(291, -19);
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
            panel3.Size = new Size(804, 22);
            panel3.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 211, 66);
            panel1.Controls.Add(closebtn);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 54);
            panel1.TabIndex = 16;
            // 
            // closebtn
            // 
            closebtn.FlatAppearance.BorderSize = 0;
            closebtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closebtn.ForeColor = Color.FromArgb(41, 40, 28);
            closebtn.Location = new Point(766, 1);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(35, 35);
            closebtn.TabIndex = 0;
            closebtn.Text = "X";
            closebtn.UseVisualStyleBackColor = true;
            closebtn.Click += closebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(37, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(725, 225);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 40, 38);
            ClientSize = new Size(800, 500);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel1;
        private Button closebtn;
        private DataGridView dataGridView1;
    }
}