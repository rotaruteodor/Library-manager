
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class FormAngajati
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
            this.listBox_angajati = new System.Windows.Forms.ListBox();
            this.listBox_droppedIn = new System.Windows.Forms.ListBox();
            this.btn_stergeAngajati = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angajati";
            // 
            // listBox_angajati
            // 
            this.listBox_angajati.FormattingEnabled = true;
            this.listBox_angajati.Location = new System.Drawing.Point(12, 32);
            this.listBox_angajati.Name = "listBox_angajati";
            this.listBox_angajati.Size = new System.Drawing.Size(784, 134);
            this.listBox_angajati.TabIndex = 3;
            this.listBox_angajati.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_angajati_MouseDown);
            // 
            // listBox_droppedIn
            // 
            this.listBox_droppedIn.AllowDrop = true;
            this.listBox_droppedIn.FormattingEnabled = true;
            this.listBox_droppedIn.Location = new System.Drawing.Point(12, 227);
            this.listBox_droppedIn.Name = "listBox_droppedIn";
            this.listBox_droppedIn.Size = new System.Drawing.Size(784, 134);
            this.listBox_droppedIn.TabIndex = 4;
            this.listBox_droppedIn.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_droppedIn_DragDrop);
            this.listBox_droppedIn.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_droppedIn_DragOver);
            // 
            // btn_stergeAngajati
            // 
            this.btn_stergeAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stergeAngajati.Location = new System.Drawing.Point(354, 367);
            this.btn_stergeAngajati.Name = "btn_stergeAngajati";
            this.btn_stergeAngajati.Size = new System.Drawing.Size(75, 23);
            this.btn_stergeAngajati.TabIndex = 5;
            this.btn_stergeAngajati.Text = "Sterge";
            this.btn_stergeAngajati.UseVisualStyleBackColor = true;
            this.btn_stergeAngajati.Click += new System.EventHandler(this.btn_stergeAngajati_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Angajati de sters";
            // 
            // FormAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_stergeAngajati);
            this.Controls.Add(this.listBox_droppedIn);
            this.Controls.Add(this.listBox_angajati);
            this.Controls.Add(this.label1);
            this.Name = "FormAngajati";
            this.Text = "FormAngajati";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_angajati;
        private System.Windows.Forms.ListBox listBox_droppedIn;
        private System.Windows.Forms.Button btn_stergeAngajati;
        private System.Windows.Forms.Label label2;
    }
}