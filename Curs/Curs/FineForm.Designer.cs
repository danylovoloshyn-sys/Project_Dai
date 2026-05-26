namespace Curs
{
    partial class FineForm
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
            txtOwner = new TextBox();
            label2 = new Label();
            txtPlate = new TextBox();
            label3 = new Label();
            txtReason = new TextBox();
            label4 = new Label();
            numFine = new NumericUpDown();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numFine).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Власник";
            // 
            // txtOwner
            // 
            txtOwner.Location = new Point(96, 23);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(100, 23);
            txtOwner.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Держ. номер";
            // 
            // txtPlate
            // 
            txtPlate.Location = new Point(113, 68);
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(100, 23);
            txtPlate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 4;
            label3.Text = "Причина штрафу";
            label3.Click += label3_Click;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(138, 116);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(367, 23);
            txtReason.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 159);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 6;
            label4.Text = "Сума штрафу";
            label4.Click += label4_Click;
            // 
            // numFine
            // 
            numFine.Location = new Point(28, 192);
            numFine.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numFine.Name = "numFine";
            numFine.Size = new Size(120, 23);
            numFine.TabIndex = 7;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(28, 243);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(163, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // FineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(numFine);
            Controls.Add(label4);
            Controls.Add(txtReason);
            Controls.Add(label3);
            Controls.Add(txtPlate);
            Controls.Add(label2);
            Controls.Add(txtOwner);
            Controls.Add(label1);
            Name = "FineForm";
            Text = "FineForm";
            ((System.ComponentModel.ISupportInitialize)numFine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOwner;
        private Label label2;
        private TextBox txtPlate;
        private Label label3;
        private TextBox txtReason;
        private Label label4;
        private NumericUpDown numFine;
        private Button btnOK;
        private Button btnCancel;
    }
}