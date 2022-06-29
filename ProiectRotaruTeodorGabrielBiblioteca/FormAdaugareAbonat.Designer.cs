
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class FormAdaugareAbonat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nume = new System.Windows.Forms.TextBox();
            this.textBox_CNP = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_nrTelefon = new System.Windows.Forms.TextBox();
            this.btn_adaugaAbonatF3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data nastere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numar de telefon";
            // 
            // textBox_nume
            // 
            this.textBox_nume.Location = new System.Drawing.Point(116, 29);
            this.textBox_nume.Name = "textBox_nume";
            this.textBox_nume.Size = new System.Drawing.Size(235, 20);
            this.textBox_nume.TabIndex = 5;
            // 
            // textBox_CNP
            // 
            this.textBox_CNP.Location = new System.Drawing.Point(116, 65);
            this.textBox_CNP.Name = "textBox_CNP";
            this.textBox_CNP.Size = new System.Drawing.Size(235, 20);
            this.textBox_CNP.TabIndex = 6;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(116, 143);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(235, 20);
            this.textBox_email.TabIndex = 8;
            // 
            // textBox_nrTelefon
            // 
            this.textBox_nrTelefon.Location = new System.Drawing.Point(116, 181);
            this.textBox_nrTelefon.Name = "textBox_nrTelefon";
            this.textBox_nrTelefon.Size = new System.Drawing.Size(235, 20);
            this.textBox_nrTelefon.TabIndex = 9;
            // 
            // btn_adaugaAbonatF3
            // 
            this.btn_adaugaAbonatF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_adaugaAbonatF3.Location = new System.Drawing.Point(116, 244);
            this.btn_adaugaAbonatF3.Name = "btn_adaugaAbonatF3";
            this.btn_adaugaAbonatF3.Size = new System.Drawing.Size(148, 58);
            this.btn_adaugaAbonatF3.TabIndex = 10;
            this.btn_adaugaAbonatF3.Text = "Adauga abonat";
            this.btn_adaugaAbonatF3.UseVisualStyleBackColor = true;
            this.btn_adaugaAbonatF3.Click += new System.EventHandler(this.btn_adaugaAbonatF3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // FormAdaugareAbonat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 346);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_adaugaAbonatF3);
            this.Controls.Add(this.textBox_nrTelefon);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_CNP);
            this.Controls.Add(this.textBox_nume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdaugareAbonat";
            this.Text = "FormAdaugareAbonat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nume;
        private System.Windows.Forms.TextBox textBox_CNP;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_nrTelefon;
        private System.Windows.Forms.Button btn_adaugaAbonatF3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}