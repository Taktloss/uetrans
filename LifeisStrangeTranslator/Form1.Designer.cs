﻿namespace LifeisStrangeTranslator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemMain = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.translationFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToTransToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMain,
            this.importToolStripMenuItem1,
            this.exportToolStripMenuItem1,
            this.convertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemMain
            // 
            this.toolStripMenuItemMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.toolStripMenuItemMain.Name = "toolStripMenuItemMain";
            this.toolStripMenuItemMain.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemMain.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.directoryToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.fileToolStripMenuItem1.Text = "File";
            this.fileToolStripMenuItem1.Click += new System.EventHandler(this.fileToolStripMenuItem1_Click);
            // 
            // directoryToolStripMenuItem1
            // 
            this.directoryToolStripMenuItem1.Name = "directoryToolStripMenuItem1";
            this.directoryToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.directoryToolStripMenuItem1.Text = "Directory";
            this.directoryToolStripMenuItem1.Click += new System.EventHandler(this.directoryToolStripMenuItem1_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem1.Text = "Import";
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem1,
            this.translationFileToolStripMenuItem});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem1.Text = "Export";
            // 
            // cSVToolStripMenuItem1
            // 
            this.cSVToolStripMenuItem1.Name = "cSVToolStripMenuItem1";
            this.cSVToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.cSVToolStripMenuItem1.Text = "CSV";
            this.cSVToolStripMenuItem1.Click += new System.EventHandler(this.cSVToolStripMenuItem1_Click);
            // 
            // translationFileToolStripMenuItem
            // 
            this.translationFileToolStripMenuItem.Name = "translationFileToolStripMenuItem";
            this.translationFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.translationFileToolStripMenuItem.Text = "Translation File";
            this.translationFileToolStripMenuItem.Click += new System.EventHandler(this.translationFileToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToTransToolStripMenuItem,
            this.transToCSVToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // cSVToTransToolStripMenuItem
            // 
            this.cSVToTransToolStripMenuItem.Name = "cSVToTransToolStripMenuItem";
            this.cSVToTransToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cSVToTransToolStripMenuItem.Text = "CSV to Trans";
            this.cSVToTransToolStripMenuItem.Click += new System.EventHandler(this.cSVToTransToolStripMenuItem_Click);
            // 
            // transToCSVToolStripMenuItem
            // 
            this.transToCSVToolStripMenuItem.Name = "transToCSVToolStripMenuItem";
            this.transToCSVToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.transToCSVToolStripMenuItem.Text = "Trans to CSV";
            this.transToCSVToolStripMenuItem.Click += new System.EventHandler(this.transToCSVToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Text});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 387);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Text
            // 
            this.Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Text.HeaderText = "Original Text";
            this.Text.Name = "Text";
            this.Text.Width = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 426);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMain;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem translationFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToTransToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem directoryToolStripMenuItem1;
    }
}

