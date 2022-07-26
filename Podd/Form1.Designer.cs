namespace Podd
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
            this.rbtBeskrivning = new System.Windows.Forms.RichTextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbUppdateringsfrekvens = new System.Windows.Forms.ComboBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbKat = new System.Windows.Forms.Label();
            this.lbUppdateringsfrekvens = new System.Windows.Forms.Label();
            this.lbUrl = new System.Windows.Forms.Label();
            this.btnTaBortPodd = new System.Windows.Forms.Button();
            this.btnSparaPodd = new System.Windows.Forms.Button();
            this.btnNyPodd = new System.Windows.Forms.Button();
            this.lvAvsnitt = new System.Windows.Forms.ListView();
            this.lvPoddar = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lbKategori = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtBeskrivning
            // 
            this.rbtBeskrivning.Location = new System.Drawing.Point(558, 308);
            this.rbtBeskrivning.Name = "rbtBeskrivning";
            this.rbtBeskrivning.Size = new System.Drawing.Size(213, 212);
            this.rbtBeskrivning.TabIndex = 37;
            this.rbtBeskrivning.Text = "";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(203, 308);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(121, 24);
            this.cbKategori.TabIndex = 35;
            // 
            // cbUppdateringsfrekvens
            // 
            this.cbUppdateringsfrekvens.AutoCompleteCustomSource.AddRange(new string[] {
            "5 min",
            "10 min",
            "15 min",
            "20 min",
            "25 min",
            "30 min"});
            this.cbUppdateringsfrekvens.FormattingEnabled = true;
            this.cbUppdateringsfrekvens.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "30",
            "45",
            "60"});
            this.cbUppdateringsfrekvens.Location = new System.Drawing.Point(14, 308);
            this.cbUppdateringsfrekvens.Name = "cbUppdateringsfrekvens";
            this.cbUppdateringsfrekvens.Size = new System.Drawing.Size(121, 24);
            this.cbUppdateringsfrekvens.TabIndex = 34;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(12, 245);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(310, 22);
            this.txtURL.TabIndex = 33;
            // 
            // lbKat
            // 
            this.lbKat.AutoSize = true;
            this.lbKat.Location = new System.Drawing.Point(200, 279);
            this.lbKat.Name = "lbKat";
            this.lbKat.Size = new System.Drawing.Size(65, 17);
            this.lbKat.TabIndex = 32;
            this.lbKat.Text = "Kategori:";
            // 
            // lbUppdateringsfrekvens
            // 
            this.lbUppdateringsfrekvens.AllowDrop = true;
            this.lbUppdateringsfrekvens.AutoSize = true;
            this.lbUppdateringsfrekvens.Location = new System.Drawing.Point(11, 279);
            this.lbUppdateringsfrekvens.Name = "lbUppdateringsfrekvens";
            this.lbUppdateringsfrekvens.Size = new System.Drawing.Size(151, 17);
            this.lbUppdateringsfrekvens.TabIndex = 31;
            this.lbUppdateringsfrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(9, 215);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(40, 17);
            this.lbUrl.TabIndex = 30;
            this.lbUrl.Text = "URL:";
            // 
            // btnTaBortPodd
            // 
            this.btnTaBortPodd.Location = new System.Drawing.Point(458, 342);
            this.btnTaBortPodd.Name = "btnTaBortPodd";
            this.btnTaBortPodd.Size = new System.Drawing.Size(65, 31);
            this.btnTaBortPodd.TabIndex = 29;
            this.btnTaBortPodd.Text = "Ta bort";
            this.btnTaBortPodd.UseVisualStyleBackColor = true;
            this.btnTaBortPodd.Click += new System.EventHandler(this.btnTaBortPodd_Click);
            // 
            // btnSparaPodd
            // 
            this.btnSparaPodd.Location = new System.Drawing.Point(389, 342);
            this.btnSparaPodd.Name = "btnSparaPodd";
            this.btnSparaPodd.Size = new System.Drawing.Size(65, 31);
            this.btnSparaPodd.TabIndex = 28;
            this.btnSparaPodd.Text = "Spara";
            this.btnSparaPodd.UseVisualStyleBackColor = true;
            this.btnSparaPodd.Click += new System.EventHandler(this.btnSparaPodd_Click);
            // 
            // btnNyPodd
            // 
            this.btnNyPodd.Location = new System.Drawing.Point(321, 342);
            this.btnNyPodd.Name = "btnNyPodd";
            this.btnNyPodd.Size = new System.Drawing.Size(62, 31);
            this.btnNyPodd.TabIndex = 27;
            this.btnNyPodd.Text = "Ny";
            this.btnNyPodd.UseVisualStyleBackColor = true;
            this.btnNyPodd.Click += new System.EventHandler(this.btnNyPodd_Click);
            // 
            // lvAvsnitt
            // 
            this.lvAvsnitt.HideSelection = false;
            this.lvAvsnitt.Location = new System.Drawing.Point(12, 379);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(510, 141);
            this.lvAvsnitt.TabIndex = 26;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lvAvsnitt.SelectedIndexChanged += new System.EventHandler(this.lvAvsnitt_SelectedIndexChanged);
            // 
            // lvPoddar
            // 
            this.lvPoddar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPoddar.HideSelection = false;
            this.lvPoddar.Location = new System.Drawing.Point(12, 31);
            this.lvPoddar.Name = "lvPoddar";
            this.lvPoddar.Size = new System.Drawing.Size(511, 179);
            this.lvPoddar.TabIndex = 25;
            this.lvPoddar.UseCompatibleStateImageBehavior = false;
            this.lvPoddar.View = System.Windows.Forms.View.Details;
            this.lvPoddar.SelectedIndexChanged += new System.EventHandler(this.lvPoddar_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titel";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kategori";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Intervall";
            this.columnHeader4.Width = 88;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(695, 236);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(65, 31);
            this.btnTaBortKategori.TabIndex = 24;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(626, 236);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(65, 31);
            this.btnSparaKategori.TabIndex = 23;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(558, 236);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(62, 31);
            this.btnNyKategori.TabIndex = 22;
            this.btnNyKategori.Text = "Ny";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(558, 196);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(202, 22);
            this.txtKategori.TabIndex = 21;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(555, 10);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(65, 17);
            this.lblKategori.TabIndex = 20;
            this.lblKategori.Text = "Kategori:";
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.ItemHeight = 16;
            this.lbKategori.Location = new System.Drawing.Point(558, 31);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(202, 148);
            this.lbKategori.TabIndex = 38;
            this.lbKategori.SelectedIndexChanged += new System.EventHandler(this.lbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Podcasts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Avsnitt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Beskrivning:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.rbtBeskrivning);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbUppdateringsfrekvens);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lbKat);
            this.Controls.Add(this.lbUppdateringsfrekvens);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.btnTaBortPodd);
            this.Controls.Add(this.btnSparaPodd);
            this.Controls.Add(this.btnNyPodd);
            this.Controls.Add(this.lvAvsnitt);
            this.Controls.Add(this.lvPoddar);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.lblKategori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbtBeskrivning;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbUppdateringsfrekvens;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lbKat;
        private System.Windows.Forms.Label lbUppdateringsfrekvens;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.Button btnTaBortPodd;
        private System.Windows.Forms.Button btnSparaPodd;
        private System.Windows.Forms.Button btnNyPodd;
        private System.Windows.Forms.ListView lvAvsnitt;
        private System.Windows.Forms.ListView lvPoddar;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ListBox lbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

