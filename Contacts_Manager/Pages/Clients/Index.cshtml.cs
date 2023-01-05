using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Contacts_Manager.Pages.Clients
{
    public class IndexModel : PageModel
    {
        // lista do przechowywania danych z bazy
        public List<ClientInfo> listClients = new List<ClientInfo>();

        // klasa OnGet dzia³a przy wejœciu na stronie lub przy wykonaniu jakieœ akcji
        public void OnGet()
        {
            try
            {
                // string wymagany do po³¹czenia z serwerem i baza danych "w tym przykadku z lokana baza danych"
                String connectionString = "Data Source=DESKTOP-338U39J\\SQLEXPRESS;Initial Catalog=Contacts_Man;Integrated Security=True";

                using (SqlConnection connection= new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT * FROM clients";
                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // odczytanie zawartoœci z bazy danych
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClientInfo clientInfo = new ClientInfo();
                                clientInfo.id = "" + reader.GetInt32(0);
                                clientInfo.name = reader.GetString(1);
                                clientInfo.email = reader.GetString(2);
                                clientInfo.phone = reader.GetString(3);
                                clientInfo.address = reader.GetString(4);
                                clientInfo.created_at = reader.GetDateTime(5).ToString();

                                listClients.Add(clientInfo);
                            }
                        }
                    }
                }
               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:" + ex.ToString());
            }
        }
    }
    // klasa zawieraj¹ca typ danych zawartych w bazie 
    public class ClientInfo
    {
        public String id;
        public String name;
        public String email;
        public String phone;
        public String address;
        public String created_at;
    }
}
