using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Svg;
using Svg.Transforms;
using System.Xml;
using System.IO;

namespace SVGViewer
{
    public partial class SVGViewer : Form
    {
        public SVGViewer()
        {
            InitializeComponent();
            textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ListSVGFiles(textBox1.Text);
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openSvgFile.ShowDialog() == DialogResult.OK)
            {
            	SvgDocument svgDoc = SvgDocument.Open(openSvgFile.FileName);
            	
            	RenderSvg(svgDoc);
            }
        }

        private string FXML = "";
        private string fileName = "";

        private void ListSVGFiles(string directory)
        {
          if (string.IsNullOrEmpty(directory))
            return;

          listBox1.Items.Clear();

          if (!Directory.Exists(directory))
          {
            MessageBox.Show(directory + ": the path does not exist!");
            return;
          }

          foreach (string file in Directory.GetFiles(directory))
          {
            string fileName = Path.GetFileName(file);

            if (fileName.EndsWith(".svg"))
              listBox1.Items.Add(fileName);
        	}
        }
        
        private void RenderSvg(SvgDocument svgDoc)
        {
          int width, height;
          if (!Int32.TryParse(tbHeight.Text, out height))
            tbHeight.Text = (height = 0).ToString();
          if (!Int32.TryParse(tbWidth.Text, out width))
            tbWidth.Text = (width = 0).ToString();

          var bitmap = svgDoc.Draw(width, height);
          if (bitmap == null) return;

          svgImage.Image = bitmap;
          svgImage.Image.Save(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(svgDoc.BaseUri.LocalPath), 
            string.Format("{0}_{1}.{2}", Path.GetFileNameWithoutExtension(fileName), DateTime.Now.ToString("yyyyMMdd_hhmmss"), "png")));

            this.Text = "Rendered Image, size: h" + svgImage.Image.Height + " w" + svgImage.Image.Width;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          if (listBox1.SelectedItem == null)
            return;

          fileName = listBox1.SelectedItem.ToString();
          SvgDocument svgDoc = SvgDocument.Open(textBox1.Text + @"\" + fileName);

          RenderSvg(svgDoc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          folderBrowserDialog1.SelectedPath = textBox1.Text;
          var result = folderBrowserDialog1.ShowDialog();

          if (result == DialogResult.OK)
          {
            textBox1.Text = folderBrowserDialog1.SelectedPath;
            ListSVGFiles(textBox1.Text);
          }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
          ListSVGFiles(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
          if (e.KeyCode == Keys.Enter)
            ListSVGFiles(textBox1.Text);
        }
    }
}
