using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Studio
{
    public partial class Creator_1 : UserControl
    {
        string virusFilePath = String.Empty;
        Stream virusFileStream;
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        Virus virus = new Virus();
        Configuration config = new Configuration();

        public Creator_1()
        {
            InitializeComponent();
        }

        private void Creator_1_Load(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Visual Basic File (*.vbs)|*.vbs|All files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                virusFilePath = saveFileDialog.FileName;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            virusFileStream.Close(); //This is unnecessary but I do not care about your opinion if you do not make a Pull Request asking me to delete this line >:v
            MessageBox.Show("Thanks for using my program. - CosmoXD");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            string alertMessage = config.InputMessageBox(String.Empty);
            virus.alert(alertMessage, virusFilePath);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            string URL = config.InputMessageBox(String.Empty);
            virus.openWebsite(URL, virusFilePath);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            virus.shutdown(virusFilePath);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string customScript = config.InputMessageBox(String.Empty);
            virus.customScript(virusFilePath, customScript);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            virus.showVirusName(virusFilePath);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            string spam = config.InputMessageBox(String.Empty);
            virus.spamMessage(virusFilePath, spam);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            string name = config.InputMessageBox(String.Empty);
            virus.virusName = name;
        }
    }
}