namespace Assinmnt
{
    partial class Train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Train));
            panel1 = new Panel();
            minbtn = new Button();
            closebtn = new Button();
            panel2 = new Panel();
            bookbtn = new Button();
            mngbookbtn = new Button();
            homebtn = new Button();
            logoutbtn = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            deletetrain = new Button();
            dataGridView1 = new DataGridView();
            updatetrain = new Button();
            addtrain = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel2.Controls.Add(bookbtn);
            panel2.Controls.Add(mngbookbtn);
            panel2.Controls.Add(homebtn);
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 80);
            panel2.TabIndex = 8;
            // 
            // bookbtn
            // 
            bookbtn.DialogResult = DialogResult.Continue;
            bookbtn.FlatAppearance.BorderColor = Color.Black;
            bookbtn.FlatAppearance.BorderSize = 0;
            bookbtn.FlatStyle = FlatStyle.Flat;
            bookbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            bookbtn.ForeColor = Color.FromArgb(38, 28, 29);
            bookbtn.Location = new Point(211, 11);
            bookbtn.Name = "bookbtn";
            bookbtn.Size = new Size(92, 55);
            bookbtn.TabIndex = 7;
            bookbtn.Text = "Ticket Booking";
            bookbtn.UseVisualStyleBackColor = true;
            bookbtn.Click += bookbtn_Click;
            // 
            // mngbookbtn
            // 
            mngbookbtn.DialogResult = DialogResult.Continue;
            mngbookbtn.FlatAppearance.BorderColor = Color.Black;
            mngbookbtn.FlatAppearance.BorderSize = 0;
            mngbookbtn.FlatStyle = FlatStyle.Flat;
            mngbookbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            mngbookbtn.ForeColor = Color.FromArgb(38, 28, 29);
            mngbookbtn.Location = new Point(95, 11);
            mngbookbtn.Name = "mngbookbtn";
            mngbookbtn.Size = new Size(101, 55);
            mngbookbtn.TabIndex = 6;
            mngbookbtn.Text = "Manage Bookings";
            mngbookbtn.UseVisualStyleBackColor = true;
            mngbookbtn.Click += mngbookbtn_Click;
            // 
            // homebtn
            // 
            homebtn.DialogResult = DialogResult.Continue;
            homebtn.FlatAppearance.BorderColor = Color.Black;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            homebtn.ForeColor = Color.FromArgb(38, 28, 29);
            homebtn.Location = new Point(7, 11);
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
            panel3.Location = new Point(0, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(1150, 10);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(1150, 586);
            panel4.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 40, 38);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(deletetrain);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(updatetrain);
            panel5.Controls.Add(addtrain);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(91, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 474);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // deletetrain
            // 
            deletetrain.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            deletetrain.FlatAppearance.BorderSize = 2;
            deletetrain.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            deletetrain.FlatStyle = FlatStyle.Flat;
            deletetrain.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletetrain.ForeColor = Color.White;
            deletetrain.Location = new Point(570, 408);
            deletetrain.Name = "deletetrain";
            deletetrain.Size = new Size(139, 40);
            deletetrain.TabIndex = 41;
            deletetrain.Text = "Delete Train";
            deletetrain.UseVisualStyleBackColor = true;
            deletetrain.Click += deletetrain_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(866, 296);
            dataGridView1.TabIndex = 40;
            // 
            // updatetrain
            // 
            updatetrain.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            updatetrain.FlatAppearance.BorderSize = 2;
            updatetrain.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            updatetrain.FlatStyle = FlatStyle.Flat;
            updatetrain.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatetrain.ForeColor = Color.White;
            updatetrain.Location = new Point(412, 408);
            updatetrain.Name = "updatetrain";
            updatetrain.Size = new Size(142, 40);
            updatetrain.TabIndex = 39;
            updatetrain.Text = "Update Train";
            updatetrain.UseVisualStyleBackColor = true;
            updatetrain.Click += updatetrain_Click;
            // 
            // addtrain
            // 
            addtrain.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            addtrain.FlatAppearance.BorderSize = 2;
            addtrain.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            addtrain.FlatStyle = FlatStyle.Flat;
            addtrain.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addtrain.ForeColor = Color.White;
            addtrain.Location = new Point(277, 408);
            addtrain.Name = "addtrain";
            addtrain.Size = new Size(119, 40);
            addtrain.TabIndex = 38;
            addtrain.Text = "Add Train";
            addtrain.UseVisualStyleBackColor = true;
            addtrain.Click += addtrain_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(578, 39);
            label4.Name = "label4";
            label4.Size = new Size(120, 26);
            label4.TabIndex = 36;
            label4.Text = "Trains here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.ForeColor = Color.FromArgb(212, 175, 55);
            label3.Location = new Point(376, 39);
            label3.Name = "label3";
            label3.Size = new Size(208, 26);
            label3.TabIndex = 35;
            label3.Text = "Update, Add, Delete";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(288, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 26);
            label1.TabIndex = 34;
            label1.Text = "You can";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 11F);
            label13.ForeColor = Color.FromArgb(212, 175, 55);
            label13.Location = new Point(497, 11);
            label13.Name = "label13";
            label13.Size = new Size(71, 26);
            label13.TabIndex = 33;
            label13.Text = "Trains";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(412, 11);
            label2.Name = "label2";
            label2.Size = new Size(96, 26);
            label2.TabIndex = 10;
            label2.Text = "Manage \r\n";
            // 
            // Train
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Train";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Train";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button minbtn;
        private Button closebtn;
        private Panel panel2;
        private Button mngbookbtn;
        private Button homebtn;
        private Button logoutbtn;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button bookbtn;
        private Panel panel4;
        private Panel panel5;
        private Button updatetrain;
        private Button addtrain;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label13;
        private Label label2;
        private DataGridView dataGridView1;
        private Button deletetrain;
    }
}