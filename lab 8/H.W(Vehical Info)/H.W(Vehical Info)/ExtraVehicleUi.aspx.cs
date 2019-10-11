using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H.W_Vehical_Info_
{
    public partial class ExtraVehicleUi : System.Web.UI.Page
    {
        Vehicle aVehicle = new Vehicle();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                messageLabel.Text = string.Empty;
                messageLabel.Text = "Please fill up the name field";
                //messageLabel.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(regTextBox.Text))
            {
                messageLabel.Text = string.Empty;
                messageLabel.Text = "Please fill up the reg  field";
                //messageLabel.ForeColor = Color.Red;
            }
            else
            {
                messageLabel.Text = string.Empty;
                aVehicle.Name = nameTextBox.Text;
                aVehicle.Reg = regTextBox.Text;
                ViewState["AVehicle"] = aVehicle;
                nameTextBox.Text = string.Empty;
                regTextBox.Text = string.Empty;
            }
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Vehicle bVehicle = (Vehicle)ViewState["AVehicle"];
            Vehicle cVehicle = (Vehicle)ViewState["AVehicle"];

            double maxSpeed = bVehicle.GetMaxSpeed();
            double minSpeed = bVehicle.GetMinSpeed();
            double avgSpeed = bVehicle.GetAvgSpeed();
            maxTextBox.Text = maxSpeed.ToString();
            minTextBox.Text = minSpeed.ToString();
            avgTextBox.Text = avgSpeed.ToString();
            nameTextBox.Text = cVehicle.Name;
            regTextBox.Text = cVehicle.Reg;


        }

        protected void enterButton_Click(object sender, EventArgs e)
        {
            speedLabel.Text = String.Empty;
            if (string.IsNullOrEmpty(speedTextBox.Text))
            {
                speedLabel.Text = string.Empty;
                speedLabel.Text = "Please fill up the speed field";
                //speedLabel.ForeColor = Color.Red;
            }
            else
            {
                Vehicle tempVehicle = (Vehicle)ViewState["AVehicle"];
                tempVehicle.Speed.Add(Convert.ToDouble(speedTextBox.Text));

                ViewState["AVehicle"] = tempVehicle;
                speedTextBox.Text = string.Empty;

                speedLabel.Text = string.Empty;
                speedLabel.Text = "Speed Info Saved";
                //speedLabel.ForeColor = Color.Green;
            }

        }
    }
}