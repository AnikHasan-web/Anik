using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformation.BLL;

namespace BookInformation
{
    public partial class ShowAllBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           BookManager bookManager = new BookManager();
           bookGridView.DataSource = bookManager.GetAllBooks();
           bookGridView.DataBind();
        }

        protected void bookGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}