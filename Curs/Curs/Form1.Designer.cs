namespace Curs
{
    partial class Form1
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
            panelTop = new Panel();
            btnStats = new Button();
            btnInspection = new Button();
            btnSearch = new Button();
            btnHome = new Button();
            panelLeft = new Panel();
            groupBox1 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtSearchContact = new TextBox();
            txtSearchPassport = new TextBox();
            txtSearchOwner = new TextBox();
            cmbSearchType = new ComboBox();
            btnReset = new Button();
            btnFind = new Button();
            label3 = new Label();
            txtPlate = new TextBox();
            txtColor = new TextBox();
            label2 = new Label();
            txtBrand = new TextBox();
            label1 = new Label();
            panelRight = new Panel();
            btnFine = new Button();
            groupBox2 = new GroupBox();
            txtInfoYear = new TextBox();
            txtInfoColor = new TextBox();
            txtInfoPlate = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtInfoBrand = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnAdd = new Button();
            dgvVehicles = new DataGridView();
            colPlate = new DataGridViewTextBoxColumn();
            colBrand = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colInspection = new DataGridViewTextBoxColumn();
            colOwner = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRight.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.WhiteSmoke;
            panelTop.Controls.Add(btnStats);
            panelTop.Controls.Add(btnInspection);
            panelTop.Controls.Add(btnSearch);
            panelTop.Controls.Add(btnHome);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(260, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(640, 70);
            panelTop.TabIndex = 0;
            // 
            // btnStats
            // 
            btnStats.BackColor = Color.White;
            btnStats.FlatStyle = FlatStyle.Flat;
            btnStats.Location = new Point(498, 12);
            btnStats.Name = "btnStats";
            btnStats.Size = new Size(120, 40);
            btnStats.TabIndex = 3;
            btnStats.Text = "Статистика";
            btnStats.UseVisualStyleBackColor = false;
            btnStats.Click += btnStats_Click;
            // 
            // btnInspection
            // 
            btnInspection.BackColor = Color.White;
            btnInspection.FlatStyle = FlatStyle.Flat;
            btnInspection.Location = new Point(341, 12);
            btnInspection.Name = "btnInspection";
            btnInspection.Size = new Size(120, 40);
            btnInspection.TabIndex = 2;
            btnInspection.Text = "Техогляд";
            btnInspection.UseVisualStyleBackColor = false;
            btnInspection.Click += btnInspection_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(183, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.White;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(27, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(120, 40);
            btnHome.TabIndex = 0;
            btnHome.Text = "Головна";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.WhiteSmoke;
            panelLeft.Controls.Add(groupBox1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(260, 640);
            panelLeft.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtSearchContact);
            groupBox1.Controls.Add(txtSearchPassport);
            groupBox1.Controls.Add(txtSearchOwner);
            groupBox1.Controls.Add(cmbSearchType);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnFind);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPlate);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 468);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пошук";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 331);
            label11.Name = "label11";
            label11.Size = new Size(67, 19);
            label11.TabIndex = 15;
            label11.Text = "Контакти";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 281);
            label10.Name = "label10";
            label10.Size = new Size(62, 19);
            label10.TabIndex = 14;
            label10.Text = "Паспорт\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 231);
            label9.Name = "label9";
            label9.Size = new Size(60, 19);
            label9.TabIndex = 13;
            label9.Text = "Власник";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 180);
            label8.Name = "label8";
            label8.Size = new Size(51, 19);
            label8.TabIndex = 12;
            label8.Text = "Тип ТЗ\n";
            label8.Click += label8_Click;
            // 
            // txtSearchContact
            // 
            txtSearchContact.Location = new Point(23, 353);
            txtSearchContact.Name = "txtSearchContact";
            txtSearchContact.Size = new Size(188, 25);
            txtSearchContact.TabIndex = 11;
            // 
            // txtSearchPassport
            // 
            txtSearchPassport.Location = new Point(23, 303);
            txtSearchPassport.Name = "txtSearchPassport";
            txtSearchPassport.Size = new Size(186, 25);
            txtSearchPassport.TabIndex = 10;
            // 
            // txtSearchOwner
            // 
            txtSearchOwner.Location = new Point(23, 253);
            txtSearchOwner.Name = "txtSearchOwner";
            txtSearchOwner.Size = new Size(186, 25);
            txtSearchOwner.TabIndex = 9;
            // 
            // cmbSearchType
            // 
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "Автомобіль", "", "Позашляховик", "", "Мотоцикл", "", "Причіп" });
            cmbSearchType.Location = new Point(23, 203);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(186, 25);
            cmbSearchType.TabIndex = 8;
            cmbSearchType.SelectedIndexChanged += cmbSearchType_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(6, 402);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 37);
            btnReset.TabIndex = 7;
            btnReset.Text = "Скинути";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click_1;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(154, 402);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(100, 35);
            btnFind.TabIndex = 6;
            btnFind.Text = "Пошук";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 127);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 5;
            label3.Text = "Держ. номер:";
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(23, 149);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(188, 25);
            txtPlate.TabIndex = 4;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(23, 99);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(188, 25);
            txtColor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 77);
            label2.Name = "label2";
            label2.Size = new Size(46, 19);
            label2.TabIndex = 2;
            label2.Text = "Колір:";
            label2.Click += label2_Click;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(23, 49);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(188, 25);
            txtBrand.TabIndex = 1;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Марка:";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.WhiteSmoke;
            panelRight.Controls.Add(btnFine);
            panelRight.Controls.Add(groupBox2);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(900, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(300, 640);
            panelRight.TabIndex = 3;
            // 
            // btnFine
            // 
            btnFine.Location = new Point(35, 327);
            btnFine.Name = "btnFine";
            btnFine.Size = new Size(173, 35);
            btnFine.TabIndex = 1;
            btnFine.Text = "Виписати штраф";
            btnFine.UseVisualStyleBackColor = true;
            btnFine.Click += btnFine_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtInfoYear);
            groupBox2.Controls.Add(txtInfoColor);
            groupBox2.Controls.Add(txtInfoPlate);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtInfoBrand);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 300);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Інформація про авто";
            // 
            // txtInfoYear
            // 
            txtInfoYear.Location = new Point(35, 202);
            txtInfoYear.Name = "txtInfoYear";
            txtInfoYear.Size = new Size(188, 25);
            txtInfoYear.TabIndex = 7;
            // 
            // txtInfoColor
            // 
            txtInfoColor.Location = new Point(35, 152);
            txtInfoColor.Name = "txtInfoColor";
            txtInfoColor.Size = new Size(188, 25);
            txtInfoColor.TabIndex = 6;
            // 
            // txtInfoPlate
            // 
            txtInfoPlate.Location = new Point(35, 102);
            txtInfoPlate.Name = "txtInfoPlate";
            txtInfoPlate.Size = new Size(188, 25);
            txtInfoPlate.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 180);
            label7.Name = "label7";
            label7.Size = new Size(27, 19);
            label7.TabIndex = 4;
            label7.Text = "Рік";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 130);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 3;
            label6.Text = "Колір:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 77);
            label5.Name = "label5";
            label5.Size = new Size(95, 19);
            label5.TabIndex = 2;
            label5.Text = "Держ. номер:";
            label5.Click += label5_Click;
            // 
            // txtInfoBrand
            // 
            txtInfoBrand.Location = new Point(35, 49);
            txtInfoBrand.Name = "txtInfoBrand";
            txtInfoBrand.Size = new Size(188, 25);
            txtInfoBrand.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 27);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 0;
            label4.Text = "Марка:";
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(260, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 60);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(183, 6);
            button3.Name = "button3";
            button3.Size = new Size(120, 40);
            button3.TabIndex = 2;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(341, 7);
            button2.Name = "button2";
            button2.Size = new Size(120, 42);
            button2.TabIndex = 1;
            button2.Text = "Редагувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gainsboro;
            btnAdd.Location = new Point(26, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Додати";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // dgvVehicles
            // 
            dgvVehicles.AllowUserToAddRows = false;
            dgvVehicles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicles.BackgroundColor = Color.White;
            dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicles.Columns.AddRange(new DataGridViewColumn[] { colPlate, colBrand, colColor, colYear, colInspection, colOwner });
            dgvVehicles.Dock = DockStyle.Fill;
            dgvVehicles.Location = new Point(260, 130);
            dgvVehicles.Name = "dgvVehicles";
            dgvVehicles.ReadOnly = true;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicles.Size = new Size(640, 510);
            dgvVehicles.TabIndex = 5;
            dgvVehicles.CellClick += dgvVehicles_CellClick;
            // 
            // colPlate
            // 
            colPlate.HeaderText = "Держ. номер";
            colPlate.Name = "colPlate";
            colPlate.ReadOnly = true;
            // 
            // colBrand
            // 
            colBrand.HeaderText = "Марка";
            colBrand.Name = "colBrand";
            colBrand.ReadOnly = true;
            // 
            // colColor
            // 
            colColor.HeaderText = "Колір";
            colColor.Name = "colColor";
            colColor.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.HeaderText = "Рік";
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colInspection
            // 
            colInspection.HeaderText = "Техогляд";
            colInspection.Name = "colInspection";
            colInspection.ReadOnly = true;
            // 
            // colOwner
            // 
            colOwner.HeaderText = "Власник";
            colOwner.Name = "colOwner";
            colOwner.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1200, 640);
            Controls.Add(dgvVehicles);
            Controls.Add(panel1);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Довідник працівника ДАІ";
            WindowState = FormWindowState.Minimized;
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRight.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnInspection;
        private Button btnSearch;
        private Button btnHome;
        private Button btnStats;
        private Panel panelLeft;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtBrand;
        private Label label1;
        private Label label3;
        private TextBox txtPlate;
        private TextBox txtColor;
        private Button btnFind;
        private Panel panelRight;
        private GroupBox groupBox2;
        private TextBox txtInfoBrand;
        private Label label4;
        private Label label5;
        private TextBox txtInfoYear;
        private TextBox txtInfoColor;
        private TextBox txtInfoPlate;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Button btnAdd;
        private Button button2;
        private Button button3;
        private DataGridView dgvVehicles;
        private DataGridViewTextBoxColumn colPlate;
        private DataGridViewTextBoxColumn colBrand;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colInspection;
        private DataGridViewTextBoxColumn colOwner;
        private Button btnReset;
        private Label label8;
        private TextBox txtSearchContact;
        private TextBox txtSearchPassport;
        private TextBox txtSearchOwner;
        private ComboBox cmbSearchType;
        private Label label9;
        private Label label11;
        private Label label10;
        private Button btnFine;
    }
}
