using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Library_4;

namespace F4_WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public double F4(double x, double y)
        {
            return (KI3_Class_4.F4(x, y));

        }
        public DataTable GetKindByID(string value)
        {
            int id = int.Parse(value);
            string DB = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Car_Specification;Integrated Security=True";
            string Query = "select * from DetailD where ID=" + id;
            using (SqlConnection Conn = new SqlConnection(DB))  
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, DB);
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
        }
        public DataTable GetAllKinds()
        {
            string DB = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Car_Specification;Integrated Security=True";
            string Query = "SELECT * FROM DetailD INNER JOIN PartD ON DetailD.Part_ID = PartD.ID";
            using (SqlConnection Conn = new SqlConnection(DB))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                Conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(Query, DB);
                da.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
        }

    }
}
