using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Clan
{
    class Profile : IProfile
    {
        private string Connection = "data source=.;initial catalog=Clan_DB;integrated security=True;";
        public bool Choose(int Avatar)
        {
            throw new NotImplementedException();
        }

        public DataTable search(string friends_search)
        {
            string query = "Select * From [dbo].[Clan_Profile] Where Name like @Name ";
            SqlConnection connection = new SqlConnection(Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@Name", "%" + friends_search + "%");
            DataTable data = new DataTable();            
            adapter.Fill(data);
            return data;
        }

        public DataTable selectall()
        {
            string query = "Select * From [dbo].[Clan_Profile]";
            SqlConnection connection = new SqlConnection(Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query,Connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update_Avatar(int Avatar, int ID)
        {
            SqlConnection connection = new SqlConnection(Connection);
            try
            {
                string query = "Update [dbo].[Clan_Profile] set Avatar = @Avatar Where PlayerID = @ID";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Avatar", Avatar);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool Update_name(string name, int ID)
        {
            SqlConnection connection = new SqlConnection(Connection);

            try
            {
                string query = "Update  [dbo].[Clan_Profile] set Name=@Name Where PlayerID = @ID";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Name", name);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        
    }
}
