
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class FormModificareCarte
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
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificare Carte";
            // 
            // ucModificareCarteSauAbonat1
            // 
            this.ucModificareCarteSauAbonat1.Location = new System.Drawing.Point(24, 50);
            this.ucModificareCarteSauAbonat1.Name = "ucModificareCarteSauAbonat1";
            this.ucModificareCarteSauAbonat1.Size = new System.Drawing.Size(244, 331);
            this.ucModificareCarteSauAbonat1.TabIndex = 0;
            // 
            // FormModificareCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucModificareCarteSauAbonat1);
            this.Name = "FormModificareCarte";
            this.Text = "FormModificareCarte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public ucModificareCarteSauAbonat ucModificareCarteSauAbonat1;
    }
}