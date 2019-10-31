//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;
//using MobileInformationManagement.BLL;
//using MobileInformationManagement.Models;
//using MobileInformationManagement.DAL;

//namespace MobileInformationManagement.DAL
//{
//    public class MobileGateWay
//    {
//        public string re;
//         string connectionString =
//            "server=PC-301-01\\SQLEXPRESS; database=MobileInformationManagement; integrated security=true";

//        public object GridView1 { get; private set; }

//        public bool SaveMobile(Mobile mobile)
//        {

//            string queryCheck = "SELECT ModelName FROM mobile_table WHERE EXISTS(SELECT ModelName FROM mobile_table WHERE IMEI = '"+mobile.IMEI+"') ";

//            SqlConnection connection = new SqlConnection(connectionString);


//            SqlCommand command = new SqlCommand(queryCheck, connection);
//            connection.Open();

//            SqlDataReader reader = command.ExecuteReader();
          
//            while (reader.Read())
//            {
//                 re = reader[0].ToString();
//            }

//            connection.Close();
//            reader.Close();

//            if (re ==null)
//            {
//                string query = "INSERT INTO [dbo].[mobile_table]([ModelName],[IMEI] ,[Price])VALUES ('" + mobile.ModelName + "', '" + mobile.IMEI + "', '" + mobile.Price + "')";



//                SqlConnection connectionn = new SqlConnection(connectionString);


//                SqlCommand commandd = new SqlCommand(query, connectionn);
//                connectionn.Open();
//                int rowEffect = commandd.ExecuteNonQuery();
//                connectionn.Close();
//                return true;

//            }
//            else
//            {
//                return false;
//            }




//        }


//        public Mobile SearchPrice(int pr1, int pr2)
//        {
            
//            List<Mobile> mobileList=new List<Mobile>();


//            string query = "SELECT [Sl#],[ModelName] ,[IMEI] ,[Price] FROM[dbo].[mobile_table] where Price BETWEEN '"+pr1+"' AND '"+pr2+"';";


//            SqlConnection connection=new SqlConnection(connectionString);


//            SqlCommand command=new SqlCommand(query,connection);



//            SqlDataReader reader = command.ExecuteReader();

//            connection.Open();

//            while (reader.Read())
//            {

//                int sl = (int)reader[0];
//                string name = reader[1].ToString();
//                string imei = reader[2].ToString();
//                int price = (int) reader[3];


//                Mobile mobile=new Mobile(name,imei,price);
//                mobile.SL = sl;

//                mobileList.Add(mobile);




//            }

//            return mobileList;









//        }



//    }
//}