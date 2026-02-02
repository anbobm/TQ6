using Microsoft.Data.Sqlite;
using Microsoft.Data;



namespace ErsterProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=C:\\Users\\mytq\\Documents\\Repository\\ErsterProjekt\\kunden.db";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Verbindung erfolgreich");
                string sql = "SELECT * FROM Kunden";
                SqliteCommand command = new SqliteCommand(sql, connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(
                    $"{reader["Id"]}: {reader["Name"]} ({reader["Alter"]} Jahre)"
                    );
                }
            }


            //Hauptmenue.Mainmenue();   
        }
    }
}
