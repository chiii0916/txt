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

namespace _1072008_HW4_1
{
    public partial class picform : Form
    {
        string[] Files;
        int num=0;
        public picform()
        {
            InitializeComponent();
        }
        
        
        private void btnfolder_Click(object sender, EventArgs e)
        {
            string path;
           
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            Files=Directory.GetFiles(path);
            pbx.Load(Files[0]);
            this.pbx.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pbx.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pbx_Click(object sender, EventArgs e)
        {
           
        }

        private void picform_Load(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if(num>0)
            {
                num -= 1;
                pbx.Load(Files[num]);
            }
            else
            {
                num = 0;
                pbx.Load(Files[num]);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                num += 1;
                pbx.Load(Files[num]);
            }
            catch
            {
                num = -1;
                Form2 f2 = new Form2();
                f2.Show();
            }
            
        }
    }
}
