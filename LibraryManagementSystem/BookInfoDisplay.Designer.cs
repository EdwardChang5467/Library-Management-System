
namespace LibraryManagementSystem
{
    partial class BookInfoDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfoDisplay));
            this.button1 = new System.Windows.Forms.Button();
            this.bookinfo = new System.Windows.Forms.ListView();
            this.bookid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookwriter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookpublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookcount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(33, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookinfo
            // 
            this.bookinfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookid,
            this.bookname,
            this.bookwriter,
            this.bookpublisher,
            this.bookcount});
            this.bookinfo.GridLines = true;
            this.bookinfo.HideSelection = false;
            this.bookinfo.Location = new System.Drawing.Point(94, 92);
            this.bookinfo.Name = "bookinfo";
            this.bookinfo.Size = new System.Drawing.Size(606, 322);
            this.bookinfo.TabIndex = 1;
            this.bookinfo.UseCompatibleStateImageBehavior = false;
            this.bookinfo.View = System.Windows.Forms.View.Details;
            this.bookinfo.SelectedIndexChanged += new System.EventHandler(this.bookinfo_SelectedIndexChanged);
            // 
            // bookid
            // 
            this.bookid.Text = "书籍编号";
            this.bookid.Width = 120;
            // 
            // bookname
            // 
            this.bookname.Text = "书籍名称";
            this.bookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookname.Width = 120;
            // 
            // bookwriter
            // 
            this.bookwriter.Text = "书籍作者";
            this.bookwriter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookwriter.Width = 120;
            // 
            // bookpublisher
            // 
            this.bookpublisher.Text = "出版社";
            this.bookpublisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookpublisher.Width = 120;
            // 
            // bookcount
            // 
            this.bookcount.Text = "书籍数量";
            this.bookcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookcount.Width = 120;
            // 
            // BookInfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookinfo);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfoDisplay";
            this.Text = "书籍信息";
            this.Load += new System.EventHandler(this.BookInfoDisplay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView bookinfo;
        private System.Windows.Forms.ColumnHeader bookid;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader bookwriter;
        private System.Windows.Forms.ColumnHeader bookpublisher;
        private System.Windows.Forms.ColumnHeader bookcount;
    }
}