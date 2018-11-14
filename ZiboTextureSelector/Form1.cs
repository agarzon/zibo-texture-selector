using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiboTextureSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string pathy = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            //MessageBox.Show(pathy);

        }

        private void Button2k_Click(object sender, EventArgs e)
        {
            this.CopyTexture("2K");
        }

        private void Button4k_Click(object sender, EventArgs e)
        {
            this.CopyTexture("4K");
        }

        private void CopyTexture(string resolution) {
            try
            {
                if (resolution == "2K") {
                    File.Copy("ACF_2k_4k/b738.acf.2k", "b738.acf", true);
                } else if(resolution == "4K") {
                    File.Copy("ACF_2k_4k/b738.acf.4k", "b738.acf", true);
                }

                this.outputLabel.Text = resolution + " texture installed!. Enjoy your flight!";
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
        }

    }
}
