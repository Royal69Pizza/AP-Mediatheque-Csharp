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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textAlertEvent = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.selectLivreForDelete = new System.Windows.Forms.ComboBox();
            this.buttonDeleteLivre = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectCategorieForEdit = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.inputImageLivreForEdit = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.inputCollectionLivreForEdit = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.inputISBNLivreForEdit = new System.Windows.Forms.TextBox();
            this.inputAuteurLivreForEdit = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.inputTitreLivreForEdit = new System.Windows.Forms.TextBox();
            this.inputIDLivreForEdit = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.selectLivreForEdit = new System.Windows.Forms.ComboBox();
            this.buttonEditLivre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectCategorieLivreForCreate = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.inputImageLivre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonCreerLivre = new System.Windows.Forms.Button();
            this.inputCollectionLivre = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.inputISBNLivre = new System.Windows.Forms.TextBox();
            this.inputAuteurLivre = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.inputTitreLivre = new System.Windows.Forms.TextBox();
            this.inputIDLivre = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.selectDvdForDelete = new System.Windows.Forms.ComboBox();
            this.buttonDeleteDvd = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.selectCategorieDvdForEdit = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.inputRealisateurDvdForEdit = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.inputSynopsisDvdForEdit = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.inputImageDvdForEdit = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.inputTitreDvdForEdit = new System.Windows.Forms.TextBox();
            this.inputIdDvdForEdit = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.inputDureeDvdForEdit = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.selectDvdForEdit = new System.Windows.Forms.ComboBox();
            this.buttonEditDvd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.selectCategorieDvdForCreate = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.inputRealisateurDvd = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.buttonCreerDvd = new System.Windows.Forms.Button();
            this.inputSynopsisDvd = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.inputImageDvd = new System.Windows.Forms.TextBox();
            this.Durée = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.inputTitreDvd = new System.Windows.Forms.TextBox();
            this.inputIdDvd = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.inputDureeDvd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabCommandesDeDocument = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.tabOngletsApplication.Size = new System.Drawing.Size(982, 629);
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
            this.tabParutions.Size = new System.Drawing.Size(974, 600);
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
            this.tabTitres.Size = new System.Drawing.Size(974, 600);
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
            this.tabLivres.Size = new System.Drawing.Size(974, 600);
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
            this.connectionTab.Size = new System.Drawing.Size(974, 600);
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
            this.tabGestionDesDocs.Controls.Add(this.groupBox4);
            this.tabGestionDesDocs.Controls.Add(this.tabControl1);
            this.tabGestionDesDocs.Controls.Add(this.label15);
            this.tabGestionDesDocs.ForeColor = System.Drawing.Color.White;
            this.tabGestionDesDocs.Location = new System.Drawing.Point(4, 25);
            this.tabGestionDesDocs.Name = "tabGestionDesDocs";
            this.tabGestionDesDocs.Padding = new System.Windows.Forms.Padding(3);
            this.tabGestionDesDocs.Size = new System.Drawing.Size(974, 600);
            this.tabGestionDesDocs.TabIndex = 5;
            this.tabGestionDesDocs.Text = "Gestion des Documents";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.textAlertEvent);
            this.groupBox4.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 547);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(955, 47);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "évenements";
            // 
            // textAlertEvent
            // 
            this.textAlertEvent.AutoSize = true;
            this.textAlertEvent.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlertEvent.ForeColor = System.Drawing.Color.White;
            this.textAlertEvent.Location = new System.Drawing.Point(7, 18);
            this.textAlertEvent.Name = "textAlertEvent";
            this.textAlertEvent.Size = new System.Drawing.Size(200, 18);
            this.textAlertEvent.TabIndex = 5;
            this.textAlertEvent.Text = "Aucun évenement enregistré";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Omega Flight Title", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 513);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Livres";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.selectLivreForDelete);
            this.groupBox2.Controls.Add(this.buttonDeleteLivre);
            this.groupBox2.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(692, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 469);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Supprimer";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(6, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(149, 18);
            this.label31.TabIndex = 30;
            this.label31.Text = "Séléctionnez un livre.";
            // 
            // selectLivreForDelete
            // 
            this.selectLivreForDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectLivreForDelete.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLivreForDelete.ForeColor = System.Drawing.Color.Red;
            this.selectLivreForDelete.FormattingEnabled = true;
            this.selectLivreForDelete.Location = new System.Drawing.Point(9, 47);
            this.selectLivreForDelete.Name = "selectLivreForDelete";
            this.selectLivreForDelete.Size = new System.Drawing.Size(234, 26);
            this.selectLivreForDelete.TabIndex = 29;
            // 
            // buttonDeleteLivre
            // 
            this.buttonDeleteLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDeleteLivre.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteLivre.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteLivre.Location = new System.Drawing.Point(96, 437);
            this.buttonDeleteLivre.Name = "buttonDeleteLivre";
            this.buttonDeleteLivre.Size = new System.Drawing.Size(147, 26);
            this.buttonDeleteLivre.TabIndex = 28;
            this.buttonDeleteLivre.Text = "Supprimer";
            this.buttonDeleteLivre.UseVisualStyleBackColor = false;
            this.buttonDeleteLivre.Click += new System.EventHandler(this.buttonDeleteLivre_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.selectCategorieForEdit);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.inputImageLivreForEdit);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.inputCollectionLivreForEdit);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.inputISBNLivreForEdit);
            this.groupBox3.Controls.Add(this.inputAuteurLivreForEdit);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.inputTitreLivreForEdit);
            this.groupBox3.Controls.Add(this.inputIDLivreForEdit);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.selectLivreForEdit);
            this.groupBox3.Controls.Add(this.buttonEditLivre);
            this.groupBox3.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(350, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 469);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modifier";
            // 
            // selectCategorieForEdit
            // 
            this.selectCategorieForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectCategorieForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategorieForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.selectCategorieForEdit.FormattingEnabled = true;
            this.selectCategorieForEdit.Location = new System.Drawing.Point(107, 177);
            this.selectCategorieForEdit.Name = "selectCategorieForEdit";
            this.selectCategorieForEdit.Size = new System.Drawing.Size(223, 26);
            this.selectCategorieForEdit.TabIndex = 39;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(9, 180);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 18);
            this.label23.TabIndex = 38;
            this.label23.Text = "Catégorie";
            // 
            // inputImageLivreForEdit
            // 
            this.inputImageLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputImageLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputImageLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.inputImageLivreForEdit.Location = new System.Drawing.Point(107, 147);
            this.inputImageLivreForEdit.Name = "inputImageLivreForEdit";
            this.inputImageLivreForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputImageLivreForEdit.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(9, 150);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(83, 18);
            this.label24.TabIndex = 36;
            this.label24.Text = "Path Image";
            // 
            // inputCollectionLivreForEdit
            // 
            this.inputCollectionLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputCollectionLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCollectionLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.inputCollectionLivreForEdit.Location = new System.Drawing.Point(107, 271);
            this.inputCollectionLivreForEdit.Name = "inputCollectionLivreForEdit";
            this.inputCollectionLivreForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputCollectionLivreForEdit.TabIndex = 35;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(9, 274);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 18);
            this.label25.TabIndex = 34;
            this.label25.Text = "Collection";
            // 
            // inputISBNLivreForEdit
            // 
            this.inputISBNLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputISBNLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputISBNLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.inputISBNLivreForEdit.Location = new System.Drawing.Point(107, 209);
            this.inputISBNLivreForEdit.Name = "inputISBNLivreForEdit";
            this.inputISBNLivreForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputISBNLivreForEdit.TabIndex = 33;
            // 
            // inputAuteurLivreForEdit
            // 
            this.inputAuteurLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputAuteurLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAuteurLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.inputAuteurLivreForEdit.Location = new System.Drawing.Point(107, 241);
            this.inputAuteurLivreForEdit.Name = "inputAuteurLivreForEdit";
            this.inputAuteurLivreForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputAuteurLivreForEdit.TabIndex = 32;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(9, 212);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(42, 18);
            this.label26.TabIndex = 31;
            this.label26.Text = "ISBN";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(9, 244);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 18);
            this.label27.TabIndex = 30;
            this.label27.Text = "Auteur";
            // 
            // inputTitreLivreForEdit
            // 
            this.inputTitreLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTitreLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitreLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.inputTitreLivreForEdit.Location = new System.Drawing.Point(107, 117);
            this.inputTitreLivreForEdit.Name = "inputTitreLivreForEdit";
            this.inputTitreLivreForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputTitreLivreForEdit.TabIndex = 29;
            // 
            // inputIDLivreForEdit
            // 
            this.inputIDLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputIDLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIDLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.inputIDLivreForEdit.Location = new System.Drawing.Point(107, 85);
            this.inputIDLivreForEdit.Name = "inputIDLivreForEdit";
            this.inputIDLivreForEdit.ReadOnly = true;
            this.inputIDLivreForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputIDLivreForEdit.TabIndex = 28;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(9, 119);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 18);
            this.label28.TabIndex = 27;
            this.label28.Text = "Titre";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(9, 88);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 18);
            this.label29.TabIndex = 26;
            this.label29.Text = "ID";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(9, 21);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(149, 18);
            this.label30.TabIndex = 25;
            this.label30.Text = "Séléctionnez un livre.";
            // 
            // selectLivreForEdit
            // 
            this.selectLivreForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectLivreForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLivreForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.selectLivreForEdit.FormattingEnabled = true;
            this.selectLivreForEdit.Location = new System.Drawing.Point(12, 47);
            this.selectLivreForEdit.Name = "selectLivreForEdit";
            this.selectLivreForEdit.Size = new System.Drawing.Size(318, 26);
            this.selectLivreForEdit.TabIndex = 24;
            this.selectLivreForEdit.SelectedIndexChanged += new System.EventHandler(this.selectLivreForEdit_SelectedIndexChanged);
            // 
            // buttonEditLivre
            // 
            this.buttonEditLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonEditLivre.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditLivre.ForeColor = System.Drawing.Color.White;
            this.buttonEditLivre.Location = new System.Drawing.Point(230, 437);
            this.buttonEditLivre.Name = "buttonEditLivre";
            this.buttonEditLivre.Size = new System.Drawing.Size(100, 26);
            this.buttonEditLivre.TabIndex = 18;
            this.buttonEditLivre.Text = "Modifier";
            this.buttonEditLivre.UseVisualStyleBackColor = false;
            this.buttonEditLivre.Click += new System.EventHandler(this.buttonEditLivre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.selectCategorieLivreForCreate);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 469);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créer";
            // 
            // selectCategorieLivreForCreate
            // 
            this.selectCategorieLivreForCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectCategorieLivreForCreate.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategorieLivreForCreate.ForeColor = System.Drawing.Color.Cyan;
            this.selectCategorieLivreForCreate.FormattingEnabled = true;
            this.selectCategorieLivreForCreate.Location = new System.Drawing.Point(109, 111);
            this.selectCategorieLivreForCreate.Name = "selectCategorieLivreForCreate";
            this.selectCategorieLivreForCreate.Size = new System.Drawing.Size(223, 26);
            this.selectCategorieLivreForCreate.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 18);
            this.label18.TabIndex = 21;
            this.label18.Text = "Catégorie";
            // 
            // inputImageLivre
            // 
            this.inputImageLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputImageLivre.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputImageLivre.ForeColor = System.Drawing.Color.Cyan;
            this.inputImageLivre.Location = new System.Drawing.Point(109, 80);
            this.inputImageLivre.Name = "inputImageLivre";
            this.inputImageLivre.Size = new System.Drawing.Size(223, 26);
            this.inputImageLivre.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 18);
            this.label19.TabIndex = 19;
            this.label19.Text = "Path Image";
            // 
            // buttonCreerLivre
            // 
            this.buttonCreerLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonCreerLivre.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreerLivre.ForeColor = System.Drawing.Color.White;
            this.buttonCreerLivre.Location = new System.Drawing.Point(232, 437);
            this.buttonCreerLivre.Name = "buttonCreerLivre";
            this.buttonCreerLivre.Size = new System.Drawing.Size(100, 26);
            this.buttonCreerLivre.TabIndex = 18;
            this.buttonCreerLivre.Text = "Créer";
            this.buttonCreerLivre.UseVisualStyleBackColor = false;
            this.buttonCreerLivre.Click += new System.EventHandler(this.buttonCreerLivre_Click);
            // 
            // inputCollectionLivre
            // 
            this.inputCollectionLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputCollectionLivre.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCollectionLivre.ForeColor = System.Drawing.Color.Cyan;
            this.inputCollectionLivre.Location = new System.Drawing.Point(109, 206);
            this.inputCollectionLivre.Name = "inputCollectionLivre";
            this.inputCollectionLivre.Size = new System.Drawing.Size(223, 26);
            this.inputCollectionLivre.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(6, 209);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 18);
            this.label22.TabIndex = 12;
            this.label22.Text = "Collection";
            // 
            // inputISBNLivre
            // 
            this.inputISBNLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputISBNLivre.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputISBNLivre.ForeColor = System.Drawing.Color.Cyan;
            this.inputISBNLivre.Location = new System.Drawing.Point(109, 144);
            this.inputISBNLivre.Name = "inputISBNLivre";
            this.inputISBNLivre.Size = new System.Drawing.Size(223, 26);
            this.inputISBNLivre.TabIndex = 11;
            // 
            // inputAuteurLivre
            // 
            this.inputAuteurLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputAuteurLivre.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAuteurLivre.ForeColor = System.Drawing.Color.Cyan;
            this.inputAuteurLivre.Location = new System.Drawing.Point(109, 174);
            this.inputAuteurLivre.Name = "inputAuteurLivre";
            this.inputAuteurLivre.Size = new System.Drawing.Size(223, 26);
            this.inputAuteurLivre.TabIndex = 10;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 147);
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
            this.label21.Location = new System.Drawing.Point(6, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 18);
            this.label21.TabIndex = 8;
            this.label21.Text = "Auteur";
            // 
            // inputTitreLivre
            // 
            this.inputTitreLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTitreLivre.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitreLivre.ForeColor = System.Drawing.Color.Cyan;
            this.inputTitreLivre.Location = new System.Drawing.Point(109, 50);
            this.inputTitreLivre.Name = "inputTitreLivre";
            this.inputTitreLivre.Size = new System.Drawing.Size(223, 26);
            this.inputTitreLivre.TabIndex = 7;
            // 
            // inputIDLivre
            // 
            this.inputIDLivre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputIDLivre.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIDLivre.ForeColor = System.Drawing.Color.Cyan;
            this.inputIDLivre.Location = new System.Drawing.Point(109, 18);
            this.inputIDLivre.Name = "inputIDLivre";
            this.inputIDLivre.Size = new System.Drawing.Size(223, 26);
            this.inputIDLivre.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 18);
            this.label16.TabIndex = 5;
            this.label16.Text = "Titre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DVD";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.selectDvdForDelete);
            this.groupBox7.Controls.Add(this.buttonDeleteDvd);
            this.groupBox7.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(692, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(249, 469);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Supprimer";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(6, 21);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(149, 18);
            this.label46.TabIndex = 30;
            this.label46.Text = "Séléctionnez un livre.";
            // 
            // selectDvdForDelete
            // 
            this.selectDvdForDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectDvdForDelete.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDvdForDelete.ForeColor = System.Drawing.Color.Red;
            this.selectDvdForDelete.FormattingEnabled = true;
            this.selectDvdForDelete.Location = new System.Drawing.Point(9, 47);
            this.selectDvdForDelete.Name = "selectDvdForDelete";
            this.selectDvdForDelete.Size = new System.Drawing.Size(234, 26);
            this.selectDvdForDelete.TabIndex = 29;
            // 
            // buttonDeleteDvd
            // 
            this.buttonDeleteDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDeleteDvd.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteDvd.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteDvd.Location = new System.Drawing.Point(96, 437);
            this.buttonDeleteDvd.Name = "buttonDeleteDvd";
            this.buttonDeleteDvd.Size = new System.Drawing.Size(147, 26);
            this.buttonDeleteDvd.TabIndex = 28;
            this.buttonDeleteDvd.Text = "Supprimer";
            this.buttonDeleteDvd.UseVisualStyleBackColor = false;
            this.buttonDeleteDvd.Click += new System.EventHandler(this.buttonDeleteDvd_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox6.Controls.Add(this.selectCategorieDvdForEdit);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.inputRealisateurDvdForEdit);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.inputSynopsisDvdForEdit);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.inputImageDvdForEdit);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.inputTitreDvdForEdit);
            this.groupBox6.Controls.Add(this.inputIdDvdForEdit);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.inputDureeDvdForEdit);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.selectDvdForEdit);
            this.groupBox6.Controls.Add(this.buttonEditDvd);
            this.groupBox6.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(350, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(336, 469);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Modifier";
            // 
            // selectCategorieDvdForEdit
            // 
            this.selectCategorieDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectCategorieDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategorieDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.selectCategorieDvdForEdit.FormattingEnabled = true;
            this.selectCategorieDvdForEdit.Location = new System.Drawing.Point(107, 174);
            this.selectCategorieDvdForEdit.Name = "selectCategorieDvdForEdit";
            this.selectCategorieDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.selectCategorieDvdForEdit.TabIndex = 39;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(9, 177);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 18);
            this.label35.TabIndex = 38;
            this.label35.Text = "Catégorie";
            // 
            // inputRealisateurDvdForEdit
            // 
            this.inputRealisateurDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputRealisateurDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRealisateurDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.inputRealisateurDvdForEdit.Location = new System.Drawing.Point(107, 237);
            this.inputRealisateurDvdForEdit.Name = "inputRealisateurDvdForEdit";
            this.inputRealisateurDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputRealisateurDvdForEdit.TabIndex = 37;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(9, 240);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 18);
            this.label39.TabIndex = 36;
            this.label39.Text = "Réalisateur";
            // 
            // inputSynopsisDvdForEdit
            // 
            this.inputSynopsisDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputSynopsisDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSynopsisDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.inputSynopsisDvdForEdit.Location = new System.Drawing.Point(107, 205);
            this.inputSynopsisDvdForEdit.Name = "inputSynopsisDvdForEdit";
            this.inputSynopsisDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputSynopsisDvdForEdit.TabIndex = 35;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(9, 208);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(68, 18);
            this.label40.TabIndex = 34;
            this.label40.Text = "Synopsis";
            // 
            // inputImageDvdForEdit
            // 
            this.inputImageDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputImageDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputImageDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.inputImageDvdForEdit.Location = new System.Drawing.Point(107, 145);
            this.inputImageDvdForEdit.Name = "inputImageDvdForEdit";
            this.inputImageDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputImageDvdForEdit.TabIndex = 32;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(9, 269);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(48, 18);
            this.label41.TabIndex = 31;
            this.label41.Text = "Durée";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(9, 148);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 18);
            this.label42.TabIndex = 30;
            this.label42.Text = "Path Image";
            // 
            // inputTitreDvdForEdit
            // 
            this.inputTitreDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTitreDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitreDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.inputTitreDvdForEdit.Location = new System.Drawing.Point(107, 113);
            this.inputTitreDvdForEdit.Name = "inputTitreDvdForEdit";
            this.inputTitreDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputTitreDvdForEdit.TabIndex = 29;
            // 
            // inputIdDvdForEdit
            // 
            this.inputIdDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputIdDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIdDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.inputIdDvdForEdit.Location = new System.Drawing.Point(107, 81);
            this.inputIdDvdForEdit.Name = "inputIdDvdForEdit";
            this.inputIdDvdForEdit.ReadOnly = true;
            this.inputIdDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputIdDvdForEdit.TabIndex = 28;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(9, 115);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(38, 18);
            this.label43.TabIndex = 27;
            this.label43.Text = "Titre";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(9, 84);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(22, 18);
            this.label44.TabIndex = 26;
            this.label44.Text = "ID";
            // 
            // inputDureeDvdForEdit
            // 
            this.inputDureeDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputDureeDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDureeDvdForEdit.ForeColor = System.Drawing.Color.Cyan;
            this.inputDureeDvdForEdit.Location = new System.Drawing.Point(107, 266);
            this.inputDureeDvdForEdit.Name = "inputDureeDvdForEdit";
            this.inputDureeDvdForEdit.Size = new System.Drawing.Size(223, 26);
            this.inputDureeDvdForEdit.TabIndex = 33;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(9, 21);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(149, 18);
            this.label45.TabIndex = 25;
            this.label45.Text = "Séléctionnez un livre.";
            // 
            // selectDvdForEdit
            // 
            this.selectDvdForEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectDvdForEdit.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDvdForEdit.ForeColor = System.Drawing.Color.Yellow;
            this.selectDvdForEdit.FormattingEnabled = true;
            this.selectDvdForEdit.Location = new System.Drawing.Point(12, 47);
            this.selectDvdForEdit.Name = "selectDvdForEdit";
            this.selectDvdForEdit.Size = new System.Drawing.Size(318, 26);
            this.selectDvdForEdit.TabIndex = 24;
            this.selectDvdForEdit.SelectedIndexChanged += new System.EventHandler(this.selectDvdForEdit_SelectedIndexChanged);
            // 
            // buttonEditDvd
            // 
            this.buttonEditDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonEditDvd.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditDvd.ForeColor = System.Drawing.Color.White;
            this.buttonEditDvd.Location = new System.Drawing.Point(230, 437);
            this.buttonEditDvd.Name = "buttonEditDvd";
            this.buttonEditDvd.Size = new System.Drawing.Size(100, 26);
            this.buttonEditDvd.TabIndex = 18;
            this.buttonEditDvd.Text = "Modifier";
            this.buttonEditDvd.UseVisualStyleBackColor = false;
            this.buttonEditDvd.Click += new System.EventHandler(this.buttonEditDvd_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox5.Controls.Add(this.selectCategorieDvdForCreate);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.inputRealisateurDvd);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.buttonCreerDvd);
            this.groupBox5.Controls.Add(this.inputSynopsisDvd);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.inputImageDvd);
            this.groupBox5.Controls.Add(this.Durée);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.inputTitreDvd);
            this.groupBox5.Controls.Add(this.inputIdDvd);
            this.groupBox5.Controls.Add(this.label37);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.inputDureeDvd);
            this.groupBox5.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(338, 469);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Créer";
            // 
            // selectCategorieDvdForCreate
            // 
            this.selectCategorieDvdForCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectCategorieDvdForCreate.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCategorieDvdForCreate.ForeColor = System.Drawing.Color.Cyan;
            this.selectCategorieDvdForCreate.FormattingEnabled = true;
            this.selectCategorieDvdForCreate.Location = new System.Drawing.Point(109, 111);
            this.selectCategorieDvdForCreate.Name = "selectCategorieDvdForCreate";
            this.selectCategorieDvdForCreate.Size = new System.Drawing.Size(223, 26);
            this.selectCategorieDvdForCreate.TabIndex = 22;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(6, 114);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 18);
            this.label32.TabIndex = 21;
            this.label32.Text = "Catégorie";
            // 
            // inputRealisateurDvd
            // 
            this.inputRealisateurDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputRealisateurDvd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRealisateurDvd.ForeColor = System.Drawing.Color.Cyan;
            this.inputRealisateurDvd.Location = new System.Drawing.Point(109, 174);
            this.inputRealisateurDvd.Name = "inputRealisateurDvd";
            this.inputRealisateurDvd.Size = new System.Drawing.Size(223, 26);
            this.inputRealisateurDvd.TabIndex = 20;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(6, 177);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 18);
            this.label33.TabIndex = 19;
            this.label33.Text = "Réalisateur";
            // 
            // buttonCreerDvd
            // 
            this.buttonCreerDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonCreerDvd.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreerDvd.ForeColor = System.Drawing.Color.White;
            this.buttonCreerDvd.Location = new System.Drawing.Point(232, 437);
            this.buttonCreerDvd.Name = "buttonCreerDvd";
            this.buttonCreerDvd.Size = new System.Drawing.Size(100, 26);
            this.buttonCreerDvd.TabIndex = 18;
            this.buttonCreerDvd.Text = "Créer";
            this.buttonCreerDvd.UseVisualStyleBackColor = false;
            this.buttonCreerDvd.Click += new System.EventHandler(this.buttonCreerDvd_Click);
            // 
            // inputSynopsisDvd
            // 
            this.inputSynopsisDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputSynopsisDvd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSynopsisDvd.ForeColor = System.Drawing.Color.Cyan;
            this.inputSynopsisDvd.Location = new System.Drawing.Point(109, 142);
            this.inputSynopsisDvd.Name = "inputSynopsisDvd";
            this.inputSynopsisDvd.Size = new System.Drawing.Size(223, 26);
            this.inputSynopsisDvd.TabIndex = 13;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(6, 145);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 18);
            this.label34.TabIndex = 12;
            this.label34.Text = "Synopsis";
            // 
            // inputImageDvd
            // 
            this.inputImageDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputImageDvd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputImageDvd.ForeColor = System.Drawing.Color.Cyan;
            this.inputImageDvd.Location = new System.Drawing.Point(109, 82);
            this.inputImageDvd.Name = "inputImageDvd";
            this.inputImageDvd.Size = new System.Drawing.Size(223, 26);
            this.inputImageDvd.TabIndex = 10;
            // 
            // Durée
            // 
            this.Durée.AutoSize = true;
            this.Durée.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Durée.ForeColor = System.Drawing.Color.White;
            this.Durée.Location = new System.Drawing.Point(6, 206);
            this.Durée.Name = "Durée";
            this.Durée.Size = new System.Drawing.Size(48, 18);
            this.Durée.TabIndex = 9;
            this.Durée.Text = "Durée";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(6, 85);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 18);
            this.label36.TabIndex = 8;
            this.label36.Text = "Path Image";
            // 
            // inputTitreDvd
            // 
            this.inputTitreDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTitreDvd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTitreDvd.ForeColor = System.Drawing.Color.Cyan;
            this.inputTitreDvd.Location = new System.Drawing.Point(109, 50);
            this.inputTitreDvd.Name = "inputTitreDvd";
            this.inputTitreDvd.Size = new System.Drawing.Size(223, 26);
            this.inputTitreDvd.TabIndex = 7;
            // 
            // inputIdDvd
            // 
            this.inputIdDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputIdDvd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIdDvd.ForeColor = System.Drawing.Color.Cyan;
            this.inputIdDvd.Location = new System.Drawing.Point(109, 18);
            this.inputIdDvd.Name = "inputIdDvd";
            this.inputIdDvd.Size = new System.Drawing.Size(223, 26);
            this.inputIdDvd.TabIndex = 6;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(6, 52);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(38, 18);
            this.label37.TabIndex = 5;
            this.label37.Text = "Titre";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(6, 21);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(22, 18);
            this.label38.TabIndex = 4;
            this.label38.Text = "ID";
            // 
            // inputDureeDvd
            // 
            this.inputDureeDvd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputDureeDvd.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDureeDvd.ForeColor = System.Drawing.Color.Cyan;
            this.inputDureeDvd.Location = new System.Drawing.Point(109, 203);
            this.inputDureeDvd.Name = "inputDureeDvd";
            this.inputDureeDvd.Size = new System.Drawing.Size(223, 26);
            this.inputDureeDvd.TabIndex = 11;
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
            this.tabCommandesDeDocument.Size = new System.Drawing.Size(974, 600);
            this.tabCommandesDeDocument.TabIndex = 6;
            this.tabCommandesDeDocument.Text = "Commandes de Documents";
            // 
            // FrmMediateq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 629);
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
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.ComboBox selectCategorieLivreForCreate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEditLivre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox selectLivreForEdit;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button buttonDeleteLivre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label textAlertEvent;
        private System.Windows.Forms.ComboBox selectCategorieForEdit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox inputImageLivreForEdit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox inputCollectionLivreForEdit;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox inputISBNLivreForEdit;
        private System.Windows.Forms.TextBox inputAuteurLivreForEdit;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox inputTitreLivreForEdit;
        private System.Windows.Forms.TextBox inputIDLivreForEdit;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox selectLivreForDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox selectCategorieDvdForCreate;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox inputRealisateurDvd;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button buttonCreerDvd;
        private System.Windows.Forms.TextBox inputSynopsisDvd;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox inputDureeDvd;
        private System.Windows.Forms.TextBox inputImageDvd;
        private System.Windows.Forms.Label Durée;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox inputTitreDvd;
        private System.Windows.Forms.TextBox inputIdDvd;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox selectDvdForEdit;
        private System.Windows.Forms.Button buttonEditDvd;
        private System.Windows.Forms.ComboBox selectCategorieDvdForEdit;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox inputRealisateurDvdForEdit;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox inputSynopsisDvdForEdit;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox inputImageDvdForEdit;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox inputTitreDvdForEdit;
        private System.Windows.Forms.TextBox inputIdDvdForEdit;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox inputDureeDvdForEdit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox selectDvdForDelete;
        private System.Windows.Forms.Button buttonDeleteDvd;
    }
}

