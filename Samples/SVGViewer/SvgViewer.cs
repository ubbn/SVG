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
            textBox1.Text = @"C:\Users\buyan\Downloads";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          if (textBox1.Text == "")
            return;

          listBox1.Items.Clear();
          string[] files = Directory.GetFiles(textBox1.Text);
          foreach (string file in files)
          {
            string fileName = Path.GetFileName(file);

            if (fileName.EndsWith(".svg"))
              listBox1.Items.Add(fileName);
        	}
        }
        
        private void RenderSvg(SvgDocument svgDoc)
        {
            //var render = new DebugRenderer();
            //svgDoc.Draw(render);
          var bitmap = svgDoc.Draw();
          if (bitmap == null) return;

          svgImage.Image = bitmap;
          svgImage.Image.Save(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(svgDoc.BaseUri.LocalPath), Path.GetFileNameWithoutExtension(fileName) + ".png"));

            //System.Diagnostics.Process.Start(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(svgDoc.BaseUri.LocalPath), "output.png"));
            this.Text = "On GITHUB: h" + svgImage.Image.Height + " w" + svgImage.Image.Width;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          fileName = listBox1.SelectedItem.ToString();
          SvgDocument svgDoc = SvgDocument.Open(textBox1.Text + @"\" + fileName);

          RenderSvg(svgDoc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          folderBrowserDialog1.SelectedPath = textBox1.Text;
          var result = folderBrowserDialog1.ShowDialog();

          if (result == DialogResult.OK)
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
