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
    public partial class BorrowReturnBookDisplay : Form
    {
        public BorrowReturnBookDisplay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BorrowReturnBookDisplay_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection("data source=localhost; database=reading_manage_system; port=3306; User Id=root; Password=wang20000309.");
            mySqlConnection.Open();

            String borrowReturnInfoSql = "select * from adminborrowreturninfoview";
            MySqlCommand mySqlCommand = new MySqlCommand(borrowReturnInfoSql, mySqlConnection);
            MySqlDataReader dr = mySqlCommand.ExecuteReader();

            // 向列表添加数据
            this.borrowreturninfo.BeginUpdate();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem();
                list.SubItems[0].Text = dr["UserId"].ToString();
                list.SubItems.Add(dr["UserAccount"].ToString());
                list.SubItems.Add(dr["bookId"].ToString());
                list.SubItems.Add(dr["bookName"].ToString());
                list.SubItems.Add(dr["borrowDate"].ToString());
                list.SubItems.Add(dr["returnDate"].ToString());
                this.borrowreturninfo.Items.Add(list);
            }
            this.borrowreturninfo.EndUpdate();

            dr.Close();
            mySqlCommand.ExecuteNonQuery();
            this.Controls.Add(borrowreturninfo);
            mySqlConnection.Close();
        }

        private void borrowreturninfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
