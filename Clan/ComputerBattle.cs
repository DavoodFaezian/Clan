using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clan
{
    class ComputerBattle : IComputerBattle
    {
        string Connection = "Data Source = .; initial Catalog = Clan_DB; User ID = sa; password = twins1386;";


        public bool Cup(int ID, int cup,int currentcup, int money, int currentmoney)
        {
            SqlConnection connection = new SqlConnection(Connection);
            try
            {
                string query = "Update [dbo].[Clan_Profile] set Cup = @Cup,Money=@Money Where PlayerID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                int finalcup;
                finalcup = cup + currentcup;
                int finalmoney;
                finalmoney = money + currentmoney;
                command.Parameters.AddWithValue("@ID", 1);
                command.Parameters.AddWithValue("@Cup", finalcup);
                command.Parameters.AddWithValue("@Money", finalmoney);
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
        public bool Money(int ID, int money, int currentmoney)
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                string query = "Update [dbo].[Clan_Profile] set Money = @Money Where PlayerID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                int finalmoney;
                finalmoney = money + currentmoney;
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Money", finalmoney);
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

        public DataTable Selectall()
        {
            SqlConnection connection = new SqlConnection();
            string query = "select * From [dbo].[Clan_Profile]";
            SqlDataAdapter adapter = new SqlDataAdapter(query,Connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        
    }
}
