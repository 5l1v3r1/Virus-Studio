using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virus_Studio
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Configuration config = new Configuration();

            //Change the buttons style
            btn_1.FlatStyle = FlatStyle.Flat;
            btn_1.FlatAppearance.BorderSize = 0;
            btn_2.FlatStyle = FlatStyle.Flat;
            btn_2.FlatAppearance.BorderSize = 0;
            btn_3.FlatStyle = FlatStyle.Flat;
            btn_3.FlatAppearance.BorderSize = 0;
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.FlatStyle = FlatStyle.Flat;
            btn_4.FlatAppearance.BorderSize = 0;

            //Set the language
            CultureInfo ci = CultureInfo.InstalledUICulture;
            if (ci.Name == "es-ES" || ci.Name == "es-MX")
                config.setLanguage(Configuration.lang.español);
            else if (ci.Name == "en-EN")
                config.setLanguage(Configuration.lang.english);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void user_control_1_Load(object sender, EventArgs e)
        {

        }
    }
}
