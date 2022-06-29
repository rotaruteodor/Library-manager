
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class FormModificareAbonat
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
            this.ucModificareCarteSauAbonat1 = new ProiectRotaruTeodorGabrielBiblioteca.ucModificareCarteSauAbonat();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificare abonat";
            // 
            // ucModificareCarteSauAbonat1
            // 
            this.ucModificareCarteSauAbonat1.Location = new System.Drawing.Point(12, 63);
            this.ucModificareCarteSauAbonat1.Name = "ucModificareCarteSauAbonat1";
            this.ucModificareCarteSauAbonat1.Size = new System.Drawing.Size(244, 331);
            this.ucModificareCarteSauAbonat1.TabIndex = 0;
            // 
            // FormModificareAbonat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucModificareCarteSauAbonat1);
            this.Name = "FormModificareAbonat";
            this.Text = "FormModificareAbonat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucModificareCarteSauAbonat ucModificareCarteSauAbonat1;
        private System.Windows.Forms.Label label1;
    }
}