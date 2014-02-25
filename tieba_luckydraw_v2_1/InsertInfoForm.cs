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
    public partial class InsertInfoForm : Form
    {
        public InsertInfoForm(Form1 f)
        {
            InitializeComponent();
            temp = f;
        }

        Form1 temp;

        private void insert_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || richTextBox1.Text == "")
            {
                return;
            }
            postStruct p;
            p.usrName = textBox1.Text.Trim();
            p.postContent = richTextBox1.Text;
            temp.insertPost(p);
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
