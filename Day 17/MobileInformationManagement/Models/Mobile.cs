using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileInformationManagement.BLL;
using MobileInformationManagement.Models;
using MobileInformationManagement.DAL;

namespace MobileInformationManagement.Models
{
    public class Mobile
    {
        public int SL { get; set; }
        public String ModelName { get; set; }
        public String IMEI { get; set; }
        public int Price { get; set; }

        public Mobile(string modelName, string iMEI, int price)
        {
            ModelName = modelName;
            IMEI = iMEI;
            Price = price;
        }
    }
}