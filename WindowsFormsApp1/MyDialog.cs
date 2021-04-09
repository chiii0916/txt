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
    public partial class MyDialog : Form
    {
        public MyDialog()
        {
            InitializeComponent();
        }

        private void btnInputData_Click(object sender, EventArgs e)
        {
            InputDataDialog dlg = new InputDataDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string data = dlg.Name +"    "+dlg.ID; //利用InputDataDialog的Name
                                                       //及ID屬性取得輸入的資料
                IbxData.BeginUpdate(); //預備開始更新ListBox裡的資料
                IbxData.Items.Add(data); //將資料新增至ListBox
                IbxData.EndUpdate(); //結束ListBox資料的更新
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IbxData.Items.Clear();
        }
    }
}
