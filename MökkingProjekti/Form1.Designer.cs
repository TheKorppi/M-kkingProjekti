﻿namespace MökkingProjekti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkingDBDataSet = new MökkingProjekti.MokkingDBDataSet();
            this.asiakasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mokkingDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasTableAdapter = new MökkingProjekti.MokkingDBDataSetTableAdapters.asiakasTableAdapter();
            this.asiakasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new MökkingProjekti.MokkingDBDataSetTableAdapters.TableAdapterManager();
            this.alueTableAdapter = new MökkingProjekti.MokkingDBDataSetTableAdapters.alueTableAdapter();
            this.mokkiTableAdapter = new MökkingProjekti.MokkingDBDataSetTableAdapters.mokkiTableAdapter();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskubtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lisaabtn = new System.Windows.Forms.Button();
            this.taulunimi = new System.Windows.Forms.Label();
            this.cbmokki = new System.Windows.Forms.ComboBox();
            this.cbalue = new System.Windows.Forms.ComboBox();
            this.btnperuutavaraus = new System.Windows.Forms.Button();
            this.btnlisaavaraus = new System.Windows.Forms.Button();
            this.dtplahtopaiva = new System.Windows.Forms.DateTimePicker();
            this.dtptulopaiva = new System.Windows.Forms.DateTimePicker();
            this.lbcheckout = new System.Windows.Forms.Label();
            this.lblocation = new System.Windows.Forms.Label();
            this.lbcottage = new System.Windows.Forms.Label();
            this.lbcheckin = new System.Windows.Forms.Label();
            this.tbvaraajanosoite = new System.Windows.Forms.TextBox();
            this.tbvarauspuhelinnumero = new System.Windows.Forms.TextBox();
            this.tbvaraajanpostinumero = new System.Windows.Forms.TextBox();
            this.tbvaraussukunimi = new System.Windows.Forms.TextBox();
            this.tbvaraussahkoposti = new System.Windows.Forms.TextBox();
            this.tbvarausetunimi = new System.Windows.Forms.TextBox();
            this.lbpostcode = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lblastname = new System.Windows.Forms.Label();
            this.lbfirstname = new System.Windows.Forms.Label();
            this.Pvaraus = new System.Windows.Forms.Panel();
            this.tbhaku = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnlisaapalveluvaraus = new System.Windows.Forms.Button();
            this.btnpoistavaraus = new System.Windows.Forms.Button();
            this.btnmuokkaavaraus = new System.Windows.Forms.Button();
            this.Plasku = new System.Windows.Forms.Panel();
            this.btnmuokkaalasku = new System.Windows.Forms.Button();
            this.btnpoistalasku = new System.Windows.Forms.Button();
            this.btnperuutalasku = new System.Windows.Forms.Button();
            this.btnlisaalasku = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lbbillprice = new System.Windows.Forms.Label();
            this.lbbilltax = new System.Windows.Forms.Label();
            this.lbbillID = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.Ppalvelu = new System.Windows.Forms.Panel();
            this.btnpoistapalvelu = new System.Windows.Forms.Button();
            this.btnmuokkaapalvelu = new System.Windows.Forms.Button();
            this.tbpalveluhinta = new System.Windows.Forms.TextBox();
            this.tbpalvelukuvaus = new System.Windows.Forms.TextBox();
            this.tbpalvelutyyppi = new System.Windows.Forms.TextBox();
            this.tbpalvelualv = new System.Windows.Forms.TextBox();
            this.tbpalvelunimi = new System.Windows.Forms.TextBox();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbkuvaus = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbtax = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.btnperuutapalvelu = new System.Windows.Forms.Button();
            this.btnlisaapalvelu = new System.Windows.Forms.Button();
            this.Pasiakas = new System.Windows.Forms.Panel();
            this.btnmuokkaa = new System.Windows.Forms.Button();
            this.btnpoistaasiakas = new System.Windows.Forms.Button();
            this.tbasiakaspostinum = new System.Windows.Forms.TextBox();
            this.tbasiakasosoite = new System.Windows.Forms.TextBox();
            this.tbasiakaspuhnum = new System.Windows.Forms.TextBox();
            this.tbasiakassposti = new System.Windows.Forms.TextBox();
            this.tbasiakassnimi = new System.Windows.Forms.TextBox();
            this.tbasiakasnimi = new System.Windows.Forms.TextBox();
            this.btnasiakasperuuta = new System.Windows.Forms.Button();
            this.btnasiakaslisaa = new System.Windows.Forms.Button();
            this.lbcustomerlname = new System.Windows.Forms.Label();
            this.lbcustomeremail = new System.Windows.Forms.Label();
            this.lbcustormerphone = new System.Windows.Forms.Label();
            this.lbcustomerpostcode = new System.Windows.Forms.Label();
            this.lbcustomeraddress = new System.Windows.Forms.Label();
            this.lbcustomerfname = new System.Windows.Forms.Label();
            this.Palue = new System.Windows.Forms.Panel();
            this.btnpoistaalue = new System.Windows.Forms.Button();
            this.btnmuokkaaalue = new System.Windows.Forms.Button();
            this.btnperuutaalue = new System.Windows.Forms.Button();
            this.btnlisaaalue = new System.Windows.Forms.Button();
            this.tbaluenimi = new System.Windows.Forms.TextBox();
            this.lblocationname = new System.Windows.Forms.Label();
            this.Pmokki = new System.Windows.Forms.Panel();
            this.btnpoistamokki = new System.Windows.Forms.Button();
            this.btnmuokkaamokki = new System.Windows.Forms.Button();
            this.tbmokkihinta = new System.Windows.Forms.TextBox();
            this.tbmokkinimi = new System.Windows.Forms.TextBox();
            this.tbmokkiosoite = new System.Windows.Forms.TextBox();
            this.tbmokkivarustelu = new System.Windows.Forms.TextBox();
            this.tbmokkikuvaus = new System.Windows.Forms.TextBox();
            this.tbmokkipostinumero = new System.Windows.Forms.TextBox();
            this.tbmokkialuenimi = new System.Windows.Forms.TextBox();
            this.lbvarutelu = new System.Windows.Forms.Label();
            this.btnperuutamokki = new System.Windows.Forms.Button();
            this.btnlisaamokki = new System.Windows.Forms.Button();
            this.lbcottagename = new System.Windows.Forms.Label();
            this.lbcottageaddress = new System.Windows.Forms.Label();
            this.lbcottagepostcode = new System.Windows.Forms.Label();
            this.lbcottageprice = new System.Windows.Forms.Label();
            this.lbdescription = new System.Windows.Forms.Label();
            this.lbloactio = new System.Windows.Forms.Label();
            this.aikajaksobtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.jotainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnalueetjamökit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnasiakkaat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnvaraukset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnlaskut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnpalvelut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            this.Pvaraus.SuspendLayout();
            this.Plasku.SuspendLayout();
            this.Ppalvelu.SuspendLayout();
            this.Pasiakas.SuspendLayout();
            this.Palue.SuspendLayout();
            this.Pmokki.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 567);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.mokkingDBDataSetBindingSource;
            // 
            // mokkingDBDataSetBindingSource
            // 
            this.mokkingDBDataSetBindingSource.DataSource = this.mokkingDBDataSet;
            this.mokkingDBDataSetBindingSource.Position = 0;
            // 
            // mokkingDBDataSet
            // 
            this.mokkingDBDataSet.DataSetName = "MokkingDBDataSet";
            this.mokkingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asiakasBindingSource1
            // 
            this.asiakasBindingSource1.DataMember = "asiakas";
            this.asiakasBindingSource1.DataSource = this.mokkingDBDataSetBindingSource;
            // 
            // mokkingDBDataSetBindingSource1
            // 
            this.mokkingDBDataSetBindingSource1.DataSource = this.mokkingDBDataSet;
            this.mokkingDBDataSetBindingSource1.Position = 0;
            // 
            // asiakasTableAdapter
            // 
            this.asiakasTableAdapter.ClearBeforeFill = true;
            // 
            // asiakasBindingSource2
            // 
            this.asiakasBindingSource2.DataMember = "asiakas";
            this.asiakasBindingSource2.DataSource = this.mokkingDBDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.alueTableAdapter = this.alueTableAdapter;
            this.tableAdapterManager.asiakasTableAdapter = this.asiakasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.laskuTableAdapter = null;
            this.tableAdapterManager.mokkiTableAdapter = this.mokkiTableAdapter;
            this.tableAdapterManager.palveluTableAdapter = null;
            this.tableAdapterManager.postiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MökkingProjekti.MokkingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.varauksen_palvelutTableAdapter = null;
            this.tableAdapterManager.varausTableAdapter = null;
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter
            // 
            this.mokkiTableAdapter.ClearBeforeFill = true;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.mokkingDBDataSet;
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.mokkingDBDataSet;
            // 
            // laskubtn
            // 
            this.laskubtn.Location = new System.Drawing.Point(1099, 682);
            this.laskubtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laskubtn.Name = "laskubtn";
            this.laskubtn.Size = new System.Drawing.Size(123, 28);
            this.laskubtn.TabIndex = 4;
            this.laskubtn.Text = "Lasku";
            this.laskubtn.UseVisualStyleBackColor = true;
            this.laskubtn.Click += new System.EventHandler(this.laskubtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1026, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "MökKing - mökkivaraustenhallintajärjestelmä";
            // 
            // lisaabtn
            // 
            this.lisaabtn.Location = new System.Drawing.Point(1097, 785);
            this.lisaabtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lisaabtn.Name = "lisaabtn";
            this.lisaabtn.Size = new System.Drawing.Size(123, 28);
            this.lisaabtn.TabIndex = 6;
            this.lisaabtn.Text = "Lisää tietoja";
            this.lisaabtn.UseVisualStyleBackColor = true;
            this.lisaabtn.Click += new System.EventHandler(this.lisaabtn_Click);
            // 
            // taulunimi
            // 
            this.taulunimi.AutoSize = true;
            this.taulunimi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taulunimi.Location = new System.Drawing.Point(20, 528);
            this.taulunimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taulunimi.Name = "taulunimi";
            this.taulunimi.Size = new System.Drawing.Size(104, 37);
            this.taulunimi.TabIndex = 7;
            this.taulunimi.Text = "Asiakas";
            // 
            // cbmokki
            // 
            this.cbmokki.FormattingEnabled = true;
            this.cbmokki.Location = new System.Drawing.Point(379, 132);
            this.cbmokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmokki.Name = "cbmokki";
            this.cbmokki.Size = new System.Drawing.Size(121, 24);
            this.cbmokki.TabIndex = 10;
            // 
            // cbalue
            // 
            this.cbalue.FormattingEnabled = true;
            this.cbalue.Location = new System.Drawing.Point(379, 101);
            this.cbalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbalue.Name = "cbalue";
            this.cbalue.Size = new System.Drawing.Size(121, 24);
            this.cbalue.TabIndex = 9;
            // 
            // btnperuutavaraus
            // 
            this.btnperuutavaraus.Location = new System.Drawing.Point(128, 319);
            this.btnperuutavaraus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnperuutavaraus.Name = "btnperuutavaraus";
            this.btnperuutavaraus.Size = new System.Drawing.Size(75, 31);
            this.btnperuutavaraus.TabIndex = 12;
            this.btnperuutavaraus.Text = "Peruuta";
            this.btnperuutavaraus.UseVisualStyleBackColor = true;
            this.btnperuutavaraus.Click += new System.EventHandler(this.btnperuutavaraus_Click);
            // 
            // btnlisaavaraus
            // 
            this.btnlisaavaraus.Location = new System.Drawing.Point(28, 304);
            this.btnlisaavaraus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlisaavaraus.Name = "btnlisaavaraus";
            this.btnlisaavaraus.Size = new System.Drawing.Size(79, 46);
            this.btnlisaavaraus.TabIndex = 11;
            this.btnlisaavaraus.Text = "Lisää varaus";
            this.btnlisaavaraus.UseVisualStyleBackColor = true;
            this.btnlisaavaraus.Click += new System.EventHandler(this.btreservation_Click);
            // 
            // dtplahtopaiva
            // 
            this.dtplahtopaiva.Location = new System.Drawing.Point(379, 71);
            this.dtplahtopaiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtplahtopaiva.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dtplahtopaiva.Name = "dtplahtopaiva";
            this.dtplahtopaiva.Size = new System.Drawing.Size(200, 22);
            this.dtplahtopaiva.TabIndex = 8;
            // 
            // dtptulopaiva
            // 
            this.dtptulopaiva.Location = new System.Drawing.Point(379, 37);
            this.dtptulopaiva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtptulopaiva.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dtptulopaiva.Name = "dtptulopaiva";
            this.dtptulopaiva.Size = new System.Drawing.Size(200, 22);
            this.dtptulopaiva.TabIndex = 7;
            // 
            // lbcheckout
            // 
            this.lbcheckout.AutoSize = true;
            this.lbcheckout.Location = new System.Drawing.Point(267, 74);
            this.lbcheckout.Name = "lbcheckout";
            this.lbcheckout.Size = new System.Drawing.Size(77, 16);
            this.lbcheckout.TabIndex = 44;
            this.lbcheckout.Text = "Lähtö päivä";
            // 
            // lblocation
            // 
            this.lblocation.AutoSize = true;
            this.lblocation.Location = new System.Drawing.Point(267, 105);
            this.lblocation.Name = "lblocation";
            this.lblocation.Size = new System.Drawing.Size(34, 16);
            this.lblocation.TabIndex = 43;
            this.lblocation.Text = "Alue";
            // 
            // lbcottage
            // 
            this.lbcottage.AutoSize = true;
            this.lbcottage.Location = new System.Drawing.Point(267, 135);
            this.lbcottage.Name = "lbcottage";
            this.lbcottage.Size = new System.Drawing.Size(43, 16);
            this.lbcottage.TabIndex = 42;
            this.lbcottage.Text = "Mökki";
            // 
            // lbcheckin
            // 
            this.lbcheckin.AutoSize = true;
            this.lbcheckin.Location = new System.Drawing.Point(267, 42);
            this.lbcheckin.Name = "lbcheckin";
            this.lbcheckin.Size = new System.Drawing.Size(71, 16);
            this.lbcheckin.TabIndex = 41;
            this.lbcheckin.Text = "Tulo päivä\r\n";
            // 
            // tbvaraajanosoite
            // 
            this.tbvaraajanosoite.Location = new System.Drawing.Point(143, 160);
            this.tbvaraajanosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvaraajanosoite.Name = "tbvaraajanosoite";
            this.tbvaraajanosoite.Size = new System.Drawing.Size(100, 22);
            this.tbvaraajanosoite.TabIndex = 5;
            // 
            // tbvarauspuhelinnumero
            // 
            this.tbvarauspuhelinnumero.Location = new System.Drawing.Point(143, 130);
            this.tbvarauspuhelinnumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvarauspuhelinnumero.Name = "tbvarauspuhelinnumero";
            this.tbvarauspuhelinnumero.Size = new System.Drawing.Size(100, 22);
            this.tbvarauspuhelinnumero.TabIndex = 4;
            // 
            // tbvaraajanpostinumero
            // 
            this.tbvaraajanpostinumero.Location = new System.Drawing.Point(143, 190);
            this.tbvaraajanpostinumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvaraajanpostinumero.Name = "tbvaraajanpostinumero";
            this.tbvaraajanpostinumero.Size = new System.Drawing.Size(100, 22);
            this.tbvaraajanpostinumero.TabIndex = 6;
            // 
            // tbvaraussukunimi
            // 
            this.tbvaraussukunimi.Location = new System.Drawing.Point(143, 71);
            this.tbvaraussukunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvaraussukunimi.Name = "tbvaraussukunimi";
            this.tbvaraussukunimi.Size = new System.Drawing.Size(100, 22);
            this.tbvaraussukunimi.TabIndex = 2;
            // 
            // tbvaraussahkoposti
            // 
            this.tbvaraussahkoposti.Location = new System.Drawing.Point(143, 101);
            this.tbvaraussahkoposti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvaraussahkoposti.Name = "tbvaraussahkoposti";
            this.tbvaraussahkoposti.Size = new System.Drawing.Size(100, 22);
            this.tbvaraussahkoposti.TabIndex = 3;
            // 
            // tbvarausetunimi
            // 
            this.tbvarausetunimi.Location = new System.Drawing.Point(143, 42);
            this.tbvarausetunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbvarausetunimi.Name = "tbvarausetunimi";
            this.tbvarausetunimi.Size = new System.Drawing.Size(100, 22);
            this.tbvarausetunimi.TabIndex = 1;
            // 
            // lbpostcode
            // 
            this.lbpostcode.AutoSize = true;
            this.lbpostcode.Location = new System.Drawing.Point(25, 193);
            this.lbpostcode.Name = "lbpostcode";
            this.lbpostcode.Size = new System.Drawing.Size(82, 16);
            this.lbpostcode.TabIndex = 34;
            this.lbpostcode.Text = "Postinumero";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(25, 164);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(69, 16);
            this.lbaddress.TabIndex = 33;
            this.lbaddress.Text = "Lähiosoite";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(25, 134);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(96, 16);
            this.lbphone.TabIndex = 32;
            this.lbphone.Text = "Puhelinnumero";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(25, 105);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(75, 16);
            this.lbemail.TabIndex = 31;
            this.lbemail.Text = "Sähköposti";
            // 
            // lblastname
            // 
            this.lblastname.AutoSize = true;
            this.lblastname.Location = new System.Drawing.Point(25, 75);
            this.lblastname.Name = "lblastname";
            this.lblastname.Size = new System.Drawing.Size(61, 16);
            this.lblastname.TabIndex = 30;
            this.lblastname.Text = "Sukunimi";
            // 
            // lbfirstname
            // 
            this.lbfirstname.AutoSize = true;
            this.lbfirstname.Location = new System.Drawing.Point(25, 46);
            this.lbfirstname.Name = "lbfirstname";
            this.lbfirstname.Size = new System.Drawing.Size(50, 16);
            this.lbfirstname.TabIndex = 29;
            this.lbfirstname.Text = "Etunimi";
            // 
            // Pvaraus
            // 
            this.Pvaraus.Controls.Add(this.tbhaku);
            this.Pvaraus.Controls.Add(this.button1);
            this.Pvaraus.Controls.Add(this.btnlisaapalveluvaraus);
            this.Pvaraus.Controls.Add(this.btnpoistavaraus);
            this.Pvaraus.Controls.Add(this.btnmuokkaavaraus);
            this.Pvaraus.Controls.Add(this.lbfirstname);
            this.Pvaraus.Controls.Add(this.btnperuutavaraus);
            this.Pvaraus.Controls.Add(this.btnlisaavaraus);
            this.Pvaraus.Controls.Add(this.tbvarausetunimi);
            this.Pvaraus.Controls.Add(this.lblastname);
            this.Pvaraus.Controls.Add(this.cbmokki);
            this.Pvaraus.Controls.Add(this.tbvaraussukunimi);
            this.Pvaraus.Controls.Add(this.cbalue);
            this.Pvaraus.Controls.Add(this.lbemail);
            this.Pvaraus.Controls.Add(this.tbvaraussahkoposti);
            this.Pvaraus.Controls.Add(this.dtplahtopaiva);
            this.Pvaraus.Controls.Add(this.lbphone);
            this.Pvaraus.Controls.Add(this.dtptulopaiva);
            this.Pvaraus.Controls.Add(this.tbvarauspuhelinnumero);
            this.Pvaraus.Controls.Add(this.lbcheckout);
            this.Pvaraus.Controls.Add(this.lbaddress);
            this.Pvaraus.Controls.Add(this.lblocation);
            this.Pvaraus.Controls.Add(this.tbvaraajanosoite);
            this.Pvaraus.Controls.Add(this.lbcottage);
            this.Pvaraus.Controls.Add(this.lbpostcode);
            this.Pvaraus.Controls.Add(this.lbcheckin);
            this.Pvaraus.Controls.Add(this.tbvaraajanpostinumero);
            this.Pvaraus.Location = new System.Drawing.Point(27, 97);
            this.Pvaraus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pvaraus.Name = "Pvaraus";
            this.Pvaraus.Size = new System.Drawing.Size(1195, 369);
            this.Pvaraus.TabIndex = 56;
            this.Pvaraus.Paint += new System.Windows.Forms.PaintEventHandler(this.Pvaraus_Paint);
            // 
            // tbhaku
            // 
            this.tbhaku.Location = new System.Drawing.Point(384, 223);
            this.tbhaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbhaku.Name = "tbhaku";
            this.tbhaku.Size = new System.Drawing.Size(100, 22);
            this.tbhaku.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 223);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Hae";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnlisaapalveluvaraus
            // 
            this.btnlisaapalveluvaraus.Location = new System.Drawing.Point(27, 245);
            this.btnlisaapalveluvaraus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlisaapalveluvaraus.Name = "btnlisaapalveluvaraus";
            this.btnlisaapalveluvaraus.Size = new System.Drawing.Size(80, 50);
            this.btnlisaapalveluvaraus.TabIndex = 47;
            this.btnlisaapalveluvaraus.Text = "Lisää palvelu";
            this.btnlisaapalveluvaraus.UseVisualStyleBackColor = true;
            // 
            // btnpoistavaraus
            // 
            this.btnpoistavaraus.Location = new System.Drawing.Point(227, 327);
            this.btnpoistavaraus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpoistavaraus.Name = "btnpoistavaraus";
            this.btnpoistavaraus.Size = new System.Drawing.Size(75, 23);
            this.btnpoistavaraus.TabIndex = 46;
            this.btnpoistavaraus.Text = "Poista";
            this.btnpoistavaraus.UseVisualStyleBackColor = true;
            this.btnpoistavaraus.Click += new System.EventHandler(this.btnpoistavaraus_Click);
            // 
            // btnmuokkaavaraus
            // 
            this.btnmuokkaavaraus.Location = new System.Drawing.Point(131, 272);
            this.btnmuokkaavaraus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuokkaavaraus.Name = "btnmuokkaavaraus";
            this.btnmuokkaavaraus.Size = new System.Drawing.Size(75, 23);
            this.btnmuokkaavaraus.TabIndex = 45;
            this.btnmuokkaavaraus.Text = "Muokkaa";
            this.btnmuokkaavaraus.UseVisualStyleBackColor = true;
            this.btnmuokkaavaraus.Click += new System.EventHandler(this.btnmuokkaavaraus_Click);
            // 
            // Plasku
            // 
            this.Plasku.Controls.Add(this.btnmuokkaalasku);
            this.Plasku.Controls.Add(this.btnpoistalasku);
            this.Plasku.Controls.Add(this.btnperuutalasku);
            this.Plasku.Controls.Add(this.btnlisaalasku);
            this.Plasku.Controls.Add(this.textBox15);
            this.Plasku.Controls.Add(this.textBox14);
            this.Plasku.Controls.Add(this.lbbillprice);
            this.Plasku.Controls.Add(this.lbbilltax);
            this.Plasku.Controls.Add(this.lbbillID);
            this.Plasku.Controls.Add(this.textBox13);
            this.Plasku.Location = new System.Drawing.Point(124, 354);
            this.Plasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Plasku.Name = "Plasku";
            this.Plasku.Size = new System.Drawing.Size(579, 370);
            this.Plasku.TabIndex = 46;
            // 
            // btnmuokkaalasku
            // 
            this.btnmuokkaalasku.Location = new System.Drawing.Point(192, 162);
            this.btnmuokkaalasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuokkaalasku.Name = "btnmuokkaalasku";
            this.btnmuokkaalasku.Size = new System.Drawing.Size(75, 23);
            this.btnmuokkaalasku.TabIndex = 6;
            this.btnmuokkaalasku.Text = "Muokkaa";
            this.btnmuokkaalasku.UseVisualStyleBackColor = true;
            this.btnmuokkaalasku.Click += new System.EventHandler(this.btnmuokkaalasku_Click);
            // 
            // btnpoistalasku
            // 
            this.btnpoistalasku.Location = new System.Drawing.Point(192, 193);
            this.btnpoistalasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpoistalasku.Name = "btnpoistalasku";
            this.btnpoistalasku.Size = new System.Drawing.Size(75, 23);
            this.btnpoistalasku.TabIndex = 7;
            this.btnpoistalasku.Text = "Poista";
            this.btnpoistalasku.UseVisualStyleBackColor = true;
            this.btnpoistalasku.Click += new System.EventHandler(this.btnpoistalasku_Click);
            // 
            // btnperuutalasku
            // 
            this.btnperuutalasku.Location = new System.Drawing.Point(51, 191);
            this.btnperuutalasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnperuutalasku.Name = "btnperuutalasku";
            this.btnperuutalasku.Size = new System.Drawing.Size(75, 23);
            this.btnperuutalasku.TabIndex = 5;
            this.btnperuutalasku.Text = "Peruuta";
            this.btnperuutalasku.UseVisualStyleBackColor = true;
            this.btnperuutalasku.Click += new System.EventHandler(this.btnperuutalasku_Click);
            // 
            // btnlisaalasku
            // 
            this.btnlisaalasku.Location = new System.Drawing.Point(51, 162);
            this.btnlisaalasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlisaalasku.Name = "btnlisaalasku";
            this.btnlisaalasku.Size = new System.Drawing.Size(75, 23);
            this.btnlisaalasku.TabIndex = 4;
            this.btnlisaalasku.Text = "Lisää";
            this.btnlisaalasku.UseVisualStyleBackColor = true;
            this.btnlisaalasku.Click += new System.EventHandler(this.btnlisaalasku_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(192, 71);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 2;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(192, 110);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 3;
            // 
            // lbbillprice
            // 
            this.lbbillprice.AutoSize = true;
            this.lbbillprice.Location = new System.Drawing.Point(47, 82);
            this.lbbillprice.Name = "lbbillprice";
            this.lbbillprice.Size = new System.Drawing.Size(53, 16);
            this.lbbillprice.TabIndex = 3;
            this.lbbillprice.Text = "Summa";
            // 
            // lbbilltax
            // 
            this.lbbilltax.AutoSize = true;
            this.lbbilltax.Location = new System.Drawing.Point(47, 114);
            this.lbbilltax.Name = "lbbilltax";
            this.lbbilltax.Size = new System.Drawing.Size(26, 16);
            this.lbbilltax.TabIndex = 2;
            this.lbbilltax.Text = "Alv";
            // 
            // lbbillID
            // 
            this.lbbillID.AutoSize = true;
            this.lbbillID.Location = new System.Drawing.Point(47, 47);
            this.lbbillID.Name = "lbbillID";
            this.lbbillID.Size = new System.Drawing.Size(66, 16);
            this.lbbillID.TabIndex = 1;
            this.lbbillID.Text = "Varaus ID";
            this.lbbillID.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(192, 41);
            this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 1;
            // 
            // Ppalvelu
            // 
            this.Ppalvelu.Controls.Add(this.btnpoistapalvelu);
            this.Ppalvelu.Controls.Add(this.btnmuokkaapalvelu);
            this.Ppalvelu.Controls.Add(this.tbpalveluhinta);
            this.Ppalvelu.Controls.Add(this.tbpalvelukuvaus);
            this.Ppalvelu.Controls.Add(this.tbpalvelutyyppi);
            this.Ppalvelu.Controls.Add(this.tbpalvelualv);
            this.Ppalvelu.Controls.Add(this.tbpalvelunimi);
            this.Ppalvelu.Controls.Add(this.lbprice);
            this.Ppalvelu.Controls.Add(this.lbkuvaus);
            this.Ppalvelu.Controls.Add(this.lbtype);
            this.Ppalvelu.Controls.Add(this.lbtax);
            this.Ppalvelu.Controls.Add(this.lbname);
            this.Ppalvelu.Controls.Add(this.btnperuutapalvelu);
            this.Ppalvelu.Controls.Add(this.btnlisaapalvelu);
            this.Ppalvelu.Location = new System.Drawing.Point(27, 97);
            this.Ppalvelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ppalvelu.Name = "Ppalvelu";
            this.Ppalvelu.Size = new System.Drawing.Size(580, 370);
            this.Ppalvelu.TabIndex = 57;
            // 
            // btnpoistapalvelu
            // 
            this.btnpoistapalvelu.Location = new System.Drawing.Point(168, 284);
            this.btnpoistapalvelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpoistapalvelu.Name = "btnpoistapalvelu";
            this.btnpoistapalvelu.Size = new System.Drawing.Size(75, 23);
            this.btnpoistapalvelu.TabIndex = 9;
            this.btnpoistapalvelu.Text = "Poista";
            this.btnpoistapalvelu.UseVisualStyleBackColor = true;
            this.btnpoistapalvelu.Click += new System.EventHandler(this.btnpoistapalvelu_Click);
            // 
            // btnmuokkaapalvelu
            // 
            this.btnmuokkaapalvelu.Location = new System.Drawing.Point(168, 250);
            this.btnmuokkaapalvelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuokkaapalvelu.Name = "btnmuokkaapalvelu";
            this.btnmuokkaapalvelu.Size = new System.Drawing.Size(75, 23);
            this.btnmuokkaapalvelu.TabIndex = 8;
            this.btnmuokkaapalvelu.Text = "Muokkaa";
            this.btnmuokkaapalvelu.UseVisualStyleBackColor = true;
            this.btnmuokkaapalvelu.Click += new System.EventHandler(this.btnmuokkaapalvelu_Click);
            // 
            // tbpalveluhinta
            // 
            this.tbpalveluhinta.Location = new System.Drawing.Point(143, 158);
            this.tbpalveluhinta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpalveluhinta.Name = "tbpalveluhinta";
            this.tbpalveluhinta.Size = new System.Drawing.Size(100, 22);
            this.tbpalveluhinta.TabIndex = 5;
            // 
            // tbpalvelukuvaus
            // 
            this.tbpalvelukuvaus.Location = new System.Drawing.Point(143, 62);
            this.tbpalvelukuvaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpalvelukuvaus.Name = "tbpalvelukuvaus";
            this.tbpalvelukuvaus.Size = new System.Drawing.Size(100, 22);
            this.tbpalvelukuvaus.TabIndex = 2;
            // 
            // tbpalvelutyyppi
            // 
            this.tbpalvelutyyppi.Location = new System.Drawing.Point(143, 95);
            this.tbpalvelutyyppi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpalvelutyyppi.Name = "tbpalvelutyyppi";
            this.tbpalvelutyyppi.Size = new System.Drawing.Size(100, 22);
            this.tbpalvelutyyppi.TabIndex = 3;
            // 
            // tbpalvelualv
            // 
            this.tbpalvelualv.Location = new System.Drawing.Point(143, 124);
            this.tbpalvelualv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpalvelualv.Name = "tbpalvelualv";
            this.tbpalvelualv.ReadOnly = true;
            this.tbpalvelualv.Size = new System.Drawing.Size(100, 22);
            this.tbpalvelualv.TabIndex = 4;
            this.tbpalvelualv.Text = "24";
            // 
            // tbpalvelunimi
            // 
            this.tbpalvelunimi.Location = new System.Drawing.Point(143, 30);
            this.tbpalvelunimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpalvelunimi.Name = "tbpalvelunimi";
            this.tbpalvelunimi.Size = new System.Drawing.Size(100, 22);
            this.tbpalvelunimi.TabIndex = 1;
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(27, 165);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(38, 16);
            this.lbprice.TabIndex = 6;
            this.lbprice.Text = "Hinta";
            // 
            // lbkuvaus
            // 
            this.lbkuvaus.AutoSize = true;
            this.lbkuvaus.Location = new System.Drawing.Point(27, 68);
            this.lbkuvaus.Name = "lbkuvaus";
            this.lbkuvaus.Size = new System.Drawing.Size(51, 16);
            this.lbkuvaus.TabIndex = 5;
            this.lbkuvaus.Text = "Kuvaus";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(21, 101);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(49, 16);
            this.lbtype.TabIndex = 4;
            this.lbtype.Text = "Tyyppi";
            // 
            // lbtax
            // 
            this.lbtax.AutoSize = true;
            this.lbtax.Location = new System.Drawing.Point(27, 132);
            this.lbtax.Name = "lbtax";
            this.lbtax.Size = new System.Drawing.Size(26, 16);
            this.lbtax.TabIndex = 3;
            this.lbtax.Text = "Alv";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(25, 30);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(34, 16);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "Nimi";
            // 
            // btnperuutapalvelu
            // 
            this.btnperuutapalvelu.Location = new System.Drawing.Point(32, 284);
            this.btnperuutapalvelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnperuutapalvelu.Name = "btnperuutapalvelu";
            this.btnperuutapalvelu.Size = new System.Drawing.Size(75, 31);
            this.btnperuutapalvelu.TabIndex = 7;
            this.btnperuutapalvelu.Text = "Peruuta";
            this.btnperuutapalvelu.UseVisualStyleBackColor = true;
            this.btnperuutapalvelu.Click += new System.EventHandler(this.btnperuutapalvelu_Click);
            // 
            // btnlisaapalvelu
            // 
            this.btnlisaapalvelu.Location = new System.Drawing.Point(32, 250);
            this.btnlisaapalvelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlisaapalvelu.Name = "btnlisaapalvelu";
            this.btnlisaapalvelu.Size = new System.Drawing.Size(75, 23);
            this.btnlisaapalvelu.TabIndex = 6;
            this.btnlisaapalvelu.Text = "Lisää";
            this.btnlisaapalvelu.UseVisualStyleBackColor = true;
            this.btnlisaapalvelu.Click += new System.EventHandler(this.btnlisaapalvelu_Click);
            // 
            // Pasiakas
            // 
            this.Pasiakas.Controls.Add(this.btnmuokkaa);
            this.Pasiakas.Controls.Add(this.btnpoistaasiakas);
            this.Pasiakas.Controls.Add(this.tbasiakaspostinum);
            this.Pasiakas.Controls.Add(this.tbasiakasosoite);
            this.Pasiakas.Controls.Add(this.tbasiakaspuhnum);
            this.Pasiakas.Controls.Add(this.tbasiakassposti);
            this.Pasiakas.Controls.Add(this.tbasiakassnimi);
            this.Pasiakas.Controls.Add(this.tbasiakasnimi);
            this.Pasiakas.Controls.Add(this.btnasiakasperuuta);
            this.Pasiakas.Controls.Add(this.btnasiakaslisaa);
            this.Pasiakas.Controls.Add(this.lbcustomerlname);
            this.Pasiakas.Controls.Add(this.lbcustomeremail);
            this.Pasiakas.Controls.Add(this.lbcustormerphone);
            this.Pasiakas.Controls.Add(this.lbcustomerpostcode);
            this.Pasiakas.Controls.Add(this.lbcustomeraddress);
            this.Pasiakas.Controls.Add(this.lbcustomerfname);
            this.Pasiakas.Location = new System.Drawing.Point(27, 97);
            this.Pasiakas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pasiakas.Name = "Pasiakas";
            this.Pasiakas.Size = new System.Drawing.Size(579, 370);
            this.Pasiakas.TabIndex = 45;
            // 
            // btnmuokkaa
            // 
            this.btnmuokkaa.Location = new System.Drawing.Point(168, 268);
            this.btnmuokkaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuokkaa.Name = "btnmuokkaa";
            this.btnmuokkaa.Size = new System.Drawing.Size(84, 30);
            this.btnmuokkaa.TabIndex = 9;
            this.btnmuokkaa.Text = "Muokkaa";
            this.btnmuokkaa.UseVisualStyleBackColor = true;
            this.btnmuokkaa.Click += new System.EventHandler(this.btnmuokkaa_Click);
            // 
            // btnpoistaasiakas
            // 
            this.btnpoistaasiakas.Location = new System.Drawing.Point(168, 303);
            this.btnpoistaasiakas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpoistaasiakas.Name = "btnpoistaasiakas";
            this.btnpoistaasiakas.Size = new System.Drawing.Size(84, 30);
            this.btnpoistaasiakas.TabIndex = 10;
            this.btnpoistaasiakas.Text = "Poista";
            this.btnpoistaasiakas.UseVisualStyleBackColor = true;
            this.btnpoistaasiakas.Click += new System.EventHandler(this.btnpoistaasiakas_Click);
            // 
            // tbasiakaspostinum
            // 
            this.tbasiakaspostinum.Location = new System.Drawing.Point(203, 194);
            this.tbasiakaspostinum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbasiakaspostinum.Name = "tbasiakaspostinum";
            this.tbasiakaspostinum.Size = new System.Drawing.Size(100, 22);
            this.tbasiakaspostinum.TabIndex = 6;
            // 
            // tbasiakasosoite
            // 
            this.tbasiakasosoite.Location = new System.Drawing.Point(203, 165);
            this.tbasiakasosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbasiakasosoite.Name = "tbasiakasosoite";
            this.tbasiakasosoite.Size = new System.Drawing.Size(100, 22);
            this.tbasiakasosoite.TabIndex = 5;
            // 
            // tbasiakaspuhnum
            // 
            this.tbasiakaspuhnum.Location = new System.Drawing.Point(203, 97);
            this.tbasiakaspuhnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbasiakaspuhnum.Name = "tbasiakaspuhnum";
            this.tbasiakaspuhnum.Size = new System.Drawing.Size(100, 22);
            this.tbasiakaspuhnum.TabIndex = 3;
            // 
            // tbasiakassposti
            // 
            this.tbasiakassposti.Location = new System.Drawing.Point(203, 132);
            this.tbasiakassposti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbasiakassposti.Name = "tbasiakassposti";
            this.tbasiakassposti.Size = new System.Drawing.Size(100, 22);
            this.tbasiakassposti.TabIndex = 4;
            // 
            // tbasiakassnimi
            // 
            this.tbasiakassnimi.Location = new System.Drawing.Point(203, 63);
            this.tbasiakassnimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbasiakassnimi.Name = "tbasiakassnimi";
            this.tbasiakassnimi.Size = new System.Drawing.Size(100, 22);
            this.tbasiakassnimi.TabIndex = 2;
            // 
            // tbasiakasnimi
            // 
            this.tbasiakasnimi.Location = new System.Drawing.Point(203, 30);
            this.tbasiakasnimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbasiakasnimi.Name = "tbasiakasnimi";
            this.tbasiakasnimi.Size = new System.Drawing.Size(100, 22);
            this.tbasiakasnimi.TabIndex = 1;
            // 
            // btnasiakasperuuta
            // 
            this.btnasiakasperuuta.Location = new System.Drawing.Point(35, 303);
            this.btnasiakasperuuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnasiakasperuuta.Name = "btnasiakasperuuta";
            this.btnasiakasperuuta.Size = new System.Drawing.Size(75, 31);
            this.btnasiakasperuuta.TabIndex = 8;
            this.btnasiakasperuuta.Text = "Peruuta";
            this.btnasiakasperuuta.UseVisualStyleBackColor = true;
            this.btnasiakasperuuta.Click += new System.EventHandler(this.btnasiakasperuuta_Click);
            // 
            // btnasiakaslisaa
            // 
            this.btnasiakaslisaa.Location = new System.Drawing.Point(35, 268);
            this.btnasiakaslisaa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnasiakaslisaa.Name = "btnasiakaslisaa";
            this.btnasiakaslisaa.Size = new System.Drawing.Size(75, 31);
            this.btnasiakaslisaa.TabIndex = 7;
            this.btnasiakaslisaa.Text = "Lisää";
            this.btnasiakaslisaa.UseVisualStyleBackColor = true;
            this.btnasiakaslisaa.Click += new System.EventHandler(this.btnasiakaslisaa_Click);
            // 
            // lbcustomerlname
            // 
            this.lbcustomerlname.AutoSize = true;
            this.lbcustomerlname.Location = new System.Drawing.Point(48, 69);
            this.lbcustomerlname.Name = "lbcustomerlname";
            this.lbcustomerlname.Size = new System.Drawing.Size(61, 16);
            this.lbcustomerlname.TabIndex = 5;
            this.lbcustomerlname.Text = "Sukunimi";
            // 
            // lbcustomeremail
            // 
            this.lbcustomeremail.AutoSize = true;
            this.lbcustomeremail.Location = new System.Drawing.Point(48, 137);
            this.lbcustomeremail.Name = "lbcustomeremail";
            this.lbcustomeremail.Size = new System.Drawing.Size(75, 16);
            this.lbcustomeremail.TabIndex = 4;
            this.lbcustomeremail.Text = "Sähköposti";
            // 
            // lbcustormerphone
            // 
            this.lbcustormerphone.AutoSize = true;
            this.lbcustormerphone.Location = new System.Drawing.Point(48, 101);
            this.lbcustormerphone.Name = "lbcustormerphone";
            this.lbcustormerphone.Size = new System.Drawing.Size(96, 16);
            this.lbcustormerphone.TabIndex = 3;
            this.lbcustormerphone.Text = "Puhelinnumero";
            // 
            // lbcustomerpostcode
            // 
            this.lbcustomerpostcode.AutoSize = true;
            this.lbcustomerpostcode.Location = new System.Drawing.Point(48, 202);
            this.lbcustomerpostcode.Name = "lbcustomerpostcode";
            this.lbcustomerpostcode.Size = new System.Drawing.Size(82, 16);
            this.lbcustomerpostcode.TabIndex = 2;
            this.lbcustomerpostcode.Text = "Postinumero";
            // 
            // lbcustomeraddress
            // 
            this.lbcustomeraddress.AutoSize = true;
            this.lbcustomeraddress.Location = new System.Drawing.Point(48, 167);
            this.lbcustomeraddress.Name = "lbcustomeraddress";
            this.lbcustomeraddress.Size = new System.Drawing.Size(69, 16);
            this.lbcustomeraddress.TabIndex = 1;
            this.lbcustomeraddress.Text = "Lähiosoite";
            // 
            // lbcustomerfname
            // 
            this.lbcustomerfname.AutoSize = true;
            this.lbcustomerfname.Location = new System.Drawing.Point(48, 31);
            this.lbcustomerfname.Name = "lbcustomerfname";
            this.lbcustomerfname.Size = new System.Drawing.Size(50, 16);
            this.lbcustomerfname.TabIndex = 0;
            this.lbcustomerfname.Text = "Etunimi";
            // 
            // Palue
            // 
            this.Palue.Controls.Add(this.btnpoistaalue);
            this.Palue.Controls.Add(this.Plasku);
            this.Palue.Controls.Add(this.btnmuokkaaalue);
            this.Palue.Controls.Add(this.btnperuutaalue);
            this.Palue.Controls.Add(this.btnlisaaalue);
            this.Palue.Controls.Add(this.tbaluenimi);
            this.Palue.Controls.Add(this.lblocationname);
            this.Palue.Location = new System.Drawing.Point(27, 97);
            this.Palue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Palue.Name = "Palue";
            this.Palue.Size = new System.Drawing.Size(580, 370);
            this.Palue.TabIndex = 14;
            // 
            // btnpoistaalue
            // 
            this.btnpoistaalue.Location = new System.Drawing.Point(181, 190);
            this.btnpoistaalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpoistaalue.Name = "btnpoistaalue";
            this.btnpoistaalue.Size = new System.Drawing.Size(75, 23);
            this.btnpoistaalue.TabIndex = 5;
            this.btnpoistaalue.Text = "Poista";
            this.btnpoistaalue.UseVisualStyleBackColor = true;
            this.btnpoistaalue.Click += new System.EventHandler(this.btnpoistaalue_Click);
            // 
            // btnmuokkaaalue
            // 
            this.btnmuokkaaalue.Location = new System.Drawing.Point(181, 158);
            this.btnmuokkaaalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuokkaaalue.Name = "btnmuokkaaalue";
            this.btnmuokkaaalue.Size = new System.Drawing.Size(75, 23);
            this.btnmuokkaaalue.TabIndex = 4;
            this.btnmuokkaaalue.Text = "Muokkaa";
            this.btnmuokkaaalue.UseVisualStyleBackColor = true;
            this.btnmuokkaaalue.Click += new System.EventHandler(this.btnmuokkaaalue_Click);
            // 
            // btnperuutaalue
            // 
            this.btnperuutaalue.Location = new System.Drawing.Point(51, 187);
            this.btnperuutaalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnperuutaalue.Name = "btnperuutaalue";
            this.btnperuutaalue.Size = new System.Drawing.Size(75, 23);
            this.btnperuutaalue.TabIndex = 3;
            this.btnperuutaalue.Text = "Peruuta";
            this.btnperuutaalue.UseVisualStyleBackColor = true;
            this.btnperuutaalue.Click += new System.EventHandler(this.btnperuutaalue_Click);
            // 
            // btnlisaaalue
            // 
            this.btnlisaaalue.Location = new System.Drawing.Point(51, 158);
            this.btnlisaaalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlisaaalue.Name = "btnlisaaalue";
            this.btnlisaaalue.Size = new System.Drawing.Size(75, 23);
            this.btnlisaaalue.TabIndex = 2;
            this.btnlisaaalue.Text = "Lisää";
            this.btnlisaaalue.UseVisualStyleBackColor = true;
            this.btnlisaaalue.Click += new System.EventHandler(this.btnlisaaalue_Click);
            // 
            // tbaluenimi
            // 
            this.tbaluenimi.Location = new System.Drawing.Point(143, 43);
            this.tbaluenimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbaluenimi.Name = "tbaluenimi";
            this.tbaluenimi.Size = new System.Drawing.Size(100, 22);
            this.tbaluenimi.TabIndex = 1;
            // 
            // lblocationname
            // 
            this.lblocationname.AutoSize = true;
            this.lblocationname.Location = new System.Drawing.Point(48, 50);
            this.lblocationname.Name = "lblocationname";
            this.lblocationname.Size = new System.Drawing.Size(76, 16);
            this.lblocationname.TabIndex = 0;
            this.lblocationname.Text = "Alueen nimi";
            // 
            // Pmokki
            // 
            this.Pmokki.Controls.Add(this.btnpoistamokki);
            this.Pmokki.Controls.Add(this.btnmuokkaamokki);
            this.Pmokki.Controls.Add(this.tbmokkihinta);
            this.Pmokki.Controls.Add(this.tbmokkinimi);
            this.Pmokki.Controls.Add(this.tbmokkiosoite);
            this.Pmokki.Controls.Add(this.tbmokkivarustelu);
            this.Pmokki.Controls.Add(this.tbmokkikuvaus);
            this.Pmokki.Controls.Add(this.tbmokkipostinumero);
            this.Pmokki.Controls.Add(this.tbmokkialuenimi);
            this.Pmokki.Controls.Add(this.lbvarutelu);
            this.Pmokki.Controls.Add(this.btnperuutamokki);
            this.Pmokki.Controls.Add(this.btnlisaamokki);
            this.Pmokki.Controls.Add(this.lbcottagename);
            this.Pmokki.Controls.Add(this.lbcottageaddress);
            this.Pmokki.Controls.Add(this.lbcottagepostcode);
            this.Pmokki.Controls.Add(this.lbcottageprice);
            this.Pmokki.Controls.Add(this.lbdescription);
            this.Pmokki.Controls.Add(this.lbloactio);
            this.Pmokki.Location = new System.Drawing.Point(27, 97);
            this.Pmokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pmokki.Name = "Pmokki";
            this.Pmokki.Size = new System.Drawing.Size(605, 370);
            this.Pmokki.TabIndex = 58;
            // 
            // btnpoistamokki
            // 
            this.btnpoistamokki.Location = new System.Drawing.Point(168, 295);
            this.btnpoistamokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpoistamokki.Name = "btnpoistamokki";
            this.btnpoistamokki.Size = new System.Drawing.Size(75, 23);
            this.btnpoistamokki.TabIndex = 10;
            this.btnpoistamokki.Text = "Poista";
            this.btnpoistamokki.UseVisualStyleBackColor = true;
            // 
            // btnmuokkaamokki
            // 
            this.btnmuokkaamokki.Location = new System.Drawing.Point(168, 247);
            this.btnmuokkaamokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmuokkaamokki.Name = "btnmuokkaamokki";
            this.btnmuokkaamokki.Size = new System.Drawing.Size(75, 23);
            this.btnmuokkaamokki.TabIndex = 9;
            this.btnmuokkaamokki.Text = "Muokkaa";
            this.btnmuokkaamokki.UseVisualStyleBackColor = true;
            // 
            // tbmokkihinta
            // 
            this.tbmokkihinta.Location = new System.Drawing.Point(379, 123);
            this.tbmokkihinta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkihinta.Name = "tbmokkihinta";
            this.tbmokkihinta.Size = new System.Drawing.Size(100, 22);
            this.tbmokkihinta.TabIndex = 7;
            // 
            // tbmokkinimi
            // 
            this.tbmokkinimi.Location = new System.Drawing.Point(143, 86);
            this.tbmokkinimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkinimi.Name = "tbmokkinimi";
            this.tbmokkinimi.Size = new System.Drawing.Size(100, 22);
            this.tbmokkinimi.TabIndex = 2;
            // 
            // tbmokkiosoite
            // 
            this.tbmokkiosoite.Location = new System.Drawing.Point(143, 123);
            this.tbmokkiosoite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkiosoite.Name = "tbmokkiosoite";
            this.tbmokkiosoite.Size = new System.Drawing.Size(100, 22);
            this.tbmokkiosoite.TabIndex = 3;
            // 
            // tbmokkivarustelu
            // 
            this.tbmokkivarustelu.Location = new System.Drawing.Point(379, 55);
            this.tbmokkivarustelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkivarustelu.Name = "tbmokkivarustelu";
            this.tbmokkivarustelu.Size = new System.Drawing.Size(100, 22);
            this.tbmokkivarustelu.TabIndex = 5;
            // 
            // tbmokkikuvaus
            // 
            this.tbmokkikuvaus.Location = new System.Drawing.Point(379, 86);
            this.tbmokkikuvaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkikuvaus.Name = "tbmokkikuvaus";
            this.tbmokkikuvaus.Size = new System.Drawing.Size(100, 22);
            this.tbmokkikuvaus.TabIndex = 6;
            // 
            // tbmokkipostinumero
            // 
            this.tbmokkipostinumero.Location = new System.Drawing.Point(143, 161);
            this.tbmokkipostinumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkipostinumero.Name = "tbmokkipostinumero";
            this.tbmokkipostinumero.Size = new System.Drawing.Size(100, 22);
            this.tbmokkipostinumero.TabIndex = 4;
            // 
            // tbmokkialuenimi
            // 
            this.tbmokkialuenimi.Location = new System.Drawing.Point(143, 55);
            this.tbmokkialuenimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmokkialuenimi.Name = "tbmokkialuenimi";
            this.tbmokkialuenimi.Size = new System.Drawing.Size(100, 22);
            this.tbmokkialuenimi.TabIndex = 1;
            // 
            // lbvarutelu
            // 
            this.lbvarutelu.AutoSize = true;
            this.lbvarutelu.Location = new System.Drawing.Point(267, 59);
            this.lbvarutelu.Name = "lbvarutelu";
            this.lbvarutelu.Size = new System.Drawing.Size(63, 16);
            this.lbvarutelu.TabIndex = 8;
            this.lbvarutelu.Text = "Varustelu";
            // 
            // btnperuutamokki
            // 
            this.btnperuutamokki.Location = new System.Drawing.Point(28, 295);
            this.btnperuutamokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnperuutamokki.Name = "btnperuutamokki";
            this.btnperuutamokki.Size = new System.Drawing.Size(75, 30);
            this.btnperuutamokki.TabIndex = 8;
            this.btnperuutamokki.Text = "Peruuta";
            this.btnperuutamokki.UseVisualStyleBackColor = true;
            // 
            // btnlisaamokki
            // 
            this.btnlisaamokki.Location = new System.Drawing.Point(29, 247);
            this.btnlisaamokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlisaamokki.Name = "btnlisaamokki";
            this.btnlisaamokki.Size = new System.Drawing.Size(75, 23);
            this.btnlisaamokki.TabIndex = 7;
            this.btnlisaamokki.Text = "Lisää";
            this.btnlisaamokki.UseVisualStyleBackColor = true;
            // 
            // lbcottagename
            // 
            this.lbcottagename.AutoSize = true;
            this.lbcottagename.Location = new System.Drawing.Point(25, 86);
            this.lbcottagename.Name = "lbcottagename";
            this.lbcottagename.Size = new System.Drawing.Size(70, 16);
            this.lbcottagename.TabIndex = 5;
            this.lbcottagename.Text = "Mökin nimi";
            // 
            // lbcottageaddress
            // 
            this.lbcottageaddress.AutoSize = true;
            this.lbcottageaddress.Location = new System.Drawing.Point(25, 121);
            this.lbcottageaddress.Name = "lbcottageaddress";
            this.lbcottageaddress.Size = new System.Drawing.Size(70, 16);
            this.lbcottageaddress.TabIndex = 4;
            this.lbcottageaddress.Text = "Katuosoite";
            // 
            // lbcottagepostcode
            // 
            this.lbcottagepostcode.AutoSize = true;
            this.lbcottagepostcode.Location = new System.Drawing.Point(25, 165);
            this.lbcottagepostcode.Name = "lbcottagepostcode";
            this.lbcottagepostcode.Size = new System.Drawing.Size(82, 16);
            this.lbcottagepostcode.TabIndex = 3;
            this.lbcottagepostcode.Text = "Postinumero";
            // 
            // lbcottageprice
            // 
            this.lbcottageprice.AutoSize = true;
            this.lbcottageprice.Location = new System.Drawing.Point(267, 127);
            this.lbcottageprice.Name = "lbcottageprice";
            this.lbcottageprice.Size = new System.Drawing.Size(38, 16);
            this.lbcottageprice.TabIndex = 2;
            this.lbcottageprice.Text = "Hinta";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(267, 96);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(51, 16);
            this.lbdescription.TabIndex = 1;
            this.lbdescription.Text = "Kuvaus";
            // 
            // lbloactio
            // 
            this.lbloactio.AutoSize = true;
            this.lbloactio.Location = new System.Drawing.Point(25, 53);
            this.lbloactio.Name = "lbloactio";
            this.lbloactio.Size = new System.Drawing.Size(34, 16);
            this.lbloactio.TabIndex = 0;
            this.lbloactio.Text = "Alue";
            // 
            // aikajaksobtn
            // 
            this.aikajaksobtn.Location = new System.Drawing.Point(1097, 878);
            this.aikajaksobtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aikajaksobtn.Name = "aikajaksobtn";
            this.aikajaksobtn.Size = new System.Drawing.Size(123, 28);
            this.aikajaksobtn.TabIndex = 59;
            this.aikajaksobtn.Text = "Aikajaksoraportit";
            this.aikajaksobtn.UseVisualStyleBackColor = true;
            this.aikajaksobtn.Click += new System.EventHandler(this.aikajaksobtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSeparator6,
            this.tsbtnalueetjamökit,
            this.toolStripSeparator1,
            this.tsbtnasiakkaat,
            this.toolStripSeparator2,
            this.tsbtnvaraukset,
            this.toolStripSeparator3,
            this.tsbtnlaskut,
            this.toolStripSeparator4,
            this.tsbtnpalvelut,
            this.toolStripSeparator5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 31);
            this.toolStrip1.TabIndex = 60;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jotainToolStripMenuItem,
            this.suljeToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(75, 28);
            this.toolStripSplitButton1.Text = "Valikko";
            // 
            // jotainToolStripMenuItem
            // 
            this.jotainToolStripMenuItem.Name = "jotainToolStripMenuItem";
            this.jotainToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.jotainToolStripMenuItem.Text = "Tiedostopolku";
            this.jotainToolStripMenuItem.Click += new System.EventHandler(this.jotainToolStripMenuItem_Click);
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.suljeToolStripMenuItem.Text = "Sulje";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnalueetjamökit
            // 
            this.tsbtnalueetjamökit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnalueetjamökit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnalueetjamökit.Image")));
            this.tsbtnalueetjamökit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnalueetjamökit.Name = "tsbtnalueetjamökit";
            this.tsbtnalueetjamökit.Size = new System.Drawing.Size(114, 24);
            this.tsbtnalueetjamökit.Text = "Alueet ja mökit";
            this.tsbtnalueetjamökit.Click += new System.EventHandler(this.tsbtnalueetjamökit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnasiakkaat
            // 
            this.tsbtnasiakkaat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnasiakkaat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnasiakkaat.Image")));
            this.tsbtnasiakkaat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnasiakkaat.Name = "tsbtnasiakkaat";
            this.tsbtnasiakkaat.Size = new System.Drawing.Size(76, 24);
            this.tsbtnasiakkaat.Text = "Asiakkaat";
            this.tsbtnasiakkaat.Click += new System.EventHandler(this.tsbtnasiakkaat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnvaraukset
            // 
            this.tsbtnvaraukset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnvaraukset.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnvaraukset.Image")));
            this.tsbtnvaraukset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnvaraukset.Name = "tsbtnvaraukset";
            this.tsbtnvaraukset.Size = new System.Drawing.Size(76, 24);
            this.tsbtnvaraukset.Text = "Varaukset";
            this.tsbtnvaraukset.Click += new System.EventHandler(this.tsbtnvaraukset_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnlaskut
            // 
            this.tsbtnlaskut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnlaskut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnlaskut.Image")));
            this.tsbtnlaskut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnlaskut.Name = "tsbtnlaskut";
            this.tsbtnlaskut.Size = new System.Drawing.Size(54, 24);
            this.tsbtnlaskut.Text = "Laskut";
            this.tsbtnlaskut.Click += new System.EventHandler(this.tsbtnlaskut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbtnpalvelut
            // 
            this.tsbtnpalvelut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnpalvelut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnpalvelut.Image")));
            this.tsbtnpalvelut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnpalvelut.Name = "tsbtnpalvelut";
            this.tsbtnpalvelut.Size = new System.Drawing.Size(64, 24);
            this.tsbtnpalvelut.Text = "Palvelut";
            this.tsbtnpalvelut.Click += new System.EventHandler(this.tsbtnpalvelut_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Pasiakas);
            this.Controls.Add(this.Ppalvelu);
            this.Controls.Add(this.aikajaksobtn);
            this.Controls.Add(this.Palue);
            this.Controls.Add(this.Pmokki);
            this.Controls.Add(this.taulunimi);
            this.Controls.Add(this.Pvaraus);
            this.Controls.Add(this.lisaabtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskubtn);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(20, 70);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mökking - mökkivaraustenhallintajärjestelmä";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            this.Pvaraus.ResumeLayout(false);
            this.Pvaraus.PerformLayout();
            this.Plasku.ResumeLayout(false);
            this.Plasku.PerformLayout();
            this.Ppalvelu.ResumeLayout(false);
            this.Ppalvelu.PerformLayout();
            this.Pasiakas.ResumeLayout(false);
            this.Pasiakas.PerformLayout();
            this.Palue.ResumeLayout(false);
            this.Palue.PerformLayout();
            this.Pmokki.ResumeLayout(false);
            this.Pmokki.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mokkingDBDataSetBindingSource;
        private MokkingDBDataSet mokkingDBDataSet;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private MokkingDBDataSetTableAdapters.asiakasTableAdapter asiakasTableAdapter;
        private System.Windows.Forms.BindingSource asiakasBindingSource1;
        private System.Windows.Forms.BindingSource mokkingDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource asiakasBindingSource2;
        private MokkingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private MokkingDBDataSetTableAdapters.mokkiTableAdapter mokkiTableAdapter;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private MokkingDBDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private System.Windows.Forms.Button laskubtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lisaabtn;
        private System.Windows.Forms.Label taulunimi;
        private System.Windows.Forms.ComboBox cbmokki;
        private System.Windows.Forms.ComboBox cbalue;
        private System.Windows.Forms.Button btnperuutavaraus;
        private System.Windows.Forms.Button btnlisaavaraus;
        private System.Windows.Forms.DateTimePicker dtplahtopaiva;
        private System.Windows.Forms.DateTimePicker dtptulopaiva;
        private System.Windows.Forms.Label lbcheckout;
        private System.Windows.Forms.Label lblocation;
        private System.Windows.Forms.Label lbcottage;
        private System.Windows.Forms.Label lbcheckin;
        private System.Windows.Forms.TextBox tbvaraajanosoite;
        private System.Windows.Forms.TextBox tbvarauspuhelinnumero;
        private System.Windows.Forms.TextBox tbvaraajanpostinumero;
        private System.Windows.Forms.TextBox tbvaraussukunimi;
        private System.Windows.Forms.TextBox tbvaraussahkoposti;
        private System.Windows.Forms.TextBox tbvarausetunimi;
        private System.Windows.Forms.Label lbpostcode;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbphone;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lblastname;
        private System.Windows.Forms.Label lbfirstname;
        private System.Windows.Forms.Panel Pvaraus;
        private System.Windows.Forms.Panel Ppalvelu;
        private System.Windows.Forms.Panel Pmokki;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbkuvaus;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbtax;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btnperuutapalvelu;
        private System.Windows.Forms.Button btnlisaapalvelu;
        private System.Windows.Forms.TextBox tbpalveluhinta;
        private System.Windows.Forms.TextBox tbpalvelukuvaus;
        private System.Windows.Forms.TextBox tbpalvelutyyppi;
        private System.Windows.Forms.TextBox tbpalvelualv;
        private System.Windows.Forms.TextBox tbpalvelunimi;
        private System.Windows.Forms.Label lbcottagename;
        private System.Windows.Forms.Label lbcottageaddress;
        private System.Windows.Forms.Label lbcottagepostcode;
        private System.Windows.Forms.Label lbcottageprice;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Label lbloactio;
        private System.Windows.Forms.TextBox tbmokkihinta;
        private System.Windows.Forms.TextBox tbmokkinimi;
        private System.Windows.Forms.TextBox tbmokkiosoite;
        private System.Windows.Forms.TextBox tbmokkivarustelu;
        private System.Windows.Forms.TextBox tbmokkikuvaus;
        private System.Windows.Forms.TextBox tbmokkipostinumero;
        private System.Windows.Forms.TextBox tbmokkialuenimi;
        private System.Windows.Forms.Label lbvarutelu;
        private System.Windows.Forms.Button btnperuutamokki;
        private System.Windows.Forms.Button btnlisaamokki;
        private System.Windows.Forms.Panel Pasiakas;
        private System.Windows.Forms.Panel Plasku;
        private System.Windows.Forms.Label lbbillID;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label lbbillprice;
        private System.Windows.Forms.Label lbbilltax;
        private System.Windows.Forms.Button btnperuutalasku;
        private System.Windows.Forms.Button btnlisaalasku;
        private System.Windows.Forms.Label lbcustomeraddress;
        private System.Windows.Forms.Label lbcustomerfname;
        private System.Windows.Forms.Label lbcustomerlname;
        private System.Windows.Forms.Label lbcustomeremail;
        private System.Windows.Forms.Label lbcustormerphone;
        private System.Windows.Forms.Label lbcustomerpostcode;
        private System.Windows.Forms.TextBox tbasiakaspostinum;
        private System.Windows.Forms.TextBox tbasiakasosoite;
        private System.Windows.Forms.TextBox tbasiakaspuhnum;
        private System.Windows.Forms.TextBox tbasiakassposti;
        private System.Windows.Forms.TextBox tbasiakassnimi;
        private System.Windows.Forms.TextBox tbasiakasnimi;
        private System.Windows.Forms.Button btnasiakasperuuta;
        private System.Windows.Forms.Button btnasiakaslisaa;
        private System.Windows.Forms.Panel Palue;
        private System.Windows.Forms.Button btnperuutaalue;
        private System.Windows.Forms.Button btnlisaaalue;
        private System.Windows.Forms.TextBox tbaluenimi;
        private System.Windows.Forms.Label lblocationname;
        private System.Windows.Forms.Button aikajaksobtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem jotainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtnalueetjamökit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnasiakkaat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnvaraukset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnlaskut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnpalvelut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Button btnmuokkaa;
        private System.Windows.Forms.Button btnpoistaasiakas;
        private System.Windows.Forms.Button btnmuokkaalasku;
        private System.Windows.Forms.Button btnpoistalasku;
        private System.Windows.Forms.Button btnpoistaalue;
        private System.Windows.Forms.Button btnmuokkaaalue;
        private System.Windows.Forms.Button btnpoistapalvelu;
        private System.Windows.Forms.Button btnmuokkaapalvelu;
        private System.Windows.Forms.Button btnpoistamokki;
        private System.Windows.Forms.Button btnmuokkaamokki;
        private System.Windows.Forms.TextBox tbhaku;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlisaapalveluvaraus;
        private System.Windows.Forms.Button btnpoistavaraus;
        private System.Windows.Forms.Button btnmuokkaavaraus;
    }
}

