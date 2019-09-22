using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectWords
{
  public partial class Form1 : Form
  {
    private DriveInfo[] allDrives;
    private List<Tuple<string, List<Tuple<string, List<int>>>>> wordsOccurence = new List<Tuple<string, List<Tuple<string, List<int>>>>>();
    private List<Tuple<string, List<int>>> filesOccurence;
    private List<int> linesOccurence;
    private string word;



    public Form1()
    {
      InitializeComponent();


      dgv1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
      dgv2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);



    }


    private void btnShowAllWords_Click(object sender, EventArgs e)
    {
      dgv1.Rows.Clear();
      dgv2.Rows.Clear();
      dgvFoundWords.SelectionChanged -= new System.EventHandler(dgvFoundWords_SelectionChanged);

      dgvFoundWords.Rows.Clear();
      foreach (Tuple<string, List<Tuple<string, List<int>>>> w in wordsOccurence)
      {
        dgvFoundWords.Rows.Add(w.Item1);
      }
      dgvFoundWords.ClearSelection();
      dgvFoundWords.SelectionChanged += new System.EventHandler(dgvFoundWords_SelectionChanged);

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
              dgv1.Rows.Add(filename.Item1, LineCount);

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

    private void Form1_Load(object sender, EventArgs e)
    {
      btnStart.Enabled = false;


      tbFileType.Text = Properties.Settings.Default.FileTypes;
      clbDrives.Items.Clear();


      //Get Drives
      //allDrives = DriveInfo.GetDrives();
      //foreach (DriveInfo d in allDrives)
      //{
      //  if (d.IsReady)
      //  {
      //    clbDrives.Items.Add(d.Name);

      //  }
      //}
    }

    private string currentFileName = "";

    private void LoadFileToDgv2(string filename, int linenumber)
    {
      if (!currentFileName.Equals(filename))
      {
        FileContent.HeaderText = filename;
        dgv2.Rows.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
          dgv2.Rows.Add(line);
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

        LoadFileToDgv2(dgv1.SelectedRows[0].Cells[0].Value.ToString(),
          Convert.ToInt32(dgv1.SelectedRows[0].Cells[1].Value));
      }
    }


    private void StartCollectingWordsFromFiles()
    {
      Properties.Settings.Default.FileTypes = tbFileType.Text;
      Properties.Settings.Default.Save();
      //Get File Types
      string[] fileTypes = tbFileType.Text.Split(' ', ',', ';');
      foreach (string fileType in fileTypes)
      {
        string[] files = Directory.GetFiles(@"c:\temp\temp", "*." + fileType, SearchOption.AllDirectories);
        foreach (string file in files)
        {

          Debug.WriteLine(file);
          string[] lines = File.ReadAllLines(file);
          int linecount = 0;
          foreach (string line in lines)
          {
            linecount++;
            string[] linessplited = line.Split(' ', ',', ';');
            foreach (string linesplited in linessplited)
            {
              string word = linesplited.Trim();
              if (!word.Equals(""))
              {
                InsertWordIntoList(word, file, linecount);
              }
            }
          }

        }
      }

      //dgvFoundWords.Rows.Clear();
      //foreach (Tuple<string, List<Tuple<string, List<int>>>> wordsOccurence in wordsOccurence)
      //{
      //  dgvFoundWords.Rows.Add(wordsOccurence.Item1);
      //}
    }



    private void btnStart_Click(object sender, EventArgs e)
    {
      StartCollectingWordsFromFiles();
      lblMsg.Text = "Finished";
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



    //Fills wordsOccurence with well known words files and lines. Just for Debug
    private void fillwordsOccurence()
    {
      word = "word1";

      linesOccurence = new List<int>() { 1, 2, 3, 4, 5 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file1.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));

      linesOccurence = new List<int>() { 3, 7 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file2.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));



      linesOccurence = new List<int>() { 1, 5, 7, 9, 12 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file3.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));



      linesOccurence = new List<int>() { 2, 7, 15, 18 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file4.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));


      word = "word2";

      linesOccurence = new List<int>() { 3, 7 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file2.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));


      linesOccurence = new List<int>() { 1, 2, 4, 9, 12 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file3.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));

      linesOccurence = new List<int>() { 3, 6, 7, 12, 15 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file4.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));

      word = "word3";
      linesOccurence = new List<int>() { 1, 2, 3, 4, 5 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file1.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));

      linesOccurence = new List<int>() { 1, 5, 6, 7, 8 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file3.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));


      linesOccurence = new List<int>() { 5, 9, 13, 19 };
      filesOccurence = new List<Tuple<string, List<int>>>() { new Tuple<string, List<int>>("c:\temp\temp\file4.c", linesOccurence) };
      wordsOccurence.Add(new Tuple<string, List<Tuple<string, List<int>>>>(word, new List<Tuple<string, List<int>>>(filesOccurence)));

    }


  }
}
