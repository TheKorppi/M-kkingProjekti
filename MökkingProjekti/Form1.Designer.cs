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
            this.cbcottage = new System.Windows.Forms.ComboBox();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.btnperuutavaraus = new System.Windows.Forms.Button();
            this.btnlisaavaraus = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbcheckout = new System.Windows.Forms.Label();
            this.lblocation = new System.Windows.Forms.Label();
            this.lbcottage = new System.Windows.Forms.Label();
            this.lbcheckin = new System.Windows.Forms.Label();
            this.tbaddress = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbpostcode = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.lbpostcode = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbphone = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lblastname = new System.Windows.Forms.Label();
            this.lbfirstname = new System.Windows.Forms.Label();
            this.Pvaraus = new System.Windows.Forms.Panel();
            this.textBox23 = new System.Windows.Forms.TextBox();
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.lblocationname = new System.Windows.Forms.Label();
            this.Pmokki = new System.Windows.Forms.Panel();
            this.btnpoistamokki = new System.Windows.Forms.Button();
            this.btnmuokkaamokki = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 461);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(745, 282);
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
            this.laskubtn.Location = new System.Drawing.Point(824, 554);
            this.laskubtn.Name = "laskubtn";
            this.laskubtn.Size = new System.Drawing.Size(92, 23);
            this.laskubtn.TabIndex = 4;
            this.laskubtn.Text = "Lasku";
            this.laskubtn.UseVisualStyleBackColor = true;
            this.laskubtn.Click += new System.EventHandler(this.laskubtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(817, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "MökKing - mökkivaraustenhallintajärjestelmä";
            // 
            // lisaabtn
            // 
            this.lisaabtn.Location = new System.Drawing.Point(823, 638);
            this.lisaabtn.Name = "lisaabtn";
            this.lisaabtn.Size = new System.Drawing.Size(92, 23);
            this.lisaabtn.TabIndex = 6;
            this.lisaabtn.Text = "Lisää tietoja";
            this.lisaabtn.UseVisualStyleBackColor = true;
            this.lisaabtn.Click += new System.EventHandler(this.lisaabtn_Click);
            // 
            // taulunimi
            // 
            this.taulunimi.AutoSize = true;
            this.taulunimi.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taulunimi.Location = new System.Drawing.Point(15, 429);
            this.taulunimi.Name = "taulunimi";
            this.taulunimi.Size = new System.Drawing.Size(82, 30);
            this.taulunimi.TabIndex = 7;
            this.taulunimi.Text = "Asiakas";
            // 
            // cbcottage
            // 
            this.cbcottage.FormattingEnabled = true;
            this.cbcottage.Location = new System.Drawing.Point(284, 107);
            this.cbcottage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcottage.Name = "cbcottage";
            this.cbcottage.Size = new System.Drawing.Size(92, 21);
            this.cbcottage.TabIndex = 10;
            // 
            // cblocation
            // 
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(284, 82);
            this.cblocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(92, 21);
            this.cblocation.TabIndex = 9;
            // 
            // btnperuutavaraus
            // 
            this.btnperuutavaraus.Location = new System.Drawing.Point(96, 259);
            this.btnperuutavaraus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnperuutavaraus.Name = "btnperuutavaraus";
            this.btnperuutavaraus.Size = new System.Drawing.Size(56, 25);
            this.btnperuutavaraus.TabIndex = 12;
            this.btnperuutavaraus.Text = "Peruuta";
            this.btnperuutavaraus.UseVisualStyleBackColor = true;
            this.btnperuutavaraus.Click += new System.EventHandler(this.btnperuutavaraus_Click);
            // 
            // btnlisaavaraus
            // 
            this.btnlisaavaraus.Location = new System.Drawing.Point(21, 247);
            this.btnlisaavaraus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlisaavaraus.Name = "btnlisaavaraus";
            this.btnlisaavaraus.Size = new System.Drawing.Size(59, 37);
            this.btnlisaavaraus.TabIndex = 11;
            this.btnlisaavaraus.Text = "Lisää varaus";
            this.btnlisaavaraus.UseVisualStyleBackColor = true;
            this.btnlisaavaraus.Click += new System.EventHandler(this.btreservation_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(284, 58);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lbcheckout
            // 
            this.lbcheckout.AutoSize = true;
            this.lbcheckout.Location = new System.Drawing.Point(200, 60);
            this.lbcheckout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcheckout.Name = "lbcheckout";
            this.lbcheckout.Size = new System.Drawing.Size(63, 13);
            this.lbcheckout.TabIndex = 44;
            this.lbcheckout.Text = "Lähtö päivä";
            // 
            // lblocation
            // 
            this.lblocation.AutoSize = true;
            this.lblocation.Location = new System.Drawing.Point(200, 85);
            this.lblocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblocation.Name = "lblocation";
            this.lblocation.Size = new System.Drawing.Size(28, 13);
            this.lblocation.TabIndex = 43;
            this.lblocation.Text = "Alue";
            // 
            // lbcottage
            // 
            this.lbcottage.AutoSize = true;
            this.lbcottage.Location = new System.Drawing.Point(200, 110);
            this.lbcottage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcottage.Name = "lbcottage";
            this.lbcottage.Size = new System.Drawing.Size(36, 13);
            this.lbcottage.TabIndex = 42;
            this.lbcottage.Text = "Mökki";
            // 
            // lbcheckin
            // 
            this.lbcheckin.AutoSize = true;
            this.lbcheckin.Location = new System.Drawing.Point(200, 34);
            this.lbcheckin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcheckin.Name = "lbcheckin";
            this.lbcheckin.Size = new System.Drawing.Size(57, 13);
            this.lbcheckin.TabIndex = 41;
            this.lbcheckin.Text = "Tulo päivä\r\n";
            // 
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(107, 130);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(76, 20);
            this.tbaddress.TabIndex = 5;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(107, 106);
            this.tbphone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(76, 20);
            this.tbphone.TabIndex = 4;
            // 
            // tbpostcode
            // 
            this.tbpostcode.Location = new System.Drawing.Point(107, 154);
            this.tbpostcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbpostcode.Name = "tbpostcode";
            this.tbpostcode.Size = new System.Drawing.Size(76, 20);
            this.tbpostcode.TabIndex = 6;
            // 
            // tblastname
            // 
            this.tblastname.Location = new System.Drawing.Point(107, 58);
            this.tblastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(76, 20);
            this.tblastname.TabIndex = 2;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(107, 82);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(76, 20);
            this.tbemail.TabIndex = 3;
            // 
            // tbfirstname
            // 
            this.tbfirstname.Location = new System.Drawing.Point(107, 34);
            this.tbfirstname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(76, 20);
            this.tbfirstname.TabIndex = 1;
            // 
            // lbpostcode
            // 
            this.lbpostcode.AutoSize = true;
            this.lbpostcode.Location = new System.Drawing.Point(19, 157);
            this.lbpostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpostcode.Name = "lbpostcode";
            this.lbpostcode.Size = new System.Drawing.Size(65, 13);
            this.lbpostcode.TabIndex = 34;
            this.lbpostcode.Text = "Postinumero";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(19, 133);
            this.lbaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(55, 13);
            this.lbaddress.TabIndex = 33;
            this.lbaddress.Text = "Lähiosoite";
            // 
            // lbphone
            // 
            this.lbphone.AutoSize = true;
            this.lbphone.Location = new System.Drawing.Point(19, 109);
            this.lbphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbphone.Name = "lbphone";
            this.lbphone.Size = new System.Drawing.Size(77, 13);
            this.lbphone.TabIndex = 32;
            this.lbphone.Text = "Puhelinnumero";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(19, 85);
            this.lbemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(60, 13);
            this.lbemail.TabIndex = 31;
            this.lbemail.Text = "Sähköposti";
            // 
            // lblastname
            // 
            this.lblastname.AutoSize = true;
            this.lblastname.Location = new System.Drawing.Point(19, 61);
            this.lblastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblastname.Name = "lblastname";
            this.lblastname.Size = new System.Drawing.Size(50, 13);
            this.lblastname.TabIndex = 30;
            this.lblastname.Text = "Sukunimi";
            // 
            // lbfirstname
            // 
            this.lbfirstname.AutoSize = true;
            this.lbfirstname.Location = new System.Drawing.Point(19, 37);
            this.lbfirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfirstname.Name = "lbfirstname";
            this.lbfirstname.Size = new System.Drawing.Size(41, 13);
            this.lbfirstname.TabIndex = 29;
            this.lbfirstname.Text = "Etunimi";
            // 
            // Pvaraus
            // 
            this.Pvaraus.Controls.Add(this.textBox23);
            this.Pvaraus.Controls.Add(this.button1);
            this.Pvaraus.Controls.Add(this.btnlisaapalveluvaraus);
            this.Pvaraus.Controls.Add(this.btnpoistavaraus);
            this.Pvaraus.Controls.Add(this.btnmuokkaavaraus);
            this.Pvaraus.Controls.Add(this.lbfirstname);
            this.Pvaraus.Controls.Add(this.btnperuutavaraus);
            this.Pvaraus.Controls.Add(this.btnlisaavaraus);
            this.Pvaraus.Controls.Add(this.tbfirstname);
            this.Pvaraus.Controls.Add(this.lblastname);
            this.Pvaraus.Controls.Add(this.cbcottage);
            this.Pvaraus.Controls.Add(this.tblastname);
            this.Pvaraus.Controls.Add(this.cblocation);
            this.Pvaraus.Controls.Add(this.lbemail);
            this.Pvaraus.Controls.Add(this.tbemail);
            this.Pvaraus.Controls.Add(this.dateTimePicker2);
            this.Pvaraus.Controls.Add(this.lbphone);
            this.Pvaraus.Controls.Add(this.dateTimePicker1);
            this.Pvaraus.Controls.Add(this.tbphone);
            this.Pvaraus.Controls.Add(this.lbcheckout);
            this.Pvaraus.Controls.Add(this.lbaddress);
            this.Pvaraus.Controls.Add(this.lblocation);
            this.Pvaraus.Controls.Add(this.tbaddress);
            this.Pvaraus.Controls.Add(this.lbcottage);
            this.Pvaraus.Controls.Add(this.lbpostcode);
            this.Pvaraus.Controls.Add(this.lbcheckin);
            this.Pvaraus.Controls.Add(this.tbpostcode);
            this.Pvaraus.Location = new System.Drawing.Point(20, 79);
            this.Pvaraus.Name = "Pvaraus";
            this.Pvaraus.Size = new System.Drawing.Size(896, 300);
            this.Pvaraus.TabIndex = 56;
            this.Pvaraus.Paint += new System.Windows.Forms.PaintEventHandler(this.Pvaraus_Paint);
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(288, 181);
            this.textBox23.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(76, 20);
            this.textBox23.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 48;
            this.button1.Text = "Hae";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnlisaapalveluvaraus
            // 
            this.btnlisaapalveluvaraus.Location = new System.Drawing.Point(20, 199);
            this.btnlisaapalveluvaraus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlisaapalveluvaraus.Name = "btnlisaapalveluvaraus";
            this.btnlisaapalveluvaraus.Size = new System.Drawing.Size(60, 41);
            this.btnlisaapalveluvaraus.TabIndex = 47;
            this.btnlisaapalveluvaraus.Text = "Lisää palvelu";
            this.btnlisaapalveluvaraus.UseVisualStyleBackColor = true;
            // 
            // btnpoistavaraus
            // 
            this.btnpoistavaraus.Location = new System.Drawing.Point(170, 266);
            this.btnpoistavaraus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpoistavaraus.Name = "btnpoistavaraus";
            this.btnpoistavaraus.Size = new System.Drawing.Size(56, 19);
            this.btnpoistavaraus.TabIndex = 46;
            this.btnpoistavaraus.Text = "Poista";
            this.btnpoistavaraus.UseVisualStyleBackColor = true;
            this.btnpoistavaraus.Click += new System.EventHandler(this.btnpoistavaraus_Click);
            // 
            // btnmuokkaavaraus
            // 
            this.btnmuokkaavaraus.Location = new System.Drawing.Point(98, 221);
            this.btnmuokkaavaraus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuokkaavaraus.Name = "btnmuokkaavaraus";
            this.btnmuokkaavaraus.Size = new System.Drawing.Size(56, 19);
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
            this.Plasku.Location = new System.Drawing.Point(93, 288);
            this.Plasku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Plasku.Name = "Plasku";
            this.Plasku.Size = new System.Drawing.Size(434, 301);
            this.Plasku.TabIndex = 46;
            // 
            // btnmuokkaalasku
            // 
            this.btnmuokkaalasku.Location = new System.Drawing.Point(144, 132);
            this.btnmuokkaalasku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuokkaalasku.Name = "btnmuokkaalasku";
            this.btnmuokkaalasku.Size = new System.Drawing.Size(56, 19);
            this.btnmuokkaalasku.TabIndex = 6;
            this.btnmuokkaalasku.Text = "Muokkaa";
            this.btnmuokkaalasku.UseVisualStyleBackColor = true;
            this.btnmuokkaalasku.Click += new System.EventHandler(this.btnmuokkaalasku_Click);
            // 
            // btnpoistalasku
            // 
            this.btnpoistalasku.Location = new System.Drawing.Point(144, 157);
            this.btnpoistalasku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpoistalasku.Name = "btnpoistalasku";
            this.btnpoistalasku.Size = new System.Drawing.Size(56, 19);
            this.btnpoistalasku.TabIndex = 7;
            this.btnpoistalasku.Text = "Poista";
            this.btnpoistalasku.UseVisualStyleBackColor = true;
            this.btnpoistalasku.Click += new System.EventHandler(this.btnpoistalasku_Click);
            // 
            // btnperuutalasku
            // 
            this.btnperuutalasku.Location = new System.Drawing.Point(38, 155);
            this.btnperuutalasku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnperuutalasku.Name = "btnperuutalasku";
            this.btnperuutalasku.Size = new System.Drawing.Size(56, 19);
            this.btnperuutalasku.TabIndex = 5;
            this.btnperuutalasku.Text = "Peruuta";
            this.btnperuutalasku.UseVisualStyleBackColor = true;
            this.btnperuutalasku.Click += new System.EventHandler(this.btnperuutalasku_Click);
            // 
            // btnlisaalasku
            // 
            this.btnlisaalasku.Location = new System.Drawing.Point(38, 132);
            this.btnlisaalasku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlisaalasku.Name = "btnlisaalasku";
            this.btnlisaalasku.Size = new System.Drawing.Size(56, 19);
            this.btnlisaalasku.TabIndex = 4;
            this.btnlisaalasku.Text = "Lisää";
            this.btnlisaalasku.UseVisualStyleBackColor = true;
            this.btnlisaalasku.Click += new System.EventHandler(this.btnlisaalasku_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(144, 58);
            this.textBox15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(76, 20);
            this.textBox15.TabIndex = 2;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(144, 89);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(76, 20);
            this.textBox14.TabIndex = 3;
            // 
            // lbbillprice
            // 
            this.lbbillprice.AutoSize = true;
            this.lbbillprice.Location = new System.Drawing.Point(35, 67);
            this.lbbillprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbillprice.Name = "lbbillprice";
            this.lbbillprice.Size = new System.Drawing.Size(42, 13);
            this.lbbillprice.TabIndex = 3;
            this.lbbillprice.Text = "Summa";
            // 
            // lbbilltax
            // 
            this.lbbilltax.AutoSize = true;
            this.lbbilltax.Location = new System.Drawing.Point(35, 93);
            this.lbbilltax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbilltax.Name = "lbbilltax";
            this.lbbilltax.Size = new System.Drawing.Size(22, 13);
            this.lbbilltax.TabIndex = 2;
            this.lbbilltax.Text = "Alv";
            // 
            // lbbillID
            // 
            this.lbbillID.AutoSize = true;
            this.lbbillID.Location = new System.Drawing.Point(35, 38);
            this.lbbillID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbbillID.Name = "lbbillID";
            this.lbbillID.Size = new System.Drawing.Size(54, 13);
            this.lbbillID.TabIndex = 1;
            this.lbbillID.Text = "Varaus ID";
            this.lbbillID.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(144, 33);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(76, 20);
            this.textBox13.TabIndex = 1;
            // 
            // Ppalvelu
            // 
            this.Ppalvelu.Controls.Add(this.btnpoistapalvelu);
            this.Ppalvelu.Controls.Add(this.btnmuokkaapalvelu);
            this.Ppalvelu.Controls.Add(this.textBox5);
            this.Ppalvelu.Controls.Add(this.textBox4);
            this.Ppalvelu.Controls.Add(this.textBox3);
            this.Ppalvelu.Controls.Add(this.textBox2);
            this.Ppalvelu.Controls.Add(this.textBox1);
            this.Ppalvelu.Controls.Add(this.lbprice);
            this.Ppalvelu.Controls.Add(this.lbkuvaus);
            this.Ppalvelu.Controls.Add(this.lbtype);
            this.Ppalvelu.Controls.Add(this.lbtax);
            this.Ppalvelu.Controls.Add(this.lbname);
            this.Ppalvelu.Controls.Add(this.btnperuutapalvelu);
            this.Ppalvelu.Controls.Add(this.btnlisaapalvelu);
            this.Ppalvelu.Location = new System.Drawing.Point(20, 79);
            this.Ppalvelu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ppalvelu.Name = "Ppalvelu";
            this.Ppalvelu.Size = new System.Drawing.Size(435, 301);
            this.Ppalvelu.TabIndex = 57;
            // 
            // btnpoistapalvelu
            // 
            this.btnpoistapalvelu.Location = new System.Drawing.Point(126, 231);
            this.btnpoistapalvelu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpoistapalvelu.Name = "btnpoistapalvelu";
            this.btnpoistapalvelu.Size = new System.Drawing.Size(56, 19);
            this.btnpoistapalvelu.TabIndex = 9;
            this.btnpoistapalvelu.Text = "Poista";
            this.btnpoistapalvelu.UseVisualStyleBackColor = true;
            this.btnpoistapalvelu.Click += new System.EventHandler(this.btnpoistapalvelu_Click);
            // 
            // btnmuokkaapalvelu
            // 
            this.btnmuokkaapalvelu.Location = new System.Drawing.Point(126, 203);
            this.btnmuokkaapalvelu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuokkaapalvelu.Name = "btnmuokkaapalvelu";
            this.btnmuokkaapalvelu.Size = new System.Drawing.Size(56, 19);
            this.btnmuokkaapalvelu.TabIndex = 8;
            this.btnmuokkaapalvelu.Text = "Muokkaa";
            this.btnmuokkaapalvelu.UseVisualStyleBackColor = true;
            this.btnmuokkaapalvelu.Click += new System.EventHandler(this.btnmuokkaapalvelu_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(107, 128);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(107, 50);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 77);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "24";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(20, 134);
            this.lbprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(32, 13);
            this.lbprice.TabIndex = 6;
            this.lbprice.Text = "Hinta";
            // 
            // lbkuvaus
            // 
            this.lbkuvaus.AutoSize = true;
            this.lbkuvaus.Location = new System.Drawing.Point(20, 55);
            this.lbkuvaus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbkuvaus.Name = "lbkuvaus";
            this.lbkuvaus.Size = new System.Drawing.Size(43, 13);
            this.lbkuvaus.TabIndex = 5;
            this.lbkuvaus.Text = "Kuvaus";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Location = new System.Drawing.Point(16, 82);
            this.lbtype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(38, 13);
            this.lbtype.TabIndex = 4;
            this.lbtype.Text = "Tyyppi";
            // 
            // lbtax
            // 
            this.lbtax.AutoSize = true;
            this.lbtax.Location = new System.Drawing.Point(20, 107);
            this.lbtax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtax.Name = "lbtax";
            this.lbtax.Size = new System.Drawing.Size(22, 13);
            this.lbtax.TabIndex = 3;
            this.lbtax.Text = "Alv";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(19, 24);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(27, 13);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "Nimi";
            // 
            // btnperuutapalvelu
            // 
            this.btnperuutapalvelu.Location = new System.Drawing.Point(24, 231);
            this.btnperuutapalvelu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnperuutapalvelu.Name = "btnperuutapalvelu";
            this.btnperuutapalvelu.Size = new System.Drawing.Size(56, 25);
            this.btnperuutapalvelu.TabIndex = 7;
            this.btnperuutapalvelu.Text = "Peruuta";
            this.btnperuutapalvelu.UseVisualStyleBackColor = true;
            this.btnperuutapalvelu.Click += new System.EventHandler(this.btnperuutapalvelu_Click);
            // 
            // btnlisaapalvelu
            // 
            this.btnlisaapalvelu.Location = new System.Drawing.Point(24, 203);
            this.btnlisaapalvelu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlisaapalvelu.Name = "btnlisaapalvelu";
            this.btnlisaapalvelu.Size = new System.Drawing.Size(56, 19);
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
            this.Pasiakas.Location = new System.Drawing.Point(20, 79);
            this.Pasiakas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pasiakas.Name = "Pasiakas";
            this.Pasiakas.Size = new System.Drawing.Size(434, 301);
            this.Pasiakas.TabIndex = 45;
            // 
            // btnmuokkaa
            // 
            this.btnmuokkaa.Location = new System.Drawing.Point(126, 218);
            this.btnmuokkaa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuokkaa.Name = "btnmuokkaa";
            this.btnmuokkaa.Size = new System.Drawing.Size(63, 24);
            this.btnmuokkaa.TabIndex = 9;
            this.btnmuokkaa.Text = "Muokkaa";
            this.btnmuokkaa.UseVisualStyleBackColor = true;
            this.btnmuokkaa.Click += new System.EventHandler(this.btnmuokkaa_Click);
            // 
            // btnpoistaasiakas
            // 
            this.btnpoistaasiakas.Location = new System.Drawing.Point(126, 246);
            this.btnpoistaasiakas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpoistaasiakas.Name = "btnpoistaasiakas";
            this.btnpoistaasiakas.Size = new System.Drawing.Size(63, 24);
            this.btnpoistaasiakas.TabIndex = 10;
            this.btnpoistaasiakas.Text = "Poista";
            this.btnpoistaasiakas.UseVisualStyleBackColor = true;
            this.btnpoistaasiakas.Click += new System.EventHandler(this.btnpoistaasiakas_Click);
            // 
            // tbasiakaspostinum
            // 
            this.tbasiakaspostinum.Location = new System.Drawing.Point(152, 158);
            this.tbasiakaspostinum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbasiakaspostinum.Name = "tbasiakaspostinum";
            this.tbasiakaspostinum.Size = new System.Drawing.Size(76, 20);
            this.tbasiakaspostinum.TabIndex = 6;
            // 
            // tbasiakasosoite
            // 
            this.tbasiakasosoite.Location = new System.Drawing.Point(152, 134);
            this.tbasiakasosoite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbasiakasosoite.Name = "tbasiakasosoite";
            this.tbasiakasosoite.Size = new System.Drawing.Size(76, 20);
            this.tbasiakasosoite.TabIndex = 5;
            // 
            // tbasiakaspuhnum
            // 
            this.tbasiakaspuhnum.Location = new System.Drawing.Point(152, 79);
            this.tbasiakaspuhnum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbasiakaspuhnum.Name = "tbasiakaspuhnum";
            this.tbasiakaspuhnum.Size = new System.Drawing.Size(76, 20);
            this.tbasiakaspuhnum.TabIndex = 4;
            // 
            // tbasiakassposti
            // 
            this.tbasiakassposti.Location = new System.Drawing.Point(152, 107);
            this.tbasiakassposti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbasiakassposti.Name = "tbasiakassposti";
            this.tbasiakassposti.Size = new System.Drawing.Size(76, 20);
            this.tbasiakassposti.TabIndex = 3;
            // 
            // tbasiakassnimi
            // 
            this.tbasiakassnimi.Location = new System.Drawing.Point(152, 51);
            this.tbasiakassnimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbasiakassnimi.Name = "tbasiakassnimi";
            this.tbasiakassnimi.Size = new System.Drawing.Size(76, 20);
            this.tbasiakassnimi.TabIndex = 2;
            // 
            // tbasiakasnimi
            // 
            this.tbasiakasnimi.Location = new System.Drawing.Point(152, 24);
            this.tbasiakasnimi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbasiakasnimi.Name = "tbasiakasnimi";
            this.tbasiakasnimi.Size = new System.Drawing.Size(76, 20);
            this.tbasiakasnimi.TabIndex = 1;
            // 
            // btnasiakasperuuta
            // 
            this.btnasiakasperuuta.Location = new System.Drawing.Point(26, 246);
            this.btnasiakasperuuta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnasiakasperuuta.Name = "btnasiakasperuuta";
            this.btnasiakasperuuta.Size = new System.Drawing.Size(56, 25);
            this.btnasiakasperuuta.TabIndex = 8;
            this.btnasiakasperuuta.Text = "Peruuta";
            this.btnasiakasperuuta.UseVisualStyleBackColor = true;
            this.btnasiakasperuuta.Click += new System.EventHandler(this.btnasiakasperuuta_Click);
            // 
            // btnasiakaslisaa
            // 
            this.btnasiakaslisaa.Location = new System.Drawing.Point(26, 218);
            this.btnasiakaslisaa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnasiakaslisaa.Name = "btnasiakaslisaa";
            this.btnasiakaslisaa.Size = new System.Drawing.Size(56, 25);
            this.btnasiakaslisaa.TabIndex = 7;
            this.btnasiakaslisaa.Text = "Lisää";
            this.btnasiakaslisaa.UseVisualStyleBackColor = true;
            this.btnasiakaslisaa.Click += new System.EventHandler(this.btnasiakaslisaa_Click);
            // 
            // lbcustomerlname
            // 
            this.lbcustomerlname.AutoSize = true;
            this.lbcustomerlname.Location = new System.Drawing.Point(36, 56);
            this.lbcustomerlname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcustomerlname.Name = "lbcustomerlname";
            this.lbcustomerlname.Size = new System.Drawing.Size(50, 13);
            this.lbcustomerlname.TabIndex = 5;
            this.lbcustomerlname.Text = "Sukunimi";
            // 
            // lbcustomeremail
            // 
            this.lbcustomeremail.AutoSize = true;
            this.lbcustomeremail.Location = new System.Drawing.Point(36, 111);
            this.lbcustomeremail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcustomeremail.Name = "lbcustomeremail";
            this.lbcustomeremail.Size = new System.Drawing.Size(60, 13);
            this.lbcustomeremail.TabIndex = 4;
            this.lbcustomeremail.Text = "Sähköposti";
            // 
            // lbcustormerphone
            // 
            this.lbcustormerphone.AutoSize = true;
            this.lbcustormerphone.Location = new System.Drawing.Point(36, 82);
            this.lbcustormerphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcustormerphone.Name = "lbcustormerphone";
            this.lbcustormerphone.Size = new System.Drawing.Size(77, 13);
            this.lbcustormerphone.TabIndex = 3;
            this.lbcustormerphone.Text = "Puhelinnumero";
            // 
            // lbcustomerpostcode
            // 
            this.lbcustomerpostcode.AutoSize = true;
            this.lbcustomerpostcode.Location = new System.Drawing.Point(36, 164);
            this.lbcustomerpostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcustomerpostcode.Name = "lbcustomerpostcode";
            this.lbcustomerpostcode.Size = new System.Drawing.Size(65, 13);
            this.lbcustomerpostcode.TabIndex = 2;
            this.lbcustomerpostcode.Text = "Postinumero";
            // 
            // lbcustomeraddress
            // 
            this.lbcustomeraddress.AutoSize = true;
            this.lbcustomeraddress.Location = new System.Drawing.Point(36, 136);
            this.lbcustomeraddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcustomeraddress.Name = "lbcustomeraddress";
            this.lbcustomeraddress.Size = new System.Drawing.Size(55, 13);
            this.lbcustomeraddress.TabIndex = 1;
            this.lbcustomeraddress.Text = "Lähiosoite";
            // 
            // lbcustomerfname
            // 
            this.lbcustomerfname.AutoSize = true;
            this.lbcustomerfname.Location = new System.Drawing.Point(36, 25);
            this.lbcustomerfname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcustomerfname.Name = "lbcustomerfname";
            this.lbcustomerfname.Size = new System.Drawing.Size(41, 13);
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
            this.Palue.Controls.Add(this.textBox22);
            this.Palue.Controls.Add(this.lblocationname);
            this.Palue.Location = new System.Drawing.Point(20, 79);
            this.Palue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Palue.Name = "Palue";
            this.Palue.Size = new System.Drawing.Size(435, 301);
            this.Palue.TabIndex = 14;
            // 
            // btnpoistaalue
            // 
            this.btnpoistaalue.Location = new System.Drawing.Point(136, 154);
            this.btnpoistaalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpoistaalue.Name = "btnpoistaalue";
            this.btnpoistaalue.Size = new System.Drawing.Size(56, 19);
            this.btnpoistaalue.TabIndex = 5;
            this.btnpoistaalue.Text = "Poista";
            this.btnpoistaalue.UseVisualStyleBackColor = true;
            this.btnpoistaalue.Click += new System.EventHandler(this.btnpoistaalue_Click);
            // 
            // btnmuokkaaalue
            // 
            this.btnmuokkaaalue.Location = new System.Drawing.Point(136, 128);
            this.btnmuokkaaalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuokkaaalue.Name = "btnmuokkaaalue";
            this.btnmuokkaaalue.Size = new System.Drawing.Size(56, 19);
            this.btnmuokkaaalue.TabIndex = 4;
            this.btnmuokkaaalue.Text = "Muokkaa";
            this.btnmuokkaaalue.UseVisualStyleBackColor = true;
            this.btnmuokkaaalue.Click += new System.EventHandler(this.btnmuokkaaalue_Click);
            // 
            // btnperuutaalue
            // 
            this.btnperuutaalue.Location = new System.Drawing.Point(38, 152);
            this.btnperuutaalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnperuutaalue.Name = "btnperuutaalue";
            this.btnperuutaalue.Size = new System.Drawing.Size(56, 19);
            this.btnperuutaalue.TabIndex = 3;
            this.btnperuutaalue.Text = "Peruuta";
            this.btnperuutaalue.UseVisualStyleBackColor = true;
            this.btnperuutaalue.Click += new System.EventHandler(this.btnperuutaalue_Click);
            // 
            // btnlisaaalue
            // 
            this.btnlisaaalue.Location = new System.Drawing.Point(38, 128);
            this.btnlisaaalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlisaaalue.Name = "btnlisaaalue";
            this.btnlisaaalue.Size = new System.Drawing.Size(56, 19);
            this.btnlisaaalue.TabIndex = 2;
            this.btnlisaaalue.Text = "Lisää";
            this.btnlisaaalue.UseVisualStyleBackColor = true;
            this.btnlisaaalue.Click += new System.EventHandler(this.btnlisaaalue_Click);
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(107, 35);
            this.textBox22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(76, 20);
            this.textBox22.TabIndex = 1;
            // 
            // lblocationname
            // 
            this.lblocationname.AutoSize = true;
            this.lblocationname.Location = new System.Drawing.Point(36, 41);
            this.lblocationname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblocationname.Name = "lblocationname";
            this.lblocationname.Size = new System.Drawing.Size(61, 13);
            this.lblocationname.TabIndex = 0;
            this.lblocationname.Text = "Alueen nimi";
            // 
            // Pmokki
            // 
            this.Pmokki.Controls.Add(this.btnpoistamokki);
            this.Pmokki.Controls.Add(this.btnmuokkaamokki);
            this.Pmokki.Controls.Add(this.textBox12);
            this.Pmokki.Controls.Add(this.textBox11);
            this.Pmokki.Controls.Add(this.textBox10);
            this.Pmokki.Controls.Add(this.textBox9);
            this.Pmokki.Controls.Add(this.textBox8);
            this.Pmokki.Controls.Add(this.textBox7);
            this.Pmokki.Controls.Add(this.textBox6);
            this.Pmokki.Controls.Add(this.label2);
            this.Pmokki.Controls.Add(this.btnperuutamokki);
            this.Pmokki.Controls.Add(this.btnlisaamokki);
            this.Pmokki.Controls.Add(this.lbcottagename);
            this.Pmokki.Controls.Add(this.lbcottageaddress);
            this.Pmokki.Controls.Add(this.lbcottagepostcode);
            this.Pmokki.Controls.Add(this.lbcottageprice);
            this.Pmokki.Controls.Add(this.lbdescription);
            this.Pmokki.Controls.Add(this.lbloactio);
            this.Pmokki.Location = new System.Drawing.Point(20, 79);
            this.Pmokki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pmokki.Name = "Pmokki";
            this.Pmokki.Size = new System.Drawing.Size(454, 301);
            this.Pmokki.TabIndex = 58;
            // 
            // btnpoistamokki
            // 
            this.btnpoistamokki.Location = new System.Drawing.Point(126, 240);
            this.btnpoistamokki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpoistamokki.Name = "btnpoistamokki";
            this.btnpoistamokki.Size = new System.Drawing.Size(56, 19);
            this.btnpoistamokki.TabIndex = 10;
            this.btnpoistamokki.Text = "Poista";
            this.btnpoistamokki.UseVisualStyleBackColor = true;
            // 
            // btnmuokkaamokki
            // 
            this.btnmuokkaamokki.Location = new System.Drawing.Point(126, 201);
            this.btnmuokkaamokki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmuokkaamokki.Name = "btnmuokkaamokki";
            this.btnmuokkaamokki.Size = new System.Drawing.Size(56, 19);
            this.btnmuokkaamokki.TabIndex = 9;
            this.btnmuokkaamokki.Text = "Muokkaa";
            this.btnmuokkaamokki.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(284, 100);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(76, 20);
            this.textBox12.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(107, 70);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 20);
            this.textBox11.TabIndex = 2;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(107, 100);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 20);
            this.textBox10.TabIndex = 3;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(284, 45);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 20);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(284, 70);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(107, 131);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 20);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(107, 45);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kuvaus";
            // 
            // btnperuutamokki
            // 
            this.btnperuutamokki.Location = new System.Drawing.Point(21, 240);
            this.btnperuutamokki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnperuutamokki.Name = "btnperuutamokki";
            this.btnperuutamokki.Size = new System.Drawing.Size(56, 24);
            this.btnperuutamokki.TabIndex = 8;
            this.btnperuutamokki.Text = "Peruuta";
            this.btnperuutamokki.UseVisualStyleBackColor = true;
            // 
            // btnlisaamokki
            // 
            this.btnlisaamokki.Location = new System.Drawing.Point(22, 201);
            this.btnlisaamokki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlisaamokki.Name = "btnlisaamokki";
            this.btnlisaamokki.Size = new System.Drawing.Size(56, 19);
            this.btnlisaamokki.TabIndex = 7;
            this.btnlisaamokki.Text = "Lisää";
            this.btnlisaamokki.UseVisualStyleBackColor = true;
            // 
            // lbcottagename
            // 
            this.lbcottagename.AutoSize = true;
            this.lbcottagename.Location = new System.Drawing.Point(19, 70);
            this.lbcottagename.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcottagename.Name = "lbcottagename";
            this.lbcottagename.Size = new System.Drawing.Size(57, 13);
            this.lbcottagename.TabIndex = 5;
            this.lbcottagename.Text = "Mökin nimi";
            // 
            // lbcottageaddress
            // 
            this.lbcottageaddress.AutoSize = true;
            this.lbcottageaddress.Location = new System.Drawing.Point(19, 98);
            this.lbcottageaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcottageaddress.Name = "lbcottageaddress";
            this.lbcottageaddress.Size = new System.Drawing.Size(57, 13);
            this.lbcottageaddress.TabIndex = 4;
            this.lbcottageaddress.Text = "Katuosoite";
            // 
            // lbcottagepostcode
            // 
            this.lbcottagepostcode.AutoSize = true;
            this.lbcottagepostcode.Location = new System.Drawing.Point(19, 134);
            this.lbcottagepostcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcottagepostcode.Name = "lbcottagepostcode";
            this.lbcottagepostcode.Size = new System.Drawing.Size(65, 13);
            this.lbcottagepostcode.TabIndex = 3;
            this.lbcottagepostcode.Text = "Postinumero";
            // 
            // lbcottageprice
            // 
            this.lbcottageprice.AutoSize = true;
            this.lbcottageprice.Location = new System.Drawing.Point(200, 103);
            this.lbcottageprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbcottageprice.Name = "lbcottageprice";
            this.lbcottageprice.Size = new System.Drawing.Size(32, 13);
            this.lbcottageprice.TabIndex = 2;
            this.lbcottageprice.Text = "Hinta";
            // 
            // lbdescription
            // 
            this.lbdescription.AutoSize = true;
            this.lbdescription.Location = new System.Drawing.Point(200, 78);
            this.lbdescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdescription.Name = "lbdescription";
            this.lbdescription.Size = new System.Drawing.Size(43, 13);
            this.lbdescription.TabIndex = 1;
            this.lbdescription.Text = "Kuvaus";
            // 
            // lbloactio
            // 
            this.lbloactio.AutoSize = true;
            this.lbloactio.Location = new System.Drawing.Point(19, 43);
            this.lbloactio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbloactio.Name = "lbloactio";
            this.lbloactio.Size = new System.Drawing.Size(28, 13);
            this.lbloactio.TabIndex = 0;
            this.lbloactio.Text = "Alue";
            // 
            // aikajaksobtn
            // 
            this.aikajaksobtn.Location = new System.Drawing.Point(823, 713);
            this.aikajaksobtn.Name = "aikajaksobtn";
            this.aikajaksobtn.Size = new System.Drawing.Size(92, 23);
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
            this.toolStrip1.Size = new System.Drawing.Size(1443, 27);
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
            this.toolStripSplitButton1.Size = new System.Drawing.Size(60, 24);
            this.toolStripSplitButton1.Text = "Valikko";
            // 
            // jotainToolStripMenuItem
            // 
            this.jotainToolStripMenuItem.Name = "jotainToolStripMenuItem";
            this.jotainToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.jotainToolStripMenuItem.Text = "Tiedostopolku";
            this.jotainToolStripMenuItem.Click += new System.EventHandler(this.jotainToolStripMenuItem_Click);
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
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
            this.tsbtnalueetjamökit.Size = new System.Drawing.Size(91, 24);
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
            this.tsbtnasiakkaat.Size = new System.Drawing.Size(61, 24);
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
            this.tsbtnvaraukset.Size = new System.Drawing.Size(61, 24);
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
            this.tsbtnlaskut.Size = new System.Drawing.Size(45, 24);
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
            this.tsbtnpalvelut.Size = new System.Drawing.Size(53, 24);
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
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 857);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Pasiakas);
            this.Controls.Add(this.Ppalvelu);
            this.Controls.Add(this.Palue);
            this.Controls.Add(this.aikajaksobtn);
            this.Controls.Add(this.Pmokki);
            this.Controls.Add(this.taulunimi);
            this.Controls.Add(this.Pvaraus);
            this.Controls.Add(this.lisaabtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskubtn);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(20, 70);
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
        private System.Windows.Forms.ComboBox cbcottage;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.Button btnperuutavaraus;
        private System.Windows.Forms.Button btnlisaavaraus;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbcheckout;
        private System.Windows.Forms.Label lblocation;
        private System.Windows.Forms.Label lbcottage;
        private System.Windows.Forms.Label lbcheckin;
        private System.Windows.Forms.TextBox tbaddress;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbpostcode;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbfirstname;
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbcottagename;
        private System.Windows.Forms.Label lbcottageaddress;
        private System.Windows.Forms.Label lbcottagepostcode;
        private System.Windows.Forms.Label lbcottageprice;
        private System.Windows.Forms.Label lbdescription;
        private System.Windows.Forms.Label lbloactio;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox textBox22;
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
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnlisaapalveluvaraus;
        private System.Windows.Forms.Button btnpoistavaraus;
        private System.Windows.Forms.Button btnmuokkaavaraus;
    }
}

