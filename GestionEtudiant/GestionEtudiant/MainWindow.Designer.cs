﻿namespace GestionEtudiant
{
    partial class mainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatistiquePage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EtudiantPage = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importer = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Tri_DCS = new System.Windows.Forms.Button();
            this.Tri_CRS = new System.Windows.Forms.Button();
            this.charger_donnes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilierePage = new System.Windows.Forms.TabPage();
            this.listeFiliereBox = new System.Windows.Forms.GroupBox();
            this.supprimerFiliereBtn = new System.Windows.Forms.Button();
            this.modifierFiliereBtn = new System.Windows.Forms.Button();
            this.tableFiliere = new System.Windows.Forms.DataGridView();
            this.ajouterFiliereBox = new System.Windows.Forms.GroupBox();
            this.ajouterFiliereBtn = new System.Windows.Forms.Button();
            this.ajouterFiliereInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.TabControl();
            this.Reporting = new System.Windows.Forms.TabPage();
            this.reportingGenerate = new System.Windows.Forms.Button();
            this.reportingButton = new System.Windows.Forms.Button();
            this.reportingTextBox = new System.Windows.Forms.TextBox();
            this.reportingLabel = new System.Windows.Forms.Label();
            this.reportingComboBox = new System.Windows.Forms.ComboBox();
            this.ModifiyingPannel = new System.Windows.Forms.Panel();
            this.NewNameInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ValidateNewName = new System.Windows.Forms.Button();
            this.StatistiquePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.EtudiantPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.FilierePage.SuspendLayout();
            this.listeFiliereBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableFiliere)).BeginInit();
            this.ajouterFiliereBox.SuspendLayout();
            this.menu.SuspendLayout();
            this.Reporting.SuspendLayout();
            this.ModifiyingPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatistiquePage
            // 
            this.StatistiquePage.Controls.Add(this.label11);
            this.StatistiquePage.Controls.Add(this.chart1);
            this.StatistiquePage.Location = new System.Drawing.Point(4, 25);
            this.StatistiquePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatistiquePage.Name = "StatistiquePage";
            this.StatistiquePage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatistiquePage.Size = new System.Drawing.Size(824, 446);
            this.StatistiquePage.TabIndex = 3;
            this.StatistiquePage.Text = "Statistique";
            this.StatistiquePage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(533, 292);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Filière";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(59, 33);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Nombre Etudiant";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(421, 306);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // EtudiantPage
            // 
            this.EtudiantPage.Controls.Add(this.comboBox1);
            this.EtudiantPage.Controls.Add(this.dataGridView1);
            this.EtudiantPage.Controls.Add(this.Importer);
            this.EtudiantPage.Controls.Add(this.Supprimer);
            this.EtudiantPage.Controls.Add(this.Modifier);
            this.EtudiantPage.Controls.Add(this.Ajouter);
            this.EtudiantPage.Controls.Add(this.Tri_DCS);
            this.EtudiantPage.Controls.Add(this.Tri_CRS);
            this.EtudiantPage.Controls.Add(this.charger_donnes);
            this.EtudiantPage.Controls.Add(this.groupBox1);
            this.EtudiantPage.Controls.Add(this.label2);
            this.EtudiantPage.Location = new System.Drawing.Point(4, 25);
            this.EtudiantPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EtudiantPage.Name = "EtudiantPage";
            this.EtudiantPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EtudiantPage.Size = new System.Drawing.Size(824, 446);
            this.EtudiantPage.TabIndex = 2;
            this.EtudiantPage.Text = "Etudiant";
            this.EtudiantPage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(174, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cne,
            this.nom,
            this.prenom,
            this.sexe,
            this.date_naissance,
            this.adresse,
            this.telephone,
            this.filiere});
            this.dataGridView1.Location = new System.Drawing.Point(422, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 178);
            this.dataGridView1.TabIndex = 10;
            // 
            // cne
            // 
            this.cne.HeaderText = "cne";
            this.cne.Name = "cne";
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "prenom";
            this.prenom.Name = "prenom";
            // 
            // sexe
            // 
            this.sexe.HeaderText = "sexe";
            this.sexe.Name = "sexe";
            // 
            // date_naissance
            // 
            this.date_naissance.HeaderText = "date de naissance";
            this.date_naissance.Name = "date_naissance";
            // 
            // adresse
            // 
            this.adresse.HeaderText = "adresse";
            this.adresse.Name = "adresse";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "telephone";
            this.telephone.Name = "telephone";
            // 
            // filiere
            // 
            this.filiere.HeaderText = "filiere";
            this.filiere.Name = "filiere";
            // 
            // Importer
            // 
            this.Importer.Location = new System.Drawing.Point(396, 402);
            this.Importer.Name = "Importer";
            this.Importer.Size = new System.Drawing.Size(75, 23);
            this.Importer.TabIndex = 9;
            this.Importer.Text = "Importer";
            this.Importer.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(285, 402);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 8;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(174, 402);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 7;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(53, 402);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            // 
            // Tri_DCS
            // 
            this.Tri_DCS.Location = new System.Drawing.Point(697, 89);
            this.Tri_DCS.Name = "Tri_DCS";
            this.Tri_DCS.Size = new System.Drawing.Size(92, 23);
            this.Tri_DCS.TabIndex = 5;
            this.Tri_DCS.Text = "Tri décroissant";
            this.Tri_DCS.UseVisualStyleBackColor = true;
            this.Tri_DCS.Click += new System.EventHandler(this.Tri_DCS_Click);
            // 
            // Tri_CRS
            // 
            this.Tri_CRS.Location = new System.Drawing.Point(580, 89);
            this.Tri_CRS.Name = "Tri_CRS";
            this.Tri_CRS.Size = new System.Drawing.Size(86, 23);
            this.Tri_CRS.TabIndex = 4;
            this.Tri_CRS.Text = "Tri croissant";
            this.Tri_CRS.UseVisualStyleBackColor = true;
            this.Tri_CRS.Click += new System.EventHandler(this.Tri_CRS_Click);
            // 
            // charger_donnes
            // 
            this.charger_donnes.Location = new System.Drawing.Point(422, 89);
            this.charger_donnes.Name = "charger_donnes";
            this.charger_donnes.Size = new System.Drawing.Size(121, 23);
            this.charger_donnes.TabIndex = 3;
            this.charger_donnes.Text = "Charger les données";
            this.charger_donnes.UseVisualStyleBackColor = true;
            this.charger_donnes.Click += new System.EventHandler(this.charger_donnes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(24, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 310);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Etudiant";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(150, 265);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 227);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(150, 126);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 20);
            this.textBox4.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(261, 159);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "M";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(150, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "F";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Filiere:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Telephone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Adresse:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date de Naissance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sexe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prenom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chercher un Etudiant";
            // 
            // FilierePage
            // 
            this.FilierePage.Controls.Add(this.ModifiyingPannel);
            this.FilierePage.Controls.Add(this.listeFiliereBox);
            this.FilierePage.Controls.Add(this.ajouterFiliereBox);
            this.FilierePage.Location = new System.Drawing.Point(4, 25);
            this.FilierePage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilierePage.Name = "FilierePage";
            this.FilierePage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FilierePage.Size = new System.Drawing.Size(824, 446);
            this.FilierePage.TabIndex = 0;
            this.FilierePage.Text = "Filière";
            this.FilierePage.UseVisualStyleBackColor = true;
            this.FilierePage.Click += new System.EventHandler(this.FilierePage_Click);
            // 
            // listeFiliereBox
            // 
            this.listeFiliereBox.Controls.Add(this.supprimerFiliereBtn);
            this.listeFiliereBox.Controls.Add(this.modifierFiliereBtn);
            this.listeFiliereBox.Controls.Add(this.tableFiliere);
            this.listeFiliereBox.Location = new System.Drawing.Point(336, 84);
            this.listeFiliereBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeFiliereBox.Name = "listeFiliereBox";
            this.listeFiliereBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeFiliereBox.Size = new System.Drawing.Size(468, 237);
            this.listeFiliereBox.TabIndex = 0;
            this.listeFiliereBox.TabStop = false;
            this.listeFiliereBox.Text = "Liste des filieres";
            // 
            // supprimerFiliereBtn
            // 
            this.supprimerFiliereBtn.Location = new System.Drawing.Point(226, 22);
            this.supprimerFiliereBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supprimerFiliereBtn.Name = "supprimerFiliereBtn";
            this.supprimerFiliereBtn.Size = new System.Drawing.Size(92, 19);
            this.supprimerFiliereBtn.TabIndex = 1;
            this.supprimerFiliereBtn.Text = "Supprimer";
            this.supprimerFiliereBtn.UseVisualStyleBackColor = true;
            // 
            // modifierFiliereBtn
            // 
            this.modifierFiliereBtn.Location = new System.Drawing.Point(130, 22);
            this.modifierFiliereBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifierFiliereBtn.Name = "modifierFiliereBtn";
            this.modifierFiliereBtn.Size = new System.Drawing.Size(92, 19);
            this.modifierFiliereBtn.TabIndex = 1;
            this.modifierFiliereBtn.Text = "Modifier";
            this.modifierFiliereBtn.UseVisualStyleBackColor = true;
            this.modifierFiliereBtn.Click += new System.EventHandler(this.modifierFiliereBtn_Click);
            // 
            // tableFiliere
            // 
            this.tableFiliere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableFiliere.Location = new System.Drawing.Point(0, 54);
            this.tableFiliere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableFiliere.Name = "tableFiliere";
            this.tableFiliere.RowHeadersWidth = 51;
            this.tableFiliere.RowTemplate.Height = 24;
            this.tableFiliere.Size = new System.Drawing.Size(468, 183);
            this.tableFiliere.TabIndex = 0;
            // 
            // ajouterFiliereBox
            // 
            this.ajouterFiliereBox.Controls.Add(this.ajouterFiliereBtn);
            this.ajouterFiliereBox.Controls.Add(this.ajouterFiliereInput);
            this.ajouterFiliereBox.Controls.Add(this.label1);
            this.ajouterFiliereBox.Location = new System.Drawing.Point(14, 84);
            this.ajouterFiliereBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouterFiliereBox.Name = "ajouterFiliereBox";
            this.ajouterFiliereBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouterFiliereBox.Size = new System.Drawing.Size(307, 237);
            this.ajouterFiliereBox.TabIndex = 0;
            this.ajouterFiliereBox.TabStop = false;
            this.ajouterFiliereBox.Text = "Ajouter une filière";
            this.ajouterFiliereBox.Enter += new System.EventHandler(this.ajouterFiliereBox_Enter);
            // 
            // ajouterFiliereBtn
            // 
            this.ajouterFiliereBtn.Location = new System.Drawing.Point(125, 154);
            this.ajouterFiliereBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouterFiliereBtn.Name = "ajouterFiliereBtn";
            this.ajouterFiliereBtn.Size = new System.Drawing.Size(56, 19);
            this.ajouterFiliereBtn.TabIndex = 2;
            this.ajouterFiliereBtn.Text = "Ajouter";
            this.ajouterFiliereBtn.UseVisualStyleBackColor = true;
            this.ajouterFiliereBtn.Click += new System.EventHandler(this.ajouterFiliereBtn_Click);
            // 
            // ajouterFiliereInput
            // 
            this.ajouterFiliereInput.Location = new System.Drawing.Point(60, 101);
            this.ajouterFiliereInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ajouterFiliereInput.Name = "ajouterFiliereInput";
            this.ajouterFiliereInput.Size = new System.Drawing.Size(218, 20);
            this.ajouterFiliereInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom : ";
            // 
            // menu
            // 
            this.menu.Controls.Add(this.FilierePage);
            this.menu.Controls.Add(this.EtudiantPage);
            this.menu.Controls.Add(this.StatistiquePage);
            this.menu.Controls.Add(this.Reporting);
            this.menu.ItemSize = new System.Drawing.Size(49, 21);
            this.menu.Location = new System.Drawing.Point(-1, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Drawing.Point(20, 3);
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(832, 475);
            this.menu.TabIndex = 0;
            // 
            // Reporting
            // 
            this.Reporting.Controls.Add(this.reportingGenerate);
            this.Reporting.Controls.Add(this.reportingButton);
            this.Reporting.Controls.Add(this.reportingTextBox);
            this.Reporting.Controls.Add(this.reportingLabel);
            this.Reporting.Controls.Add(this.reportingComboBox);
            this.Reporting.Location = new System.Drawing.Point(4, 25);
            this.Reporting.Name = "Reporting";
            this.Reporting.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Reporting.Size = new System.Drawing.Size(824, 446);
            this.Reporting.TabIndex = 4;
            this.Reporting.Text = "ReportingPage";
            this.Reporting.UseVisualStyleBackColor = true;
            // 
            // reportingGenerate
            // 
            this.reportingGenerate.Location = new System.Drawing.Point(359, 169);
            this.reportingGenerate.Name = "reportingGenerate";
            this.reportingGenerate.Size = new System.Drawing.Size(104, 23);
            this.reportingGenerate.TabIndex = 4;
            this.reportingGenerate.Text = "Afficher";
            this.reportingGenerate.UseVisualStyleBackColor = true;
            this.reportingGenerate.Visible = false;
            this.reportingGenerate.Click += new System.EventHandler(this.ReportingGenerate_Click);
            // 
            // reportingButton
            // 
            this.reportingButton.Location = new System.Drawing.Point(359, 247);
            this.reportingButton.Name = "reportingButton";
            this.reportingButton.Size = new System.Drawing.Size(104, 24);
            this.reportingButton.TabIndex = 3;
            this.reportingButton.Text = "Afficher";
            this.reportingButton.UseVisualStyleBackColor = true;
            this.reportingButton.Visible = false;
            this.reportingButton.Click += new System.EventHandler(this.ReportingButton_Click);
            // 
            // reportingTextBox
            // 
            this.reportingTextBox.Location = new System.Drawing.Point(341, 198);
            this.reportingTextBox.Name = "reportingTextBox";
            this.reportingTextBox.Size = new System.Drawing.Size(132, 20);
            this.reportingTextBox.TabIndex = 2;
            this.reportingTextBox.Visible = false;
            // 
            // reportingLabel
            // 
            this.reportingLabel.AutoSize = true;
            this.reportingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportingLabel.Location = new System.Drawing.Point(245, 201);
            this.reportingLabel.Name = "reportingLabel";
            this.reportingLabel.Size = new System.Drawing.Size(81, 13);
            this.reportingLabel.TabIndex = 1;
            this.reportingLabel.Text = "Saisir un CNE : ";
            this.reportingLabel.Visible = false;
            // 
            // reportingComboBox
            // 
            this.reportingComboBox.FormattingEnabled = true;
            this.reportingComboBox.Items.AddRange(new object[] {
            "Tous les étudiants",
            "Chaque étudiant"});
            this.reportingComboBox.Location = new System.Drawing.Point(314, 94);
            this.reportingComboBox.Name = "reportingComboBox";
            this.reportingComboBox.Size = new System.Drawing.Size(190, 21);
            this.reportingComboBox.TabIndex = 0;
            this.reportingComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox3_SelectedIndexChanged);
            // 
            // ModifiyingPannel
            // 
            this.ModifiyingPannel.BackColor = System.Drawing.Color.DimGray;
            this.ModifiyingPannel.Controls.Add(this.ValidateNewName);
            this.ModifiyingPannel.Controls.Add(this.label12);
            this.ModifiyingPannel.Controls.Add(this.NewNameInput);
            this.ModifiyingPannel.Location = new System.Drawing.Point(163, 76);
            this.ModifiyingPannel.Name = "ModifiyingPannel";
            this.ModifiyingPannel.Size = new System.Drawing.Size(316, 157);
            this.ModifiyingPannel.TabIndex = 1;
            this.ModifiyingPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.ModifiyingPannel_Paint);
            // 
            // NewNameInput
            // 
            this.NewNameInput.Location = new System.Drawing.Point(91, 55);
            this.NewNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.NewNameInput.Name = "NewNameInput";
            this.NewNameInput.Size = new System.Drawing.Size(162, 20);
            this.NewNameInput.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Nouveau Nom : ";
            // 
            // ValidateNewName
            // 
            this.ValidateNewName.Location = new System.Drawing.Point(124, 95);
            this.ValidateNewName.Margin = new System.Windows.Forms.Padding(2);
            this.ValidateNewName.Name = "ValidateNewName";
            this.ValidateNewName.Size = new System.Drawing.Size(56, 19);
            this.ValidateNewName.TabIndex = 3;
            this.ValidateNewName.Text = "Validez";
            this.ValidateNewName.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 470);
            this.Controls.Add(this.menu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainWindow";
            this.Text = "Gestion Des Etudiants";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.StatistiquePage.ResumeLayout(false);
            this.StatistiquePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.EtudiantPage.ResumeLayout(false);
            this.EtudiantPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.FilierePage.ResumeLayout(false);
            this.listeFiliereBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableFiliere)).EndInit();
            this.ajouterFiliereBox.ResumeLayout(false);
            this.ajouterFiliereBox.PerformLayout();
            this.menu.ResumeLayout(false);
            this.Reporting.ResumeLayout(false);
            this.Reporting.PerformLayout();
            this.ModifiyingPannel.ResumeLayout(false);
            this.ModifiyingPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage StatistiquePage;
        private System.Windows.Forms.TabPage EtudiantPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage FilierePage;
        private System.Windows.Forms.GroupBox listeFiliereBox;
        private System.Windows.Forms.Button supprimerFiliereBtn;
        private System.Windows.Forms.Button modifierFiliereBtn;
        private System.Windows.Forms.DataGridView tableFiliere;
        private System.Windows.Forms.GroupBox ajouterFiliereBox;
        private System.Windows.Forms.Button ajouterFiliereBtn;
        private System.Windows.Forms.TextBox ajouterFiliereInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl menu;
        private System.Windows.Forms.TabPage Reporting;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cne;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn filiere;
        private System.Windows.Forms.Button Importer;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Tri_DCS;
        private System.Windows.Forms.Button Tri_CRS;
        private System.Windows.Forms.Button charger_donnes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox reportingComboBox;
        private System.Windows.Forms.TextBox reportingTextBox;
        private System.Windows.Forms.Label reportingLabel;
        private System.Windows.Forms.Button reportingButton;
        private System.Windows.Forms.Button reportingGenerate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel ModifiyingPannel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox NewNameInput;
        private System.Windows.Forms.Button ValidateNewName;
    }
}

