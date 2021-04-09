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
    public partial class InputDataDialog : Form
    {
        public InputDataDialog()
        {
            InitializeComponent();
        }

        public string Name
        {
            set { tbxName.Text = value; }
            get { return tbxName.Text; }
        }

        public string ID
        {
            set { tbxID.Text = value; }
            get { return tbxID.Text; }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
