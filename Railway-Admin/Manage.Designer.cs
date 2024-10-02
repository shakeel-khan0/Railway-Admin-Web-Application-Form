namespace Assinmnt
{
    partial class Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage));
            panel1 = new Panel();
            minbtn = new Button();
            closebtn = new Button();
            panel2 = new Panel();
            mngtrainbtn = new Button();
            bookbtn = new Button();
            homebtn = new Button();
            logoutbtn = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            bookingdataview = new DataGridView();
            update = new Button();
            cancl = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label13 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookingdataview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 211, 66);
            panel1.Controls.Add(minbtn);
            panel1.Controls.Add(closebtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 42);
            panel1.TabIndex = 2;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 211, 66);
            panel2.Controls.Add(mngtrainbtn);
            panel2.Controls.Add(bookbtn);
            panel2.Controls.Add(homebtn);
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 80);
            panel2.TabIndex = 8;
            // 
            // mngtrainbtn
            // 
            mngtrainbtn.DialogResult = DialogResult.Continue;
            mngtrainbtn.FlatAppearance.BorderColor = Color.Black;
            mngtrainbtn.FlatAppearance.BorderSize = 0;
            mngtrainbtn.FlatStyle = FlatStyle.Flat;
            mngtrainbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            mngtrainbtn.ForeColor = Color.FromArgb(38, 28, 29);
            mngtrainbtn.Location = new Point(201, 12);
            mngtrainbtn.Name = "mngtrainbtn";
            mngtrainbtn.Size = new Size(88, 55);
            mngtrainbtn.TabIndex = 8;
            mngtrainbtn.Text = "Manage Trains";
            mngtrainbtn.UseVisualStyleBackColor = true;
            mngtrainbtn.Click += mngtrainbtn_Click;
            // 
            // bookbtn
            // 
            bookbtn.DialogResult = DialogResult.Continue;
            bookbtn.FlatAppearance.BorderColor = Color.Black;
            bookbtn.FlatAppearance.BorderSize = 0;
            bookbtn.FlatStyle = FlatStyle.Flat;
            bookbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            bookbtn.ForeColor = Color.FromArgb(38, 28, 29);
            bookbtn.Location = new Point(90, 12);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(98, 55);
            bookbtn.TabIndex = 5;
            bookbtn.Text = "Ticket Booking";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // homebtn
            // 
            homebtn.DialogResult = DialogResult.Continue;
            homebtn.FlatAppearance.BorderColor = Color.Black;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            homebtn.ForeColor = Color.FromArgb(38, 28, 29);
            homebtn.Location = new Point(7, 12);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(71, 55);
            homebtn.TabIndex = 4;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.FlatAppearance.BorderColor = Color.Black;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            logoutbtn.ForeColor = Color.FromArgb(38, 28, 29);
            logoutbtn.Location = new Point(1036, 11);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(100, 55);
            logoutbtn.TabIndex = 2;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
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
            panel3.Location = new Point(0, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(1150, 10);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(1150, 620);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 40, 38);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(bookingdataview);
            panel5.Controls.Add(update);
            panel5.Controls.Add(cancl);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(91, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 474);
            panel5.TabIndex = 0;
            // 
            // bookingdataview
            // 
            bookingdataview.BackgroundColor = Color.White;
            bookingdataview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingdataview.Location = new Point(34, 87);
            bookingdataview.Name = "bookingdataview";
            bookingdataview.RowHeadersWidth = 62;
            bookingdataview.Size = new Size(900, 267);
            bookingdataview.TabIndex = 40;
            // 
            // update
            // 
            update.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            update.FlatAppearance.BorderSize = 2;
            update.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.ForeColor = Color.White;
            update.Location = new Point(467, 400);
            update.Name = "update";
            update.Size = new Size(211, 40);
            update.TabIndex = 39;
            update.Text = "Update Reservations";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // cancl
            // 
            cancl.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            cancl.FlatAppearance.BorderSize = 2;
            cancl.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            cancl.FlatStyle = FlatStyle.Flat;
            cancl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancl.ForeColor = Color.White;
            cancl.Location = new Point(287, 400);
            cancl.Name = "cancl";
            cancl.Size = new Size(172, 40);
            cancl.TabIndex = 38;
            cancl.Text = "Cancel Booking";
            cancl.UseVisualStyleBackColor = true;
            cancl.Click += cancl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(640, 14);
            label4.Name = "label4";
            label4.Size = new Size(130, 26);
            label4.TabIndex = 36;
            label4.Text = "details here!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.ForeColor = Color.FromArgb(212, 175, 55);
            label3.Location = new Point(553, 14);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 35;
            label3.Text = "Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(437, 14);
            label1.Name = "label1";
            label1.Size = new Size(124, 26);
            label1.TabIndex = 34;
            label1.Text = "and Update";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 11F);
            label13.ForeColor = Color.FromArgb(212, 175, 55);
            label13.Location = new Point(304, 14);
            label13.Name = "label13";
            label13.Size = new Size(139, 26);
            label13.TabIndex = 33;
            label13.Text = "Reservations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(218, 14);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 10;
            label2.Text = "Manage \r\n";
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Manage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookingdataview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button minbtn;
        private Button closebtn;
        private Panel panel2;
        private Button homebtn;
        private Button logoutbtn;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label13;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button bookbtn;
        private Button update;
        private Button cancl;
        private Button mngtrainbtn;
        private DataGridView bookingdataview;
    }
}