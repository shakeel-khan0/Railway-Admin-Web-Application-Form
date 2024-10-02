namespace Assinmnt
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            panel1 = new Panel();
            minbtn = new Button();
            closebtn = new Button();
            panel2 = new Panel();
            mngtrainbtn = new Button();
            mngbookbtn = new Button();
            homebtn = new Button();
            logoutbtn = new Button();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            label24 = new Label();
            seatnocombo = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            classtypcombi = new ComboBox();
            label21 = new Label();
            tickttypcombo = new ComboBox();
            admincombo = new ComboBox();
            label8 = new Label();
            label20 = new Label();
            traincombo = new ComboBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label12 = new Label();
            comboBox2 = new ComboBox();
            label15 = new Label();
            comboBox1 = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            crdbtn = new Button();
            label11 = new Label();
            numericUpDown2 = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.TabIndex = 1;
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
            panel2.Controls.Add(mngbookbtn);
            panel2.Controls.Add(homebtn);
            panel2.Controls.Add(logoutbtn);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 80);
            panel2.TabIndex = 6;
            // 
            // mngtrainbtn
            // 
            mngtrainbtn.DialogResult = DialogResult.Continue;
            mngtrainbtn.FlatAppearance.BorderColor = Color.Black;
            mngtrainbtn.FlatAppearance.BorderSize = 0;
            mngtrainbtn.FlatStyle = FlatStyle.Flat;
            mngtrainbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            mngtrainbtn.ForeColor = Color.FromArgb(38, 28, 29);
            mngtrainbtn.Location = new Point(213, 11);
            mngtrainbtn.Name = "mngtrainbtn";
            mngtrainbtn.Size = new Size(88, 55);
            mngtrainbtn.TabIndex = 7;
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
            mngbookbtn.Location = new Point(90, 11);
            mngbookbtn.Name = "mngbookbtn";
            mngbookbtn.Size = new Size(112, 55);
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
            panel3.Location = new Point(0, 42);
            panel3.Name = "panel3";
            panel3.Size = new Size(1150, 10);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(0, 127);
            panel4.Name = "panel4";
            panel4.Size = new Size(1150, 620);
            panel4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(413, 25);
            label6.Name = "label6";
            label6.Size = new Size(219, 37);
            label6.TabIndex = 6;
            label6.Text = "BOOK YOUR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(249, 211, 66);
            label5.Location = new Point(618, 25);
            label5.Name = "label5";
            label5.Size = new Size(136, 37);
            label5.TabIndex = 3;
            label5.Text = "TICKET";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(41, 40, 38);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(label24);
            panel5.Controls.Add(seatnocombo);
            panel5.Controls.Add(label23);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(classtypcombi);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(tickttypcombo);
            panel5.Controls.Add(admincombo);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(traincombo);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(comboBox2);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(crdbtn);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(numericUpDown2);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dateTimePicker1);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(91, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(970, 492);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.FromArgb(41, 40, 38);
            label24.Font = new Font("Microsoft Sans Serif", 7F);
            label24.ForeColor = Color.Red;
            label24.Location = new Point(658, 400);
            label24.Name = "label24";
            label24.Size = new Size(123, 17);
            label24.TabIndex = 52;
            label24.Text = "Invalid Credentials";
            label24.Visible = false;
            // 
            // seatnocombo
            // 
            seatnocombo.ForeColor = Color.Gray;
            seatnocombo.FormattingEnabled = true;
            seatnocombo.Items.AddRange(new object[] { "1A", "2A", "3A", "4A ", "5A", "6B", "7B", "8B", "9B", "10B" });
            seatnocombo.Location = new Point(658, 364);
            seatnocombo.Name = "seatnocombo";
            seatnocombo.Size = new Size(224, 33);
            seatnocombo.TabIndex = 51;
            seatnocombo.Text = "(select seat number)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 10F);
            label23.ForeColor = Color.WhiteSmoke;
            label23.Location = new Point(514, 374);
            label23.Name = "label23";
            label23.Size = new Size(83, 25);
            label23.TabIndex = 49;
            label23.Text = "Seat No";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(41, 40, 38);
            label22.Font = new Font("Microsoft Sans Serif", 7F);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(658, 339);
            label22.Name = "label22";
            label22.Size = new Size(123, 17);
            label22.TabIndex = 48;
            label22.Text = "Invalid Credentials";
            label22.Visible = false;
            label22.Click += label22_Click;
            // 
            // classtypcombi
            // 
            classtypcombi.ForeColor = Color.Gray;
            classtypcombi.FormattingEnabled = true;
            classtypcombi.Items.AddRange(new object[] { "Economy Class ", "AC Class", "Bussiness Class", "First Class" });
            classtypcombi.Location = new Point(658, 303);
            classtypcombi.Name = "classtypcombi";
            classtypcombi.Size = new Size(224, 33);
            classtypcombi.TabIndex = 47;
            classtypcombi.Text = "(select train class)";
            classtypcombi.SelectedIndexChanged += classtypcombi_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(41, 40, 38);
            label21.Font = new Font("Microsoft Sans Serif", 7F);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(661, 275);
            label21.Name = "label21";
            label21.Size = new Size(123, 17);
            label21.TabIndex = 46;
            label21.Text = "Invalid Credentials";
            label21.Visible = false;
            // 
            // tickttypcombo
            // 
            tickttypcombo.ForeColor = Color.Gray;
            tickttypcombo.FormattingEnabled = true;
            tickttypcombo.Items.AddRange(new object[] { "One-way", "Round-trip", "Muilti-city" });
            tickttypcombo.Location = new Point(658, 239);
            tickttypcombo.Name = "tickttypcombo";
            tickttypcombo.Size = new Size(224, 33);
            tickttypcombo.TabIndex = 45;
            tickttypcombo.Text = "(select ticket type)";
            tickttypcombo.SelectedIndexChanged += tickttypcombo_SelectedIndexChanged;
            // 
            // admincombo
            // 
            admincombo.ForeColor = Color.Gray;
            admincombo.FormattingEnabled = true;
            admincombo.Location = new Point(658, 171);
            admincombo.Name = "admincombo";
            admincombo.Size = new Size(224, 33);
            admincombo.TabIndex = 44;
            admincombo.Text = "(select admin id)";
            admincombo.SelectedIndexChanged += admincombo_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(41, 40, 38);
            label8.Font = new Font("Microsoft Sans Serif", 7F);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(658, 207);
            label8.Name = "label8";
            label8.Size = new Size(123, 17);
            label8.TabIndex = 43;
            label8.Text = "Invalid Credentials";
            label8.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 10F);
            label20.ForeColor = Color.WhiteSmoke;
            label20.Location = new Point(514, 181);
            label20.Name = "label20";
            label20.Size = new Size(92, 25);
            label20.TabIndex = 42;
            label20.Text = "Admin ID";
            // 
            // traincombo
            // 
            traincombo.ForeColor = Color.Gray;
            traincombo.FormattingEnabled = true;
            traincombo.Location = new Point(200, 171);
            traincombo.Name = "traincombo";
            traincombo.Size = new Size(224, 33);
            traincombo.TabIndex = 41;
            traincombo.Text = "(select train id)";
            traincombo.SelectedIndexChanged += traincombo_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(41, 40, 38);
            label19.Font = new Font("Microsoft Sans Serif", 7F);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(94, 136);
            label19.Name = "label19";
            label19.Size = new Size(123, 17);
            label19.TabIndex = 40;
            label19.Text = "Invalid Credentials";
            label19.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(41, 40, 38);
            label18.Font = new Font("Microsoft Sans Serif", 7F);
            label18.ForeColor = Color.Red;
            label18.Location = new Point(410, 136);
            label18.Name = "label18";
            label18.Size = new Size(123, 17);
            label18.TabIndex = 39;
            label18.Text = "Invalid Credentials";
            label18.Visible = false;
            label18.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(41, 40, 38);
            label17.Font = new Font("Microsoft Sans Serif", 7F);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(203, 336);
            label17.Name = "label17";
            label17.Size = new Size(123, 17);
            label17.TabIndex = 38;
            label17.Text = "Invalid Credentials";
            label17.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(41, 40, 38);
            label16.Font = new Font("Microsoft Sans Serif", 7F);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(203, 209);
            label16.Name = "label16";
            label16.Size = new Size(123, 17);
            label16.TabIndex = 37;
            label16.Text = "Invalid Credentials";
            label16.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(41, 40, 38);
            label12.Font = new Font("Microsoft Sans Serif", 7F);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(203, 274);
            label12.Name = "label12";
            label12.Size = new Size(123, 17);
            label12.TabIndex = 36;
            label12.Text = "Invalid Credentials";
            label12.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9F);
            comboBox2.ForeColor = Color.Gray;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(410, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 33);
            comboBox2.TabIndex = 14;
            comboBox2.Text = "(select arrival city)";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 11F);
            label15.ForeColor = Color.FromArgb(212, 175, 55);
            label15.Location = new Point(445, 53);
            label15.Name = "label15";
            label15.Size = new Size(142, 26);
            label15.TabIndex = 35;
            label15.Text = "User-Friendly";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.ForeColor = Color.Gray;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "" });
            comboBox1.Location = new Point(94, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 33);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "(select departure city)";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 11F);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(582, 53);
            label14.Name = "label14";
            label14.Size = new Size(91, 26);
            label14.TabIndex = 34;
            label14.Text = "platform\r\n";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 11F);
            label13.ForeColor = Color.FromArgb(212, 175, 55);
            label13.Location = new Point(530, 16);
            label13.Name = "label13";
            label13.Size = new Size(119, 26);
            label13.TabIndex = 33;
            label13.Text = "Effortlessly";
            // 
            // crdbtn
            // 
            crdbtn.FlatAppearance.BorderColor = Color.FromArgb(249, 211, 66);
            crdbtn.FlatAppearance.BorderSize = 2;
            crdbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(249, 211, 66);
            crdbtn.FlatStyle = FlatStyle.Flat;
            crdbtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crdbtn.ForeColor = Color.White;
            crdbtn.Location = new Point(427, 420);
            crdbtn.Name = "crdbtn";
            crdbtn.Size = new Size(126, 45);
            crdbtn.TabIndex = 31;
            crdbtn.Text = "Book";
            crdbtn.UseVisualStyleBackColor = true;
            crdbtn.Click += crdbtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10F);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(514, 311);
            label11.Name = "label11";
            label11.Size = new Size(112, 25);
            label11.TabIndex = 26;
            label11.Text = "Train Class";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(278, 366);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(75, 31);
            numericUpDown2.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(56, 374);
            label10.Name = "label10";
            label10.Size = new Size(114, 25);
            label10.TabIndex = 24;
            label10.Text = "No of Seats";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 10F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(514, 247);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 20;
            label9.Text = "Ticket type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(295, 53);
            label7.Name = "label7";
            label7.Size = new Size(161, 26);
            label7.TabIndex = 17;
            label7.Text = "Save time with ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(56, 311);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 16;
            label4.Text = "Mobile";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Gray;
            textBox5.Location = new Point(203, 307);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(221, 30);
            textBox5.TabIndex = 15;
            textBox5.Text = "03×××××××××";
            textBox5.Click += textBox5_Click;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(56, 181);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 14;
            label3.Text = "Train ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(56, 247);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(203, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 30);
            textBox3.TabIndex = 11;
            textBox3.Text = "(enter name)";
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(320, 16);
            label2.Name = "label2";
            label2.Size = new Size(214, 26);
            label2.TabIndex = 10;
            label2.Text = "Secure your E-Ticket";
            label2.Click += label2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "Date";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 10F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(723, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(198, 30);
            dateTimePicker1.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(673, 103);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(358, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 700);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label3;
        private Label label1;
        private TextBox textBox3;
        private Label label7;
        private Label label4;
        private TextBox textBox5;
        private Label label9;
        private Label label11;
        private NumericUpDown numericUpDown2;
        private Label label10;
        private Label label13;
        private Button crdbtn;
        private Label label15;
        private Label label14;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label16;
        private Label label12;
        private Label label19;
        private Label label18;
        private Label label17;
        private ComboBox admincombo;
        private Label label8;
        private Label label20;
        private ComboBox traincombo;
        private Button mngtrainbtn;
        private Label label21;
        private ComboBox tickttypcombo;
        private Label label22;
        private ComboBox classtypcombi;
        private Label label23;
        private ComboBox seatnocombo;
        private Label label24;
    }
}