using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        MySqlConnection connection;
        public ComboBox ComboBox1 { get; private set; }
        private string EAJ;

        public Form1()
        {
            InitializeComponent();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            // Dodaj kontrolkę TextBox do formularza
            string connectionString = "Server=192.168.230.170;port=3306;username=user;password=mati;database=tcon"; // Zmień na właściwe dane połączenia
            connection = new MySqlConnection(connectionString);
            EAJ = "";

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // Ustawienia parametrów połączenia
            serialPort.PortName = "COM8";
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;

            // Pobierz dane z bazy danych i ustaw je w comboBox1.Items
            LoadDataFromMySQL();

        }

        private void LoadDataFromMySQL()
        {
            try
            {
                connection.Open();

                string query = "SELECT HS_PN FROM common_all"; // Zmień na właściwe zapytanie SQL
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string item = reader.GetString(0); // Pobierz wartość z kolumny o indeksie 0 (lub użyj nazwy kolumny)
                    comboBox1.Items.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // Odczytanie danych z portu i wyświetlenie ich w polu tekstowym
            string data = serialPort.ReadExisting();
            string temp_data = "";
            string LGEPN = "";


            textBox2.Invoke(new Action(() =>
            {
                textBox2.Text = "";
                textBox2.AppendText(data);
                temp_data = data;
                LGEPN = data.Substring(9, 8);
                LGEPN = "EAJ" + LGEPN;
            }));

            InfoLabel.Invoke(new Action(() =>
            {
                if (EAJ == LGEPN)
                {
                    InfoLabel.Text = "MODEL IS CORRECT";
                    InfoLabel.ForeColor = Color.Yellow;
                    label2.Text = "OK";
                    label2.ForeColor = Color.FromArgb(51, 255, 51);
                }
                else
                {
                    InfoLabel.Text = "NG: TAKE OUT MODULE FROM LINE";
                    InfoLabel.ForeColor = Color.Red;
                    label2.Text = "NG";
                    label2.ForeColor = Color.Red;



                    //label2.ForeColor = Color.Red;

                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = "alarm.wav"; // Ścieżka do pliku dźwiękowego alarm.wav
                    player.Play();
                }
            }));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                textBox1.AppendText("Connected" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                textBox1.AppendText("Disconnected" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                textBox1.AppendText("Connected" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                textBox1.AppendText("Disconnected" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SizeChanged(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                tabPage.Size = tabControl1.ClientSize; // Ustaw rozmiar TabPage na rozmiar TabControl
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string ComboStringPN = comboBox1.SelectedItem.ToString();

                try
                {
                    connection.Open();

                    string query = $"SELECT * FROM `common_all` WHERE `HS_PN` LIKE '%{ComboStringPN}'"; // Zmień na właściwe zapytanie SQL
                                                                                                        //string query = "SELECT ColumnName FROM TableName WHERE ColumnName LIKE @searchString";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string HSPN = reader.GetString(2); // Pobierz wartość z kolumny o indeksie 0 (lub użyj nazwy kolumny)
                                                           //comboBox1.Items.Add(item);
                        testbox.Text = HSPN;
                        string MODEL = reader.GetString(3);
                        ModelBox.Text = MODEL;
                        EAJ = reader.GetString(1);
                        LgepnBox.Text = EAJ;
                        
                        ///!!!!! Program nie wie z jakiego textboxa ma probać informację. 
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }
        }
        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar))
            {
                string searchString = ComboBox1.Text + e.KeyChar; // Pobierz aktualną wartość ComboBox1 i dodaj wprowadzony przez użytkownika znak

                int index = ComboBox1.FindString(searchString); // Znajdź indeks elementu, który pasuje do wyszukiwanej wartości

                if (index >= 0)
                {
                    ComboBox1.SelectedIndex = index; // Ustaw zaznaczony element na znaleziony indeks
                }
                else
                {
                    ComboBox1.SelectedIndex = -1; // Wybierz żaden element, jeśli nie znaleziono pasujących wartości
                }
            }
            // e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = $"SELECT * FROM `common_all` WHERE `HS_PN` LIKE '%{textBox3.Text}'"; // Zmień na właściwe zapytanie SQL
                //string query = "SELECT ColumnName FROM TableName WHERE ColumnName LIKE @searchString";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string HSPN = reader.GetString(2); // Pobierz wartość z kolumny o indeksie 0 (lub użyj nazwy kolumny)
                    //comboBox1.Items.Add(item);
                    testbox.Text = HSPN;
                    string MODEL = reader.GetString(3);
                    ModelBox.Text = MODEL;
                    EAJ = reader.GetString(1);
                    LgepnBox.Text = EAJ;

                    ///!!!!! Program nie wie z jakiego textboxa ma probać informację. 
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LgepnBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


