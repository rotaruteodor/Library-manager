
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class FormImprumuturi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImprumuturi));
            this.label1 = new System.Windows.Forms.Label();
            this.listview_imprumuturi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_detaliiImprumut = new System.Windows.Forms.Button();
            this.btn_stergeImprumut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_IDCarte = new System.Windows.Forms.TextBox();
            this.textBox_CNPAbonat = new System.Windows.Forms.TextBox();
            this.textBoxDataImprumut = new System.Windows.Forms.TextBox();
            this.textBoxZileImprumutate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salveazaModificarile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista imprumuturi";
            // 
            // listview_imprumuturi
            // 
            this.listview_imprumuturi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listview_imprumuturi.FullRowSelect = true;
            this.listview_imprumuturi.HideSelection = false;
            this.listview_imprumuturi.Location = new System.Drawing.Point(17, 62);
            this.listview_imprumuturi.Name = "listview_imprumuturi";
            this.listview_imprumuturi.Size = new System.Drawing.Size(416, 156);
            this.listview_imprumuturi.TabIndex = 2;
            this.listview_imprumuturi.UseCompatibleStateImageBehavior = false;
            this.listview_imprumuturi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Carte";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CNP Abonat";
            this.columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data imprumutului";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Zile imprumutate";
            this.columnHeader4.Width = 91;
            // 
            // btn_detaliiImprumut
            // 
            this.btn_detaliiImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_detaliiImprumut.Location = new System.Drawing.Point(17, 224);
            this.btn_detaliiImprumut.Name = "btn_detaliiImprumut";
            this.btn_detaliiImprumut.Size = new System.Drawing.Size(136, 23);
            this.btn_detaliiImprumut.TabIndex = 3;
            this.btn_detaliiImprumut.Text = "Vezi detalii imprumut";
            this.btn_detaliiImprumut.UseVisualStyleBackColor = true;
            this.btn_detaliiImprumut.Click += new System.EventHandler(this.btn_detaliiImprumut_Click);
            // 
            // btn_stergeImprumut
            // 
            this.btn_stergeImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_stergeImprumut.Location = new System.Drawing.Point(322, 224);
            this.btn_stergeImprumut.Name = "btn_stergeImprumut";
            this.btn_stergeImprumut.Size = new System.Drawing.Size(111, 23);
            this.btn_stergeImprumut.TabIndex = 4;
            this.btn_stergeImprumut.Text = "Sterge imprumut";
            this.btn_stergeImprumut.UseVisualStyleBackColor = true;
            this.btn_stergeImprumut.Click += new System.EventHandler(this.btn_stergeImprumut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Modifica imprumut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_IDCarte
            // 
            this.textBox_IDCarte.Location = new System.Drawing.Point(589, 73);
            this.textBox_IDCarte.Name = "textBox_IDCarte";
            this.textBox_IDCarte.Size = new System.Drawing.Size(185, 20);
            this.textBox_IDCarte.TabIndex = 6;
            this.textBox_IDCarte.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_IDCarte_Validating);
            // 
            // textBox_CNPAbonat
            // 
            this.textBox_CNPAbonat.Location = new System.Drawing.Point(589, 99);
            this.textBox_CNPAbonat.Name = "textBox_CNPAbonat";
            this.textBox_CNPAbonat.Size = new System.Drawing.Size(185, 20);
            this.textBox_CNPAbonat.TabIndex = 7;
            this.textBox_CNPAbonat.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_CNPAbonat_Validating);
            // 
            // textBoxDataImprumut
            // 
            this.textBoxDataImprumut.Location = new System.Drawing.Point(589, 125);
            this.textBoxDataImprumut.Name = "textBoxDataImprumut";
            this.textBoxDataImprumut.Size = new System.Drawing.Size(185, 20);
            this.textBoxDataImprumut.TabIndex = 8;
            this.textBoxDataImprumut.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDataImprumut_Validating);
            // 
            // textBoxZileImprumutate
            // 
            this.textBoxZileImprumutate.Location = new System.Drawing.Point(589, 151);
            this.textBoxZileImprumutate.Name = "textBoxZileImprumutate";
            this.textBoxZileImprumutate.Size = new System.Drawing.Size(185, 20);
            this.textBoxZileImprumutate.TabIndex = 9;
            this.textBoxZileImprumutate.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxZileImprumutate_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Carte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CNP Abonat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data imprumutului";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zile imprumutate";
            // 
            // btn_salveazaModificarile
            // 
            this.btn_salveazaModificarile.Location = new System.Drawing.Point(589, 178);
            this.btn_salveazaModificarile.Name = "btn_salveazaModificarile";
            this.btn_salveazaModificarile.Size = new System.Drawing.Size(185, 23);
            this.btn_salveazaModificarile.TabIndex = 14;
            this.btn_salveazaModificarile.Text = "Salveaza modificarile";
            this.btn_salveazaModificarile.UseVisualStyleBackColor = true;
            this.btn_salveazaModificarile.Click += new System.EventHandler(this.btn_salveazaModificarile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Printeaza detalii imprumut";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormImprumuturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_salveazaModificarile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxZileImprumutate);
            this.Controls.Add(this.textBoxDataImprumut);
            this.Controls.Add(this.textBox_CNPAbonat);
            this.Controls.Add(this.textBox_IDCarte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_stergeImprumut);
            this.Controls.Add(this.btn_detaliiImprumut);
            this.Controls.Add(this.listview_imprumuturi);
            this.Controls.Add(this.label1);
            this.Name = "FormImprumuturi";
            this.Text = "FormImprumuturi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listview_imprumuturi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_detaliiImprumut;
        private System.Windows.Forms.Button btn_stergeImprumut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_IDCarte;
        private System.Windows.Forms.TextBox textBox_CNPAbonat;
        private System.Windows.Forms.TextBox textBoxDataImprumut;
        private System.Windows.Forms.TextBox textBoxZileImprumutate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salveazaModificarile;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}