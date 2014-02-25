namespace BMX_TieBarTool
{
    partial class InsertPrizeItemForm
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
            this.insertPrizeItembutton = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertPrizeItembutton
            // 
            this.insertPrizeItembutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertPrizeItembutton.BackColor = System.Drawing.Color.LightGray;
            this.insertPrizeItembutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.insertPrizeItembutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.insertPrizeItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertPrizeItembutton.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertPrizeItembutton.Location = new System.Drawing.Point(141, 300);
            this.insertPrizeItembutton.Name = "insertPrizeItembutton";
            this.insertPrizeItembutton.Size = new System.Drawing.Size(138, 43);
            this.insertPrizeItembutton.TabIndex = 6;
            this.insertPrizeItembutton.Text = "Insert";
            this.insertPrizeItembutton.UseVisualStyleBackColor = false;
            this.insertPrizeItembutton.Click += new System.EventHandler(this.insertPrizeItembutton_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel_button.BackColor = System.Drawing.Color.LightGray;
            this.cancel_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.cancel_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(4, 300);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(131, 43);
            this.cancel_button.TabIndex = 7;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 249);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paste PrizeItems Here";
            // 
            // InsertPrizeItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.insertPrizeItembutton);
            this.Name = "InsertPrizeItemForm";
            this.Text = "InsertPrizeItemForm";
            this.Load += new System.EventHandler(this.InsertPrizeItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertPrizeItembutton;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;

    }
}