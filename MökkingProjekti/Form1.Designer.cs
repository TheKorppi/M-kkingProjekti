namespace MökkingProjekti
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
            this.taulunimicb = new System.Windows.Forms.ComboBox();
            this.laskubtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lisaabtn = new System.Windows.Forms.Button();
            this.taulunimi = new System.Windows.Forms.Label();
            this.cbcottage = new System.Windows.Forms.ComboBox();
            this.cblocation = new System.Windows.Forms.ComboBox();
            this.btcancel = new System.Windows.Forms.Button();
            this.btreservation = new System.Windows.Forms.Button();
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
            this.Plasku = new System.Windows.Forms.Panel();
            this.btbillcancel = new System.Windows.Forms.Button();
            this.btaddbill = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.lbbillprice = new System.Windows.Forms.Label();
            this.lbbilltax = new System.Windows.Forms.Label();
            this.lbbillID = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.Ppalvelu = new System.Windows.Forms.Panel();
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
            this.btcancel1 = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.Pasiakas = new System.Windows.Forms.Panel();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.btcustomercancel = new System.Windows.Forms.Button();
            this.btcustomeradd = new System.Windows.Forms.Button();
            this.lbcustomerlname = new System.Windows.Forms.Label();
            this.lbcustomeremail = new System.Windows.Forms.Label();
            this.lbcustormerphone = new System.Windows.Forms.Label();
            this.lbcustomerpostcode = new System.Windows.Forms.Label();
            this.lbcustomeraddress = new System.Windows.Forms.Label();
            this.lbcustomerfname = new System.Windows.Forms.Label();
            this.Palue = new System.Windows.Forms.Panel();
            this.btlocationcancel = new System.Windows.Forms.Button();
            this.btlocationadd = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.lblocationname = new System.Windows.Forms.Label();
            this.Pmokki = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btcanelcottage = new System.Windows.Forms.Button();
            this.btaddcottage = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(1007, 412);
            this.dataGridView1.TabIndex = 0;
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
            // taulunimicb
            // 
            this.taulunimicb.FormattingEnabled = true;
            this.taulunimicb.Items.AddRange(new object[] {
            "asiakas",
            "alue",
            "lasku",
            "mokki",
            "palvelu",
            "posti",
            "varauksen_palvelut",
            "varaus"});
            this.taulunimicb.Location = new System.Drawing.Point(1099, 623);
            this.taulunimicb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taulunimicb.Name = "taulunimicb";
            this.taulunimicb.Size = new System.Drawing.Size(121, 24);
            this.taulunimicb.TabIndex = 3;
            this.taulunimicb.Text = "asiakas";
            this.taulunimicb.SelectedIndexChanged += new System.EventHandler(this.taulunimicb_SelectedIndexChanged);
            // 
            // laskubtn
            // 
            this.laskubtn.Location = new System.Drawing.Point(1099, 736);
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
            this.lisaabtn.Location = new System.Drawing.Point(1099, 842);
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
            // cbcottage
            // 
            this.cbcottage.FormattingEnabled = true;
            this.cbcottage.Location = new System.Drawing.Point(379, 132);
            this.cbcottage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbcottage.Name = "cbcottage";
            this.cbcottage.Size = new System.Drawing.Size(121, 24);
            this.cbcottage.TabIndex = 10;
            // 
            // cblocation
            // 
            this.cblocation.FormattingEnabled = true;
            this.cblocation.Location = new System.Drawing.Point(379, 101);
            this.cblocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cblocation.Name = "cblocation";
            this.cblocation.Size = new System.Drawing.Size(121, 24);
            this.cblocation.TabIndex = 9;
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(17, 330);
            this.btcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(75, 31);
            this.btcancel.TabIndex = 12;
            this.btcancel.Text = "Peruuta";
            this.btcancel.UseVisualStyleBackColor = true;
            // 
            // btreservation
            // 
            this.btreservation.Location = new System.Drawing.Point(17, 302);
            this.btreservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btreservation.Name = "btreservation";
            this.btreservation.Size = new System.Drawing.Size(75, 23);
            this.btreservation.TabIndex = 11;
            this.btreservation.Text = "Varaus";
            this.btreservation.UseVisualStyleBackColor = true;
            this.btreservation.Click += new System.EventHandler(this.btreservation_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(379, 71);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 37);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
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
            // tbaddress
            // 
            this.tbaddress.Location = new System.Drawing.Point(143, 160);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.Size = new System.Drawing.Size(100, 22);
            this.tbaddress.TabIndex = 5;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(143, 130);
            this.tbphone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(100, 22);
            this.tbphone.TabIndex = 4;
            // 
            // tbpostcode
            // 
            this.tbpostcode.Location = new System.Drawing.Point(143, 190);
            this.tbpostcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpostcode.Name = "tbpostcode";
            this.tbpostcode.Size = new System.Drawing.Size(100, 22);
            this.tbpostcode.TabIndex = 6;
            // 
            // tblastname
            // 
            this.tblastname.Location = new System.Drawing.Point(143, 71);
            this.tblastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(100, 22);
            this.tblastname.TabIndex = 2;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(143, 101);
            this.tbemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(100, 22);
            this.tbemail.TabIndex = 3;
            // 
            // tbfirstname
            // 
            this.tbfirstname.Location = new System.Drawing.Point(143, 42);
            this.tbfirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(100, 22);
            this.tbfirstname.TabIndex = 1;
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
            this.Pvaraus.Controls.Add(this.lbfirstname);
            this.Pvaraus.Controls.Add(this.btcancel);
            this.Pvaraus.Controls.Add(this.btreservation);
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
            this.Pvaraus.Location = new System.Drawing.Point(27, 86);
            this.Pvaraus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pvaraus.Name = "Pvaraus";
            this.Pvaraus.Size = new System.Drawing.Size(1195, 369);
            this.Pvaraus.TabIndex = 56;
            this.Pvaraus.Paint += new System.Windows.Forms.PaintEventHandler(this.Pvaraus_Paint);
            // 
            // Plasku
            // 
            this.Plasku.Controls.Add(this.btbillcancel);
            this.Plasku.Controls.Add(this.btaddbill);
            this.Plasku.Controls.Add(this.textBox15);
            this.Plasku.Controls.Add(this.textBox14);
            this.Plasku.Controls.Add(this.lbbillprice);
            this.Plasku.Controls.Add(this.lbbilltax);
            this.Plasku.Controls.Add(this.lbbillID);
            this.Plasku.Controls.Add(this.textBox13);
            this.Plasku.Location = new System.Drawing.Point(27, 86);
            this.Plasku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Plasku.Name = "Plasku";
            this.Plasku.Size = new System.Drawing.Size(579, 370);
            this.Plasku.TabIndex = 46;
            // 
            // btbillcancel
            // 
            this.btbillcancel.Location = new System.Drawing.Point(51, 191);
            this.btbillcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbillcancel.Name = "btbillcancel";
            this.btbillcancel.Size = new System.Drawing.Size(75, 23);
            this.btbillcancel.TabIndex = 7;
            this.btbillcancel.Text = "Peruuta";
            this.btbillcancel.UseVisualStyleBackColor = true;
            // 
            // btaddbill
            // 
            this.btaddbill.Location = new System.Drawing.Point(51, 162);
            this.btaddbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btaddbill.Name = "btaddbill";
            this.btaddbill.Size = new System.Drawing.Size(75, 23);
            this.btaddbill.TabIndex = 6;
            this.btaddbill.Text = "Lisää";
            this.btaddbill.UseVisualStyleBackColor = true;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(192, 71);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 5;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(192, 110);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 4;
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
            this.textBox13.TabIndex = 0;
            // 
            // Ppalvelu
            // 
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
            this.Ppalvelu.Controls.Add(this.btcancel1);
            this.Ppalvelu.Controls.Add(this.btadd);
            this.Ppalvelu.Location = new System.Drawing.Point(27, 86);
            this.Ppalvelu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ppalvelu.Name = "Ppalvelu";
            this.Ppalvelu.Size = new System.Drawing.Size(580, 370);
            this.Ppalvelu.TabIndex = 57;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(143, 158);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(143, 62);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 95);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 124);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
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
            // btcancel1
            // 
            this.btcancel1.Location = new System.Drawing.Point(27, 302);
            this.btcancel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcancel1.Name = "btcancel1";
            this.btcancel1.Size = new System.Drawing.Size(75, 31);
            this.btcancel1.TabIndex = 1;
            this.btcancel1.Text = "Peruuta";
            this.btcancel1.UseVisualStyleBackColor = true;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(29, 274);
            this.btadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "Lisää";
            this.btadd.UseVisualStyleBackColor = true;
            // 
            // Pasiakas
            // 
            this.Pasiakas.Controls.Add(this.textBox21);
            this.Pasiakas.Controls.Add(this.textBox20);
            this.Pasiakas.Controls.Add(this.textBox19);
            this.Pasiakas.Controls.Add(this.textBox18);
            this.Pasiakas.Controls.Add(this.textBox17);
            this.Pasiakas.Controls.Add(this.textBox16);
            this.Pasiakas.Controls.Add(this.btcustomercancel);
            this.Pasiakas.Controls.Add(this.btcustomeradd);
            this.Pasiakas.Controls.Add(this.lbcustomerlname);
            this.Pasiakas.Controls.Add(this.lbcustomeremail);
            this.Pasiakas.Controls.Add(this.lbcustormerphone);
            this.Pasiakas.Controls.Add(this.lbcustomerpostcode);
            this.Pasiakas.Controls.Add(this.lbcustomeraddress);
            this.Pasiakas.Controls.Add(this.lbcustomerfname);
            this.Pasiakas.Location = new System.Drawing.Point(27, 86);
            this.Pasiakas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pasiakas.Name = "Pasiakas";
            this.Pasiakas.Size = new System.Drawing.Size(579, 370);
            this.Pasiakas.TabIndex = 45;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(203, 194);
            this.textBox21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 22);
            this.textBox21.TabIndex = 13;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(203, 165);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 22);
            this.textBox20.TabIndex = 12;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(203, 133);
            this.textBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 22);
            this.textBox19.TabIndex = 11;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(203, 98);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 22);
            this.textBox18.TabIndex = 10;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(203, 63);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 22);
            this.textBox17.TabIndex = 9;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(203, 30);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 22);
            this.textBox16.TabIndex = 8;
            // 
            // btcustomercancel
            // 
            this.btcustomercancel.Location = new System.Drawing.Point(35, 303);
            this.btcustomercancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcustomercancel.Name = "btcustomercancel";
            this.btcustomercancel.Size = new System.Drawing.Size(75, 31);
            this.btcustomercancel.TabIndex = 7;
            this.btcustomercancel.Text = "Peruuta";
            this.btcustomercancel.UseVisualStyleBackColor = true;
            // 
            // btcustomeradd
            // 
            this.btcustomeradd.Location = new System.Drawing.Point(35, 276);
            this.btcustomeradd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcustomeradd.Name = "btcustomeradd";
            this.btcustomeradd.Size = new System.Drawing.Size(75, 23);
            this.btcustomeradd.TabIndex = 6;
            this.btcustomeradd.Text = "Lisää";
            this.btcustomeradd.UseVisualStyleBackColor = true;
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
            this.lbcustomeremail.Location = new System.Drawing.Point(48, 103);
            this.lbcustomeremail.Name = "lbcustomeremail";
            this.lbcustomeremail.Size = new System.Drawing.Size(75, 16);
            this.lbcustomeremail.TabIndex = 4;
            this.lbcustomeremail.Text = "Sähköposti";
            // 
            // lbcustormerphone
            // 
            this.lbcustormerphone.AutoSize = true;
            this.lbcustormerphone.Location = new System.Drawing.Point(48, 137);
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
            this.Palue.Controls.Add(this.btlocationcancel);
            this.Palue.Controls.Add(this.btlocationadd);
            this.Palue.Controls.Add(this.textBox22);
            this.Palue.Controls.Add(this.lblocationname);
            this.Palue.Location = new System.Drawing.Point(27, 86);
            this.Palue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Palue.Name = "Palue";
            this.Palue.Size = new System.Drawing.Size(580, 370);
            this.Palue.TabIndex = 14;
            // 
            // btlocationcancel
            // 
            this.btlocationcancel.Location = new System.Drawing.Point(51, 187);
            this.btlocationcancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btlocationcancel.Name = "btlocationcancel";
            this.btlocationcancel.Size = new System.Drawing.Size(75, 23);
            this.btlocationcancel.TabIndex = 9;
            this.btlocationcancel.Text = "Peruuta";
            this.btlocationcancel.UseVisualStyleBackColor = true;
            // 
            // btlocationadd
            // 
            this.btlocationadd.Location = new System.Drawing.Point(51, 158);
            this.btlocationadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btlocationadd.Name = "btlocationadd";
            this.btlocationadd.Size = new System.Drawing.Size(75, 23);
            this.btlocationadd.TabIndex = 8;
            this.btlocationadd.Text = "Lisää";
            this.btlocationadd.UseVisualStyleBackColor = true;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(143, 43);
            this.textBox22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 22);
            this.textBox22.TabIndex = 1;
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
            this.Pmokki.Controls.Add(this.textBox12);
            this.Pmokki.Controls.Add(this.textBox11);
            this.Pmokki.Controls.Add(this.textBox10);
            this.Pmokki.Controls.Add(this.textBox9);
            this.Pmokki.Controls.Add(this.textBox8);
            this.Pmokki.Controls.Add(this.textBox7);
            this.Pmokki.Controls.Add(this.textBox6);
            this.Pmokki.Controls.Add(this.label2);
            this.Pmokki.Controls.Add(this.btcanelcottage);
            this.Pmokki.Controls.Add(this.btaddcottage);
            this.Pmokki.Controls.Add(this.lbcottagename);
            this.Pmokki.Controls.Add(this.lbcottageaddress);
            this.Pmokki.Controls.Add(this.lbcottagepostcode);
            this.Pmokki.Controls.Add(this.lbcottageprice);
            this.Pmokki.Controls.Add(this.lbdescription);
            this.Pmokki.Controls.Add(this.lbloactio);
            this.Pmokki.Location = new System.Drawing.Point(27, 86);
            this.Pmokki.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pmokki.Name = "Pmokki";
            this.Pmokki.Size = new System.Drawing.Size(605, 370);
            this.Pmokki.TabIndex = 58;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(379, 123);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(143, 86);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 14;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(143, 123);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 13;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(379, 55);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(379, 86);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(143, 161);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(143, 55);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kuvaus";
            // 
            // btcanelcottage
            // 
            this.btcanelcottage.Location = new System.Drawing.Point(29, 321);
            this.btcanelcottage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcanelcottage.Name = "btcanelcottage";
            this.btcanelcottage.Size = new System.Drawing.Size(75, 30);
            this.btcanelcottage.TabIndex = 7;
            this.btcanelcottage.Text = "peruuta";
            this.btcanelcottage.UseVisualStyleBackColor = true;
            // 
            // btaddcottage
            // 
            this.btaddcottage.Location = new System.Drawing.Point(29, 292);
            this.btaddcottage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btaddcottage.Name = "btaddcottage";
            this.btaddcottage.Size = new System.Drawing.Size(75, 23);
            this.btaddcottage.TabIndex = 6;
            this.btaddcottage.Text = "Lisää";
            this.btaddcottage.UseVisualStyleBackColor = true;
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
            this.aikajaksobtn.Location = new System.Drawing.Point(1099, 932);
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
            this.jotainToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.jotainToolStripMenuItem.Text = "Jotain";
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.suljeToolStripMenuItem.Text = "Sulje";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnalueetjamökit
            // 
            this.tsbtnalueetjamökit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnalueetjamökit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnalueetjamökit.Image")));
            this.tsbtnalueetjamökit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnalueetjamökit.Name = "tsbtnalueetjamökit";
            this.tsbtnalueetjamökit.Size = new System.Drawing.Size(114, 28);
            this.tsbtnalueetjamökit.Text = "Alueet ja mökit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnasiakkaat
            // 
            this.tsbtnasiakkaat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnasiakkaat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnasiakkaat.Image")));
            this.tsbtnasiakkaat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnasiakkaat.Name = "tsbtnasiakkaat";
            this.tsbtnasiakkaat.Size = new System.Drawing.Size(76, 28);
            this.tsbtnasiakkaat.Text = "Asiakkaat";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnvaraukset
            // 
            this.tsbtnvaraukset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnvaraukset.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnvaraukset.Image")));
            this.tsbtnvaraukset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnvaraukset.Name = "tsbtnvaraukset";
            this.tsbtnvaraukset.Size = new System.Drawing.Size(76, 28);
            this.tsbtnvaraukset.Text = "Varaukset";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnlaskut
            // 
            this.tsbtnlaskut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnlaskut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnlaskut.Image")));
            this.tsbtnlaskut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnlaskut.Name = "tsbtnlaskut";
            this.tsbtnlaskut.Size = new System.Drawing.Size(54, 28);
            this.tsbtnlaskut.Text = "Laskut";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbtnpalvelut
            // 
            this.tsbtnpalvelut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnpalvelut.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnpalvelut.Image")));
            this.tsbtnpalvelut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnpalvelut.Name = "tsbtnpalvelut";
            this.tsbtnpalvelut.Size = new System.Drawing.Size(64, 28);
            this.tsbtnpalvelut.Text = "Palvelut";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Pasiakas);
            this.Controls.Add(this.Plasku);
            this.Controls.Add(this.Palue);
            this.Controls.Add(this.aikajaksobtn);
            this.Controls.Add(this.Ppalvelu);
            this.Controls.Add(this.Pmokki);
            this.Controls.Add(this.taulunimi);
            this.Controls.Add(this.Pvaraus);
            this.Controls.Add(this.lisaabtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laskubtn);
            this.Controls.Add(this.taulunimicb);
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
        private System.Windows.Forms.ComboBox taulunimicb;
        private System.Windows.Forms.Button laskubtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lisaabtn;
        private System.Windows.Forms.Label taulunimi;
        private System.Windows.Forms.ComboBox cbcottage;
        private System.Windows.Forms.ComboBox cblocation;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btreservation;
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
        private System.Windows.Forms.Button btcancel1;
        private System.Windows.Forms.Button btadd;
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
        private System.Windows.Forms.Button btcanelcottage;
        private System.Windows.Forms.Button btaddcottage;
        private System.Windows.Forms.Panel Pasiakas;
        private System.Windows.Forms.Panel Plasku;
        private System.Windows.Forms.Label lbbillID;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label lbbillprice;
        private System.Windows.Forms.Label lbbilltax;
        private System.Windows.Forms.Button btbillcancel;
        private System.Windows.Forms.Button btaddbill;
        private System.Windows.Forms.Label lbcustomeraddress;
        private System.Windows.Forms.Label lbcustomerfname;
        private System.Windows.Forms.Label lbcustomerlname;
        private System.Windows.Forms.Label lbcustomeremail;
        private System.Windows.Forms.Label lbcustormerphone;
        private System.Windows.Forms.Label lbcustomerpostcode;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button btcustomercancel;
        private System.Windows.Forms.Button btcustomeradd;
        private System.Windows.Forms.Panel Palue;
        private System.Windows.Forms.Button btlocationcancel;
        private System.Windows.Forms.Button btlocationadd;
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
    }
}

