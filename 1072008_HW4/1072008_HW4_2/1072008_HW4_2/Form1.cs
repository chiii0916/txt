
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1072008_HW4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            check();

        }
        public int count()
        {
            int money=0;
            for(int i=0;i<clbmenu.CheckedItems.Count;i++)
            {
                if(clbmenu.CheckedItems[i]==clbmenu.Items[0])
                {
                    money += 300;
                }
                else if(clbmenu.CheckedItems[i]==clbmenu.Items[1])
                {
                    money += 350;
                }
                else if (clbmenu.CheckedItems[i] == clbmenu.Items[2])
                {
                    money += 350;
                }
                else if (clbmenu.CheckedItems[i] == clbmenu.Items[3])
                {
                    money += 450;
                }
                else if (clbmenu.CheckedItems[i] == clbmenu.Items[4])
                {
                    money += 550;
                }
                else if (clbmenu.CheckedItems[i] == clbmenu.Items[5])
                {
                    money += 550;
                }
            }
            if (checkBox1.Checked == true)
                money += 10;
            if (checkBox2.Checked == true)
                money += 30;

            return money;

        }

        public void check()
        {
            string name = tbxName.Text;
            string item = clbmenu.Text;
            message.Text += tbxName.Text + "您好,您買了";
            for (int i = 0; i < clbmenu.CheckedItems.Count; i++)
                message.Text += clbmenu.CheckedItems[i] + ",";

            message.Text += "總金額為" + count() + ",";
            message.Text += "付款方式為";
            if (rbn1.Checked == true)
                message.Text += "貨到付款";
            else if (rbn2.Checked == true)
                message.Text += "ATM,";
            message.Text += ",產品將於";
            message.Text += dateTimePicker1.Value.ToShortDateString();
            message.Text += "送達,謝謝";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
