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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnStartCollectingWords = new System.Windows.Forms.Button();
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
      this.tbFilter = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbCaseSensitive = new System.Windows.Forms.CheckBox();
      this.dgvFoundFiles = new System.Windows.Forms.DataGridView();
      this.FoundFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTimeElapsed = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.gbTasks = new System.Windows.Forms.GroupBox();
      this.dgvTasks = new System.Windows.Forms.DataGridView();
      this.tbNewTaskNumber = new System.Windows.Forms.TextBox();
      this.dgvProjects = new System.Windows.Forms.DataGridView();
      this.taskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idTaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.db1DataSet = new CollectWords.db1DataSet();
      this.tasksTableAdapter = new CollectWords.db1DataSetTableAdapters.TasksTableAdapter();
      this.btnShowWords = new System.Windows.Forms.Button();
      this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.tAProjects = new CollectWords.db1DataSetTableAdapters.TAProjects();
      this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idProjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rbCollectNewTasksWords = new System.Windows.Forms.RadioButton();
      this.rbShowPreviouslyCollectedWords = new System.Windows.Forms.RadioButton();
      this.gbSelectAction = new System.Windows.Forms.GroupBox();
      this.gbNewTask = new System.Windows.Forms.GroupBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.lblFolderToCollectWords = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundWords)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.gbTasks.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
      this.gbSelectAction.SuspendLayout();
      this.gbNewTask.SuspendLayout();
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
      // btnStartCollectingWords
      // 
      this.btnStartCollectingWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnStartCollectingWords.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartCollectingWords.Location = new System.Drawing.Point(6, 111);
      this.btnStartCollectingWords.Name = "btnStartCollectingWords";
      this.btnStartCollectingWords.Size = new System.Drawing.Size(307, 34);
      this.btnStartCollectingWords.TabIndex = 1;
      this.btnStartCollectingWords.Text = "Start Collecting (Takes Time)";
      this.btnStartCollectingWords.UseVisualStyleBackColor = true;
      this.btnStartCollectingWords.Click += new System.EventHandler(this.btnStartCollectingWords_Click);
      // 
      // dgv1
      // 
      this.dgv1.AllowUserToAddRows = false;
      this.dgv1.AllowUserToDeleteRows = false;
      this.dgv1.AllowUserToResizeColumns = false;
      this.dgv1.AllowUserToResizeRows = false;
      this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle31.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
      this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Line,
            this.FullPath});
      dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv1.DefaultCellStyle = dataGridViewCellStyle34;
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
      dataGridViewCellStyle32.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FileName.DefaultCellStyle = dataGridViewCellStyle32;
      this.FileName.HeaderText = "File";
      this.FileName.Name = "FileName";
      this.FileName.ReadOnly = true;
      this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // Line
      // 
      this.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      dataGridViewCellStyle33.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Line.DefaultCellStyle = dataGridViewCellStyle33;
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
      dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle35.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
      this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileContent});
      dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv2.DefaultCellStyle = dataGridViewCellStyle37;
      this.dgv2.EnableHeadersVisualStyles = false;
      this.dgv2.Location = new System.Drawing.Point(341, 386);
      this.dgv2.MultiSelect = false;
      this.dgv2.Name = "dgv2";
      this.dgv2.ReadOnly = true;
      this.dgv2.RowHeadersVisible = false;
      this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv2.Size = new System.Drawing.Size(1204, 333);
      this.dgv2.TabIndex = 12;
      this.dgv2.DoubleClick += new System.EventHandler(this.dgv2_DoubleClick);
      // 
      // FileContent
      // 
      this.FileContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle36.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FileContent.DefaultCellStyle = dataGridViewCellStyle36;
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
      dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle38.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvFoundWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle38;
      this.dgvFoundWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFoundWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
      dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvFoundWords.DefaultCellStyle = dataGridViewCellStyle40;
      this.dgvFoundWords.EnableHeadersVisualStyles = false;
      this.dgvFoundWords.Location = new System.Drawing.Point(664, 82);
      this.dgvFoundWords.MultiSelect = false;
      this.dgvFoundWords.Name = "dgvFoundWords";
      this.dgvFoundWords.ReadOnly = true;
      this.dgvFoundWords.RowHeadersVisible = false;
      this.dgvFoundWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFoundWords.Size = new System.Drawing.Size(315, 296);
      this.dgvFoundWords.TabIndex = 13;
      this.dgvFoundWords.SelectionChanged += new System.EventHandler(this.dgvFoundWords_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle39.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle39;
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
      this.lblMsg.Location = new System.Drawing.Point(353, 724);
      this.lblMsg.Name = "lblMsg";
      this.lblMsg.Size = new System.Drawing.Size(82, 20);
      this.lblMsg.TabIndex = 15;
      this.lblMsg.Text = "Messages";
      // 
      // btnDefineFolders
      // 
      this.btnDefineFolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDefineFolders.Font = new System.Drawing.Font("Consolas", 8.25F);
      this.btnDefineFolders.Location = new System.Drawing.Point(6, 45);
      this.btnDefineFolders.Name = "btnDefineFolders";
      this.btnDefineFolders.Size = new System.Drawing.Size(307, 25);
      this.btnDefineFolders.TabIndex = 19;
      this.btnDefineFolders.Text = "Define Folder to Collect Words";
      this.btnDefineFolders.UseVisualStyleBackColor = true;
      this.btnDefineFolders.Click += new System.EventHandler(this.btnDefineFolders_Click);
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
      dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle41.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvFoundFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
      this.dgvFoundFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFoundFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoundFiles});
      dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvFoundFiles.DefaultCellStyle = dataGridViewCellStyle43;
      this.dgvFoundFiles.EnableHeadersVisualStyles = false;
      this.dgvFoundFiles.Location = new System.Drawing.Point(12, 514);
      this.dgvFoundFiles.MultiSelect = false;
      this.dgvFoundFiles.Name = "dgvFoundFiles";
      this.dgvFoundFiles.ReadOnly = true;
      this.dgvFoundFiles.RowHeadersVisible = false;
      this.dgvFoundFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFoundFiles.Size = new System.Drawing.Size(323, 90);
      this.dgvFoundFiles.TabIndex = 27;
      // 
      // FoundFiles
      // 
      this.FoundFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle42.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle42.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FoundFiles.DefaultCellStyle = dataGridViewCellStyle42;
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
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.dgvProjects);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.groupBox2.Location = new System.Drawing.Point(12, 13);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(226, 116);
      this.groupBox2.TabIndex = 31;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Select Project";
      // 
      // gbTasks
      // 
      this.gbTasks.Controls.Add(this.btnShowWords);
      this.gbTasks.Controls.Add(this.dgvTasks);
      this.gbTasks.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.gbTasks.Location = new System.Drawing.Point(357, 129);
      this.gbTasks.Name = "gbTasks";
      this.gbTasks.Size = new System.Drawing.Size(260, 249);
      this.gbTasks.TabIndex = 32;
      this.gbTasks.TabStop = false;
      this.gbTasks.Text = "Task";
      // 
      // dgvTasks
      // 
      this.dgvTasks.AllowUserToAddRows = false;
      this.dgvTasks.AllowUserToDeleteRows = false;
      this.dgvTasks.AllowUserToResizeColumns = false;
      this.dgvTasks.AllowUserToResizeRows = false;
      this.dgvTasks.AutoGenerateColumns = false;
      dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle44.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle44;
      this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskDataGridViewTextBoxColumn,
            this.idTaskDataGridViewTextBoxColumn});
      this.dgvTasks.DataSource = this.tasksBindingSource;
      this.dgvTasks.EnableHeadersVisualStyles = false;
      this.dgvTasks.Location = new System.Drawing.Point(6, 20);
      this.dgvTasks.MultiSelect = false;
      this.dgvTasks.Name = "dgvTasks";
      this.dgvTasks.ReadOnly = true;
      this.dgvTasks.RowHeadersVisible = false;
      this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvTasks.Size = new System.Drawing.Size(245, 183);
      this.dgvTasks.TabIndex = 33;
      this.dgvTasks.SelectionChanged += new System.EventHandler(this.dgvTasks_SelectionChanged);
      // 
      // tbNewTaskNumber
      // 
      this.tbNewTaskNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbNewTaskNumber.Location = new System.Drawing.Point(6, 19);
      this.tbNewTaskNumber.MaxLength = 4;
      this.tbNewTaskNumber.Name = "tbNewTaskNumber";
      this.tbNewTaskNumber.Size = new System.Drawing.Size(135, 20);
      this.tbNewTaskNumber.TabIndex = 35;
      this.tbNewTaskNumber.TextChanged += new System.EventHandler(this.tbNewTaskNumber_TextChanged);
      // 
      // dgvProjects
      // 
      this.dgvProjects.AllowUserToAddRows = false;
      this.dgvProjects.AllowUserToDeleteRows = false;
      this.dgvProjects.AllowUserToResizeColumns = false;
      this.dgvProjects.AllowUserToResizeRows = false;
      this.dgvProjects.AutoGenerateColumns = false;
      dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      dataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
      this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectDataGridViewTextBoxColumn,
            this.idProjectDataGridViewTextBoxColumn});
      this.dgvProjects.DataSource = this.projectsBindingSource;
      this.dgvProjects.EnableHeadersVisualStyles = false;
      this.dgvProjects.Location = new System.Drawing.Point(6, 19);
      this.dgvProjects.MultiSelect = false;
      this.dgvProjects.Name = "dgvProjects";
      this.dgvProjects.ReadOnly = true;
      this.dgvProjects.RowHeadersVisible = false;
      this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProjects.Size = new System.Drawing.Size(214, 91);
      this.dgvProjects.TabIndex = 36;
      this.dgvProjects.SelectionChanged += new System.EventHandler(this.dgvProjects_SelectionChanged);
      // 
      // taskDataGridViewTextBoxColumn
      // 
      this.taskDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.taskDataGridViewTextBoxColumn.DataPropertyName = "Task";
      this.taskDataGridViewTextBoxColumn.HeaderText = "Task";
      this.taskDataGridViewTextBoxColumn.Name = "taskDataGridViewTextBoxColumn";
      this.taskDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // idTaskDataGridViewTextBoxColumn
      // 
      this.idTaskDataGridViewTextBoxColumn.DataPropertyName = "IdTask";
      this.idTaskDataGridViewTextBoxColumn.HeaderText = "IdTask";
      this.idTaskDataGridViewTextBoxColumn.Name = "idTaskDataGridViewTextBoxColumn";
      this.idTaskDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // tasksBindingSource
      // 
      this.tasksBindingSource.DataMember = "Tasks";
      this.tasksBindingSource.DataSource = this.db1DataSet;
      // 
      // db1DataSet
      // 
      this.db1DataSet.DataSetName = "db1DataSet";
      this.db1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // tasksTableAdapter
      // 
      this.tasksTableAdapter.ClearBeforeFill = true;
      // 
      // btnShowWords
      // 
      this.btnShowWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnShowWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
      this.btnShowWords.Location = new System.Drawing.Point(6, 209);
      this.btnShowWords.Name = "btnShowWords";
      this.btnShowWords.Size = new System.Drawing.Size(245, 34);
      this.btnShowWords.TabIndex = 33;
      this.btnShowWords.Text = "Show Words";
      this.btnShowWords.UseVisualStyleBackColor = true;
      // 
      // projectsBindingSource
      // 
      this.projectsBindingSource.DataMember = "Projects";
      this.projectsBindingSource.DataSource = this.db1DataSet;
      // 
      // tAProjects
      // 
      this.tAProjects.ClearBeforeFill = true;
      // 
      // projectDataGridViewTextBoxColumn
      // 
      this.projectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.projectDataGridViewTextBoxColumn.DataPropertyName = "Project";
      this.projectDataGridViewTextBoxColumn.HeaderText = "Project";
      this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
      this.projectDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // idProjectDataGridViewTextBoxColumn
      // 
      this.idProjectDataGridViewTextBoxColumn.DataPropertyName = "IdProject";
      this.idProjectDataGridViewTextBoxColumn.HeaderText = "IdProject";
      this.idProjectDataGridViewTextBoxColumn.Name = "idProjectDataGridViewTextBoxColumn";
      this.idProjectDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // rbCollectNewTasksWords
      // 
      this.rbCollectNewTasksWords.AutoSize = true;
      this.rbCollectNewTasksWords.Location = new System.Drawing.Point(14, 19);
      this.rbCollectNewTasksWords.Name = "rbCollectNewTasksWords";
      this.rbCollectNewTasksWords.Size = new System.Drawing.Size(148, 17);
      this.rbCollectNewTasksWords.TabIndex = 33;
      this.rbCollectNewTasksWords.TabStop = true;
      this.rbCollectNewTasksWords.Text = "Collect New Tasks Words";
      this.rbCollectNewTasksWords.UseVisualStyleBackColor = true;
      this.rbCollectNewTasksWords.CheckedChanged += new System.EventHandler(this.rbCollectNewTasksWords_CheckedChanged);
      // 
      // rbShowPreviouslyCollectedWords
      // 
      this.rbShowPreviouslyCollectedWords.AutoSize = true;
      this.rbShowPreviouslyCollectedWords.Location = new System.Drawing.Point(14, 42);
      this.rbShowPreviouslyCollectedWords.Name = "rbShowPreviouslyCollectedWords";
      this.rbShowPreviouslyCollectedWords.Size = new System.Drawing.Size(184, 17);
      this.rbShowPreviouslyCollectedWords.TabIndex = 34;
      this.rbShowPreviouslyCollectedWords.TabStop = true;
      this.rbShowPreviouslyCollectedWords.Text = "Show Previously Collected Words";
      this.rbShowPreviouslyCollectedWords.UseVisualStyleBackColor = true;
      this.rbShowPreviouslyCollectedWords.CheckedChanged += new System.EventHandler(this.rbShowPreviouslyCollectedWords_CheckedChanged);
      // 
      // gbSelectAction
      // 
      this.gbSelectAction.Controls.Add(this.rbCollectNewTasksWords);
      this.gbSelectAction.Controls.Add(this.rbShowPreviouslyCollectedWords);
      this.gbSelectAction.Location = new System.Drawing.Point(12, 129);
      this.gbSelectAction.Name = "gbSelectAction";
      this.gbSelectAction.Size = new System.Drawing.Size(323, 72);
      this.gbSelectAction.TabIndex = 35;
      this.gbSelectAction.TabStop = false;
      this.gbSelectAction.Text = "Select Action Related to Project";
      // 
      // gbNewTask
      // 
      this.gbNewTask.Controls.Add(this.lblFolderToCollectWords);
      this.gbNewTask.Controls.Add(this.tbNewTaskNumber);
      this.gbNewTask.Controls.Add(this.btnDefineFolders);
      this.gbNewTask.Controls.Add(this.btnStartCollectingWords);
      this.gbNewTask.Font = new System.Drawing.Font("Consolas", 8.25F);
      this.gbNewTask.Location = new System.Drawing.Point(12, 207);
      this.gbNewTask.Name = "gbNewTask";
      this.gbNewTask.Size = new System.Drawing.Size(319, 171);
      this.gbNewTask.TabIndex = 36;
      this.gbNewTask.TabStop = false;
      this.gbNewTask.Text = "New Task Number";
      this.gbNewTask.VisibleChanged += new System.EventHandler(this.gbNewTask_VisibleChanged);
      // 
      // lblFolderToCollectWords
      // 
      this.lblFolderToCollectWords.AutoSize = true;
      this.lblFolderToCollectWords.Location = new System.Drawing.Point(6, 73);
      this.lblFolderToCollectWords.Name = "lblFolderToCollectWords";
      this.lblFolderToCollectWords.Size = new System.Drawing.Size(127, 13);
      this.lblFolderToCollectWords.TabIndex = 36;
      this.lblFolderToCollectWords.Text = "FolderToCollectWords";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1553, 906);
      this.Controls.Add(this.gbNewTask);
      this.Controls.Add(this.gbSelectAction);
      this.Controls.Add(this.gbTasks);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.dgvFoundFiles);
      this.Controls.Add(this.cbCaseSensitive);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.tbFilter);
      this.Controls.Add(this.lblMsg);
      this.Controls.Add(this.dgvFoundWords);
      this.Controls.Add(this.dgv2);
      this.Controls.Add(this.dgv1);
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
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundFiles)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.gbTasks.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.db1DataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
      this.gbSelectAction.ResumeLayout(false);
      this.gbSelectAction.PerformLayout();
      this.gbNewTask.ResumeLayout(false);
      this.gbNewTask.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnStartCollectingWords;
    private System.Windows.Forms.DataGridView dgv1;
    private System.Windows.Forms.DataGridView dgv2;
    private System.Windows.Forms.DataGridView dgvFoundWords;
    private System.Windows.Forms.Label lblMsg;
    private System.Windows.Forms.Button btnDefineFolders;
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
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox gbTasks;
    private System.Windows.Forms.TextBox tbNewTaskNumber;
    private System.Windows.Forms.DataGridView dgvTasks;
    private System.Windows.Forms.DataGridView dgvProjects;
    private System.Windows.Forms.DataGridViewTextBoxColumn taskDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idTaskDataGridViewTextBoxColumn;
    private System.Windows.Forms.BindingSource tasksBindingSource;
    private db1DataSet db1DataSet;
    private db1DataSetTableAdapters.TasksTableAdapter tasksTableAdapter;
    private System.Windows.Forms.Button btnShowWords;
    private System.Windows.Forms.BindingSource projectsBindingSource;
    private db1DataSetTableAdapters.TAProjects tAProjects;
    private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idProjectDataGridViewTextBoxColumn;
    private System.Windows.Forms.RadioButton rbCollectNewTasksWords;
    private System.Windows.Forms.RadioButton rbShowPreviouslyCollectedWords;
    private System.Windows.Forms.GroupBox gbSelectAction;
    private System.Windows.Forms.GroupBox gbNewTask;
    private System.Windows.Forms.Label lblFolderToCollectWords;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}

