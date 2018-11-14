using System;
using System.IO;
using System.Windows.Forms;

namespace ZiboTextureSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            catch (Exception)
            {
                MessageBox.Show("Remember, you must install this executable in your ZIBO B737-800X folder", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //throw;
            }
        }

    }
}
