using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileInformationManagement.BLL;
using MobileInformationManagement.Models;
using MobileInformationManagement.DAL;

namespace MobileInformationManagement.BLL
{
    public class MobileManager
    {
        MobileGateWay mobileGateWay=new MobileGateWay();


        public bool SaveMobile(Mobile mobile)
        {

            int len = mobile.IMEI.Length;





            if (len==15)
            {
              bool fg =  mobileGateWay.SaveMobile(mobile);

                return fg;
            }
            else
            {
             return  false;
            }

            

        }


        public void SearchPrice(int pr1, int pr2)
        {
            mobileGateWay.SearchPrice(pr1,pr2);
        }

       
    }
}