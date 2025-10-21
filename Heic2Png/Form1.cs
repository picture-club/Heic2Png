using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heic2Png
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string[] heicFiles = Directory.GetFiles(tbxSrcFolder.Text, "*.heic", SearchOption.AllDirectories);

            lblHeicCnt.Text = heicFiles.Length.ToString();
            lblHeicCnt.Refresh();

            int idxPng = 0;

            foreach (string file in heicFiles)
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string outputPath = Path.Combine(tbxDestFolder.Text, fileName + ".png");

                    using (var image = new MagickImage(file))
                    {
                        image.Format = MagickFormat.Png;
                        image.Write(outputPath);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error converting {file}: {ex.Message}");
                }
                finally
                {
                    lblPngCnt.Text = (++idxPng).ToString();
                    lblPngCnt.Refresh();
                }
            }
        }

        private void btnSrcBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(tbxSrcFolder.Text))
                {
                    fbd.SelectedPath = tbxSrcFolder.Text;
                }

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tbxSrcFolder.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnDestBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (Directory.Exists(tbxDestFolder.Text))
                {
                    fbd.SelectedPath = tbxDestFolder.Text;
                }

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tbxDestFolder.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
