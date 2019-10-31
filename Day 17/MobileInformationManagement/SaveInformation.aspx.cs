using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileInformationManagement.BLL;
using MobileInformationManagement.Models;
using MobileInformationManagement.DAL;

namespace MobileInformationManagement
{
    public partial class SaveInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string modelName = inputModelName.Value;
            string imei = inputImei.Value;
            int price =Convert.ToInt32( inputPrice.Value);


            Mobile mobile = new Mobile(modelName, imei, price);

            mobile.ModelName = modelName;
            mobile.IMEI = imei;
            mobile.Price = price;


            MobileManager mobileManager = new MobileManager();
           bool dec= mobileManager.SaveMobile(mobile);
           if (dec)
           {
               saveLabel.Text = string.Empty;
               saveLabel.Text = "Save";
            }
           else
           {
               saveLabel.Text = string.Empty;
               saveLabel.Text = "Not Saved";
            }








        }
    }
}