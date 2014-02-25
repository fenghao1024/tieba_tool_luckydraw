using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

////////////////////////////////////////////////////////////
////    
////    BMX Rider : FengHao
////    
////             2013.06.10
////    
////////////////////////////////////////////////////////////
namespace BMX_TieBarTool
{
    public partial class SearchForm : Form
    {
        public SearchForm(Form1 f)
        {
            InitializeComponent();
            tempForm = f;
        }
        Form1 tempForm;

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int startIndex = 0;
        private void search_button_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text == "")
                return;
            int index = tempForm.FindItemInAllInfolistBox(IDtextBox.Text, startIndex);
            if (index == -1)
            {
                MessageBox.Show("No Found");
            }
            else
            {
                tempForm.selectItemInAllInfolistBox(index);
                startIndex = index + 1;
            }
        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {
            startIndex = 0;
        }
    }
}
