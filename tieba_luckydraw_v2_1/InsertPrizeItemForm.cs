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
    public partial class InsertPrizeItemForm : Form
    {
        public InsertPrizeItemForm(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        Form1 parentForm;
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // insert prize item to MainForm
        private void insertPrizeItembutton_Click(object sender, EventArgs e)
        {
            this.parentForm.insertPrizeItem(splidStr(richTextBox1.Text, new string[]{"\n", "\r\n"}));
            this.richTextBox1.Clear();
        }

        private string[] splidStr(string data, string[] splidMark)
        {
            //data = data.Replace("\r\n", "\n");
            return data.Split(splidMark, StringSplitOptions.RemoveEmptyEntries);
        }

        private void InsertPrizeItemForm_Load(object sender, EventArgs e)
        {
            insertPrizeItembutton.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.richTextBox1.Text != "")
            {
                insertPrizeItembutton.Enabled = true;
            }
        }


    }
}
