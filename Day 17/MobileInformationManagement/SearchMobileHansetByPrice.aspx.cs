using MobileInformationManagement.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MobileInformationManagement.Models;
using MobileInformationManagement.DAL;

namespace MobileInformationManagement
{
    public partial class SearchMobileHansetByPrice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void searchByPriceButton_Click(object sender, EventArgs e)
        {
            int pr1 = Convert.ToInt32(inputPrice1);
            int pr2 = Convert.ToInt32(inputPrice2);

               MobileManager mobileManager=new MobileManager();


               mobileManager.SearchPrice(pr1,pr2);





           
        }
    }
}