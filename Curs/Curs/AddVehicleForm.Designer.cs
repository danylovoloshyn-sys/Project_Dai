namespace Curs
{
    partial class AddVehicleForm
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
            label1 = new Label();
            txtBrand = new TextBox();
            txtColor = new TextBox();
            txtPlate = new TextBox();
            numYear = new NumericUpDown();
            dtInspection = new DateTimePicker();
            txtOwner = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            cmbType = new ComboBox();
            txtPassport = new TextBox();
            txtContact = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 12);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(142, 57);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(100, 23);
            txtBrand.TabIndex = 1;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(142, 128);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 2;
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(142, 203);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(100, 23);
            txtPlate.TabIndex = 3;
            // 
            // numYear
            // 
            numYear.Location = new Point(80, 279);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(120, 23);
            numYear.TabIndex = 4;
            numYear.Value = new decimal(new int[] { 2020, 0, 0, 0 });
            // 
            // dtInspection
            // 
            dtInspection.Location = new Point(392, 60);
            dtInspection.Name = "dtInspection";
            dtInspection.Size = new Size(200, 23);
            dtInspection.TabIndex = 5;
            dtInspection.ValueChanged += dtInspection_ValueChanged;
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(106, 352);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(178, 23);
            txtOwner.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Марка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 128);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Колір";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 206);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 9;
            label4.Text = "Держ. номер\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 281);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 10;
            label5.Text = "Рік";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 65);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 11;
            label6.Text = "Техогляд";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 355);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 12;
            label7.Text = "Власник";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(532, 388);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 13;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(657, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Автомобіль", "", "Позашляховик", "", "Мотоцикл", "", "Причіп" });
            cmbType.Location = new Point(471, 125);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 15;
            // 
            // txtPassport
            // 
            txtPassport.Location = new Point(472, 198);
            txtPassport.Name = "txtPassport";
            txtPassport.Size = new Size(120, 23);
            txtPassport.TabIndex = 16;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(445, 264);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(162, 23);
            txtContact.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(381, 122);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 18;
            label8.Text = "Тип ТЗ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 203);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 19;
            label9.Text = "Паспорт\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(367, 267);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 20;
            label10.Text = "Контакти";
            // 
            // AddVehicleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtContact);
            Controls.Add(txtPassport);
            Controls.Add(cmbType);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOwner);
            Controls.Add(dtInspection);
            Controls.Add(numYear);
            Controls.Add(txtPlate);
            Controls.Add(txtColor);
            Controls.Add(txtBrand);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddVehicleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Додавання авто";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBrand;
        private TextBox txtColor;
        private TextBox txtPlate;
        private NumericUpDown numYear;
        private DateTimePicker dtInspection;
        private TextBox txtOwner;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnOK;
        private Button btnCancel;
        private ComboBox cmbType;
        private TextBox txtPassport;
        private TextBox txtContact;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}