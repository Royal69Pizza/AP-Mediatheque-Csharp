﻿
namespace Mediateq_AP_SIO2
{
    partial class FrmMediateq
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabOngletsApplication = new System.Windows.Forms.TabControl();
            this.tabParutions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvParutions = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateParution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTitres = new System.Windows.Forms.ComboBox();
            this.tabTitres = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTitres = new System.Windows.Forms.DataGridView();
            this.idTitre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empruntable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodicite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDomaines = new System.Windows.Forms.ComboBox();
            this.tabLivres = new System.Windows.Forms.TabPage();
            this.grpRechercheTitre = new System.Windows.Forms.GroupBox();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.idDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.auteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lacollection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTitre = new System.Windows.Forms.TextBox();
            this.grpRechercheCode = new System.Windows.Forms.GroupBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txbNumDoc = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCollection = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.connectionTab = new System.Windows.Forms.TabPage();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.tabGestionDesDocs = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.inputTitreLivre = new System.Windows.Forms.TextBox();
            this.inputIDLivre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabCommandesDeDocument = new System.Windows.Forms.TabPage();
            this.inputAuteurLivre = new System.Windows.Forms.TextBox();
            this.inputISBNLivre = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.inputCollectionLivre = new System.Windows.Forms.TextBox();
            this.buttonCreerLivre = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.inputImageLivre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.selectCategorieLivre = new System.Windows.Forms.ComboBox();
            this.tabOngletsApplication.SuspendLayout();
            this.tabParutions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).BeginInit();
            this.tabTitres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).BeginInit();
            this.tabLivres.SuspendLayout();
            this.grpRechercheTitre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.grpRechercheCode.SuspendLayout();
            this.connectionTab.SuspendLayout();
            this.tabGestionDesDocs.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOngletsApplication
            // 
            this.tabOngletsApplication.Controls.Add(this.tabParutions);
            this.tabOngletsApplication.Controls.Add(this.tabTitres);
            this.tabOngletsApplication.Controls.Add(this.tabLivres);
            this.tabOngletsApplication.Controls.Add(this.connectionTab);
            this.tabOngletsApplication.Controls.Add(this.tabGestionDesDocs);
            this.tabOngletsApplication.Controls.Add(this.tabCommandesDeDocument);
            this.tabOngletsApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOngletsApplication.Location = new System.Drawing.Point(0, 0);
            this.tabOngletsApplication.Margin = new System.Windows.Forms.Padding(4);
            this.tabOngletsApplication.Name = "tabOngletsApplication";
            this.tabOngletsApplication.SelectedIndex = 0;
            this.tabOngletsApplication.Size = new System.Drawing.Size(982, 626);
            this.tabOngletsApplication.TabIndex = 0;
            // 
            // tabParutions
            // 
            this.tabParutions.Controls.Add(this.label3);
            this.tabParutions.Controls.Add(this.dgvParutions);
            this.tabParutions.Controls.Add(this.label1);
            this.tabParutions.Controls.Add(this.cbxTitres);
            this.tabParutions.Location = new System.Drawing.Point(4, 25);
            this.tabParutions.Margin = new System.Windows.Forms.Padding(4);
            this.tabParutions.Name = "tabParutions";
            this.tabParutions.Padding = new System.Windows.Forms.Padding(4);
            this.tabParutions.Size = new System.Drawing.Size(974, 597);
            this.tabParutions.TabIndex = 0;
            this.tabParutions.Text = "Parutions";
            this.tabParutions.UseVisualStyleBackColor = true;
            this.tabParutions.Enter += new System.EventHandler(this.tabParutions_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Visualisation des numéros reçus par titre";
            // 
            // dgvParutions
            // 
            this.dgvParutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParutions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.dateParution,
            this.photo});
            this.dgvParutions.Location = new System.Drawing.Point(12, 68);
            this.dgvParutions.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParutions.Name = "dgvParutions";
            this.dgvParutions.RowHeadersWidth = 51;
            this.dgvParutions.Size = new System.Drawing.Size(724, 289);
            this.dgvParutions.TabIndex = 2;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.Width = 60;
            // 
            // dateParution
            // 
            this.dateParution.HeaderText = "DATE DE PARUTION";
            this.dateParution.MinimumWidth = 6;
            this.dateParution.Name = "dateParution";
            this.dateParution.Width = 140;
            // 
            // photo
            // 
            this.photo.HeaderText = "EMPLACEMENT PHOTO";
            this.photo.MinimumWidth = 6;
            this.photo.Name = "photo";
            this.photo.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisir un titre :";
            // 
            // cbxTitres
            // 
            this.cbxTitres.FormattingEnabled = true;
            this.cbxTitres.Location = new System.Drawing.Point(142, 36);
            this.cbxTitres.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTitres.Name = "cbxTitres";
            this.cbxTitres.Size = new System.Drawing.Size(193, 24);
            this.cbxTitres.TabIndex = 0;
            this.cbxTitres.SelectedIndexChanged += new System.EventHandler(this.cbxTitres_SelectedIndexChanged);
            // 
            // tabTitres
            // 
            this.tabTitres.Controls.Add(this.label4);
            this.tabTitres.Controls.Add(this.dgvTitres);
            this.tabTitres.Controls.Add(this.label2);
            this.tabTitres.Controls.Add(this.cbxDomaines);
            this.tabTitres.Location = new System.Drawing.Point(4, 25);
            this.tabTitres.Margin = new System.Windows.Forms.Padding(4);
            this.tabTitres.Name = "tabTitres";
            this.tabTitres.Padding = new System.Windows.Forms.Padding(4);
            this.tabTitres.Size = new System.Drawing.Size(974, 597);
            this.tabTitres.TabIndex = 1;
            this.tabTitres.Text = "Titres";
            this.tabTitres.UseVisualStyleBackColor = true;
            this.tabTitres.Enter += new System.EventHandler(this.tabTitres_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Visualisation des titres abonnés";
            // 
            // dgvTitres
            // 
            this.dgvTitres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTitre,
            this.nom,
            this.empruntable,
            this.dateFin,
            this.periodicite});
            this.dgvTitres.Location = new System.Drawing.Point(9, 69);
            this.dgvTitres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTitres.Name = "dgvTitres";
            this.dgvTitres.RowHeadersWidth = 51;
            this.dgvTitres.Size = new System.Drawing.Size(831, 137);
            this.dgvTitres.TabIndex = 2;
            // 
            // idTitre
            // 
            this.idTitre.HeaderText = "NUMERO";
            this.idTitre.MinimumWidth = 6;
            this.idTitre.Name = "idTitre";
            this.idTitre.Width = 60;
            // 
            // nom
            // 
            this.nom.HeaderText = "TITRE";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 200;
            // 
            // empruntable
            // 
            this.empruntable.HeaderText = "EMPRUNTABLE";
            this.empruntable.MinimumWidth = 6;
            this.empruntable.Name = "empruntable";
            this.empruntable.Width = 125;
            // 
            // dateFin
            // 
            this.dateFin.HeaderText = "FIN D\'ABONNEMENT";
            this.dateFin.MinimumWidth = 6;
            this.dateFin.Name = "dateFin";
            this.dateFin.Width = 140;
            // 
            // periodicite
            // 
            this.periodicite.HeaderText = "PERIODICITE";
            this.periodicite.MinimumWidth = 6;
            this.periodicite.Name = "periodicite";
            this.periodicite.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choisir un domaine :";
            // 
            // cbxDomaines
            // 
            this.cbxDomaines.FormattingEnabled = true;
            this.cbxDomaines.Location = new System.Drawing.Point(171, 37);
            this.cbxDomaines.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDomaines.Name = "cbxDomaines";
            this.cbxDomaines.Size = new System.Drawing.Size(300, 24);
            this.cbxDomaines.TabIndex = 0;
            this.cbxDomaines.SelectedIndexChanged += new System.EventHandler(this.cbxDomaines_SelectedIndexChanged);
            // 
            // tabLivres
            // 
            this.tabLivres.Controls.Add(this.grpRechercheTitre);
            this.tabLivres.Controls.Add(this.grpRechercheCode);
            this.tabLivres.Location = new System.Drawing.Point(4, 25);
            this.tabLivres.Margin = new System.Windows.Forms.Padding(4);
            this.tabLivres.Name = "tabLivres";
            this.tabLivres.Size = new System.Drawing.Size(974, 597);
            this.tabLivres.TabIndex = 2;
            this.tabLivres.Text = "Livres";
            this.tabLivres.UseVisualStyleBackColor = true;
            this.tabLivres.Enter += new System.EventHandler(this.tabLivres_Enter);
            // 
            // grpRechercheTitre
            // 
            this.grpRechercheTitre.Controls.Add(this.dgvLivres);
            this.grpRechercheTitre.Controls.Add(this.label6);
            this.grpRechercheTitre.Controls.Add(this.txbTitre);
            this.grpRechercheTitre.Location = new System.Drawing.Point(4, 266);
            this.grpRechercheTitre.Margin = new System.Windows.Forms.Padding(4);
            this.grpRechercheTitre.Name = "grpRechercheTitre";
            this.grpRechercheTitre.Padding = new System.Windows.Forms.Padding(4);
            this.grpRechercheTitre.Size = new System.Drawing.Size(964, 325);
            this.grpRechercheTitre.TabIndex = 18;
            this.grpRechercheTitre.TabStop = false;
            this.grpRechercheTitre.Text = "Recherche par titre";
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDoc,
            this.titre,
            this.auteur,
            this.isbn,
            this.lacollection});
            this.dgvLivres.Location = new System.Drawing.Point(11, 58);
            this.dgvLivres.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.RowHeadersWidth = 51;
            this.dgvLivres.Size = new System.Drawing.Size(919, 222);
            this.dgvLivres.TabIndex = 4;
            // 
            // idDoc
            // 
            this.idDoc.HeaderText = "NUMERO";
            this.idDoc.MinimumWidth = 6;
            this.idDoc.Name = "idDoc";
            this.idDoc.Width = 60;
            // 
            // titre
            // 
            this.titre.HeaderText = "TITRE DU LIVRE";
            this.titre.MinimumWidth = 6;
            this.titre.Name = "titre";
            this.titre.Width = 200;
            // 
            // auteur
            // 
            this.auteur.HeaderText = "AUTEUR(E)";
            this.auteur.MinimumWidth = 6;
            this.auteur.Name = "auteur";
            this.auteur.Width = 125;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "Code ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.Width = 90;
            // 
            // lacollection
            // 
            this.lacollection.HeaderText = "COLLECTION";
            this.lacollection.MinimumWidth = 6;
            this.lacollection.Name = "lacollection";
            this.lacollection.Width = 200;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Saisir le titre ou la partie d\'un titre :";
            // 
            // txbTitre
            // 
            this.txbTitre.Location = new System.Drawing.Point(282, 28);
            this.txbTitre.Margin = new System.Windows.Forms.Padding(4);
            this.txbTitre.Name = "txbTitre";
            this.txbTitre.Size = new System.Drawing.Size(231, 22);
            this.txbTitre.TabIndex = 3;
            this.txbTitre.TextChanged += new System.EventHandler(this.txbTitre_TextChanged);
            // 
            // grpRechercheCode
            // 
            this.grpRechercheCode.Controls.Add(this.lblCategorie);
            this.grpRechercheCode.Controls.Add(this.label13);
            this.grpRechercheCode.Controls.Add(this.btnRechercher);
            this.grpRechercheCode.Controls.Add(this.lblTitre);
            this.grpRechercheCode.Controls.Add(this.lblImage);
            this.grpRechercheCode.Controls.Add(this.label5);
            this.grpRechercheCode.Controls.Add(this.label10);
            this.grpRechercheCode.Controls.Add(this.txbNumDoc);
            this.grpRechercheCode.Controls.Add(this.lblNumero);
            this.grpRechercheCode.Controls.Add(this.lblAuteur);
            this.grpRechercheCode.Controls.Add(this.lblISBN);
            this.grpRechercheCode.Controls.Add(this.label7);
            this.grpRechercheCode.Controls.Add(this.label11);
            this.grpRechercheCode.Controls.Add(this.lblCollection);
            this.grpRechercheCode.Controls.Add(this.label8);
            this.grpRechercheCode.Controls.Add(this.label12);
            this.grpRechercheCode.Controls.Add(this.label9);
            this.grpRechercheCode.Location = new System.Drawing.Point(4, 4);
            this.grpRechercheCode.Margin = new System.Windows.Forms.Padding(4);
            this.grpRechercheCode.Name = "grpRechercheCode";
            this.grpRechercheCode.Padding = new System.Windows.Forms.Padding(4);
            this.grpRechercheCode.Size = new System.Drawing.Size(964, 254);
            this.grpRechercheCode.TabIndex = 17;
            this.grpRechercheCode.TabStop = false;
            this.grpRechercheCode.Text = "Recherche par code document";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(641, 218);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(72, 16);
            this.lblCategorie.TabIndex = 18;
            this.lblCategorie.Text = "(catégorie)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(467, 218);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Catégorie de public :";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(385, 24);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(128, 25);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Location = new System.Drawing.Point(361, 96);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(36, 16);
            this.lblTitre.TabIndex = 12;
            this.lblTitre.Text = "(titre)";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(217, 140);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(53, 16);
            this.lblImage.TabIndex = 16;
            this.lblImage.Text = "(image)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saisir un numéro de document :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(299, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Titre :";
            // 
            // txbNumDoc
            // 
            this.txbNumDoc.Location = new System.Drawing.Point(264, 25);
            this.txbNumDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumDoc.Name = "txbNumDoc";
            this.txbNumDoc.Size = new System.Drawing.Size(88, 22);
            this.txbNumDoc.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(196, 96);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(60, 16);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "(numéro)";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(381, 178);
            this.lblAuteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(52, 16);
            this.lblAuteur.TabIndex = 14;
            this.lblAuteur.Text = "(auteur)";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(119, 178);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(40, 16);
            this.lblISBN.TabIndex = 15;
            this.lblISBN.Text = "(isbn)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Numéro de document :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(299, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Auteur(e) :";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(111, 218);
            this.lblCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(72, 16);
            this.lblCollection.TabIndex = 13;
            this.lblCollection.Text = "(collection)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Emplacement de l\'image :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Collection :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Code ISBN :";
            // 
            // connectionTab
            // 
            this.connectionTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectionTab.Controls.Add(this.buttonLogin);
            this.connectionTab.Controls.Add(this.inputPwd);
            this.connectionTab.Controls.Add(this.inputLogin);
            this.connectionTab.Controls.Add(this.label14);
            this.connectionTab.Controls.Add(this.user);
            this.connectionTab.ForeColor = System.Drawing.Color.Black;
            this.connectionTab.Location = new System.Drawing.Point(4, 25);
            this.connectionTab.Name = "connectionTab";
            this.connectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionTab.Size = new System.Drawing.Size(974, 597);
            this.connectionTab.TabIndex = 4;
            this.connectionTab.Text = "Connection";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonLogin.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(199, 154);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(223, 26);
            this.buttonLogin.TabIndex = 17;
            this.buttonLogin.Text = "Créer";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // inputPwd
            // 
            this.inputPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputPwd.ForeColor = System.Drawing.Color.White;
            this.inputPwd.Location = new System.Drawing.Point(155, 88);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.Size = new System.Drawing.Size(256, 22);
            this.inputPwd.TabIndex = 3;
            // 
            // inputLogin
            // 
            this.inputLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputLogin.ForeColor = System.Drawing.Color.White;
            this.inputLogin.Location = new System.Drawing.Point(103, 47);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(278, 22);
            this.inputLogin.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(52, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Mot de passe";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(52, 47);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(45, 18);
            this.user.TabIndex = 0;
            this.user.Text = "Login";
            // 
            // tabGestionDesDocs
            // 
            this.tabGestionDesDocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabGestionDesDocs.Controls.Add(this.groupBox2);
            this.tabGestionDesDocs.Controls.Add(this.groupBox4);
            this.tabGestionDesDocs.Controls.Add(this.label15);
            this.tabGestionDesDocs.ForeColor = System.Drawing.Color.White;
            this.tabGestionDesDocs.Location = new System.Drawing.Point(4, 25);
            this.tabGestionDesDocs.Name = "tabGestionDesDocs";
            this.tabGestionDesDocs.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionDesDocs.Size = new System.Drawing.Size(974, 597);
            this.tabGestionDesDocs.TabIndex = 5;
            this.tabGestionDesDocs.Text = "Gestion des Documents";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Font = new System.Drawing.Font("Omega Flight Title", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(414, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 549);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DVD";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Omega Flight Title", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 549);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Livres";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.selectCategorieLivre);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.inputImageLivre);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.buttonCreerLivre);
            this.groupBox1.Controls.Add(this.inputCollectionLivre);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.inputISBNLivre);
            this.groupBox1.Controls.Add(this.inputAuteurLivre);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.inputTitreLivre);
            this.groupBox1.Controls.Add(this.inputIDLivre);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(12, 106);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 18);
            this.label20.TabIndex = 9;
            this.label20.Text = "ISBN";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(6, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 18);
            this.label21.TabIndex = 8;
            this.label21.Text = "Auteur";
            // 
            // inputTitreLivre
            // 
            this.inputTitreLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTitreLivre.ForeColor = System.Drawing.Color.White;
            this.inputTitreLivre.Location = new System.Drawing.Point(97, 42);
            this.inputTitreLivre.Name = "inputTitreLivre";
            this.inputTitreLivre.Size = new System.Drawing.Size(160, 22);
            this.inputTitreLivre.TabIndex = 7;
            // 
            // inputIDLivre
            // 
            this.inputIDLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputIDLivre.ForeColor = System.Drawing.Color.White;
            this.inputIDLivre.Location = new System.Drawing.Point(82, 14);
            this.inputIDLivre.Name = "inputIDLivre";
            this.inputIDLivre.Size = new System.Drawing.Size(175, 22);
            this.inputIDLivre.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 23);
            this.label16.TabIndex = 5;
            this.label16.Text = "Titre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Omega Flight Title", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 3);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(363, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Gestion des Documents";
            // 
            // tabCommandesDeDocument
            // 
            this.tabCommandesDeDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabCommandesDeDocument.ForeColor = System.Drawing.Color.White;
            this.tabCommandesDeDocument.Location = new System.Drawing.Point(4, 25);
            this.tabCommandesDeDocument.Name = "tabCommandesDeDocument";
            this.tabCommandesDeDocument.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommandesDeDocument.Size = new System.Drawing.Size(974, 597);
            this.tabCommandesDeDocument.TabIndex = 6;
            this.tabCommandesDeDocument.Text = "Commandes de Documents";
            // 
            // inputAuteurLivre
            // 
            this.inputAuteurLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputAuteurLivre.ForeColor = System.Drawing.Color.White;
            this.inputAuteurLivre.Location = new System.Drawing.Point(97, 74);
            this.inputAuteurLivre.Name = "inputAuteurLivre";
            this.inputAuteurLivre.Size = new System.Drawing.Size(160, 22);
            this.inputAuteurLivre.TabIndex = 10;
            // 
            // inputISBNLivre
            // 
            this.inputISBNLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputISBNLivre.ForeColor = System.Drawing.Color.White;
            this.inputISBNLivre.Location = new System.Drawing.Point(97, 102);
            this.inputISBNLivre.Name = "inputISBNLivre";
            this.inputISBNLivre.Size = new System.Drawing.Size(160, 22);
            this.inputISBNLivre.TabIndex = 11;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(17, 143);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 23);
            this.label22.TabIndex = 12;
            this.label22.Text = "Collection";
            // 
            // inputCollectionLivre
            // 
            this.inputCollectionLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputCollectionLivre.ForeColor = System.Drawing.Color.White;
            this.inputCollectionLivre.Location = new System.Drawing.Point(114, 142);
            this.inputCollectionLivre.Name = "inputCollectionLivre";
            this.inputCollectionLivre.Size = new System.Drawing.Size(160, 22);
            this.inputCollectionLivre.TabIndex = 13;
            // 
            // buttonCreerLivre
            // 
            this.buttonCreerLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonCreerLivre.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreerLivre.ForeColor = System.Drawing.Color.White;
            this.buttonCreerLivre.Location = new System.Drawing.Point(97, 271);
            this.buttonCreerLivre.Name = "buttonCreerLivre";
            this.buttonCreerLivre.Size = new System.Drawing.Size(223, 26);
            this.buttonCreerLivre.TabIndex = 18;
            this.buttonCreerLivre.Text = "Créer";
            this.buttonCreerLivre.UseVisualStyleBackColor = false;
            this.buttonCreerLivre.Click += new System.EventHandler(this.buttonCreerLivre_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(17, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 23);
            this.label18.TabIndex = 21;
            this.label18.Text = "Catégorie";
            // 
            // inputImageLivre
            // 
            this.inputImageLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputImageLivre.ForeColor = System.Drawing.Color.White;
            this.inputImageLivre.Location = new System.Drawing.Point(97, 169);
            this.inputImageLivre.Name = "inputImageLivre";
            this.inputImageLivre.Size = new System.Drawing.Size(160, 22);
            this.inputImageLivre.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(12, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 23);
            this.label19.TabIndex = 19;
            this.label19.Text = "Path Image";
            // 
            // selectCategorieLivre
            // 
            this.selectCategorieLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectCategorieLivre.ForeColor = System.Drawing.Color.White;
            this.selectCategorieLivre.FormattingEnabled = true;
            this.selectCategorieLivre.Location = new System.Drawing.Point(97, 209);
            this.selectCategorieLivre.Name = "selectCategorieLivre";
            this.selectCategorieLivre.Size = new System.Drawing.Size(245, 23);
            this.selectCategorieLivre.TabIndex = 22;
            // 
            // FrmMediateq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 626);
            this.Controls.Add(this.tabOngletsApplication);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMediateq";
            this.Text = "Gestion Médiathèque";
            this.Load += new System.EventHandler(this.FrmMediateq_Load);
            this.tabOngletsApplication.ResumeLayout(false);
            this.tabParutions.ResumeLayout(false);
            this.tabParutions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParutions)).EndInit();
            this.tabTitres.ResumeLayout(false);
            this.tabTitres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitres)).EndInit();
            this.tabLivres.ResumeLayout(false);
            this.grpRechercheTitre.ResumeLayout(false);
            this.grpRechercheTitre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.grpRechercheCode.ResumeLayout(false);
            this.grpRechercheCode.PerformLayout();
            this.connectionTab.ResumeLayout(false);
            this.connectionTab.PerformLayout();
            this.tabGestionDesDocs.ResumeLayout(false);
            this.tabGestionDesDocs.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOngletsApplication;
        private System.Windows.Forms.TabPage tabParutions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTitres;
        private System.Windows.Forms.TabPage tabTitres;
        private System.Windows.Forms.ComboBox cbxDomaines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTitres;
        private System.Windows.Forms.DataGridView dgvParutions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateParution;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTitre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn empruntable;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodicite;
        private System.Windows.Forms.TabPage tabLivres;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TextBox txbTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNumDoc;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpRechercheTitre;
        private System.Windows.Forms.GroupBox grpRechercheCode;
        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn auteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lacollection;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage connectionTab;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabPage tabGestionDesDocs;
        private System.Windows.Forms.TabPage tabCommandesDeDocument;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputTitreLivre;
        private System.Windows.Forms.TextBox inputIDLivre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox inputISBNLivre;
        private System.Windows.Forms.TextBox inputAuteurLivre;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox inputCollectionLivre;
        private System.Windows.Forms.Button buttonCreerLivre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox inputImageLivre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox selectCategorieLivre;
    }
}

