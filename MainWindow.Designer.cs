﻿namespace Smart_SQLite
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSQLEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOUTPUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSQLiteScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblCon = new System.Windows.Forms.TabControl();
            this.DataView = new System.Windows.Forms.TabPage();
            this.dvGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLA = new System.Windows.Forms.RichTextBox();
            this.sqV = new System.Windows.Forms.DataGridView();
            this.txtSQLSchema = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtSQL = new System.Windows.Forms.RichTextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tts = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsLBL2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.TableNames = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.acM = new AutocompleteMenuNS.AutocompleteMenu();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.rbtnInsertMode = new System.Windows.Forms.CheckBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.tblCon.SuspendLayout();
            this.DataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqV)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenbankToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.printToolStripMenuItem,
            this.editToolStripMenuItem,
            this.itemExecute,
            this.developerToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datenbankToolStripMenuItem
            // 
            this.datenbankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.newToolStripMenuItem});
            this.datenbankToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("datenbankToolStripMenuItem.Image")));
            this.datenbankToolStripMenuItem.Name = "datenbankToolStripMenuItem";
            this.datenbankToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.datenbankToolStripMenuItem.Text = "Database";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripMenuItem.Image")));
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.öffnenToolStripMenuItem.Text = "Open";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pDFToolStripMenuItem.Image")));
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cSVToolStripMenuItem.Image")));
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSQLEditorToolStripMenuItem,
            this.clearOUTPUTToolStripMenuItem});
            this.clearToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearToolStripMenuItem.Image")));
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // clearSQLEditorToolStripMenuItem
            // 
            this.clearSQLEditorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearSQLEditorToolStripMenuItem.Image")));
            this.clearSQLEditorToolStripMenuItem.Name = "clearSQLEditorToolStripMenuItem";
            this.clearSQLEditorToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearSQLEditorToolStripMenuItem.Text = "Clear SQL Editor";
            this.clearSQLEditorToolStripMenuItem.Click += new System.EventHandler(this.clearSQLEditorToolStripMenuItem_Click);
            // 
            // clearOUTPUTToolStripMenuItem
            // 
            this.clearOUTPUTToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearOUTPUTToolStripMenuItem.Image")));
            this.clearOUTPUTToolStripMenuItem.Name = "clearOUTPUTToolStripMenuItem";
            this.clearOUTPUTToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.clearOUTPUTToolStripMenuItem.Text = "Clear OUTPUT";
            this.clearOUTPUTToolStripMenuItem.Click += new System.EventHandler(this.clearOUTPUTToolStripMenuItem_Click);
            // 
            // itemExecute
            // 
            this.itemExecute.Image = ((System.Drawing.Image)(resources.GetObject("itemExecute.Image")));
            this.itemExecute.Name = "itemExecute";
            this.itemExecute.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.itemExecute.Size = new System.Drawing.Size(76, 20);
            this.itemExecute.Text = "Execute";
            this.itemExecute.Click += new System.EventHandler(this.itemExecute_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSQLiteScriptToolStripMenuItem});
            this.developerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("developerToolStripMenuItem.Image")));
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.developerToolStripMenuItem.Text = "Developer";
            // 
            // loadSQLiteScriptToolStripMenuItem
            // 
            this.loadSQLiteScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadSQLiteScriptToolStripMenuItem.Image")));
            this.loadSQLiteScriptToolStripMenuItem.Name = "loadSQLiteScriptToolStripMenuItem";
            this.loadSQLiteScriptToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.loadSQLiteScriptToolStripMenuItem.Text = "Load SQLite Script";
            this.loadSQLiteScriptToolStripMenuItem.Click += new System.EventHandler(this.loadSQLiteScriptToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleToolStripMenuItem.Image")));
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.consoleToolStripMenuItem.Text = "Console";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tblCon
            // 
            this.tblCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblCon.Controls.Add(this.DataView);
            this.tblCon.Controls.Add(this.tabPage2);
            this.tblCon.ItemSize = new System.Drawing.Size(400, 15);
            this.tblCon.Location = new System.Drawing.Point(0, 27);
            this.tblCon.Name = "tblCon";
            this.tblCon.SelectedIndex = 0;
            this.tblCon.ShowToolTips = true;
            this.tblCon.Size = new System.Drawing.Size(1203, 598);
            this.tblCon.TabIndex = 1;
            // 
            // DataView
            // 
            this.DataView.Controls.Add(this.dvGV);
            this.DataView.Location = new System.Drawing.Point(4, 19);
            this.DataView.Name = "DataView";
            this.DataView.Padding = new System.Windows.Forms.Padding(3);
            this.DataView.Size = new System.Drawing.Size(1195, 575);
            this.DataView.TabIndex = 0;
            this.DataView.Text = "Data View";
            this.DataView.UseVisualStyleBackColor = true;
            // 
            // dvGV
            // 
            this.dvGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.dvGV.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvGV.Location = new System.Drawing.Point(0, -1);
            this.dvGV.Name = "dvGV";
            this.dvGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dvGV.Size = new System.Drawing.Size(1195, 573);
            this.dvGV.TabIndex = 0;
            this.dvGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvGV_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtLA);
            this.tabPage2.Controls.Add(this.sqV);
            this.tabPage2.Controls.Add(this.txtSQLSchema);
            this.tabPage2.Location = new System.Drawing.Point(4, 19);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1195, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SQL Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(852, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Actions";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SQLite Sequence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Table Schema";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLA
            // 
            this.acM.SetAutocompleteMenu(this.txtLA, null);
            this.txtLA.Location = new System.Drawing.Point(855, 25);
            this.txtLA.Name = "txtLA";
            this.txtLA.Size = new System.Drawing.Size(334, 546);
            this.txtLA.TabIndex = 2;
            this.txtLA.Text = "";
            // 
            // sqV
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.sqV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.sqV.BackgroundColor = System.Drawing.Color.DimGray;
            this.sqV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sqV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.sqV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sqV.DefaultCellStyle = dataGridViewCellStyle12;
            this.sqV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sqV.Location = new System.Drawing.Point(451, 25);
            this.sqV.Name = "sqV";
            this.sqV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqV.Size = new System.Drawing.Size(398, 546);
            this.sqV.TabIndex = 1;
            // 
            // txtSQLSchema
            // 
            this.acM.SetAutocompleteMenu(this.txtSQLSchema, null);
            this.txtSQLSchema.BackColor = System.Drawing.Color.Navy;
            this.txtSQLSchema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQLSchema.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSQLSchema.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSQLSchema.Location = new System.Drawing.Point(0, 25);
            this.txtSQLSchema.Name = "txtSQLSchema";
            this.txtSQLSchema.Size = new System.Drawing.Size(445, 546);
            this.txtSQLSchema.TabIndex = 0;
            this.txtSQLSchema.Text = "";
            this.txtSQLSchema.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acM.SetAutocompleteMenu(this.txtOutput, null);
            this.txtOutput.BackColor = System.Drawing.Color.Black;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Location = new System.Drawing.Point(4, 651);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(625, 96);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "";
            this.txtOutput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // txtSQL
            // 
            this.txtSQL.AcceptsTab = true;
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acM.SetAutocompleteMenu(this.txtSQL, this.acM);
            this.txtSQL.BackColor = System.Drawing.Color.BurlyWood;
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQL.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSQL.Location = new System.Drawing.Point(631, 651);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(706, 96);
            this.txtSQL.TabIndex = 3;
            this.txtSQL.Text = "";
            this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // ssStatus
            // 
            this.ssStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ssStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ssStatus.Dock = System.Windows.Forms.DockStyle.None;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tts,
            this.stsLBL2});
            this.ssStatus.Location = new System.Drawing.Point(0, 750);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssStatus.Size = new System.Drawing.Size(17, 22);
            this.ssStatus.TabIndex = 4;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tts
            // 
            this.tts.Name = "tts";
            this.tts.Size = new System.Drawing.Size(0, 17);
            // 
            // stsLBL2
            // 
            this.stsLBL2.Name = "stsLBL2";
            this.stsLBL2.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SQL CMD";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // TableNames
            // 
            this.TableNames.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.TableNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableNames.BackColor = System.Drawing.Color.Gainsboro;
            this.TableNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableNames.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNames.ForeColor = System.Drawing.Color.Black;
            this.TableNames.FullRowSelect = true;
            this.TableNames.GridLines = true;
            this.TableNames.HideSelection = false;
            this.TableNames.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TableNames.Location = new System.Drawing.Point(1205, 45);
            this.TableNames.Name = "TableNames";
            this.TableNames.Size = new System.Drawing.Size(132, 576);
            this.TableNames.TabIndex = 7;
            this.TableNames.UseCompatibleStateImageBehavior = false;
            this.TableNames.SelectedIndexChanged += new System.EventHandler(this.TableNames_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1202, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Table Names";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // acM
            // 
            this.acM.AllowsTabKey = true;
            this.acM.AppearInterval = 300;
            this.acM.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("acM.Colors")));
            this.acM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.acM.ImageList = null;
            this.acM.Items = new string[] {
        "SELECT ",
        "FROM",
        "WHERE",
        "ORDER BY",
        "SELECT DISTINCT",
        "AND",
        "OR",
        "NOT",
        "INSERT INTO",
        "IS NULL",
        "IS NOT NULL",
        "SET",
        "UPDATE",
        "DELETE",
        "TOP",
        "LIMIT",
        "MIN",
        "MAX",
        "COUNT",
        "AVG",
        "SUM",
        "LIKE",
        "IN",
        "BETWEEN ",
        "AS",
        "INNER JOIN",
        "LEFT OUTER JOIN",
        "RIGHT OUTER JOIN",
        "FULL OUTER JOIN",
        "JOIN",
        "LEFT JOIN",
        "RIGHT JOIN",
        "FULL JOIN",
        "UNION ",
        "UNION ALL",
        "GROUP BY",
        "HAVING",
        "WHERE EXISTS",
        "ANY",
        "ALL",
        "INTO",
        "CASE",
        "CREATE DATABASE",
        "DROP DATABASE",
        "BACKUP DATABASE",
        "CREATE TABLE",
        "DROP TABLE",
        "ALTER TABLE",
        "NOT NULL",
        "UNIQUE",
        "PRIMARY KEY",
        "FOREIGN KEY",
        "CHECK",
        "DEFAULT",
        "CREATE INDEX",
        "CREATE UNIQUE INDEX",
        "AUTO_INCREMENT",
        "VIEW"};
            this.acM.TargetControlWrapper = null;
            // 
            // cmb1
            // 
            this.cmb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Select template",
            "Insert template",
            "Join template",
            "order template"});
            this.cmb1.Location = new System.Drawing.Point(1205, 627);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(132, 21);
            this.cmb1.TabIndex = 1;
            this.cmb1.Text = "Templates";
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // rbtnInsertMode
            // 
            this.rbtnInsertMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnInsertMode.AutoSize = true;
            this.rbtnInsertMode.Location = new System.Drawing.Point(1121, 631);
            this.rbtnInsertMode.Name = "rbtnInsertMode";
            this.rbtnInsertMode.Size = new System.Drawing.Size(82, 17);
            this.rbtnInsertMode.TabIndex = 9;
            this.rbtnInsertMode.Text = "Insert Mode";
            this.rbtnInsertMode.UseVisualStyleBackColor = true;
            this.rbtnInsertMode.CheckedChanged += new System.EventHandler(this.rbtnInsertMode_CheckedChanged_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1344, 772);
            this.Controls.Add(this.rbtnInsertMode);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.tblCon);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Smart SQLite Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblCon.ResumeLayout(false);
            this.DataView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqV)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datenbankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.TabControl tblCon;
        private System.Windows.Forms.TabPage DataView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtSQL;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemExecute;
        private System.Windows.Forms.ToolStripStatusLabel tts;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox txtSQLSchema;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.DataGridView sqV;
        public System.Windows.Forms.DataGridView dvGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private AutocompleteMenuNS.AutocompleteMenu acM;
        public System.Windows.Forms.RichTextBox txtLA;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stsLBL2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSQLEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOUTPUTToolStripMenuItem;
        private System.Windows.Forms.CheckBox rbtnInsertMode;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem loadSQLiteScriptToolStripMenuItem;
        public System.Windows.Forms.ListView TableNames;
    }
}

