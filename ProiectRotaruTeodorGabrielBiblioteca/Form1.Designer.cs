
namespace ProiectRotaruTeodorGabrielBiblioteca
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listviewCartiF1 = new System.Windows.Forms.ListView();
            this.categorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titlu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nrPagini = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStripF1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listaCartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordoneazaAlfabeticDupaCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupaTitluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descrescatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniImprumuturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziImprumuturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideCharturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniAbonatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziImprumuturiAbonatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optiuniAngajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziAngajatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideChartChartVarsteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_adaugaCarteF1 = new System.Windows.Forms.Button();
            this.button_stergeCarteF1 = new System.Windows.Forms.Button();
            this.btn_exitF1 = new System.Windows.Forms.Button();
            this.listviewAbonatiF1 = new System.Windows.Forms.ListView();
            this.numeComplet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data_Nastere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr_telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.btn_stergeAbonatF1 = new System.Windows.Forms.Button();
            this.btn_strgAboF1 = new System.Windows.Forms.Button();
            this.btn_adaugaImprumutF1 = new System.Windows.Forms.Button();
            this.textbox_zileImprumutateF1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_modificaCarte = new System.Windows.Forms.Button();
            this.btn_modificaAbonat = new System.Windows.Forms.Button();
            this.contextMenuStripF1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewCartiF1
            // 
            this.listviewCartiF1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.categorie,
            this.titlu,
            this.autor,
            this.nrPagini,
            this.stoc});
            this.listviewCartiF1.FullRowSelect = true;
            this.listviewCartiF1.HideSelection = false;
            this.listviewCartiF1.Location = new System.Drawing.Point(12, 25);
            this.listviewCartiF1.Name = "listviewCartiF1";
            this.listviewCartiF1.Size = new System.Drawing.Size(695, 226);
            this.listviewCartiF1.TabIndex = 0;
            this.listviewCartiF1.UseCompatibleStateImageBehavior = false;
            this.listviewCartiF1.View = System.Windows.Forms.View.Details;
            // 
            // categorie
            // 
            this.categorie.Text = "Categorie";
            this.categorie.Width = 132;
            // 
            // titlu
            // 
            this.titlu.Text = "Titlu";
            this.titlu.Width = 219;
            // 
            // autor
            // 
            this.autor.Text = "Autor";
            this.autor.Width = 147;
            // 
            // nrPagini
            // 
            this.nrPagini.Text = "Numar de pagini";
            this.nrPagini.Width = 95;
            // 
            // stoc
            // 
            this.stoc.Text = "Stoc";
            this.stoc.Width = 96;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista carti:";
            // 
            // contextMenuStripF1
            // 
            this.contextMenuStripF1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaCartiToolStripMenuItem,
            this.optiuniImprumuturiToolStripMenuItem,
            this.optiuniAbonatiToolStripMenuItem,
            this.optiuniAngajatiToolStripMenuItem,
            this.deschideChartChartVarsteToolStripMenuItem});
            this.contextMenuStripF1.Name = "contextMenuStripF1";
            this.contextMenuStripF1.Size = new System.Drawing.Size(218, 114);
            // 
            // listaCartiToolStripMenuItem
            // 
            this.listaCartiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordoneazaAlfabeticDupaCategorieToolStripMenuItem,
            this.ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem});
            this.listaCartiToolStripMenuItem.Name = "listaCartiToolStripMenuItem";
            this.listaCartiToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listaCartiToolStripMenuItem.Text = "Optiuni lista carti";
            // 
            // ordoneazaAlfabeticDupaCategorieToolStripMenuItem
            // 
            this.ordoneazaAlfabeticDupaCategorieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dupaCategorieToolStripMenuItem,
            this.dupaAutorToolStripMenuItem,
            this.dupaTitluToolStripMenuItem});
            this.ordoneazaAlfabeticDupaCategorieToolStripMenuItem.Name = "ordoneazaAlfabeticDupaCategorieToolStripMenuItem";
            this.ordoneazaAlfabeticDupaCategorieToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ordoneazaAlfabeticDupaCategorieToolStripMenuItem.Text = "Ordoneaza alfabetic";
            // 
            // dupaCategorieToolStripMenuItem
            // 
            this.dupaCategorieToolStripMenuItem.Name = "dupaCategorieToolStripMenuItem";
            this.dupaCategorieToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dupaCategorieToolStripMenuItem.Text = "Dupa categorie";
            this.dupaCategorieToolStripMenuItem.Click += new System.EventHandler(this.dupaCategorieToolStripMenuItem_Click);
            // 
            // dupaAutorToolStripMenuItem
            // 
            this.dupaAutorToolStripMenuItem.Name = "dupaAutorToolStripMenuItem";
            this.dupaAutorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dupaAutorToolStripMenuItem.Text = "Dupa autor";
            this.dupaAutorToolStripMenuItem.Click += new System.EventHandler(this.dupaAutorToolStripMenuItem_Click);
            // 
            // dupaTitluToolStripMenuItem
            // 
            this.dupaTitluToolStripMenuItem.Name = "dupaTitluToolStripMenuItem";
            this.dupaTitluToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.dupaTitluToolStripMenuItem.Text = "Dupa titlu";
            this.dupaTitluToolStripMenuItem.Click += new System.EventHandler(this.dupaTitluToolStripMenuItem_Click);
            // 
            // ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem
            // 
            this.ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crescatorToolStripMenuItem,
            this.descrescatorToolStripMenuItem});
            this.ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem.Name = "ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem";
            this.ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem.Text = "Ordoneaza numar pagini";
            // 
            // crescatorToolStripMenuItem
            // 
            this.crescatorToolStripMenuItem.Name = "crescatorToolStripMenuItem";
            this.crescatorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.crescatorToolStripMenuItem.Text = "Crescator";
            this.crescatorToolStripMenuItem.Click += new System.EventHandler(this.crescatorToolStripMenuItem_Click);
            // 
            // descrescatorToolStripMenuItem
            // 
            this.descrescatorToolStripMenuItem.Name = "descrescatorToolStripMenuItem";
            this.descrescatorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.descrescatorToolStripMenuItem.Text = "Descrescator";
            this.descrescatorToolStripMenuItem.Click += new System.EventHandler(this.descrescatorToolStripMenuItem_Click);
            // 
            // optiuniImprumuturiToolStripMenuItem
            // 
            this.optiuniImprumuturiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziImprumuturiToolStripMenuItem,
            this.deschideCharturiToolStripMenuItem});
            this.optiuniImprumuturiToolStripMenuItem.Name = "optiuniImprumuturiToolStripMenuItem";
            this.optiuniImprumuturiToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.optiuniImprumuturiToolStripMenuItem.Text = "Optiuni imprumuturi";
            // 
            // veziImprumuturiToolStripMenuItem
            // 
            this.veziImprumuturiToolStripMenuItem.Name = "veziImprumuturiToolStripMenuItem";
            this.veziImprumuturiToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.veziImprumuturiToolStripMenuItem.Text = "Vezi imprumuturi";
            this.veziImprumuturiToolStripMenuItem.Click += new System.EventHandler(this.veziImprumuturiToolStripMenuItem_Click);
            // 
            // deschideCharturiToolStripMenuItem
            // 
            this.deschideCharturiToolStripMenuItem.Name = "deschideCharturiToolStripMenuItem";
            this.deschideCharturiToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deschideCharturiToolStripMenuItem.Text = "Deschide chart \"Carti per luna\"";
            this.deschideCharturiToolStripMenuItem.Click += new System.EventHandler(this.deschideCharturiToolStripMenuItem_Click);
            // 
            // optiuniAbonatiToolStripMenuItem
            // 
            this.optiuniAbonatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziImprumuturiAbonatToolStripMenuItem});
            this.optiuniAbonatiToolStripMenuItem.Name = "optiuniAbonatiToolStripMenuItem";
            this.optiuniAbonatiToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.optiuniAbonatiToolStripMenuItem.Text = "Optiuni abonati";
            // 
            // veziImprumuturiAbonatToolStripMenuItem
            // 
            this.veziImprumuturiAbonatToolStripMenuItem.Name = "veziImprumuturiAbonatToolStripMenuItem";
            this.veziImprumuturiAbonatToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.veziImprumuturiAbonatToolStripMenuItem.Text = "Vezi imprumuturi abonat";
            this.veziImprumuturiAbonatToolStripMenuItem.Click += new System.EventHandler(this.veziImprumuturiAbonatToolStripMenuItem_Click);
            // 
            // optiuniAngajatiToolStripMenuItem
            // 
            this.optiuniAngajatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veziAngajatiToolStripMenuItem});
            this.optiuniAngajatiToolStripMenuItem.Name = "optiuniAngajatiToolStripMenuItem";
            this.optiuniAngajatiToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.optiuniAngajatiToolStripMenuItem.Text = "Optiuni angajati";
            // 
            // veziAngajatiToolStripMenuItem
            // 
            this.veziAngajatiToolStripMenuItem.Name = "veziAngajatiToolStripMenuItem";
            this.veziAngajatiToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.veziAngajatiToolStripMenuItem.Text = "Vezi angajati";
            this.veziAngajatiToolStripMenuItem.Click += new System.EventHandler(this.veziAngajatiToolStripMenuItem_Click);
            // 
            // deschideChartChartVarsteToolStripMenuItem
            // 
            this.deschideChartChartVarsteToolStripMenuItem.Name = "deschideChartChartVarsteToolStripMenuItem";
            this.deschideChartChartVarsteToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.deschideChartChartVarsteToolStripMenuItem.Text = "Deschide chart \"Chart varste\"";
            this.deschideChartChartVarsteToolStripMenuItem.Click += new System.EventHandler(this.deschideChartChartVarsteToolStripMenuItem_Click);
            // 
            // btn_adaugaCarteF1
            // 
            this.btn_adaugaCarteF1.Location = new System.Drawing.Point(713, 53);
            this.btn_adaugaCarteF1.Name = "btn_adaugaCarteF1";
            this.btn_adaugaCarteF1.Size = new System.Drawing.Size(91, 23);
            this.btn_adaugaCarteF1.TabIndex = 2;
            this.btn_adaugaCarteF1.Text = "Adauga carte";
            this.btn_adaugaCarteF1.UseVisualStyleBackColor = true;
            this.btn_adaugaCarteF1.Click += new System.EventHandler(this.btn_adaugaCarteF1_Click);
            // 
            // button_stergeCarteF1
            // 
            this.button_stergeCarteF1.Location = new System.Drawing.Point(713, 95);
            this.button_stergeCarteF1.Name = "button_stergeCarteF1";
            this.button_stergeCarteF1.Size = new System.Drawing.Size(93, 23);
            this.button_stergeCarteF1.TabIndex = 3;
            this.button_stergeCarteF1.Text = "Sterge carte";
            this.button_stergeCarteF1.UseVisualStyleBackColor = true;
            this.button_stergeCarteF1.Click += new System.EventHandler(this.button_stergeCarteF1_Click);
            // 
            // btn_exitF1
            // 
            this.btn_exitF1.Location = new System.Drawing.Point(950, 491);
            this.btn_exitF1.Name = "btn_exitF1";
            this.btn_exitF1.Size = new System.Drawing.Size(94, 23);
            this.btn_exitF1.TabIndex = 4;
            this.btn_exitF1.Text = "&Save and Exit";
            this.btn_exitF1.UseVisualStyleBackColor = true;
            this.btn_exitF1.Click += new System.EventHandler(this.btn_exitF1_Click);
            // 
            // listviewAbonatiF1
            // 
            this.listviewAbonatiF1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numeComplet,
            this.CNP,
            this.Data_Nastere,
            this.Email,
            this.Nr_telefon});
            this.listviewAbonatiF1.FullRowSelect = true;
            this.listviewAbonatiF1.HideSelection = false;
            this.listviewAbonatiF1.Location = new System.Drawing.Point(12, 321);
            this.listviewAbonatiF1.Name = "listviewAbonatiF1";
            this.listviewAbonatiF1.Size = new System.Drawing.Size(695, 193);
            this.listviewAbonatiF1.TabIndex = 5;
            this.listviewAbonatiF1.UseCompatibleStateImageBehavior = false;
            this.listviewAbonatiF1.View = System.Windows.Forms.View.Details;
            // 
            // numeComplet
            // 
            this.numeComplet.Text = "Nume";
            this.numeComplet.Width = 168;
            // 
            // CNP
            // 
            this.CNP.Text = "CNP";
            this.CNP.Width = 167;
            // 
            // Data_Nastere
            // 
            this.Data_Nastere.Text = "Data nastere";
            this.Data_Nastere.Width = 109;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 131;
            // 
            // Nr_telefon
            // 
            this.Nr_telefon.Text = "Numar de telefon";
            this.Nr_telefon.Width = 113;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista abonati";
            // 
            // btn_stergeAbonatF1
            // 
            this.btn_stergeAbonatF1.Location = new System.Drawing.Point(713, 361);
            this.btn_stergeAbonatF1.Name = "btn_stergeAbonatF1";
            this.btn_stergeAbonatF1.Size = new System.Drawing.Size(93, 23);
            this.btn_stergeAbonatF1.TabIndex = 7;
            this.btn_stergeAbonatF1.Text = "Adauga abonat";
            this.btn_stergeAbonatF1.UseVisualStyleBackColor = true;
            this.btn_stergeAbonatF1.Click += new System.EventHandler(this.btn_stergeAbonatF1_Click);
            // 
            // btn_strgAboF1
            // 
            this.btn_strgAboF1.Location = new System.Drawing.Point(713, 401);
            this.btn_strgAboF1.Name = "btn_strgAboF1";
            this.btn_strgAboF1.Size = new System.Drawing.Size(93, 23);
            this.btn_strgAboF1.TabIndex = 8;
            this.btn_strgAboF1.Text = "Sterge abonat";
            this.btn_strgAboF1.UseVisualStyleBackColor = true;
            this.btn_strgAboF1.Click += new System.EventHandler(this.btn_strgAboF1_Click);
            // 
            // btn_adaugaImprumutF1
            // 
            this.btn_adaugaImprumutF1.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_adaugaImprumutF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_adaugaImprumutF1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_adaugaImprumutF1.Location = new System.Drawing.Point(929, 226);
            this.btn_adaugaImprumutF1.Name = "btn_adaugaImprumutF1";
            this.btn_adaugaImprumutF1.Size = new System.Drawing.Size(115, 51);
            this.btn_adaugaImprumutF1.TabIndex = 9;
            this.btn_adaugaImprumutF1.Text = "&Adauga imprumut";
            this.btn_adaugaImprumutF1.UseVisualStyleBackColor = false;
            this.btn_adaugaImprumutF1.Click += new System.EventHandler(this.btn_adaugaImprumutF1_Click);
            // 
            // textbox_zileImprumutateF1
            // 
            this.textbox_zileImprumutateF1.Location = new System.Drawing.Point(929, 299);
            this.textbox_zileImprumutateF1.Name = "textbox_zileImprumutateF1";
            this.textbox_zileImprumutateF1.Size = new System.Drawing.Size(115, 20);
            this.textbox_zileImprumutateF1.TabIndex = 10;
            this.textbox_zileImprumutateF1.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_zileImprumutateF1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(808, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zile imprumutate ->";
            // 
            // btn_modificaCarte
            // 
            this.btn_modificaCarte.Location = new System.Drawing.Point(713, 142);
            this.btn_modificaCarte.Name = "btn_modificaCarte";
            this.btn_modificaCarte.Size = new System.Drawing.Size(93, 23);
            this.btn_modificaCarte.TabIndex = 12;
            this.btn_modificaCarte.Text = "Modifica carte";
            this.btn_modificaCarte.UseVisualStyleBackColor = true;
            this.btn_modificaCarte.Click += new System.EventHandler(this.btn_modificaCarte_Click);
            // 
            // btn_modificaAbonat
            // 
            this.btn_modificaAbonat.Location = new System.Drawing.Point(713, 449);
            this.btn_modificaAbonat.Name = "btn_modificaAbonat";
            this.btn_modificaAbonat.Size = new System.Drawing.Size(91, 23);
            this.btn_modificaAbonat.TabIndex = 13;
            this.btn_modificaAbonat.Text = "Modifica abonat";
            this.btn_modificaAbonat.UseVisualStyleBackColor = true;
            this.btn_modificaAbonat.Click += new System.EventHandler(this.btn_modificaAbonat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 526);
            this.ContextMenuStrip = this.contextMenuStripF1;
            this.Controls.Add(this.btn_modificaAbonat);
            this.Controls.Add(this.btn_modificaCarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_zileImprumutateF1);
            this.Controls.Add(this.btn_adaugaImprumutF1);
            this.Controls.Add(this.btn_strgAboF1);
            this.Controls.Add(this.btn_stergeAbonatF1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listviewAbonatiF1);
            this.Controls.Add(this.listviewCartiF1);
            this.Controls.Add(this.btn_exitF1);
            this.Controls.Add(this.button_stergeCarteF1);
            this.Controls.Add(this.btn_adaugaCarteF1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripF1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader categorie;
        private System.Windows.Forms.ColumnHeader titlu;
        private System.Windows.Forms.ColumnHeader autor;
        private System.Windows.Forms.ColumnHeader nrPagini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripF1;
        private System.Windows.Forms.ToolStripMenuItem listaCartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordoneazaAlfabeticDupaCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordoneazaCrescatorDupaNumarPaginiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dupaTitluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descrescatorToolStripMenuItem;
        private System.Windows.Forms.Button btn_adaugaCarteF1;
        public System.Windows.Forms.ListView listviewCartiF1;
        private System.Windows.Forms.Button button_stergeCarteF1;
        private System.Windows.Forms.ColumnHeader stoc;
        private System.Windows.Forms.Button btn_exitF1;
        public System.Windows.Forms.ListView listviewAbonatiF1;
        private System.Windows.Forms.ColumnHeader numeComplet;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader Data_Nastere;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Nr_telefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_stergeAbonatF1;
        private System.Windows.Forms.Button btn_strgAboF1;
        private System.Windows.Forms.ToolStripMenuItem optiuniImprumuturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziImprumuturiToolStripMenuItem;
        private System.Windows.Forms.Button btn_adaugaImprumutF1;
        private System.Windows.Forms.TextBox textbox_zileImprumutateF1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem optiuniAbonatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziImprumuturiAbonatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideCharturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optiuniAngajatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziAngajatiToolStripMenuItem;
        private System.Windows.Forms.Button btn_modificaCarte;
        private System.Windows.Forms.Button btn_modificaAbonat;
        private System.Windows.Forms.ToolStripMenuItem deschideChartChartVarsteToolStripMenuItem;
    }
}

