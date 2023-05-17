using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //List<string> items = GetDataFromMySQL();
            Form1 form = new Form1();
            //form.SetcomboBox1Items(items);
            //form.comboBox1.SelectedItem = items;

            Application.Run(new Form1());
            /*static List<string> GetDataFromMySQL()
            {
                List<string> items = new List<string>();

                string connectionString = "your_connection_string"; // Zmień na właściwe dane połączenia
                string query = "SELECT column_name FROM table_name"; // Zmień na właściwe zapytanie SQL

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string item = reader.GetString(0); // Pobierz wartość z kolumny o indeksie 0 (lub użyj nazwy kolumny)
                                items.Add(item);
                            }
                        }
                    }
                }

                return items;

            }*/
        }
    }
}
