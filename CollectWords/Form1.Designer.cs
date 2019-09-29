namespace CollectWords
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.tbFileType = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dgv1 = new System.Windows.Forms.DataGridView();
      this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgv2 = new System.Windows.Forms.DataGridView();
      this.FileContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgvFoundWords = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblMsg = new System.Windows.Forms.Label();
      this.btnDefineFolders = new System.Windows.Forms.Button();
      this.dgvFoldersToScan = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.clbSelectDrive = new System.Windows.Forms.CheckedListBox();
      this.btnRescanDrivers = new System.Windows.Forms.Button();
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbCaseSensitive = new System.Windows.Forms.CheckBox();
      this.dgvFoundFiles = new System.Windows.Forms.DataGridView();
      this.FoundFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTimeElapsed = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundWords)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoldersToScan)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnExit.Location = new System.Drawing.Point(12, 610);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(319, 34);
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnStart
      // 
      this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnStart.Location = new System.Drawing.Point(12, 346);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(323, 34);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Start Collecting (Takes Time)";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // tbFileType
      // 
      this.tbFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.tbFileType.Location = new System.Drawing.Point(12, 152);
      this.tbFileType.Name = "tbFileType";
      this.tbFileType.Size = new System.Drawing.Size(256, 26);
      this.tbFileType.TabIndex = 4;
      this.tbFileType.TextChanged += new System.EventHandler(this.tbFileType_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label1.Location = new System.Drawing.Point(12, 109);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(256, 40);
      this.label1.TabIndex = 5;
      this.label1.Text = "File Type\r\n(Comma/Space Separated Values)";
      // 
      // dgv1
      // 
      this.dgv1.AllowUserToAddRows = false;
      this.dgv1.AllowUserToDeleteRows = false;
      this.dgv1.AllowUserToResizeColumns = false;
      this.dgv1.AllowUserToResizeRows = false;
      this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle33.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
      this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Line,
            this.FullPath});
      dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv1.DefaultCellStyle = dataGridViewCellStyle36;
      this.dgv1.EnableHeadersVisualStyles = false;
      this.dgv1.Location = new System.Drawing.Point(985, 84);
      this.dgv1.MultiSelect = false;
      this.dgv1.Name = "dgv1";
      this.dgv1.ReadOnly = true;
      this.dgv1.RowHeadersVisible = false;
      this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv1.Size = new System.Drawing.Size(556, 294);
      this.dgv1.TabIndex = 11;
      this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
      this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
      // 
      // FileName
      // 
      this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle34.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FileName.DefaultCellStyle = dataGridViewCellStyle34;
      this.FileName.HeaderText = "File";
      this.FileName.Name = "FileName";
      this.FileName.ReadOnly = true;
      this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // Line
      // 
      this.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      dataGridViewCellStyle35.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Line.DefaultCellStyle = dataGridViewCellStyle35;
      this.Line.HeaderText = "Line";
      this.Line.Name = "Line";
      this.Line.ReadOnly = true;
      this.Line.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.Line.Width = 70;
      // 
      // FullPath
      // 
      this.FullPath.HeaderText = "FullPath";
      this.FullPath.Name = "FullPath";
      this.FullPath.ReadOnly = true;
      this.FullPath.Visible = false;
      // 
      // dgv2
      // 
      this.dgv2.AllowUserToAddRows = false;
      this.dgv2.AllowUserToDeleteRows = false;
      this.dgv2.AllowUserToResizeColumns = false;
      this.dgv2.AllowUserToResizeRows = false;
      this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle37.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
      this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileContent});
      dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv2.DefaultCellStyle = dataGridViewCellStyle39;
      this.dgv2.EnableHeadersVisualStyles = false;
      this.dgv2.Location = new System.Drawing.Point(341, 386);
      this.dgv2.MultiSelect = false;
      this.dgv2.Name = "dgv2";
      this.dgv2.ReadOnly = true;
      this.dgv2.RowHeadersVisible = false;
      this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv2.Size = new System.Drawing.Size(1204, 376);
      this.dgv2.TabIndex = 12;
      this.dgv2.DoubleClick += new System.EventHandler(this.dgv2_DoubleClick);
      // 
      // FileContent
      // 
      this.FileContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle38.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FileContent.DefaultCellStyle = dataGridViewCellStyle38;
      this.FileContent.HeaderText = "FileContent";
      this.FileContent.Name = "FileContent";
      this.FileContent.ReadOnly = true;
      this.FileContent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.FileContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // dgvFoundWords
      // 
      this.dgvFoundWords.AllowUserToAddRows = false;
      this.dgvFoundWords.AllowUserToDeleteRows = false;
      this.dgvFoundWords.AllowUserToResizeColumns = false;
      this.dgvFoundWords.AllowUserToResizeRows = false;
      dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle40.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvFoundWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
      this.dgvFoundWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFoundWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
      dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvFoundWords.DefaultCellStyle = dataGridViewCellStyle42;
      this.dgvFoundWords.EnableHeadersVisualStyles = false;
      this.dgvFoundWords.Location = new System.Drawing.Point(341, 82);
      this.dgvFoundWords.MultiSelect = false;
      this.dgvFoundWords.Name = "dgvFoundWords";
      this.dgvFoundWords.ReadOnly = true;
      this.dgvFoundWords.RowHeadersVisible = false;
      this.dgvFoundWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFoundWords.Size = new System.Drawing.Size(638, 296);
      this.dgvFoundWords.TabIndex = 13;
      this.dgvFoundWords.SelectionChanged += new System.EventHandler(this.dgvFoundWords_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle41.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle41.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle41;
      this.dataGridViewTextBoxColumn1.HeaderText = "Found Words";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // lblMsg
      // 
      this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblMsg.AutoSize = true;
      this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblMsg.Location = new System.Drawing.Point(337, 775);
      this.lblMsg.Name = "lblMsg";
      this.lblMsg.Size = new System.Drawing.Size(82, 20);
      this.lblMsg.TabIndex = 15;
      this.lblMsg.Text = "Messages";
      // 
      // btnDefineFolders
      // 
      this.btnDefineFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnDefineFolders.Location = new System.Drawing.Point(12, 184);
      this.btnDefineFolders.Name = "btnDefineFolders";
      this.btnDefineFolders.Size = new System.Drawing.Size(182, 34);
      this.btnDefineFolders.TabIndex = 19;
      this.btnDefineFolders.Text = "Define Folder(s)";
      this.btnDefineFolders.UseVisualStyleBackColor = true;
      this.btnDefineFolders.Click += new System.EventHandler(this.btnDefineFolders_Click);
      // 
      // dgvFoldersToScan
      // 
      this.dgvFoldersToScan.AllowUserToAddRows = false;
      this.dgvFoldersToScan.AllowUserToResizeColumns = false;
      this.dgvFoldersToScan.AllowUserToResizeRows = false;
      dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvFoldersToScan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
      this.dgvFoldersToScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFoldersToScan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
      dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvFoldersToScan.DefaultCellStyle = dataGridViewCellStyle45;
      this.dgvFoldersToScan.EnableHeadersVisualStyles = false;
      this.dgvFoldersToScan.Location = new System.Drawing.Point(12, 224);
      this.dgvFoldersToScan.MultiSelect = false;
      this.dgvFoldersToScan.Name = "dgvFoldersToScan";
      this.dgvFoldersToScan.ReadOnly = true;
      this.dgvFoldersToScan.RowHeadersVisible = false;
      this.dgvFoldersToScan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFoldersToScan.Size = new System.Drawing.Size(323, 116);
      this.dgvFoldersToScan.TabIndex = 20;
      this.dgvFoldersToScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFoldersToScan_MouseClick);
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle44.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle44;
      this.dataGridViewTextBoxColumn2.HeaderText = "Folder to Scan";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      // 
      // clbSelectDrive
      // 
      this.clbSelectDrive.CheckOnClick = true;
      this.clbSelectDrive.FormattingEnabled = true;
      this.clbSelectDrive.Location = new System.Drawing.Point(12, 12);
      this.clbSelectDrive.Name = "clbSelectDrive";
      this.clbSelectDrive.Size = new System.Drawing.Size(120, 94);
      this.clbSelectDrive.TabIndex = 22;
      this.clbSelectDrive.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbSelectDrive_ItemCheck);
      // 
      // btnRescanDrivers
      // 
      this.btnRescanDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnRescanDrivers.Location = new System.Drawing.Point(138, 12);
      this.btnRescanDrivers.Name = "btnRescanDrivers";
      this.btnRescanDrivers.Size = new System.Drawing.Size(130, 34);
      this.btnRescanDrivers.TabIndex = 23;
      this.btnRescanDrivers.Text = "Rescan";
      this.btnRescanDrivers.UseVisualStyleBackColor = true;
      this.btnRescanDrivers.Click += new System.EventHandler(this.btnRescanDrivers_Click);
      // 
      // tbFilter
      // 
      this.tbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.tbFilter.Location = new System.Drawing.Point(341, 50);
      this.tbFilter.Name = "tbFilter";
      this.tbFilter.Size = new System.Drawing.Size(1102, 26);
      this.tbFilter.TabIndex = 24;
      this.tbFilter.Text = "C:\\Users\\acleite\\Documents\\Bosch Steering Wheel\\Task6191\\DirImplementationSet\\Imp" +
    "lementationSet\\SCL";
      this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label2.Location = new System.Drawing.Point(337, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 20);
      this.label2.TabIndex = 25;
      this.label2.Text = "Filter";
      // 
      // cbCaseSensitive
      // 
      this.cbCaseSensitive.AutoSize = true;
      this.cbCaseSensitive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.cbCaseSensitive.Location = new System.Drawing.Point(387, 18);
      this.cbCaseSensitive.Name = "cbCaseSensitive";
      this.cbCaseSensitive.Size = new System.Drawing.Size(130, 24);
      this.cbCaseSensitive.TabIndex = 26;
      this.cbCaseSensitive.Text = "Case sensitive";
      this.cbCaseSensitive.UseVisualStyleBackColor = true;
      this.cbCaseSensitive.CheckedChanged += new System.EventHandler(this.cbCaseSensitive_CheckedChanged);
      // 
      // dgvFoundFiles
      // 
      this.dgvFoundFiles.AllowUserToAddRows = false;
      this.dgvFoundFiles.AllowUserToDeleteRows = false;
      this.dgvFoundFiles.AllowUserToResizeColumns = false;
      this.dgvFoundFiles.AllowUserToResizeRows = false;
      dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle46.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle46.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle46.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvFoundFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle46;
      this.dgvFoundFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFoundFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoundFiles});
      dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvFoundFiles.DefaultCellStyle = dataGridViewCellStyle48;
      this.dgvFoundFiles.EnableHeadersVisualStyles = false;
      this.dgvFoundFiles.Location = new System.Drawing.Point(12, 386);
      this.dgvFoundFiles.MultiSelect = false;
      this.dgvFoundFiles.Name = "dgvFoundFiles";
      this.dgvFoundFiles.ReadOnly = true;
      this.dgvFoundFiles.RowHeadersVisible = false;
      this.dgvFoundFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFoundFiles.Size = new System.Drawing.Size(323, 218);
      this.dgvFoundFiles.TabIndex = 27;
      // 
      // FoundFiles
      // 
      this.FoundFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle47.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FoundFiles.DefaultCellStyle = dataGridViewCellStyle47;
      this.FoundFiles.HeaderText = "Found Files";
      this.FoundFiles.Name = "FoundFiles";
      this.FoundFiles.ReadOnly = true;
      this.FoundFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // lblTimeElapsed
      // 
      this.lblTimeElapsed.AutoSize = true;
      this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.lblTimeElapsed.Location = new System.Drawing.Point(15, 32);
      this.lblTimeElapsed.Name = "lblTimeElapsed";
      this.lblTimeElapsed.Size = new System.Drawing.Size(105, 20);
      this.lblTimeElapsed.TabIndex = 28;
      this.lblTimeElapsed.Text = "Time Elapsed";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.lblTimeElapsed);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.groupBox1.Location = new System.Drawing.Point(12, 650);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(319, 69);
      this.groupBox1.TabIndex = 29;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Time Elapsed";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1553, 810);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dgvFoundFiles);
      this.Controls.Add(this.cbCaseSensitive);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.btnRescanDrivers);
      this.Controls.Add(this.clbSelectDrive);
      this.Controls.Add(this.dgvFoldersToScan);
      this.Controls.Add(this.btnDefineFolders);
      this.Controls.Add(this.lblMsg);
      this.Controls.Add(this.dgvFoundWords);
      this.Controls.Add(this.dgv2);
      this.Controls.Add(this.dgv1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbFileType);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.btnExit);
      this.Name = "Form1";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundWords)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoldersToScan)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.TextBox tbFileType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgv1;
    private System.Windows.Forms.DataGridView dgv2;
    private System.Windows.Forms.DataGridView dgvFoundWords;
    private System.Windows.Forms.Label lblMsg;
    private System.Windows.Forms.Button btnDefineFolders;
    private System.Windows.Forms.DataGridView dgvFoldersToScan;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.CheckedListBox clbSelectDrive;
    private System.Windows.Forms.Button btnRescanDrivers;
    private System.Windows.Forms.TextBox tbFilter;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox cbCaseSensitive;
    private System.Windows.Forms.DataGridViewTextBoxColumn FileContent;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridView dgvFoundFiles;
    private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Line;
    private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
    private System.Windows.Forms.DataGridViewTextBoxColumn FoundFiles;
    private System.Windows.Forms.Label lblTimeElapsed;
    private System.Windows.Forms.GroupBox groupBox1;
  }
}

