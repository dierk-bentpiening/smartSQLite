namespace Smart_SQLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datenbankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblCon = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.TableNames = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnInsertMode = new System.Windows.Forms.RadioButton();
            this.acM = new AutocompleteMenuNS.AutocompleteMenu();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tblCon.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqV)).BeginInit();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datenbankToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.editToolStripMenuItem,
            this.itemExecute,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1344, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datenbankToolStripMenuItem
            // 
            this.datenbankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem});
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
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.öffnenToolStripMenuItem.Text = "Open";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editToolStripMenuItem.Text = "Edit";
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
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
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.sortToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sortToolStripMenuItem.Image")));
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ascendingToolStripMenuItem.Image")));
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("descendingToolStripMenuItem.Image")));
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // tblCon
            // 
            this.tblCon.Controls.Add(this.tabPage1);
            this.tblCon.Controls.Add(this.tabPage2);
            this.tblCon.ItemSize = new System.Drawing.Size(400, 15);
            this.tblCon.Location = new System.Drawing.Point(0, 27);
            this.tblCon.Name = "tblCon";
            this.tblCon.SelectedIndex = 0;
            this.tblCon.ShowToolTips = true;
            this.tblCon.Size = new System.Drawing.Size(1203, 598);
            this.tblCon.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1195, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvGV
            // 
            this.dvGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvGV.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sqV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.sqV.BackgroundColor = System.Drawing.Color.DimGray;
            this.sqV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sqV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.sqV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sqV.DefaultCellStyle = dataGridViewCellStyle6;
            this.sqV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sqV.Location = new System.Drawing.Point(451, 25);
            this.sqV.Name = "sqV";
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
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.acM.SetAutocompleteMenu(this.txtSQL, this.acM);
            this.txtSQL.BackColor = System.Drawing.SystemColors.Info;
            this.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSQL.Location = new System.Drawing.Point(631, 651);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(706, 96);
            this.txtSQL.TabIndex = 3;
            this.txtSQL.Text = "";
            this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tts});
            this.ssStatus.Location = new System.Drawing.Point(0, 750);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ssStatus.Size = new System.Drawing.Size(1344, 22);
            this.ssStatus.TabIndex = 4;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tts
            // 
            this.tts.Name = "tts";
            this.tts.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // label2
            // 
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
            this.TableNames.AutoArrange = false;
            this.TableNames.BackColor = System.Drawing.Color.DarkCyan;
            this.TableNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableNames.CheckBoxes = true;
            this.TableNames.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNames.ForeColor = System.Drawing.SystemColors.Window;
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
            // rbtnInsertMode
            // 
            this.rbtnInsertMode.AutoSize = true;
            this.rbtnInsertMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnInsertMode.Location = new System.Drawing.Point(1070, 631);
            this.rbtnInsertMode.Name = "rbtnInsertMode";
            this.rbtnInsertMode.Size = new System.Drawing.Size(79, 17);
            this.rbtnInsertMode.TabIndex = 9;
            this.rbtnInsertMode.TabStop = true;
            this.rbtnInsertMode.Text = "Insert mode";
            this.rbtnInsertMode.UseVisualStyleBackColor = true;
            this.rbtnInsertMode.CheckedChanged += new System.EventHandler(this.rbtnInsertMode_CheckedChanged);
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
            this.cmb1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(1205, 627);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(132, 21);
            this.cmb1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1344, 772);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.rbtnInsertMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TableNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.tblCon);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Smart SQLite";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tblCon.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.ListView TableNames;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox txtSQLSchema;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.DataGridView sqV;
        public System.Windows.Forms.DataGridView dvGV;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbtnInsertMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private AutocompleteMenuNS.AutocompleteMenu acM;
        public System.Windows.Forms.RichTextBox txtLA;
        private System.Windows.Forms.ComboBox cmb1;
    }
}

