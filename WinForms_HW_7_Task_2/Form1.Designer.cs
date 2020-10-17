namespace WindowsForms_TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myButton9 = new WindowsForms_TicTacToe.MyButton();
            this.myButton8 = new WindowsForms_TicTacToe.MyButton();
            this.myButton7 = new WindowsForms_TicTacToe.MyButton();
            this.myButton6 = new WindowsForms_TicTacToe.MyButton();
            this.myButton5 = new WindowsForms_TicTacToe.MyButton();
            this.myButton4 = new WindowsForms_TicTacToe.MyButton();
            this.myButton3 = new WindowsForms_TicTacToe.MyButton();
            this.myButton2 = new WindowsForms_TicTacToe.MyButton();
            this.myButton1 = new WindowsForms_TicTacToe.MyButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::WindowsForms_TicTacToe.Properties.Resources.@__Pngtree__neon_stereoscopic_illuminated_lines_lamp_927699__for_menu;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.результатыИгрToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.играToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.играToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.играToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.играToolStripMenuItem.Text = "Игра";
            this.играToolStripMenuItem.Click += new System.EventHandler(this.играToolStripMenuItem_Click);
            // 
            // результатыИгрToolStripMenuItem
            // 
            this.результатыИгрToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.результатыИгрToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.результатыИгрToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.результатыИгрToolStripMenuItem.Name = "результатыИгрToolStripMenuItem";
            this.результатыИгрToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.результатыИгрToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.результатыИгрToolStripMenuItem.Text = "Статистика игр";
            this.результатыИгрToolStripMenuItem.Click += new System.EventHandler(this.результатыИгрToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.BackgroundImage = global::WindowsForms_TicTacToe.Properties.Resources.@__Pngtree__neon_stereoscopic_illuminated_lines_lamp_927699__for_menu;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(952, 23);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(86)))));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(86)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(113, 18);
            this.toolStripStatusLabel1.Text = "Текущее время";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsForms_TicTacToe.Properties.Resources.tic_tac_toe_1954446_1920_min;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.myButton9);
            this.panel1.Controls.Add(this.myButton8);
            this.panel1.Controls.Add(this.myButton7);
            this.panel1.Controls.Add(this.myButton6);
            this.panel1.Controls.Add(this.myButton5);
            this.panel1.Controls.Add(this.myButton4);
            this.panel1.Controls.Add(this.myButton3);
            this.panel1.Controls.Add(this.myButton2);
            this.panel1.Controls.Add(this.myButton1);
            this.panel1.Location = new System.Drawing.Point(153, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 266);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // myButton9
            // 
            this.myButton9.BackColor = System.Drawing.Color.Transparent;
            this.myButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton9.FlatAppearance.BorderSize = 0;
            this.myButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.myButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton9.ForeColor = System.Drawing.Color.Transparent;
            this.myButton9.IsEmpty = true;
            this.myButton9.Location = new System.Drawing.Point(600, 278);
            this.myButton9.Name = "myButton9";
            this.myButton9.Size = new System.Drawing.Size(144, 84);
            this.myButton9.Symbol = '\0';
            this.myButton9.TabIndex = 8;
            this.myButton9.UseVisualStyleBackColor = false;
            this.myButton9.X = 0;
            this.myButton9.Y = 0;
            this.myButton9.Click += new System.EventHandler(this.myButton9_Click);
            // 
            // myButton8
            // 
            this.myButton8.BackColor = System.Drawing.Color.Transparent;
            this.myButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton8.FlatAppearance.BorderSize = 0;
            this.myButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.myButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton8.ForeColor = System.Drawing.Color.Transparent;
            this.myButton8.IsEmpty = true;
            this.myButton8.Location = new System.Drawing.Point(400, 278);
            this.myButton8.Name = "myButton8";
            this.myButton8.Size = new System.Drawing.Size(144, 84);
            this.myButton8.Symbol = '\0';
            this.myButton8.TabIndex = 7;
            this.myButton8.UseVisualStyleBackColor = false;
            this.myButton8.X = 0;
            this.myButton8.Y = 0;
            this.myButton8.Click += new System.EventHandler(this.myButton8_Click);
            // 
            // myButton7
            // 
            this.myButton7.BackColor = System.Drawing.Color.Transparent;
            this.myButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton7.FlatAppearance.BorderSize = 0;
            this.myButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.myButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton7.ForeColor = System.Drawing.Color.Transparent;
            this.myButton7.IsEmpty = true;
            this.myButton7.Location = new System.Drawing.Point(196, 278);
            this.myButton7.Name = "myButton7";
            this.myButton7.Size = new System.Drawing.Size(144, 84);
            this.myButton7.Symbol = '\0';
            this.myButton7.TabIndex = 6;
            this.myButton7.UseVisualStyleBackColor = false;
            this.myButton7.X = 0;
            this.myButton7.Y = 0;
            this.myButton7.Click += new System.EventHandler(this.myButton7_Click);
            // 
            // myButton6
            // 
            this.myButton6.BackColor = System.Drawing.Color.Transparent;
            this.myButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton6.FlatAppearance.BorderSize = 0;
            this.myButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton6.ForeColor = System.Drawing.Color.Transparent;
            this.myButton6.IsEmpty = true;
            this.myButton6.Location = new System.Drawing.Point(600, 151);
            this.myButton6.Name = "myButton6";
            this.myButton6.Size = new System.Drawing.Size(144, 84);
            this.myButton6.Symbol = '\0';
            this.myButton6.TabIndex = 5;
            this.myButton6.UseVisualStyleBackColor = false;
            this.myButton6.X = 0;
            this.myButton6.Y = 0;
            this.myButton6.Click += new System.EventHandler(this.myButton6_Click);
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.Transparent;
            this.myButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton5.FlatAppearance.BorderSize = 0;
            this.myButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton5.ForeColor = System.Drawing.Color.Transparent;
            this.myButton5.IsEmpty = true;
            this.myButton5.Location = new System.Drawing.Point(400, 151);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(144, 84);
            this.myButton5.Symbol = '\0';
            this.myButton5.TabIndex = 4;
            this.myButton5.UseVisualStyleBackColor = false;
            this.myButton5.X = 0;
            this.myButton5.Y = 0;
            this.myButton5.Click += new System.EventHandler(this.myButton5_Click);
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.Transparent;
            this.myButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton4.FlatAppearance.BorderSize = 0;
            this.myButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton4.ForeColor = System.Drawing.Color.Transparent;
            this.myButton4.IsEmpty = true;
            this.myButton4.Location = new System.Drawing.Point(196, 151);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(144, 84);
            this.myButton4.Symbol = '\0';
            this.myButton4.TabIndex = 3;
            this.myButton4.UseVisualStyleBackColor = false;
            this.myButton4.X = 0;
            this.myButton4.Y = 0;
            this.myButton4.Click += new System.EventHandler(this.myButton4_Click);
            // 
            // myButton3
            // 
            this.myButton3.BackColor = System.Drawing.Color.Transparent;
            this.myButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton3.FlatAppearance.BorderSize = 0;
            this.myButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton3.ForeColor = System.Drawing.Color.Transparent;
            this.myButton3.IsEmpty = true;
            this.myButton3.Location = new System.Drawing.Point(600, 38);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(144, 84);
            this.myButton3.Symbol = '\0';
            this.myButton3.TabIndex = 2;
            this.myButton3.UseVisualStyleBackColor = false;
            this.myButton3.X = 0;
            this.myButton3.Y = 0;
            this.myButton3.Click += new System.EventHandler(this.myButton3_Click);
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.Color.Transparent;
            this.myButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myButton2.FlatAppearance.BorderSize = 0;
            this.myButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton2.ForeColor = System.Drawing.Color.Transparent;
            this.myButton2.IsEmpty = true;
            this.myButton2.Location = new System.Drawing.Point(400, 38);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(144, 84);
            this.myButton2.Symbol = '\0';
            this.myButton2.TabIndex = 1;
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.X = 0;
            this.myButton2.Y = 0;
            this.myButton2.Click += new System.EventHandler(this.myButton2_Click);
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.Transparent;
            this.myButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.myButton1.FlatAppearance.BorderSize = 0;
            this.myButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.myButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.myButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myButton1.ForeColor = System.Drawing.Color.Transparent;
            this.myButton1.IsEmpty = true;
            this.myButton1.Location = new System.Drawing.Point(196, 38);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(144, 84);
            this.myButton1.Symbol = '\0';
            this.myButton1.TabIndex = 0;
            this.myButton1.UseVisualStyleBackColor = false;
            this.myButton1.X = 0;
            this.myButton1.Y = 0;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "kisspng-tic-tac-toe-minimax-tic-tak-to-shot-alcohol-5b2e76a19def03.72660099152977" +
        "16816469.png");
            this.imageList1.Images.SetKeyName(1, "zero.png");
            this.imageList1.Images.SetKeyName(2, "—Pngtree—neon stereoscopic illuminated lines lamp_927699_for_bottom.jpg");
            this.imageList1.Images.SetKeyName(3, "border_.jpg");
            this.imageList1.Images.SetKeyName(4, "border_2.jpg");
            this.imageList1.Images.SetKeyName(5, "menu_bottom.jpg");
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsForms_TicTacToe.Properties.Resources.tic_tac_toe_1777859_1920;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(304, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 325);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(126, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 94);
            this.panel3.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton1.Location = new System.Drawing.Point(4, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Я";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.SteelBlue;
            this.radioButton2.Location = new System.Drawing.Point(4, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Комьютер";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Первым ходит";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(165, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(126, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 29);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(165, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Никнейм";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.comboBox1.Location = new System.Drawing.Point(130, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Низкий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровень сложности";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::WindowsForms_TicTacToe.Properties.Resources.milky_way_2695569_1920;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(952, 425);
            this.panel4.TabIndex = 10;
            this.panel4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(44, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(419, 385);
            this.dataGridView1.TabIndex = 13;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.BorderWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(246)))), ((int)(((byte)(254)))));
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(515, 40);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelFormat = "{f2}%";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(411, 359);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 474);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Крестики Нолики v 1.0  ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыИгрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private MyButton myButton9;
        private MyButton myButton8;
        private MyButton myButton7;
        private MyButton myButton6;
        private MyButton myButton5;
        private MyButton myButton4;
        private MyButton myButton3;
        private MyButton myButton2;
        private MyButton myButton1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}

