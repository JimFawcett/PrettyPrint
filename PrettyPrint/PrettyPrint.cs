/////////////////////////////////////////////////////////////////////////
// PrettyPrint.cs - Source code printing                               //
// ver 1.1                                                             //
//                                                                     //
// Language:    Visual Studio 2005, C#                                 //
// Platform:    Dell Dimension 9200, Vista Ultimate, 32b               //
// Application: Format code for class presentation                     //
// Author:      Jim Fawcett, CST 2-187, Syracuse University            //
//              (315) 443-3948, jfawcett@twcny.rr.com                  //
/////////////////////////////////////////////////////////////////////////
/*
 * Module Operation:
 * =================
 * Provides titled, dated, paginated, and line-numbered, listings of
 * source code in landscape mode.
 * 
 * Build Process:
 * ==============
 * Required Files:
 *   PrettyPrint.cs
 * 
 * Compiler Command:
 *   csc PrettyPrint.cs
 * 
 * Maintenance History:
 * ====================
 * ver 1.4 : 18 Jan 10
 * - added print to XPS document
 * - still need to set default save name
 * - restore normal operation after unchecking save to file
 * ver 1.3 : 12 Jan 10
 * - removed preview button, added path checkbox
 * - fixed empty print exception bug
 * ver 1.2 : 04 Jan 08
 * - modified directory search in Browse_Button_Click
 * ver 1.1 : 10 Jul 07
 * - added StreamReader close and dispose in Print_Button_Click
 * ver 1.0 : 01 Jul 07
 * - first release
 * 
 * Planned Modifications:
 * ======================
 * - Support user settings for:
 *   - font-size
 *   - 2 source pages per output page
 *   - page borders
 * - finish drag and drop operations in TextBox
 * - word-wrap
 * - Print preview
 * - Use of printerSettings instead of predefined offsets for Margins
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PrettyPrint
{
  public partial class PrettyPrint : Form
  {
    private string[] files;
    private string currentFile;
    private StreamReader sr;
    private int linecount;
    private int pagecount;
    private Font ftitle;
    private Font fcode;
    private Pen pen;
    private DateTime fileDate;
    private string filePath;
    private int leftPageMargin = 50;
    private int rightPageMargin = 1000;
    private int topPageMargin = 50;
    private int topCodeMargin = 80;
    private int leftCodeMargin = 85;
    private int codeLineHeight = 12;
    private int footerPadding = 100;

    public PrettyPrint()
    {
      InitializeComponent();
    }

    private void Browse_Button_Click(object sender, EventArgs e)
    {
      listBox1.Items.Clear();
      if (Directory.Exists(textBox1.Text))
        openFileDialog1.InitialDirectory = textBox1.Text;
      else
        openFileDialog1.InitialDirectory = "c:\\su";
      if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        textBox1.Text = Path.GetDirectoryName(openFileDialog1.FileName);
        files = openFileDialog1.FileNames;
        foreach (string file in files)
        {
          string name = Path.GetFileName(file);
          listBox1.Items.Add(name);
        }
      }
    }

    private void Print_Button_Click(object sender, EventArgs e)
    {
      if (listBox1.Items.Count == 0)
        return;
      ftitle = new Font("Tahoma", 12, FontStyle.Bold);
      fcode = new Font("Courier New", 9, FontStyle.Bold);
      pen = new Pen(Brushes.Black);

      foreach (string file in files)
      {
        currentFile = file;
        FileInfo fi = new FileInfo(file);
        fileDate = fi.LastWriteTime;
        sr = new StreamReader(currentFile);
        linecount = 0;
        pagecount = 0;
        string name = Path.GetFileName(file);
        filePath = Path.GetDirectoryName(file);
        this.printDocument1.DocumentName = name;
        this.printDocument1.DefaultPageSettings.Landscape = true;
        if (checkBox2.Checked)
        {
          // generates PCL file
          //this.printDocument1.PrinterSettings.PrintToFile = true;
          //this.printDocument1.PrinterSettings.PrintFileName = "c:\\temp\\prettyprint.xps";

          this.printDialog1.Document = this.printDocument1;
          if (this.printDialog1.ShowDialog() == DialogResult.OK)
          {
            //string tempname = Path.GetFileNameWithoutExtension(currentFile) + ".xps";
            //this.printDialog1.PrinterSettings.PrintFileName = tempname;
            //this.printDocument1.PrinterSettings.PrintFileName = Path.GetFileName(currentFile) + ".xps";
          }
        }
        else
        {
          this.printDialog1.Reset();
          //this.printDialog1.Document = null;
        }
        this.printDocument1.Print();
        sr.Close();
        sr.Dispose();
      }
      ftitle.Dispose();
      fcode.Dispose();
    }

    //private void Preview_Button_Click(object sender, EventArgs e)
    //{
    //  // not implemented yet
    //}

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      Graphics g = e.Graphics;
      StringBuilder fileInfoStr = new StringBuilder(printDocument1.DocumentName);
      fileInfoStr.Append("   :   ");
      fileInfoStr.Append(fileDate.ToString());
      if (checkBox1.Checked)
      {
        fileInfoStr.Append("   :   ");
        fileInfoStr.Append(filePath);
      }
      g.DrawString(fileInfoStr.ToString(), ftitle, Brushes.Black, leftPageMargin, topPageMargin);
      g.DrawLine(pen, leftPageMargin, topPageMargin + 22, rightPageMargin, topPageMargin + 22);
      int i = 0;
      StringBuilder footer;
      while (!sr.EndOfStream)
      {
        string line = sr.ReadLine();
        g.DrawString((++linecount).ToString(), fcode, Brushes.Black, leftPageMargin, topCodeMargin + codeLineHeight * (i));
        g.DrawString(line, fcode, Brushes.Black, leftCodeMargin, topCodeMargin + codeLineHeight * (i++));
        if (i % 50 == 0)
        {
          e.HasMorePages = true;
          footer = new StringBuilder("Page ");
          footer.Append((++pagecount).ToString());
          g.DrawString(footer.ToString(), fcode, Brushes.Black, leftPageMargin, footerPadding + codeLineHeight * (i));
          return;
        }
      }
      e.HasMorePages = false;
      footer = new StringBuilder("Page ");
      footer.Append((++pagecount).ToString());
      g.DrawString(footer.ToString(), fcode, Brushes.Black, leftPageMargin, footerPadding + codeLineHeight * (i));
    }

    private void PrettyPrint_Load(object sender, EventArgs e)
    {
      this.Text = "Source Code Printer, ver 1.1";
      string cmdline = System.Environment.CommandLine;
      string[] args = cmdline.Split(' ');
      if (args.Length > 1)
        textBox1.Text = args[1];
    }

    //////////////////////////////////////////////////
    // Drag and Drop operations do not work yet

    private void textBox1_DragDrop(object sender, DragEventArgs e)
    {
      string[] debug = e.Data.GetFormats();
      string dragData = (string)e.Data.GetData(typeof(string));
      textBox1.Text = dragData;
    }

    private void textBox1_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(typeof(string)))
      {
        e.Effect = DragDropEffects.Copy;
      }
      else
      {
        e.Effect = DragDropEffects.None;
      }
    }

    private void textBox1_DragLeave(object sender, EventArgs e)
    {

    }

    private void textBox1_DragOver(object sender, DragEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      //MessageBox.Show("text changed");
      //if (textBox1.Text[textBox1.Text.Length - 1] == '\n')
      //  Browse_Button_Click(this, null);
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
     
    }
  }
}