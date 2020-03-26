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
    }
}
