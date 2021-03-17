using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan
{
    class Addplayer : IAddplayer
    {
        
        string Connection = "Data Source = BLUEWINDOW\\MY_SQL; initial Catalog = Clan_DB; User ID = sa; password = twins1386;";

        public bool add(int ID, string Name, int avatar)
        {
            SqlConnection connection = new SqlConnection(Connection);
            try
            {
                string query = "Insert Into [dbo].[Clan_Profile](Name,Avatar,Cup,money) Values (@Name,@Avatar,@Cup,@Money)";
                SqlCommand command = new SqlCommand(query,connection);               
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Avatar", avatar);
                command.Parameters.AddWithValue("@Cup", 0);
                command.Parameters.AddWithValue("@Money", 0);
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
