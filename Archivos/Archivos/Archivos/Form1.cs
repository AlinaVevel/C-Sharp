using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                Bitmap image = new Bitmap(openFileDialog1.FileName);                
                
                pictureBox1.Image = image;
                pictureBox1.Invalidate();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Bitmap image;
            if (pictureBox1.Image != null) 
            {

                
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Guardar como...";
               
                savedialog.OverwritePrompt = true;
               
                savedialog.CheckPathExists = true;            
                savedialog.Filter = "JPG|*.jpg";
               
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("No se puede guardar", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
