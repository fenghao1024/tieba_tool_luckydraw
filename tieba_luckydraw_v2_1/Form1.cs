using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
using mshtml;
using System.Threading;
using System.Timers;


////////////////////////////////////////////////////////////
////    
////    BMX Rider : FengHao
////    
////             2013.06.10
////    
////////////////////////////////////////////////////////////
namespace BMX_TieBarTool
{

    public struct postStruct
    {
        public string usrName;
        public string postContent;
    };

    public partial class Form1 : Form
    {

        //public string strTeiBarURL = "http://tieba.baidu.com/f?kw=bmx";
        public string strTeiBarURL = "http://tieba.baidu.com/p/2356501475";
        
        private string htmlData;
        
        private List<string> urlList;

        private List<postStruct> postStructList;

        private int[] winnerNum;
        private List<int> winnerNumList;
        private int winnerCount;

        private List<string> resultList;

        private bool isGameEnd = false;
      
        public Form1()
        {
            InitializeComponent();
            //contentStrBox = new List<string>();
            urlList = new List<string>();
            postStructList = new List<postStruct>();
            Main_webBrowser.ScriptErrorsSuppressed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            URLtextBox.Text = strTeiBarURL;
            getdata_button.Enabled = false;
            winnerNumList = new List<int>();
        }

        private void Goto_url_Click(object sender, EventArgs e)
        {
            Main_webBrowser.Navigate(URLtextBox.Text);
            getdata_button.Enabled = true;
        }

        private void getdata_button_Click(object sender, EventArgs e)
        {
            StreamReader htmlStreamReader = new StreamReader(Main_webBrowser.DocumentStream, Encoding.GetEncoding("gb2312"));
            htmlData = htmlStreamReader.ReadToEnd();
            int startIndex = 0;

            List<string> list = new List<string>();
            while(true)
            {
                string context = idAndCountentReader.getSegment(htmlData, "<cc>", "</cc>", ref startIndex);

                if (context == null)
                {
                    break;
                }
                list.Add(context);
            }
            string[] str = list.ToArray();


            List<string> idList = new List<string>();
            startIndex = 0;
            while (true)
            {
                string context = idAndCountentReader.getSegment(htmlData, "<li class=\"d_name\"", "</li>", ref startIndex);
                if (context == null)
                    break;
                idList.Add(context);
            }
            string[] strId = idList.ToArray();

            
            int count = idList.Count;
            char[] shouldRemoveChar = {'\r', '\n', '\t'};
            for (int i = 0; i < count; i++ )
            {
                int temp_index = 0;
                strId[i] = idAndCountentReader.getContent(strId[i], shouldRemoveChar, ref temp_index);
            }


            count = list.Count;    
            char[] shouldRemoveChar2 = {'\t'};
            for (int i = 0; i < count; i++)
            {
                int temp_index = 0;
                str[i] = str[i].Replace("<br>", "\r\n");
                str[i] = idAndCountentReader.getContent(str[i], shouldRemoveChar2, ref temp_index);
            }

            idList.Clear();
            list.Clear();
            for (int i = 0; i < count; i++)
            {
                idList.Add(strId[i]);
                list.Add(str[i]);
            }
            insertPost(idList, list);

            this.urlList.Add(Main_webBrowser.Url.ToString());
            
        }

        private void URLtextBox_TextChanged(object sender, EventArgs e)
        {
            Goto_url.Enabled = true;
        }


        private void insertPost(List<string> userName, List<string> postContent)
        {
            if (userName.Count != postContent.Count)
                return;

            List<postStruct> tempList = postStructMaker(userName, postContent);
            if (tempList == null)
                return;
            //deleteRepeatItem(ref this.postStructList);
            for (int i = 0; i < tempList.Count; i++)
            {
                this.postStructList.Add(tempList[i]);
                AllInfolistBox.Items.Add(tempList[i].usrName);
            }
        }

        private void deleteRepeatItem(ref List<postStruct> postStructList)
        {
            for (int i = 0; i < postStructList.Count; i++)
            {
                string s = postStructList[i].usrName;
                for (int j = i + 1; j < postStructList.Count; j++)
                {
                    if (s.Equals(postStructList[j].usrName))
                    {
                        postStructList.Remove(postStructList[j]);
                        AllInfolistBox.Items.RemoveAt(j);
                    }
                }
            }
        }

        private List<postStruct> postStructMaker(List<string> userName, List<string> postContent)
        {
            if(userName.Count != postContent.Count)
                return null;

            List<postStruct> tempList = new List<postStruct>();
            for(int i = 0; i < postContent.Count; i++)
            {
                postStruct p;
                p.usrName = userName[i];
                p.postContent = postContent[i];
                tempList.Add(p);
            }
            return tempList;
        }

        private void AllInfolistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.AllInfolistBox.SelectedIndex < 0)
                return;
            this.postContentBox.Text = this.postStructList[AllInfolistBox.SelectedIndex].postContent;
        }

        private void deleteInfo_button_Click(object sender, EventArgs e)
        {
            delete_info();
        }

        private void delete_info()
        {
            if (this.AllInfolistBox.SelectedIndex < 0)
                return;
            int index = this.AllInfolistBox.SelectedIndex;
            this.AllInfolistBox.Items.RemoveAt(index);
            this.postStructList.RemoveAt(index);
            this.postContentBox.Clear();
            //this.AllInfolistBox.SelectedIndex = 0;
        }

        private void deleteSameInfobutton_Click(object sender, EventArgs e)
        {
            deleteRepeatItem(ref this.postStructList);
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            InsertInfoForm insertForm = new InsertInfoForm(this);
            //insertForm.Parent = this;
            insertForm.Show();
        }

        public void insertPost(postStruct post)
        {
            this.AllInfolistBox.Items.Add(post.usrName);
            postStructList.Add(post);
        }

        public int FindItemInAllInfolistBox(string key,int startIndex)
        {
            int index = -1;
            if(key == null || startIndex < 0)
                return -1;

            for (int i = startIndex; i < AllInfolistBox.Items.Count; i++)
            {
                string data = AllInfolistBox.Items[i].ToString();
                index = idAndCountentReader.findStr(data, key, 0);
                if(index != -1)
                {
                    // index = i; return index;
                    return i;
                }
            }
            
            return -1;
        }

        public void selectItemInAllInfolistBox(int index)
        {
            AllInfolistBox.SetSelected(index, true);
        }



        private void Main_webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.URLtextBox.Text = Main_webBrowser.Url.ToString();
        }

        private void AllInfolistBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                delete_info();
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm(this);
            //sf.Location = new Point(600, this.Height / 2);
            sf.Show();
        }

        // gameStart
        private void start_button_Click(object sender, EventArgs e)
        {

        }

        // delete prize item
        private void deletePrizeItembutton_Click(object sender, EventArgs e)
        {
            delete_prize();
        } // by delete Prize button
        private void prizeBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                delete_prize();
        } // by keyBoard ---> keys.delete

        // delete prize implement
        private void delete_prize()
        {
            if (this.prizeBox.SelectedIndex < 0)
                return;
            int index = this.prizeBox.SelectedIndex;
            this.prizeBox.Items.RemoveAt(index);
            //this.postStructList.RemoveAt(index);
            //this.postContentBox.Clear();
            //this.AllInfolistBox.SelectedIndex = 0;
        }


        // insert prize Item
        private void insertPrizeItembutton_Click(object sender, EventArgs e)
        {
            InsertPrizeItemForm prizeItemForm = new InsertPrizeItemForm(this);
            prizeItemForm.Location = new Point(this.Width / 2, this.Height / 2);
            prizeItemForm.Show();
        }
        public void insertPrizeItem(string[] items)
        {
            foreach(string s in items)
            {
                prizeBox.Items.Add(s);
            }
        }
        private string resultMake()
        {
            string data = "";
            for (int i = 0; i < resultList.Count; i++)
            {
                data += resultList[i].ToString();
                data += "\n\n\n==============================================================";
            }
            return data + "\r\n\t\t\t\t\t×××××××××　贴吧抽奖神器v2.0　×××××××××" + DateTime.Now.ToString();
        }
        // export winner info and prize to txt
        private void exportWinnerbutton_Click(object sender, EventArgs e)
        {
            if (!isGameEnd)
            {
                MessageBox.Show("抽奖尚未结束！！");
                return;
            }
            if(luckyDogBox.Items.Count == 0)
            {
                return ;
            }
            string str = resultMake();
            saveProfile_withDialog(str);
        }

        // luckyDox listBox 
        private void luckyDogBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(resultList == null)
            {
                return;
            }
            if (luckyDogBox.SelectedIndex == -1)
            {
                return;
            }
            luckyDogPostBox.Text = resultList[luckyDogBox.SelectedIndex];
            prizeBox.SetSelected(luckyDogBox.SelectedIndex, true);
        }

        private string lucyDogPostBoxShow(string prize, string id, string post)
        {
            return "\n奖品：" + prize + "\n\n 获奖者ID：" + id + "\n\n 当时的报名内容：" + post;
        }

        // prize listBox 
        private void prizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prizeTabPage_Click(object sender, EventArgs e)
        {
            luckyDogBox.Items.Clear();
            if(winnerNum == null || winnerNum.Length < 0)
                return ;
            foreach (int i in winnerNum)
            {
                luckyDogBox.Items.Add(AllInfolistBox.Items[i].ToString());
            }
        }

        private void StartTabPage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rock();
            if (-1 != GameStart())
            {
                if (checkIsGameEnd())
                {
                    MessageBox.Show("抽奖结束");
                    GameEnd();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //rock();
        }

        private void rock()
        {
            int timeOut = 2;
            for (int j = 0; j < 3; j++)
            {
                Point curLctn = pictureBox1.Location;
                for (int i = 0; i < 30; i++)
                {
                    pictureBox1.Location = new Point(curLctn.X, curLctn.Y - i);
                    Thread.Sleep(timeOut);
                }
                curLctn = pictureBox1.Location;
                for (int i = 0; i < 30; i++)
                {
                    pictureBox1.Location = new Point(curLctn.X, curLctn.Y + i);
                    Thread.Sleep(timeOut);
                }
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            rock();
            if (-1 != GameStart())
            {
                if (checkIsGameEnd())
                {
                    MessageBox.Show("抽奖结束");
                    GameEnd();
                }
            }
        }

        private bool checkIsGameEnd()
        {
            bool isEnd = false;
            winnerCount = prizeBox.Items.Count;
            if (winnerNumList.Count >= winnerCount)
            {
                isEnd = true;
            }
            return isEnd;
        }

        private int GameStart()
        {
            isGameEnd = false;
            if (AllInfolistBox.Items.Count <= 0 || prizeBox.Items.Count <= 0)
            {
                MessageBox.Show("抽奖参与者或者奖品名单未设置");
                return -1;
            }

            this.getdata_button.Enabled = false;
            this.deleteInfo_button.Enabled = false;
            this.insert_button.Enabled = false;
            this.deletePrizeItembutton.Enabled = false;
            this.deleteSameInfobutton.Enabled = false;
            this.insertPrizeItembutton.Enabled = false;

            winnerNum = winnerNumList.ToArray();
            int thisWinner = getNextWinner(0, postStructList.Count, winnerNum);
            winnerNumList.Add(thisWinner);

            this.congratulateLabel.Text = "Congratulation...";
            this.winnerLabel.Text = postStructList[thisWinner].usrName;

            this.luckyDogBox.Items.Add(postStructList[thisWinner].usrName);

            return thisWinner;
        }
        private void GameEnd()
        {
            isGameEnd = true;
            resultList = new List<string>();
            for (int i = 0; i < winnerCount; i++)
            {
                int index = winnerNumList[i];
                resultList.Add(lucyDogPostBoxShow(prizeBox.Items[i].ToString(), luckyDogBox.Items[i].ToString(), postStructList[index].postContent));
            }
        }

        private int getNextWinner(int min, int max, int[] except)
        {
            // Guid.NewGuid() 
            string str = Guid.NewGuid().ToString();
            str = StringToHex(str);
            str = str.Substring(new Random().Next(0, str.Length - 9), 8);
            int seed = Convert.ToInt32(str, 16);
            Random random = new Random(seed);
            int x;
            while (true)
            {
                bool bbreak = true;
                x = random.Next(min, max);
                for (int i = 0; i < except.Length; i++)
                {
                    if (x == except[i])
                    {
                        bbreak = false;
                        break;
                    }
                }
                if (bbreak)
                    break;
            }
            return x;
        }

        public string StringToHex(string str)
        {
            //str = str.Trim();
            byte[] ByteFoo = System.Text.Encoding.Default.GetBytes(str);
            string TempStr = "";
            foreach (byte b in ByteFoo)
            {
                TempStr += b.ToString("X"); //X表示十六进制显示
            }
            return TempStr;
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            if (!getID_and_Post_withFile(readProfile_withDialog()))
                return;
            
            AllInfolistBox.Items.Clear();
            
            for (int i = 0; i < postStructList.Count; i++)
            {
                AllInfolistBox.Items.Add(postStructList[i].usrName);
            }
        }
        private string readProfile_withDialog()
        {
            string data;
            string path;
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK != ofd.ShowDialog())
            {
                return null;
            }
            path = ofd.FileName;

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, Encoding.Default);
            data = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            return data;
        }
        private bool getID_and_Post_withFile(string data)
        {
            //postStruct p;
            if (data == null)
                return false;

            postStructList = new List<postStruct>();

            List<string> idList = new List<string>();
            List<string> postList = new List<string>();
            int startIndex = 0;
            while (true)
            {
                string tempstr = idAndCountentReader.getSegment(data, "<teiba_standard_mark_name>", "</teiba_standard_mark_name>", ref startIndex);
                if (tempstr == null)
                {
                    break;
                }
                char[] charRemove = {'\n'};
                int tempIndex = 0;
                tempstr = idAndCountentReader.getContent(tempstr, charRemove,ref tempIndex);
                idList.Add(tempstr);
            }

            startIndex = 0;
            while (true)
            {
                string tempstr = idAndCountentReader.getSegment(data, "<teiba_standard_mark_post>", "</teiba_standard_mark_post>", ref startIndex);
                if (tempstr == null)
                {
                    break;
                }
                tempstr = tempstr.Replace('\r', ' ');
                int tempIndex = 0;
                tempstr = idAndCountentReader.getContent(tempstr, null, ref tempIndex);
                postList.Add(tempstr);
            }

            for (int i = 0; i < idList.Count; i++)
            {
                postStruct p;
                p.usrName = idList[i];
                p.postContent = postList[i];
                postStructList.Add(p);
            }

            return true;

        }


        private void save_button_Click(object sender, EventArgs e)
        {
            if (postStructList.Count <= 0)
                return;
            string data = "";
            for(int i = 0; i < postStructList.Count; i++)
            {
                string name = "\n<teiba_standard_mark_name>" + postStructList[i].usrName + "</teiba_standard_mark_name>\n";
                string post = "\n<teiba_standard_mark_post>" + postStructList[i].postContent + "</teiba_standard_mark_post>\n\n\n";
                data += name;
                data += post;
            }

            saveProfile_withDialog(data);

        }

        private void saveProfile_withDialog(string data)
        {
            data = data.Replace("\n", "\r\n");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.RestoreDirectory = true;
            string temppath = "";
            if (DialogResult.OK != sfd.ShowDialog())
                return;
            temppath = sfd.FileName.ToString();

            FileStream fs = new FileStream(temppath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            fs.Flush();
            sw.Flush();
            sw.Write(data);
            sw.Close();
            fs.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Links[0].LinkData = "http://tieba.baidu.com/f?kw=bmx";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString()); 
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.Links[0].LinkData = "http://weibo.com/1924941937";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString()); 
        }
        

    }
}
