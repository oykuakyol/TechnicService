using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicService.CustomerClasses
{
    class CustomerClass
    {

        public int ID { get; set; }

        public String FirstName { get; set; }


        public String LastName { get; set; }


        public String Address { get; set; }


       

        static string myconnstrng = ConfigurationManager.ConnectionStrings["TechnicService.Properties.Settings.customerConnectionString"].ConnectionString;
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Customer";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }

            finally
            {
                conn.Close();

            }
            return dt;

        }



        public bool Insert(CustomerClass std)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Customer(FisrtName,LastName,Address) VALUES(@FisrtName,@LastName,@Address)";


                    SqlCommand cmd = new SqlCommand(sql, conn);
              
                cmd.Parameters.AddWithValue("@FisrtName", std.FirstName);
                cmd.Parameters.AddWithValue("@LastName", std.LastName);
                cmd.Parameters.AddWithValue("@Address", std.Address);
                

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;


}
public bool Update(CustomerClass std)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE Customer SET FisrtName=@FisrtName , LastName=@LastName , Address=@Address";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FisrtName", std.FirstName);
                cmd.Parameters.AddWithValue("@LastName", std.LastName);
                cmd.Parameters.AddWithValue("@Address", std.Address);
                
            
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        
        
        
        
        } 
    
   public bool Delete(CustomerClass std)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM Customer WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", std.ID);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            
            }
        catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }




















   
    
    
    
    
    
    
    
    } 
}