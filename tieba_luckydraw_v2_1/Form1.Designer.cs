namespace BMX_TieBarTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.postContentBox = new System.Windows.Forms.RichTextBox();
            this.AllInfolistBox = new System.Windows.Forms.ListBox();
            this.URLtextBox = new System.Windows.Forms.TextBox();
            this.Main_webBrowser = new System.Windows.Forms.WebBrowser();
            this.Goto_url = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.browserTabPage = new System.Windows.Forms.TabPage();
            this.getdata_button = new System.Windows.Forms.Button();
            this.windowCtrlTabPage = new System.Windows.Forms.TabPage();
            this.open_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.deleteSameInfobutton = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.deleteInfo_button = new System.Windows.Forms.Button();
            this.StartTabPage = new System.Windows.Forms.TabPage();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.congratulateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prizeTabPage = new System.Windows.Forms.TabPage();
            this.luckyDogPostBox = new System.Windows.Forms.RichTextBox();
            this.exportWinnerbutton = new System.Windows.Forms.Button();
            this.luckyDogBox = new System.Windows.Forms.ListBox();
            this.insertPrizeItembutton = new System.Windows.Forms.Button();
            this.deletePrizeItembutton = new System.Windows.Forms.Button();
            this.prizeBox = new System.Windows.Forms.ListBox();
            this.developPate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.browserTabPage.SuspendLayout();
            this.windowCtrlTabPage.SuspendLayout();
            this.StartTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.prizeTabPage.SuspendLayout();
            this.developPate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // postContentBox
            // 
            this.postContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postContentBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.postContentBox.Location = new System.Drawing.Point(228, 10);
            this.postContentBox.Name = "postContentBox";
            this.postContentBox.Size = new System.Drawing.Size(550, 407);
            this.postContentBox.TabIndex = 0;
            this.postContentBox.Text = "";
            // 
            // AllInfolistBox
            // 
            this.AllInfolistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllInfolistBox.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AllInfolistBox.FormattingEnabled = true;
            this.AllInfolistBox.ItemHeight = 25;
            this.AllInfolistBox.Location = new System.Drawing.Point(3, 10);
            this.AllInfolistBox.Name = "AllInfolistBox";
            this.AllInfolistBox.Size = new System.Drawing.Size(219, 404);
            this.AllInfolistBox.TabIndex = 2;
            this.AllInfolistBox.SelectedIndexChanged += new System.EventHandler(this.AllInfolistBox_SelectedIndexChanged);
            this.AllInfolistBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AllInfolistBox_KeyUp);
            // 
            // URLtextBox
            // 
            this.URLtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLtextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.URLtextBox.Location = new System.Drawing.Point(6, 6);
            this.URLtextBox.Name = "URLtextBox";
            this.URLtextBox.Size = new System.Drawing.Size(720, 29);
            this.URLtextBox.TabIndex = 3;
            this.URLtextBox.TextChanged += new System.EventHandler(this.URLtextBox_TextChanged);
            // 
            // Main_webBrowser
            // 
            this.Main_webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Main_webBrowser.Location = new System.Drawing.Point(3, 41);
            this.Main_webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Main_webBrowser.Name = "Main_webBrowser";
            this.Main_webBrowser.Size = new System.Drawing.Size(775, 387);
            this.Main_webBrowser.TabIndex = 4;
            this.Main_webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.Main_webBrowser_Navigated);
            // 
            // Goto_url
            // 
            this.Goto_url.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Goto_url.BackColor = System.Drawing.Color.LightGray;
            this.Goto_url.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Goto_url.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Goto_url.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Goto_url.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goto_url.Location = new System.Drawing.Point(724, 6);
            this.Goto_url.Name = "Goto_url";
            this.Goto_url.Size = new System.Drawing.Size(54, 29);
            this.Goto_url.TabIndex = 5;
            this.Goto_url.Text = "GO";
            this.Goto_url.UseVisualStyleBackColor = false;
            this.Goto_url.Click += new System.EventHandler(this.Goto_url_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.browserTabPage);
            this.tabControl.Controls.Add(this.windowCtrlTabPage);
            this.tabControl.Controls.Add(this.StartTabPage);
            this.tabControl.Controls.Add(this.prizeTabPage);
            this.tabControl.Controls.Add(this.developPate);
            this.tabControl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(2, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 530);
            this.tabControl.TabIndex = 6;
            // 
            // browserTabPage
            // 
            this.browserTabPage.Controls.Add(this.getdata_button);
            this.browserTabPage.Controls.Add(this.Goto_url);
            this.browserTabPage.Controls.Add(this.Main_webBrowser);
            this.browserTabPage.Controls.Add(this.URLtextBox);
            this.browserTabPage.Location = new System.Drawing.Point(4, 37);
            this.browserTabPage.Name = "browserTabPage";
            this.browserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.browserTabPage.Size = new System.Drawing.Size(784, 489);
            this.browserTabPage.TabIndex = 1;
            this.browserTabPage.Text = "Browser";
            this.browserTabPage.UseVisualStyleBackColor = true;
            // 
            // getdata_button
            // 
            this.getdata_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getdata_button.BackColor = System.Drawing.Color.LightGray;
            this.getdata_button.FlatAppearance.BorderSize = 0;
            this.getdata_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.getdata_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.getdata_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getdata_button.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getdata_button.ForeColor = System.Drawing.Color.DarkViolet;
            this.getdata_button.Location = new System.Drawing.Point(3, 442);
            this.getdata_button.Name = "getdata_button";
            this.getdata_button.Size = new System.Drawing.Size(778, 36);
            this.getdata_button.TabIndex = 6;
            this.getdata_button.Text = "GetUserInfo";
            this.getdata_button.UseVisualStyleBackColor = false;
            this.getdata_button.Click += new System.EventHandler(this.getdata_button_Click);
            // 
            // windowCtrlTabPage
            // 
            this.windowCtrlTabPage.Controls.Add(this.open_button);
            this.windowCtrlTabPage.Controls.Add(this.save_button);
            this.windowCtrlTabPage.Controls.Add(this.search_button);
            this.windowCtrlTabPage.Controls.Add(this.deleteSameInfobutton);
            this.windowCtrlTabPage.Controls.Add(this.insert_button);
            this.windowCtrlTabPage.Controls.Add(this.deleteInfo_button);
            this.windowCtrlTabPage.Controls.Add(this.AllInfolistBox);
            this.windowCtrlTabPage.Controls.Add(this.postContentBox);
            this.windowCtrlTabPage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowCtrlTabPage.Location = new System.Drawing.Point(4, 37);
            this.windowCtrlTabPage.Name = "windowCtrlTabPage";
            this.windowCtrlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.windowCtrlTabPage.Size = new System.Drawing.Size(784, 489);
            this.windowCtrlTabPage.TabIndex = 0;
            this.windowCtrlTabPage.Text = "Info";
            this.windowCtrlTabPage.UseVisualStyleBackColor = true;
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.open_button.BackColor = System.Drawing.Color.LightGray;
            this.open_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.open_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.open_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_button.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_button.Location = new System.Drawing.Point(620, 433);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(78, 48);
            this.open_button.TabIndex = 8;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = false;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.BackColor = System.Drawing.Color.LightGray;
            this.save_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.save_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(704, 433);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(74, 48);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search_button.BackColor = System.Drawing.Color.LightGray;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(427, 433);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(155, 48);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Search by ID";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // deleteSameInfobutton
            // 
            this.deleteSameInfobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteSameInfobutton.BackColor = System.Drawing.Color.LightGray;
            this.deleteSameInfobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.deleteSameInfobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.deleteSameInfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSameInfobutton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSameInfobutton.Location = new System.Drawing.Point(228, 433);
            this.deleteSameInfobutton.Name = "deleteSameInfobutton";
            this.deleteSameInfobutton.Size = new System.Drawing.Size(181, 48);
            this.deleteSameInfobutton.TabIndex = 5;
            this.deleteSameInfobutton.Text = "DeleteSameInfo";
            this.deleteSameInfobutton.UseVisualStyleBackColor = false;
            this.deleteSameInfobutton.Click += new System.EventHandler(this.deleteSameInfobutton_Click);
            // 
            // insert_button
            // 
            this.insert_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.insert_button.BackColor = System.Drawing.Color.LightGray;
            this.insert_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.insert_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.insert_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_button.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_button.Location = new System.Drawing.Point(121, 433);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(101, 48);
            this.insert_button.TabIndex = 4;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = false;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // deleteInfo_button
            // 
            this.deleteInfo_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteInfo_button.BackColor = System.Drawing.Color.LightGray;
            this.deleteInfo_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.deleteInfo_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.deleteInfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteInfo_button.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteInfo_button.Location = new System.Drawing.Point(3, 433);
            this.deleteInfo_button.Name = "deleteInfo_button";
            this.deleteInfo_button.Size = new System.Drawing.Size(101, 48);
            this.deleteInfo_button.TabIndex = 3;
            this.deleteInfo_button.Text = "Delete";
            this.deleteInfo_button.UseVisualStyleBackColor = false;
            this.deleteInfo_button.Click += new System.EventHandler(this.deleteInfo_button_Click);
            // 
            // StartTabPage
            // 
            this.StartTabPage.Controls.Add(this.winnerLabel);
            this.StartTabPage.Controls.Add(this.congratulateLabel);
            this.StartTabPage.Controls.Add(this.panel2);
            this.StartTabPage.Location = new System.Drawing.Point(4, 37);
            this.StartTabPage.Name = "StartTabPage";
            this.StartTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartTabPage.Size = new System.Drawing.Size(784, 489);
            this.StartTabPage.TabIndex = 2;
            this.StartTabPage.Text = "GameStart";
            this.StartTabPage.UseVisualStyleBackColor = true;
            this.StartTabPage.Click += new System.EventHandler(this.StartTabPage_Click);
            // 
            // winnerLabel
            // 
            this.winnerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.winnerLabel.BackColor = System.Drawing.Color.Silver;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.MediumPurple;
            this.winnerLabel.Location = new System.Drawing.Point(25, 182);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(414, 237);
            this.winnerLabel.TabIndex = 6;
            // 
            // congratulateLabel
            // 
            this.congratulateLabel.AutoSize = true;
            this.congratulateLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratulateLabel.Location = new System.Drawing.Point(34, 47);
            this.congratulateLabel.Name = "congratulateLabel";
            this.congratulateLabel.Size = new System.Drawing.Size(0, 33);
            this.congratulateLabel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(501, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 477);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::BMX_TieBarTool.Properties.Resources.RockRock1;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::BMX_TieBarTool.Properties.Resources.RockRock1;
            this.pictureBox1.Location = new System.Drawing.Point(41, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // prizeTabPage
            // 
            this.prizeTabPage.Controls.Add(this.luckyDogPostBox);
            this.prizeTabPage.Controls.Add(this.exportWinnerbutton);
            this.prizeTabPage.Controls.Add(this.luckyDogBox);
            this.prizeTabPage.Controls.Add(this.insertPrizeItembutton);
            this.prizeTabPage.Controls.Add(this.deletePrizeItembutton);
            this.prizeTabPage.Controls.Add(this.prizeBox);
            this.prizeTabPage.Location = new System.Drawing.Point(4, 37);
            this.prizeTabPage.Name = "prizeTabPage";
            this.prizeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.prizeTabPage.Size = new System.Drawing.Size(784, 489);
            this.prizeTabPage.TabIndex = 3;
            this.prizeTabPage.Text = "Prize";
            this.prizeTabPage.UseVisualStyleBackColor = true;
            this.prizeTabPage.Click += new System.EventHandler(this.prizeTabPage_Click);
            // 
            // luckyDogPostBox
            // 
            this.luckyDogPostBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.luckyDogPostBox.Location = new System.Drawing.Point(490, 27);
            this.luckyDogPostBox.Name = "luckyDogPostBox";
            this.luckyDogPostBox.Size = new System.Drawing.Size(288, 399);
            this.luckyDogPostBox.TabIndex = 8;
            this.luckyDogPostBox.Text = "";
            // 
            // exportWinnerbutton
            // 
            this.exportWinnerbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exportWinnerbutton.BackColor = System.Drawing.Color.LightGray;
            this.exportWinnerbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.exportWinnerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.exportWinnerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportWinnerbutton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportWinnerbutton.Location = new System.Drawing.Point(275, 435);
            this.exportWinnerbutton.Name = "exportWinnerbutton";
            this.exportWinnerbutton.Size = new System.Drawing.Size(217, 48);
            this.exportWinnerbutton.TabIndex = 7;
            this.exportWinnerbutton.Text = "Export LuckyDog";
            this.exportWinnerbutton.UseVisualStyleBackColor = false;
            this.exportWinnerbutton.Click += new System.EventHandler(this.exportWinnerbutton_Click);
            // 
            // luckyDogBox
            // 
            this.luckyDogBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.luckyDogBox.FormattingEnabled = true;
            this.luckyDogBox.ItemHeight = 28;
            this.luckyDogBox.Location = new System.Drawing.Point(252, 27);
            this.luckyDogBox.Name = "luckyDogBox";
            this.luckyDogBox.Size = new System.Drawing.Size(240, 396);
            this.luckyDogBox.TabIndex = 6;
            this.luckyDogBox.SelectedIndexChanged += new System.EventHandler(this.luckyDogBox_SelectedIndexChanged);
            // 
            // insertPrizeItembutton
            // 
            this.insertPrizeItembutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.insertPrizeItembutton.BackColor = System.Drawing.Color.LightGray;
            this.insertPrizeItembutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.insertPrizeItembutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.insertPrizeItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertPrizeItembutton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPrizeItembutton.Location = new System.Drawing.Point(115, 435);
            this.insertPrizeItembutton.Name = "insertPrizeItembutton";
            this.insertPrizeItembutton.Size = new System.Drawing.Size(131, 48);
            this.insertPrizeItembutton.TabIndex = 5;
            this.insertPrizeItembutton.Text = "Insert";
            this.insertPrizeItembutton.UseVisualStyleBackColor = false;
            this.insertPrizeItembutton.Click += new System.EventHandler(this.insertPrizeItembutton_Click);
            // 
            // deletePrizeItembutton
            // 
            this.deletePrizeItembutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletePrizeItembutton.BackColor = System.Drawing.Color.LightGray;
            this.deletePrizeItembutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.deletePrizeItembutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.deletePrizeItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePrizeItembutton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePrizeItembutton.Location = new System.Drawing.Point(6, 435);
            this.deletePrizeItembutton.Name = "deletePrizeItembutton";
            this.deletePrizeItembutton.Size = new System.Drawing.Size(93, 48);
            this.deletePrizeItembutton.TabIndex = 4;
            this.deletePrizeItembutton.Text = "Delete";
            this.deletePrizeItembutton.UseVisualStyleBackColor = false;
            this.deletePrizeItembutton.Click += new System.EventHandler(this.deletePrizeItembutton_Click);
            // 
            // prizeBox
            // 
            this.prizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.prizeBox.FormattingEnabled = true;
            this.prizeBox.ItemHeight = 28;
            this.prizeBox.Location = new System.Drawing.Point(6, 27);
            this.prizeBox.Name = "prizeBox";
            this.prizeBox.Size = new System.Drawing.Size(240, 396);
            this.prizeBox.TabIndex = 0;
            this.prizeBox.SelectedIndexChanged += new System.EventHandler(this.prizeBox_SelectedIndexChanged);
            this.prizeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.prizeBox_KeyUp);
            // 
            // developPate
            // 
            this.developPate.Controls.Add(this.label1);
            this.developPate.Controls.Add(this.linkLabel2);
            this.developPate.Controls.Add(this.label3);
            this.developPate.Controls.Add(this.label2);
            this.developPate.Controls.Add(this.linkLabel1);
            this.developPate.Controls.Add(this.pictureBox2);
            this.developPate.Location = new System.Drawing.Point(4, 37);
            this.developPate.Name = "developPate";
            this.developPate.Padding = new System.Windows.Forms.Padding(3);
            this.developPate.Size = new System.Drawing.Size(784, 489);
            this.developPate.TabIndex = 4;
            this.developPate.Text = "Developer";
            this.developPate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-5, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 10);
            this.label1.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(613, 252);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 28);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "@BMXDN";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feng Hao";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developer:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(491, 451);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(282, 28);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://tieba.baidu.com/f?kw=bmx";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BMX_TieBarTool.Properties.Resources.My360V2;
            this.pictureBox2.InitialImage = global::BMX_TieBarTool.Properties.Resources.My360V2;
            this.pictureBox2.Location = new System.Drawing.Point(50, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(480, 270);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "贴吧抽奖神器 v2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.browserTabPage.ResumeLayout(false);
            this.browserTabPage.PerformLayout();
            this.windowCtrlTabPage.ResumeLayout(false);
            this.StartTabPage.ResumeLayout(false);
            this.StartTabPage.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.prizeTabPage.ResumeLayout(false);
            this.developPate.ResumeLayout(false);
            this.developPate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox postContentBox;
        private System.Windows.Forms.ListBox AllInfolistBox;
        private System.Windows.Forms.TextBox URLtextBox;
        private System.Windows.Forms.WebBrowser Main_webBrowser;
        private System.Windows.Forms.Button Goto_url;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage windowCtrlTabPage;
        private System.Windows.Forms.TabPage browserTabPage;
        private System.Windows.Forms.Button getdata_button;
        private System.Windows.Forms.Button deleteInfo_button;
        private System.Windows.Forms.TabPage StartTabPage;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button deleteSameInfobutton;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TabPage prizeTabPage;
        private System.Windows.Forms.ListBox prizeBox;
        private System.Windows.Forms.Button exportWinnerbutton;
        private System.Windows.Forms.ListBox luckyDogBox;
        private System.Windows.Forms.Button insertPrizeItembutton;
        private System.Windows.Forms.Button deletePrizeItembutton;
        private System.Windows.Forms.RichTextBox luckyDogPostBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label congratulateLabel;
        private System.Windows.Forms.TabPage developPate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

