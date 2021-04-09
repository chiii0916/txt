using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            dlg.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDialog mydlg = new MyDialog();
            mydlg.Show();
        }
    }
}
