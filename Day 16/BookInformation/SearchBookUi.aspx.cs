using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookInformation
{
    public partial class SearchBookUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text;
            string connectionString =
                @"Server = PC-301-17\SQLEXPRESS; Database = BookInformationKeeperDB; Integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Book_tbl where BookName like '" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
           bookGridView.DataSource = ds;
            bookGridView.DataBind();
        }
    }
}