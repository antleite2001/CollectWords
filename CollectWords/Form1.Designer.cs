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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnExit = new System.Windows.Forms.Button();
      this.btnStart = new System.Windows.Forms.Button();
      this.clbDrives = new System.Windows.Forms.CheckedListBox();
      this.tbFileType = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.dgv1 = new System.Windows.Forms.DataGridView();
      this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgv2 = new System.Windows.Forms.DataGridView();
      this.FileContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgvFoundWords = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnShowAllWords = new System.Windows.Forms.Button();
      this.lblMsg = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundWords)).BeginInit();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnExit.Location = new System.Drawing.Point(48, 402);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(114, 34);
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnStart
      // 
      this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnStart.Location = new System.Drawing.Point(16, 220);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(277, 34);
      this.btnStart.TabIndex = 1;
      this.btnStart.Text = "Start Collecting (Takes Time)";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // clbDrives
      // 
      this.clbDrives.CheckOnClick = true;
      this.clbDrives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.clbDrives.FormattingEnabled = true;
      this.clbDrives.Location = new System.Drawing.Point(12, 12);
      this.clbDrives.Name = "clbDrives";
      this.clbDrives.Size = new System.Drawing.Size(120, 130);
      this.clbDrives.TabIndex = 3;
      // 
      // tbFileType
      // 
      this.tbFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.tbFileType.Location = new System.Drawing.Point(16, 188);
      this.tbFileType.Name = "tbFileType";
      this.tbFileType.Size = new System.Drawing.Size(277, 26);
      this.tbFileType.TabIndex = 4;
      this.tbFileType.TextChanged += new System.EventHandler(this.tbFileType_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.label1.Location = new System.Drawing.Point(12, 165);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(323, 20);
      this.label1.TabIndex = 5;
      this.label1.Text = "File Type (Comma/Space Separated Values)";
      // 
      // dgv1
      // 
      this.dgv1.AllowUserToAddRows = false;
      this.dgv1.AllowUserToDeleteRows = false;
      this.dgv1.AllowUserToResizeColumns = false;
      this.dgv1.AllowUserToResizeRows = false;
      dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
      this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Line});
      dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv1.DefaultCellStyle = dataGridViewCellStyle14;
      this.dgv1.EnableHeadersVisualStyles = false;
      this.dgv1.Location = new System.Drawing.Point(411, 43);
      this.dgv1.MultiSelect = false;
      this.dgv1.Name = "dgv1";
      this.dgv1.ReadOnly = true;
      this.dgv1.RowHeadersVisible = false;
      this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv1.Size = new System.Drawing.Size(420, 353);
      this.dgv1.TabIndex = 11;
      this.dgv1.SelectionChanged += new System.EventHandler(this.dgv1_SelectionChanged);
      // 
      // FileName
      // 
      this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FileName.DefaultCellStyle = dataGridViewCellStyle12;
      this.FileName.HeaderText = "File";
      this.FileName.Name = "FileName";
      this.FileName.ReadOnly = true;
      this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // Line
      // 
      this.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Line.DefaultCellStyle = dataGridViewCellStyle13;
      this.Line.HeaderText = "Line";
      this.Line.Name = "Line";
      this.Line.ReadOnly = true;
      this.Line.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.Line.Width = 64;
      // 
      // dgv2
      // 
      this.dgv2.AllowUserToAddRows = false;
      this.dgv2.AllowUserToDeleteRows = false;
      this.dgv2.AllowUserToResizeColumns = false;
      this.dgv2.AllowUserToResizeRows = false;
      dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
      this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileContent});
      dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv2.DefaultCellStyle = dataGridViewCellStyle17;
      this.dgv2.EnableHeadersVisualStyles = false;
      this.dgv2.Location = new System.Drawing.Point(837, 43);
      this.dgv2.MultiSelect = false;
      this.dgv2.Name = "dgv2";
      this.dgv2.ReadOnly = true;
      this.dgv2.RowHeadersVisible = false;
      this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv2.Size = new System.Drawing.Size(597, 353);
      this.dgv2.TabIndex = 12;
      // 
      // FileContent
      // 
      this.FileContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FileContent.DefaultCellStyle = dataGridViewCellStyle16;
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
      dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvFoundWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
      this.dgvFoundWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvFoundWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
      dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgvFoundWords.DefaultCellStyle = dataGridViewCellStyle20;
      this.dgvFoundWords.EnableHeadersVisualStyles = false;
      this.dgvFoundWords.Location = new System.Drawing.Point(411, 402);
      this.dgvFoundWords.MultiSelect = false;
      this.dgvFoundWords.Name = "dgvFoundWords";
      this.dgvFoundWords.ReadOnly = true;
      this.dgvFoundWords.RowHeadersVisible = false;
      this.dgvFoundWords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvFoundWords.Size = new System.Drawing.Size(597, 118);
      this.dgvFoundWords.TabIndex = 13;
      this.dgvFoundWords.SelectionChanged += new System.EventHandler(this.dgvFoundWords_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle19;
      this.dataGridViewTextBoxColumn1.HeaderText = "Found Words";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // btnShowAllWords
      // 
      this.btnShowAllWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      this.btnShowAllWords.Location = new System.Drawing.Point(1014, 402);
      this.btnShowAllWords.Name = "btnShowAllWords";
      this.btnShowAllWords.Size = new System.Drawing.Size(137, 34);
      this.btnShowAllWords.TabIndex = 14;
      this.btnShowAllWords.Text = "Show All";
      this.btnShowAllWords.UseVisualStyleBackColor = true;
      this.btnShowAllWords.Click += new System.EventHandler(this.btnShowAllWords_Click);
      // 
      // lblMsg
      // 
      this.lblMsg.AutoSize = true;
      this.lblMsg.Location = new System.Drawing.Point(77, 527);
      this.lblMsg.Name = "lblMsg";
      this.lblMsg.Size = new System.Drawing.Size(35, 13);
      this.lblMsg.TabIndex = 15;
      this.lblMsg.Text = "label2";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1446, 641);
      this.Controls.Add(this.lblMsg);
      this.Controls.Add(this.btnShowAllWords);
      this.Controls.Add(this.dgvFoundWords);
      this.Controls.Add(this.dgv2);
      this.Controls.Add(this.dgv1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbFileType);
      this.Controls.Add(this.clbDrives);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.btnExit);
      this.Name = "Form1";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFoundWords)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.CheckedListBox clbDrives;
    private System.Windows.Forms.TextBox tbFileType;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgv1;
    private System.Windows.Forms.DataGridView dgv2;
    private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Line;
    private System.Windows.Forms.DataGridViewTextBoxColumn FileContent;
    private System.Windows.Forms.DataGridView dgvFoundWords;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.Button btnShowAllWords;
    private System.Windows.Forms.Label lblMsg;
  }
}

