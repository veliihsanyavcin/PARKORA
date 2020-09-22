namespace PARKORA
{
    partial class MainForm
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
            this.grpAracInfo1 = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewTicketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRapor = new System.Windows.Forms.Button();
            this.listViewTicketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listViewTicketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.grpAracInfo1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTicketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTicketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTicketBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAracInfo1
            // 
            this.grpAracInfo1.Controls.Add(this.btnGiris);
            this.grpAracInfo1.Controls.Add(this.cmbSinif);
            this.grpAracInfo1.Controls.Add(this.label3);
            this.grpAracInfo1.Controls.Add(this.txtPlaka);
            this.grpAracInfo1.Controls.Add(this.label1);
            this.grpAracInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAracInfo1.Location = new System.Drawing.Point(12, 12);
            this.grpAracInfo1.Name = "grpAracInfo1";
            this.grpAracInfo1.Size = new System.Drawing.Size(245, 211);
            this.grpAracInfo1.TabIndex = 0;
            this.grpAracInfo1.TabStop = false;
            this.grpAracInfo1.Text = "Araç Girişi";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(29, 155);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(190, 39);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Araç Girişi";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(86, 105);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(133, 32);
            this.cmbSinif.TabIndex = 2;
            this.cmbSinif.SelectedIndexChanged += new System.EventHandler(this.cmbSinif_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sınıfı";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(86, 44);
            this.txtPlaka.Mask = "00 LL 0000";
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(133, 29);
            this.txtPlaka.TabIndex = 0;
            this.txtPlaka.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPlaka_MaskInputRejected);
            this.txtPlaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlaka_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // lstAraclar
            // 
            this.lstAraclar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstAraclar.DataSource = this.listViewTicketBindingSource;
            this.lstAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.ItemHeight = 24;
            this.lstAraclar.Location = new System.Drawing.Point(272, 23);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(481, 364);
            this.lstAraclar.TabIndex = 1;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(PARKORA.Ticket);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(12, 245);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(245, 142);
            this.btnRapor.TabIndex = 0;
            this.btnRapor.Text = "RAPOR";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 400);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.grpAracInfo1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAracInfo1.ResumeLayout(false);
            this.grpAracInfo1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listViewTicketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTicketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listViewTicketBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAracInfo1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.BindingSource listViewTicketBindingSource;
        private System.Windows.Forms.BindingSource listViewTicketBindingSource1;
        private System.Windows.Forms.BindingSource listViewTicketBindingSource2;
    }
}

