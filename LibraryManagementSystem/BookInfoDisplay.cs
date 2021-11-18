using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class BookInfoDisplay : Form
    {
        public BookInfoDisplay()
        {
            InitializeComponent();
        }

        private void BookInfoDisplay_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("data source=localhost; database=reading_manage_system; port=3306; User Id=root; Password=wang20000309.");
            mySqlConnection.Open();

            String bookInfoSql = "select * from book";
            MySqlCommand mySqlCommand = new MySqlCommand(bookInfoSql, mySqlConnection);
            MySqlDataReader dr = mySqlCommand.ExecuteReader();

            // 向列表添加数据
            this.bookinfo.BeginUpdate();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();
                list.SubItems[0].Text = dr["bookId"].ToString();
                list.SubItems.Add(dr["bookName"].ToString());
                list.SubItems.Add(dr["bookWriter"].ToString());
                list.SubItems.Add(dr["bookPublisher"].ToString());
                list.SubItems.Add(dr["bookCount"].ToString());
                this.bookinfo.Items.Add(list);
            }
            this.bookinfo.EndUpdate();

            dr.Close();
            mySqlCommand.ExecuteNonQuery();
            this.Controls.Add(bookinfo);
            mySqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookinfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
