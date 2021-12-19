using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace Jtrade
{
	public static class SQL
	{
		private const string p_connectionString = "Server=localhost\\SQLEXPRESS; Database= trading;Integrated Security=SSPI;";
				
		public static List<string> Read(string ReqSQL) 
		{
			var list = new List<string>();

			SqlConnection connection;
            SqlCommand command;
            SqlDataReader dataReader;
        	connection = new SqlConnection(p_connectionString);
        	        	        	           
            try
            {
                connection.Open();
                command = new SqlCommand(ReqSQL, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                	list.Add(dataReader[1].ToString());
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return list;
		}
		public static void Write(string ReqSQL)
		{
			SqlConnection connection;
			connection = new SqlConnection(p_connectionString);
            var command = new SqlCommand(ReqSQL, connection);
                               	        	           
            try
            {
                connection.Open();                        
                command.ExecuteNonQuery();
                connection.Close();
                Log.WriteLog("Ajout d'un nouveau titre dans la base de données : " +ReqSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}
		
		public static void Delete(string ReqSQL)
		{
			SqlConnection connection;
			connection = new SqlConnection(p_connectionString);
            var command = new SqlCommand(ReqSQL, connection);
                               	        	           
            try
            {
                connection.Open();                        
                command.ExecuteNonQuery();
                connection.Close();
                Log.WriteLog("Suppression du titre dans la base de données : " +ReqSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}
		public static void Update(string ReqSQL)
		{
			SqlConnection connection;
			connection = new SqlConnection(p_connectionString);
            var command = new SqlCommand(ReqSQL, connection);
                                        	        	           
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Log.WriteLog("Modification du titre dans la base de données : " +ReqSQL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}
	}
}
