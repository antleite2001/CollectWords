using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectWords
{
  public partial class Form1 : Form
  {
    private Stopwatch sw = new Stopwatch();

    private support s = new support();
    //C:\Users\acleite\Documents\Bosch Steering Wheel\Task6191\DirImplementationSet\ImplementationSet\BSW\CUBAS\var01\inc\Platform_Types.h
    private List<string> excludeList = new List<string>()
    { "if", "else", "switch", "case", "default","void","break","int", "float", "char", "double", "long",
      "auto", "signed", "const", "extern", "register", "unsigned","continue","return", "for", "while", "do", "enum",
      "sizeof","struct", "typedef", "union","volatile","#ifndef", "#if", "#else","#endif", "#define",
      "#include", "#ifdef","#undef", "#pragma","sint8","sint16","uint16","sint32","sint64","uint32","uint64","float32",
      "float64","boolean","sint8_least","uint8_least","sint16_least","uint16_least","sint32_least","uint32_least",
      "tUI16","tUI32","tUI8","uint8"};


    //All words starting with this list will not be included in the wordsOccurence List
    private List<string> excludestartwith = new List<string>()
    { "0","1","2","3","4","5","6","7","8","9" };

    private char[] delimiters = new char[]
    { '~',
      ':',
      '?',
      '.',
      '\'',
      '*',
      '/',
      '\t',
      ' ',
      '!',
      ',',
      ';',
      '=',
      ')',
      '(',
      '\"',
      '&',
      '[',
      ']',
      '{',
      '}',
      '<',
      '>',
      '-',
      '+',
      '%',
      '^',
      '|' };


    private bool isInMultiLineComment = false;
    private DriveInfo[] allDrives;
    private List<Tuple<string, List<Tuple<string, List<int>>>>> wordsOccurence = new List<Tuple<string, List<Tuple<string, List<int>>>>>();
    private List<Tuple<string, List<int>>> filesOccurence;
    private List<int> linesOccurence;
    private string word;
    private string currentFileName = "";



    public Form1()
    {
      InitializeComponent();


      dgv1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dgv2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dgvFoundWords.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));



    }

    private void ShowAll()
    {
      dgv1.Rows.Clear();
      dgv2.Rows.Clear();
      dgvFoundWords.SelectionChanged -= new System.EventHandler(dgvFoundWords_SelectionChanged);

      dgvFoundWords.Rows.Clear();
      foreach (Tuple<string, List<Tuple<string, List<int>>>> w in wordsOccurence)
      {
        dgvFoundWords.Rows.Add(w.Item1);
      }
      dgvFoundWords.Sort(dgvFoundWords.Columns[0], ListSortDirection.Ascending);
      dgvFoundWords.ClearSelection();
      dgvFoundWords.SelectionChanged += new System.EventHandler(dgvFoundWords_SelectionChanged);
    }


    private void btnShowAllWords_Click(object sender, EventArgs e)
    {
      ShowAll();

    }


    private void ShowFilesContainingSelectedWord()
    {
      dgv1.SelectionChanged -= new System.EventHandler(dgv1_SelectionChanged);

      dgv1.Rows.Clear();
      dgv2.Rows.Clear();



      foreach (Tuple<string, List<Tuple<string, List<int>>>> wordOccurence in wordsOccurence)
      {
        if (dgvFoundWords.SelectedRows[0].Cells[0].Value.ToString().Equals(wordOccurence.Item1))
        {
          foreach (Tuple<string, List<int>> filename in wordOccurence.Item2)
          {
            foreach (int LineCount in filename.Item2)
            {
              dgv1.Rows.Add(Path.GetFileName(filename.Item1), LineCount, filename.Item1);

            }
          }
        }
      }
      dgv1.ClearSelection();
      dgv1.SelectionChanged += new System.EventHandler(dgv1_SelectionChanged);

    }


    private void dgvFoundWords_SelectionChanged(object sender, EventArgs e)
    {

      if (dgvFoundWords.SelectedRows.Count == 1)
      {
        ShowFilesContainingSelectedWord();
      }

    }



    private void btnExit_Click(object sender, EventArgs e)
    {
      Close();
    }



    private void cbFolders_TextChanged(object sender, EventArgs e)
    {
      //FillcbFolders(cbFolders.Text);
    }

    private void btnDefineFolders_Click(object sender, EventArgs e)
    {

      FolderSelectDialog dialog = new FolderSelectDialog
      {
        InitialDirectory = clbSelectDrive.CheckedItems[0].ToString(),// Properties.Settings.Default.TargetFolder,
        Title = "Select a folder to save your screen captures"
      };

      if (dialog.Show())
      {
        if (Directory.Exists(dialog.FileName))
        {
          dgvFoldersToScan.Rows.Add(dialog.FileName);

        }

      }
    }

    private void btnRescanDrivers_Click(object sender, EventArgs e)
    {

    }

    private void ReScanDrives()
    {
      //Get Drives
      clbSelectDrive.Items.Clear();
      allDrives = DriveInfo.GetDrives();
      foreach (DriveInfo d in allDrives)
      {
        if (d.IsReady)
        {

          clbSelectDrive.Items.Add(d.Name);

        }
      }
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      btnStart.Enabled = false;
      btnDefineFolders.Enabled = false;

      tbFileType.Text = Properties.Settings.Default.FileTypes;



      ReScanDrives();
    }

    private void clbSelectDrive_ItemCheck(object sender, ItemCheckEventArgs e)
    {
      btnDefineFolders.Enabled = e.NewValue == CheckState.Checked;
      if (e.NewValue == CheckState.Checked && clbSelectDrive.CheckedItems.Count > 0)
      {
        clbSelectDrive.ItemCheck -= clbSelectDrive_ItemCheck;
        clbSelectDrive.SetItemChecked(clbSelectDrive.CheckedIndices[0], false);
        clbSelectDrive.ItemCheck += clbSelectDrive_ItemCheck;

      }

    }


    private void dgvFoldersToScan_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        ContextMenu m = new ContextMenu();
        m.MenuItems.Add(new MenuItem("Cut"));


        int currentMouseOverRow = dgvFoldersToScan.HitTest(e.X, e.Y).RowIndex;

        if (currentMouseOverRow >= 0)
        {
          dgvFoldersToScan.Rows[currentMouseOverRow].Selected = true;
        }

        m.Show(dgvFoldersToScan, new Point(e.X, e.Y));

      }
    }



    private void LoadFileToDgv2(string filename, int linenumber)
    {
      if (!currentFileName.Equals(filename))
      {
        FileContent.HeaderText = filename;
        dgv2.Rows.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {

          dgv2.Rows.Add(line.Replace("\t", " "));
        }
      }
      //Select linenumber
      dgv2.ClearSelection();
      dgv2.Rows[linenumber - 1].Selected = true;

      dgv2.FirstDisplayedScrollingRowIndex = linenumber - 1;




    }


    private void dgv1_SelectionChanged(object sender, EventArgs e)
    {
      if (dgv1.SelectedRows.Count == 1)
      {

        LoadFileToDgv2(dgv1.SelectedRows[0].Cells[2].Value.ToString(),
          Convert.ToInt32(dgv1.SelectedRows[0].Cells[1].Value));
      }
    }


    private void StartCollectingWordsFromFiles()
    {
      sw.Restart();
      Properties.Settings.Default.FileTypes = tbFileType.Text;
      Properties.Settings.Default.Save();
      //Get File Types
      string[] fileTypes = tbFileType.Text.Split(' ', ',', ';');
      int i;
      string word = "";
      string[] linessplited;
      string[] lines;
      string[] files;
      int linecount = 0;
      string linetemp = "";
      foreach (string fileType in fileTypes)
      {

        FoundFiles.HeaderText = "Found files type (" + fileType + ")";


        foreach (DataGridViewRow f in dgvFoldersToScan.Rows)
        {
          files = Directory.GetFiles(f.Cells[0].Value.ToString(), "*." + fileType, SearchOption.AllDirectories);
          foreach (string file in files)
          {
            dgvFoundFiles.Rows.Add(Path.GetFileName(file));
          }

          dgvFoundFiles.Refresh();

          foreach (string file in files)
          {
            for (int v = 0; v < dgvFoundFiles.Rows.Count; v++)
            {
              if (file.Contains(dgvFoundFiles.Rows[v].Cells[0].Value.ToString()))
              {
                dgvFoundFiles.Rows.RemoveAt(v);
                break;
              }
            }
            dgvFoundFiles.Refresh();

            lines = File.ReadAllLines(file);
            linecount = 0;
            foreach (string line in lines)
            {
              linecount++;
              linetemp = line;
              s.removecomment(0, ref linetemp, ref isInMultiLineComment);
              linessplited = linetemp.Split(delimiters);
              foreach (string linesplited in linessplited)
              {
                word = linesplited.Trim();
                if (!string.IsNullOrEmpty(word) && !excludeList.Contains(word) &&
                  !excludestartwith.Any(w => word.StartsWith(w)))
                {
                  InsertWordIntoList(word, file, linecount);
                  lblMsg.Text = word;
                  lblMsg.Refresh();
                  ShowElapsedTime();
                }
              }
            }
          }
        }
      }
      sw.Stop();
    }

    private void ShowElapsedTime()
    {
      if (sw.Elapsed.TotalHours > 1.0)
      {
        lblTimeElapsed.Text = sw.Elapsed.TotalHours.ToString() + " (h)";
      }
      else if (sw.Elapsed.TotalMinutes > 1.0)
      {
        lblTimeElapsed.Text = sw.Elapsed.TotalMinutes.ToString() + " (m)";
      }
      else if (sw.Elapsed.TotalSeconds > 1.0)
      {
        lblTimeElapsed.Text =
               sw.Elapsed.TotalSeconds.ToString() + " (s)";
      }
      else
      {
        lblTimeElapsed.Text =
          sw.Elapsed.TotalMilliseconds.ToString() + " (ms)";
      }
      lblTimeElapsed.Refresh();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      dgv1.Rows.Clear();
      dgv2.Rows.Clear();
      dgvFoundWords.Rows.Clear();

      lblTimeElapsed.Text = "";
      dgv1.Refresh();
      dgv2.Refresh();
      dgvFoundWords.Refresh();
      Refresh();



      StartCollectingWordsFromFiles();

      lblMsg.Text = "Finished";



      ShowAll();
    }

    private void InsertWordIntoList(string word, string file, int linecount)
    {
      if (wordsOccurence.Any(m => m.Item1.Equals(word)))
      {
        //word found
        Tuple<string, List<Tuple<string, List<int>>>> wordfound = wordsOccurence.First(m => m.Item1.Equals(word));
        if (wordfound.Item2.Any(m => m.Item1.Equals(file)))
        {
          //Word found. File found.  
          if (wordsOccurence.First(m => m.Item1.Equals(word)).Item2.First(m => m.Item1.Equals(file)).Item2.Contains(linecount))
          {
            //Word found. File found. linecount found nothing to do

          }
          else
          {
            //Word found. File found. linecount not found. Insert LineCount
            wordsOccurence.First(m => m.Item1.Equals(word)).Item2.First(m => m.Item1.Equals(file)).Item2.Add(linecount);
          }
        }
        else
        {
          //Word found. file not found. Insert File and LineCount
          wordsOccurence.First(m => m.Item1.Equals(word)).Item2.Add(new Tuple<string, List<int>>(file, new List<int>() { linecount }));
        }
      }
      else //word not found
      {

        filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>(file, new List<int>() { linecount }) };
        wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word,
           new List<Tuple<string, List<int>>>(filesOccurence)));
      }
    }

    private void tbFileType_TextChanged(object sender, EventArgs e)
    {
      btnStart.Enabled = tbFileType.TextLength > 0;
    }





    #region FolderSelectDialogCLS
    /// <summary>
    /// https://stackoverflow.com/questions/11767/browse-for-a-directory-in-c-sharp
    /// ability to copy and paste from a textbox at the bottom and the navigation pane on the left with favorites and common locations
    /// </summary>
    public class FolderSelectDialog
    {

      private string _initialDirectory;
      private string _title;
      private string _fileName = "";
      /// <summary>
      /// 
      /// </summary>
      public string InitialDirectory
      {
        get { return string.IsNullOrEmpty(_initialDirectory) ? Environment.CurrentDirectory : _initialDirectory; }
        set { _initialDirectory = value; }
      }
      /// <summary>
      /// 
      /// </summary>
      public string Title
      {
        get { return _title ?? "Select a folder"; }
        set { _title = value; }
      }
      /// <summary>
      /// 
      /// </summary>
      public string FileName
      {
        get
        {
          return _fileName;
        }
      }
      /// <summary>
      /// 
      /// </summary>
      /// <returns></returns>
      public bool Show()
      {
        return Show(IntPtr.Zero);
      }

      /// <param name="hWndOwner">Handle of the control or window to be the parent of the file dialog</param>
      /// <returns>true if the user clicks OK</returns>
      public bool Show(IntPtr hWndOwner)
      {
        ShowDialogResult result = Environment.OSVersion.Version.Major >= 6
                  ? VistaDialog.Show(hWndOwner, InitialDirectory, Title)
                  : ShowXpDialog(hWndOwner, InitialDirectory, Title);
        _fileName = result.FileName;
        return result.Result;
      }

      private struct ShowDialogResult
      {
        public bool Result { get; set; }
        public string FileName { get; set; }
      }

      private static ShowDialogResult ShowXpDialog(IntPtr ownerHandle, string initialDirectory, string title)
      {
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
        {
          Description = title,
          SelectedPath = initialDirectory,
          ShowNewFolderButton = false
        };
        ShowDialogResult dialogResult = new ShowDialogResult();
        if (folderBrowserDialog.ShowDialog(new WindowWrapper(ownerHandle)) == DialogResult.OK)
        {
          dialogResult.Result = true;
          dialogResult.FileName = folderBrowserDialog.SelectedPath;
        }
        return dialogResult;
      }

      private static class VistaDialog
      {
        private const string c_foldersFilter = "Folders|\n";

        private const BindingFlags c_flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
        private static readonly Assembly s_windowsFormsAssembly = typeof(FileDialog).Assembly;
        private static readonly Type s_iFileDialogType = s_windowsFormsAssembly.GetType("System.Windows.Forms.FileDialogNative+IFileDialog");
        private static readonly MethodInfo s_createVistaDialogMethodInfo = typeof(OpenFileDialog).GetMethod("CreateVistaDialog", c_flags);
        private static readonly MethodInfo s_onBeforeVistaDialogMethodInfo = typeof(OpenFileDialog).GetMethod("OnBeforeVistaDialog", c_flags);
        private static readonly MethodInfo s_getOptionsMethodInfo = typeof(FileDialog).GetMethod("GetOptions", c_flags);
        private static readonly MethodInfo s_setOptionsMethodInfo = s_iFileDialogType.GetMethod("SetOptions", c_flags);
        private static readonly uint s_fosPickFoldersBitFlag = (uint)s_windowsFormsAssembly
            .GetType("System.Windows.Forms.FileDialogNative+FOS")
            .GetField("FOS_PICKFOLDERS")
            .GetValue(null);
        private static readonly ConstructorInfo s_vistaDialogEventsConstructorInfo = s_windowsFormsAssembly
            .GetType("System.Windows.Forms.FileDialog+VistaDialogEvents")
            .GetConstructor(c_flags, null, new[] { typeof(FileDialog) }, null);
        private static readonly MethodInfo s_adviseMethodInfo = s_iFileDialogType.GetMethod("Advise");
        private static readonly MethodInfo s_unAdviseMethodInfo = s_iFileDialogType.GetMethod("Unadvise");
        private static readonly MethodInfo s_showMethodInfo = s_iFileDialogType.GetMethod("Show");

        public static ShowDialogResult Show(IntPtr ownerHandle, string initialDirectory, string title)
        {
          OpenFileDialog openFileDialog = new OpenFileDialog
          {

            AddExtension = false,
            CheckFileExists = false,
            DereferenceLinks = true,
            Filter = c_foldersFilter,
            InitialDirectory = initialDirectory,
            Multiselect = false,
            Title = title
          };
          object iFileDialog = s_createVistaDialogMethodInfo.Invoke(openFileDialog, new object[] { });
          s_onBeforeVistaDialogMethodInfo.Invoke(openFileDialog, new[] { iFileDialog });
          s_setOptionsMethodInfo.Invoke(iFileDialog, new object[] { (uint)s_getOptionsMethodInfo.Invoke(openFileDialog, new object[] { }) | s_fosPickFoldersBitFlag });
          object[] adviseParametersWithOutputConnectionToken = new[] { s_vistaDialogEventsConstructorInfo.Invoke(new object[] { openFileDialog }), 0U };
          s_adviseMethodInfo.Invoke(iFileDialog, adviseParametersWithOutputConnectionToken);

          try
          {
            int retVal = (int)s_showMethodInfo.Invoke(iFileDialog, new object[] { ownerHandle });
            return new ShowDialogResult
            {

              Result = retVal == 0,
              FileName = openFileDialog.FileName
            };
          }
          finally
          {
            s_unAdviseMethodInfo.Invoke(iFileDialog, new[] { adviseParametersWithOutputConnectionToken[1] });
          }
        }
      }

      // Wrap an IWin32Window around an IntPtr
      private class WindowWrapper : IWin32Window
      {
        private readonly IntPtr _handle;
        public WindowWrapper(IntPtr handle) { _handle = handle; }
        public IntPtr Handle { get { return _handle; } }
      }
    }



    #endregion

    private void tbFilter_TextChanged(object sender, EventArgs e)
    {
      if (tbFilter.TextLength > 0)
      {
        int rowIndex = -1;
        //NvMIf_ApplVarContainerYawRateOffComp_GAS
        //Try to find equal
        foreach (DataGridViewRow row in dgvFoundWords.Rows)
        {
          if (cbCaseSensitive.Checked)
          {
            if (row.Cells[0].Value.ToString().StartsWith(tbFilter.Text))
            {
              dgvFoundWords.Rows[row.Index].Selected = true;
              dgvFoundWords.FirstDisplayedScrollingRowIndex = row.Index;
              return;
            }
          }
          else
          {
            if (row.Cells[0].Value.ToString().ToUpper().StartsWith(tbFilter.Text.ToUpper()))
            {
              dgvFoundWords.Rows[row.Index].Selected = true;
              dgvFoundWords.FirstDisplayedScrollingRowIndex = row.Index;
              return;
            }
          }
        }


        //Try to find inside any position
        foreach (DataGridViewRow row in dgvFoundWords.Rows)
        {
          if (cbCaseSensitive.Checked)
          {
            if (row.Cells[0].Value.ToString().Contains(tbFilter.Text))
            {
              dgvFoundWords.Rows[row.Index].Selected = true;
              dgvFoundWords.FirstDisplayedScrollingRowIndex = row.Index;
              return;
            }
          }
          else
          {
            if (row.Cells[0].Value.ToString().ToUpper().Contains(tbFilter.Text.ToUpper()))
            {
              dgvFoundWords.Rows[row.Index].Selected = true;
              dgvFoundWords.FirstDisplayedScrollingRowIndex = row.Index;
              return;
            }
          }
        }

        dgvFoundWords.ClearSelection();
        dgv1.Rows.Clear();
        dgv2.Rows.Clear();

      }
      else
      {
        dgvFoundWords.ClearSelection();
        dgv1.Rows.Clear();
        dgv2.Rows.Clear();
      }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void checkBox25_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void dgv1_DoubleClick(object sender, EventArgs e)
    {
      if (dgv1.SelectedRows.Count == 1)
      {
        Process.Start(dgv1.SelectedRows[0].Cells[2].Value.ToString());
      }
    }

    private void dgv2_DoubleClick(object sender, EventArgs e)
    {
      Process.Start(dgv1.SelectedRows[0].Cells[2].Value.ToString());
    }

    private void cbCaseSensitive_CheckedChanged(object sender, EventArgs e)
    {

    }
  }
}
