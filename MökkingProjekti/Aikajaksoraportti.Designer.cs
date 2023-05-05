namespace MökkingProjekti
{
    partial class Aikajaksoraportti
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
            this.alkamispvmdatetime = new System.Windows.Forms.DateTimePicker();
            this.paattymispaivadatetime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aikajaksoraporttidgv = new System.Windows.Forms.DataGridView();
            this.lisapalvelutradio = new System.Windows.Forms.RadioButton();
            this.majoittumisetradio = new System.Windows.Forms.RadioButton();
            this.aikajaksopanel = new System.Windows.Forms.Panel();
            this.aikaraportticb = new System.Windows.Forms.ComboBox();
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mokkingDBDataSet = new MökkingProjekti.MokkingDBDataSet();
            this.aikajaksolabel = new System.Windows.Forms.Label();
            this.alueTableAdapter = new MökkingProjekti.MokkingDBDataSetTableAdapters.alueTableAdapter();
            this.aikajaksoetsibtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aikajaksoraporttidgv)).BeginInit();
            this.aikajaksopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // alkamispvmdatetime
            // 
            this.alkamispvmdatetime.Location = new System.Drawing.Point(31, 48);
            this.alkamispvmdatetime.MaxDate = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.alkamispvmdatetime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.alkamispvmdatetime.Name = "alkamispvmdatetime";
            this.alkamispvmdatetime.Size = new System.Drawing.Size(200, 20);
            this.alkamispvmdatetime.TabIndex = 0;
            this.alkamispvmdatetime.Value = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            this.alkamispvmdatetime.ValueChanged += new System.EventHandler(this.alkamispvmdatetime_ValueChanged);
            // 
            // paattymispaivadatetime
            // 
            this.paattymispaivadatetime.Location = new System.Drawing.Point(31, 121);
            this.paattymispaivadatetime.MaxDate = new System.DateTime(5000, 1, 1, 0, 0, 0, 0);
            this.paattymispaivadatetime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.paattymispaivadatetime.Name = "paattymispaivadatetime";
            this.paattymispaivadatetime.Size = new System.Drawing.Size(200, 20);
            this.paattymispaivadatetime.TabIndex = 1;
            this.paattymispaivadatetime.Value = new System.DateTime(2023, 5, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alkamispäivämäärä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Päättymispäivämäärä";
            // 
            // aikajaksoraporttidgv
            // 
            this.aikajaksoraporttidgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aikajaksoraporttidgv.Location = new System.Drawing.Point(299, 32);
            this.aikajaksoraporttidgv.Name = "aikajaksoraporttidgv";
            this.aikajaksoraporttidgv.Size = new System.Drawing.Size(965, 346);
            this.aikajaksoraporttidgv.TabIndex = 7;
            // 
            // lisapalvelutradio
            // 
            this.lisapalvelutradio.AutoSize = true;
            this.lisapalvelutradio.Location = new System.Drawing.Point(0, 26);
            this.lisapalvelutradio.Name = "lisapalvelutradio";
            this.lisapalvelutradio.Size = new System.Drawing.Size(114, 17);
            this.lisapalvelutradio.TabIndex = 8;
            this.lisapalvelutradio.Text = "Ostetut lisäpalvelut";
            this.lisapalvelutradio.UseVisualStyleBackColor = true;
            // 
            // majoittumisetradio
            // 
            this.majoittumisetradio.AutoSize = true;
            this.majoittumisetradio.Checked = true;
            this.majoittumisetradio.Location = new System.Drawing.Point(0, 3);
            this.majoittumisetradio.Name = "majoittumisetradio";
            this.majoittumisetradio.Size = new System.Drawing.Size(86, 17);
            this.majoittumisetradio.TabIndex = 9;
            this.majoittumisetradio.TabStop = true;
            this.majoittumisetradio.Text = "Majoittumiset";
            this.majoittumisetradio.UseVisualStyleBackColor = true;
            // 
            // aikajaksopanel
            // 
            this.aikajaksopanel.Controls.Add(this.majoittumisetradio);
            this.aikajaksopanel.Controls.Add(this.lisapalvelutradio);
            this.aikajaksopanel.Location = new System.Drawing.Point(31, 164);
            this.aikajaksopanel.Name = "aikajaksopanel";
            this.aikajaksopanel.Size = new System.Drawing.Size(128, 50);
            this.aikajaksopanel.TabIndex = 10;
            this.aikajaksopanel.Click += new System.EventHandler(this.aikajaksopanel_Click);
            // 
            // aikaraportticb
            // 
            this.aikaraportticb.DataSource = this.alueBindingSource;
            this.aikaraportticb.DisplayMember = "nimi";
            this.aikaraportticb.FormattingEnabled = true;
            this.aikaraportticb.Location = new System.Drawing.Point(31, 254);
            this.aikaraportticb.Name = "aikaraportticb";
            this.aikaraportticb.Size = new System.Drawing.Size(121, 21);
            this.aikaraportticb.TabIndex = 11;
            this.aikaraportticb.ValueMember = "nimi";
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.mokkingDBDataSet;
            // 
            // mokkingDBDataSet
            // 
            this.mokkingDBDataSet.DataSetName = "MokkingDBDataSet";
            this.mokkingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aikajaksolabel
            // 
            this.aikajaksolabel.AutoSize = true;
            this.aikajaksolabel.Location = new System.Drawing.Point(31, 235);
            this.aikajaksolabel.Name = "aikajaksolabel";
            this.aikajaksolabel.Size = new System.Drawing.Size(28, 13);
            this.aikajaksolabel.TabIndex = 12;
            this.aikajaksolabel.Text = "Alue";
            // 
            // alueTableAdapter
            // 
            this.alueTableAdapter.ClearBeforeFill = true;
            // 
            // aikajaksoetsibtn
            // 
            this.aikajaksoetsibtn.Location = new System.Drawing.Point(31, 355);
            this.aikajaksoetsibtn.Name = "aikajaksoetsibtn";
            this.aikajaksoetsibtn.Size = new System.Drawing.Size(121, 23);
            this.aikajaksoetsibtn.TabIndex = 14;
            this.aikajaksoetsibtn.Text = "Hae aikajaksolta";
            this.aikajaksoetsibtn.UseVisualStyleBackColor = true;
            this.aikajaksoetsibtn.Click += new System.EventHandler(this.aikajaksoetsibtn_Click);
            // 
            // Aikajaksoraportti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 450);
            this.Controls.Add(this.aikajaksoetsibtn);
            this.Controls.Add(this.aikajaksolabel);
            this.Controls.Add(this.aikaraportticb);
            this.Controls.Add(this.aikajaksopanel);
            this.Controls.Add(this.aikajaksoraporttidgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paattymispaivadatetime);
            this.Controls.Add(this.alkamispvmdatetime);
            this.Name = "Aikajaksoraportti";
            this.Text = "Aikajaksoraportti";
            this.Load += new System.EventHandler(this.Aikajaksoraportti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aikajaksoraporttidgv)).EndInit();
            this.aikajaksopanel.ResumeLayout(false);
            this.aikajaksopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker alkamispvmdatetime;
        private System.Windows.Forms.DateTimePicker paattymispaivadatetime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView aikajaksoraporttidgv;
        private System.Windows.Forms.RadioButton lisapalvelutradio;
        private System.Windows.Forms.RadioButton majoittumisetradio;
        private System.Windows.Forms.Panel aikajaksopanel;
        private System.Windows.Forms.ComboBox aikaraportticb;
        private System.Windows.Forms.Label aikajaksolabel;
        private MokkingDBDataSet mokkingDBDataSet;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private MokkingDBDataSetTableAdapters.alueTableAdapter alueTableAdapter;
        private System.Windows.Forms.Button aikajaksoetsibtn;
    }
}