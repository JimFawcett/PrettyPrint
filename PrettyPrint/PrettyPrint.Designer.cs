namespace PrettyPrint
{
  partial class PrettyPrint
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrettyPrint));
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      this.Browse_Button = new System.Windows.Forms.Button();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.Print_Button = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // printDialog1
      // 
      this.printDialog1.UseEXDialog = true;
      // 
      // printDocument1
      // 
      this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
      this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
      // 
      // printPreviewDialog1
      // 
      this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
      this.printPreviewDialog1.Enabled = true;
      this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
      this.printPreviewDialog1.Name = "printPreviewDialog1";
      this.printPreviewDialog1.Visible = false;
      // 
      // Browse_Button
      // 
      this.Browse_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Browse_Button.Location = new System.Drawing.Point(379, 399);
      this.Browse_Button.Margin = new System.Windows.Forms.Padding(4);
      this.Browse_Button.Name = "Browse_Button";
      this.Browse_Button.Size = new System.Drawing.Size(100, 28);
      this.Browse_Button.TabIndex = 0;
      this.Browse_Button.Text = "Browse";
      this.Browse_Button.UseVisualStyleBackColor = true;
      this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
      // 
      // listBox1
      // 
      this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 16;
      this.listBox1.Location = new System.Drawing.Point(16, 54);
      this.listBox1.Margin = new System.Windows.Forms.Padding(4);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(461, 324);
      this.listBox1.TabIndex = 1;
      // 
      // Print_Button
      // 
      this.Print_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.Print_Button.Location = new System.Drawing.Point(250, 399);
      this.Print_Button.Margin = new System.Windows.Forms.Padding(4);
      this.Print_Button.Name = "Print_Button";
      this.Print_Button.Size = new System.Drawing.Size(100, 28);
      this.Print_Button.TabIndex = 3;
      this.Print_Button.Text = "Print";
      this.Print_Button.UseVisualStyleBackColor = true;
      this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Multiselect = true;
      // 
      // textBox1
      // 
      this.textBox1.AcceptsReturn = true;
      this.textBox1.AllowDrop = true;
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(16, 15);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(461, 22);
      this.textBox1.TabIndex = 4;
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
      this.textBox1.DragLeave += new System.EventHandler(this.textBox1_DragLeave);
      this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
      this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox1_DragOver);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(16, 401);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(97, 21);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Show Path";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(120, 401);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(101, 21);
      this.checkBox2.TabIndex = 6;
      this.checkBox2.Text = "Print to File";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
      // 
      // PrettyPrint
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(495, 448);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.Print_Button);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.Browse_Button);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "PrettyPrint";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.PrettyPrint_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    private System.Windows.Forms.Button Browse_Button;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Button Print_Button;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.CheckBox checkBox2;
  }
}

