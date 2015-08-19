namespace SVGViewer
{
    partial class SVGViewer
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SVGViewer));
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.open = new System.Windows.Forms.ToolStripButton();
      this.svgImage = new System.Windows.Forms.PictureBox();
      this.openSvgFile = new System.Windows.Forms.OpenFileDialog();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.lblPath = new System.Windows.Forms.Label();
      this.lblDescription = new System.Windows.Forms.Label();
      this.lblListBox = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.tbWidth = new System.Windows.Forms.TextBox();
      this.lblWidth = new System.Windows.Forms.Label();
      this.lblHeight = new System.Windows.Forms.Label();
      this.tbHeight = new System.Windows.Forms.TextBox();
      this.toolStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.svgImage)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1060, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // open
      // 
      this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
      this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.open.Name = "open";
      this.open.Size = new System.Drawing.Size(56, 22);
      this.open.Text = "Open";
      this.open.Click += new System.EventHandler(this.open_Click);
      // 
      // svgImage
      // 
      this.svgImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.svgImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.svgImage.Location = new System.Drawing.Point(0, 25);
      this.svgImage.Name = "svgImage";
      this.svgImage.Size = new System.Drawing.Size(735, 449);
      this.svgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.svgImage.TabIndex = 1;
      this.svgImage.TabStop = false;
      // 
      // openSvgFile
      // 
      this.openSvgFile.Filter = "Vector Graphics (*.svg)|*.svg";
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.Location = new System.Drawing.Point(741, 42);
      this.textBox1.MaxLength = 327670;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(307, 20);
      this.textBox1.TabIndex = 1;
      this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
      this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
      // 
      // listBox1
      // 
      this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(741, 128);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(307, 264);
      this.listBox1.TabIndex = 3;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(951, 65);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(97, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Open Folder";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lblPath
      // 
      this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblPath.AutoSize = true;
      this.lblPath.Location = new System.Drawing.Point(742, 25);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(48, 13);
      this.lblPath.TabIndex = 5;
      this.lblPath.Text = "File Path";
      // 
      // lblDescription
      // 
      this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblDescription.Location = new System.Drawing.Point(742, 65);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(198, 31);
      this.lblDescription.TabIndex = 6;
      this.lblDescription.Text = "Enter path or choose from dialog. It will list all SVG files existing the given p" +
    "ath";
      // 
      // lblListBox
      // 
      this.lblListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblListBox.AutoSize = true;
      this.lblListBox.Location = new System.Drawing.Point(745, 109);
      this.lblListBox.Name = "lblListBox";
      this.lblListBox.Size = new System.Drawing.Size(271, 13);
      this.lblListBox.TabIndex = 7;
      this.lblListBox.Text = "SVG files (press any listed file to render SVG on left side)";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.tbWidth);
      this.groupBox1.Controls.Add(this.tbHeight);
      this.groupBox1.Controls.Add(this.lblWidth);
      this.groupBox1.Controls.Add(this.lblHeight);
      this.groupBox1.Location = new System.Drawing.Point(741, 398);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(307, 70);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Override original size";
      // 
      // tbWidth
      // 
      this.tbWidth.Location = new System.Drawing.Point(64, 45);
      this.tbWidth.Name = "tbWidth";
      this.tbWidth.Size = new System.Drawing.Size(100, 20);
      this.tbWidth.TabIndex = 5;
      // 
      // lblWidth
      // 
      this.lblWidth.AutoSize = true;
      this.lblWidth.Location = new System.Drawing.Point(22, 45);
      this.lblWidth.Name = "lblWidth";
      this.lblWidth.Size = new System.Drawing.Size(35, 13);
      this.lblWidth.TabIndex = 13;
      this.lblWidth.Text = "Width";
      // 
      // lblHeight
      // 
      this.lblHeight.AutoSize = true;
      this.lblHeight.Location = new System.Drawing.Point(21, 22);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new System.Drawing.Size(38, 13);
      this.lblHeight.TabIndex = 12;
      this.lblHeight.Text = "Height";
      // 
      // tbHeight
      // 
      this.tbHeight.Location = new System.Drawing.Point(64, 19);
      this.tbHeight.Name = "tbHeight";
      this.tbHeight.Size = new System.Drawing.Size(100, 20);
      this.tbHeight.TabIndex = 4;
      // 
      // SVGViewer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1060, 474);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.lblListBox);
      this.Controls.Add(this.lblDescription);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.svgImage);
      this.Controls.Add(this.toolStrip1);
      this.Name = "SVGViewer";
      this.Text = "SVG to PNG Conversion";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.svgImage)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.PictureBox svgImage;
        private System.Windows.Forms.OpenFileDialog openSvgFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
    }
}

