namespace MökkingProjekti
{
    partial class laskuform
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
            this.tulostalaskubtn = new System.Windows.Forms.Button();
            this.varausdgv = new System.Windows.Forms.DataGridView();
            this.mokkingDBDataSet = new MökkingProjekti.MokkingDBDataSet();
            this.mokkingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausTableAdapter = new MökkingProjekti.MokkingDBDataSetTableAdapters.varausTableAdapter();
            this.asiakaannimitb = new System.Windows.Forms.TextBox();
            this.mokinnimitb = new System.Windows.Forms.TextBox();
            this.toimipaikkatb = new System.Windows.Forms.TextBox();
            this.palveluidenlkmtb = new System.Windows.Forms.TextBox();
            this.alkamispvmtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loppumispvmtb = new System.Windows.Forms.TextBox();
            this.laskunsummatb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.varauksenidtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.varausdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tulostalaskubtn
            // 
            this.tulostalaskubtn.Location = new System.Drawing.Point(985, 290);
            this.tulostalaskubtn.Name = "tulostalaskubtn";
            this.tulostalaskubtn.Size = new System.Drawing.Size(346, 90);
            this.tulostalaskubtn.TabIndex = 5;
            this.tulostalaskubtn.Text = "tulosta lasku";
            this.tulostalaskubtn.UseVisualStyleBackColor = true;
            this.tulostalaskubtn.Click += new System.EventHandler(this.tulostalaskubtn_Click);
            // 
            // varausdgv
            // 
            this.varausdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varausdgv.Location = new System.Drawing.Point(12, 12);
            this.varausdgv.Name = "varausdgv";
            this.varausdgv.Size = new System.Drawing.Size(879, 426);
            this.varausdgv.TabIndex = 6;
            this.varausdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varausdgv_CellContentClick);
            // 
            // mokkingDBDataSet
            // 
            this.mokkingDBDataSet.DataSetName = "MokkingDBDataSet";
            this.mokkingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokkingDBDataSetBindingSource
            // 
            this.mokkingDBDataSetBindingSource.DataSource = this.mokkingDBDataSet;
            this.mokkingDBDataSetBindingSource.Position = 0;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.mokkingDBDataSetBindingSource;
            // 
            // varausTableAdapter
            // 
            this.varausTableAdapter.ClearBeforeFill = true;
            // 
            // asiakaannimitb
            // 
            this.asiakaannimitb.Location = new System.Drawing.Point(985, 39);
            this.asiakaannimitb.Name = "asiakaannimitb";
            this.asiakaannimitb.Size = new System.Drawing.Size(113, 20);
            this.asiakaannimitb.TabIndex = 7;
            // 
            // mokinnimitb
            // 
            this.mokinnimitb.Location = new System.Drawing.Point(1218, 39);
            this.mokinnimitb.Name = "mokinnimitb";
            this.mokinnimitb.Size = new System.Drawing.Size(113, 20);
            this.mokinnimitb.TabIndex = 8;
            // 
            // toimipaikkatb
            // 
            this.toimipaikkatb.Location = new System.Drawing.Point(985, 92);
            this.toimipaikkatb.Name = "toimipaikkatb";
            this.toimipaikkatb.Size = new System.Drawing.Size(113, 20);
            this.toimipaikkatb.TabIndex = 9;
            // 
            // palveluidenlkmtb
            // 
            this.palveluidenlkmtb.Location = new System.Drawing.Point(1218, 92);
            this.palveluidenlkmtb.Name = "palveluidenlkmtb";
            this.palveluidenlkmtb.Size = new System.Drawing.Size(113, 20);
            this.palveluidenlkmtb.TabIndex = 10;
            // 
            // alkamispvmtb
            // 
            this.alkamispvmtb.Location = new System.Drawing.Point(985, 153);
            this.alkamispvmtb.Name = "alkamispvmtb";
            this.alkamispvmtb.Size = new System.Drawing.Size(113, 20);
            this.alkamispvmtb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Asiakkaan nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1215, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mökin nimi";
            // 
            // loppumispvmtb
            // 
            this.loppumispvmtb.Location = new System.Drawing.Point(1218, 153);
            this.loppumispvmtb.Name = "loppumispvmtb";
            this.loppumispvmtb.Size = new System.Drawing.Size(113, 20);
            this.loppumispvmtb.TabIndex = 16;
            // 
            // laskunsummatb
            // 
            this.laskunsummatb.Location = new System.Drawing.Point(985, 210);
            this.laskunsummatb.Name = "laskunsummatb";
            this.laskunsummatb.Size = new System.Drawing.Size(113, 20);
            this.laskunsummatb.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(982, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Toimipaikka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1215, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Käytettyjen palveluiden lkm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(982, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Varauksen alkamispvm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1215, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Varauksen loppumispvm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(982, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Laskun summa";
            // 
            // varauksenidtb
            // 
            this.varauksenidtb.Location = new System.Drawing.Point(1218, 210);
            this.varauksenidtb.Name = "varauksenidtb";
            this.varauksenidtb.Size = new System.Drawing.Size(113, 20);
            this.varauksenidtb.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1215, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Varauksen ID";
            // 
            // laskuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.varauksenidtb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laskunsummatb);
            this.Controls.Add(this.loppumispvmtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alkamispvmtb);
            this.Controls.Add(this.palveluidenlkmtb);
            this.Controls.Add(this.toimipaikkatb);
            this.Controls.Add(this.mokinnimitb);
            this.Controls.Add(this.asiakaannimitb);
            this.Controls.Add(this.varausdgv);
            this.Controls.Add(this.tulostalaskubtn);
            this.Name = "laskuform";
            this.Text = "laskuform";
            this.Load += new System.EventHandler(this.laskuform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.varausdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkingDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tulostalaskubtn;
        private System.Windows.Forms.DataGridView varausdgv;
        private System.Windows.Forms.BindingSource mokkingDBDataSetBindingSource;
        private MokkingDBDataSet mokkingDBDataSet;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private MokkingDBDataSetTableAdapters.varausTableAdapter varausTableAdapter;
        private System.Windows.Forms.TextBox asiakaannimitb;
        private System.Windows.Forms.TextBox mokinnimitb;
        private System.Windows.Forms.TextBox toimipaikkatb;
        private System.Windows.Forms.TextBox palveluidenlkmtb;
        private System.Windows.Forms.TextBox alkamispvmtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loppumispvmtb;
        private System.Windows.Forms.TextBox laskunsummatb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox varauksenidtb;
        private System.Windows.Forms.Label label8;
    }
}