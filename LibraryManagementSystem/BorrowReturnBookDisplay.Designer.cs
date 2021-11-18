
namespace LibraryManagementSystem
{
    partial class BorrowReturnBookDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowReturnBookDisplay));
            this.button1 = new System.Windows.Forms.Button();
            this.borrowreturninfo = new System.Windows.Forms.ListView();
            this.userid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.account = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrowdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returndate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(34, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // borrowreturninfo
            // 
            this.borrowreturninfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userid,
            this.account,
            this.bookid,
            this.bookname,
            this.borrowdate,
            this.returndate});
            this.borrowreturninfo.GridLines = true;
            this.borrowreturninfo.HideSelection = false;
            this.borrowreturninfo.Location = new System.Drawing.Point(85, 81);
            this.borrowreturninfo.Name = "borrowreturninfo";
            this.borrowreturninfo.Size = new System.Drawing.Size(594, 315);
            this.borrowreturninfo.TabIndex = 1;
            this.borrowreturninfo.UseCompatibleStateImageBehavior = false;
            this.borrowreturninfo.View = System.Windows.Forms.View.Details;
            this.borrowreturninfo.SelectedIndexChanged += new System.EventHandler(this.borrowreturninfo_SelectedIndexChanged);
            // 
            // userid
            // 
            this.userid.Text = "用户编号";
            this.userid.Width = 100;
            // 
            // account
            // 
            this.account.Text = "用户账号";
            this.account.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.account.Width = 100;
            // 
            // bookid
            // 
            this.bookid.Text = "书籍编号";
            this.bookid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookid.Width = 100;
            // 
            // bookname
            // 
            this.bookname.Text = "书籍名称";
            this.bookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookname.Width = 100;
            // 
            // borrowdate
            // 
            this.borrowdate.Text = "借书日期";
            this.borrowdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.borrowdate.Width = 100;
            // 
            // returndate
            // 
            this.returndate.Text = "还书日期";
            this.returndate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.returndate.Width = 100;
            // 
            // BorrowReturnBookDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.borrowreturninfo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrowReturnBookDisplay";
            this.Text = "借还书信息";
            this.Load += new System.EventHandler(this.BorrowReturnBookDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView borrowreturninfo;
        private System.Windows.Forms.ColumnHeader userid;
        private System.Windows.Forms.ColumnHeader account;
        private System.Windows.Forms.ColumnHeader bookid;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader borrowdate;
        private System.Windows.Forms.ColumnHeader returndate;
    }
}