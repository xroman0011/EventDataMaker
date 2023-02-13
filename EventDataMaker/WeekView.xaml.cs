using CsvHelper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EventDataMaker
{
    /// <summary>
    /// Interaction logic for WeekView.xaml
    /// </summary>
    public partial class WeekView : Window
    {
        public WeekView()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var weekData = new List<WeekData>()
            {
                new WeekData
                {
                    Dia = "Lunes",
                    Telefono = TelefonoLunes.Content.ToString(),
                    Email = EmailLunes.Content.ToString(),
                    Collaborate = CollaborateLunes.Content.ToString(),
                    Presencial = PresencialLunes.Content.ToString()
                },
                new WeekData
                {
                    Dia = "Martes",
                    Telefono = TelefonoMartes.Content.ToString(),
                    Email = EmailMartes.Content.ToString(),
                    Collaborate = CollaborateMartes.Content.ToString(),
                    Presencial = PresencialMartes.Content.ToString()
                },
                new WeekData
                {
                    Dia = "Miercoles",
                    Telefono = TelefonoMiercoles.Content.ToString(),
                    Email = EmailMiercoles.Content.ToString(),
                    Collaborate = CollaborateMiercoles.Content.ToString(),
                    Presencial = PresencialMiercoles.Content.ToString()
                },
                new WeekData
                {
                    Dia = "Jueves",
                    Telefono = TelefonoJueves.Content.ToString(),
                    Email = EmailJueves.Content.ToString(),
                    Collaborate = CollaborateJueves.Content.ToString(),
                    Presencial = PresencialJueves.Content.ToString()
                },
                new WeekData
                {
                    Dia = "Viernes",
                    Telefono = TelefonoViernes.Content.ToString(),
                    Email = EmailViernes.Content.ToString(),
                    Collaborate = CollaborateViernes.Content.ToString(),
                    Presencial = PresencialViernes.Content.ToString()
                },
                new WeekData
                {
                    Dia = "Sabado",
                    Telefono = TelefonoSabado.Content.ToString(),
                    Email = EmailSabado.Content.ToString(),
                    Collaborate = CollaborateSabado.Content.ToString(),
                    Presencial = PresencialSabado.Content.ToString()
                },
            };

            try
            {
                using (var writer = new StreamWriter(@"C:\Users\lcolon\Desktop\semanadata.csv", false, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(weekData);
                }
                SelectedId.ItemsSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong " + ex.Message);

                return;
            }
            MessageBox.Show("File semanadata.csv has been downloaded in the Desktop");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedId.ItemsSource == null)
            {
                return;
            }
            else
            {
                string connetionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=BibliotecaDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                var cnn = new SqlConnection(connetionString);

                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }

                string sqlString = $"SELECT TelefonoLunes, TelefonoMartes, TelefonoMiercoles, TelefonoJueves, TelefonoViernes, TelefonoSabado, EmailLunes, EmailMartes, EmailMiercoles, EmailJueves, EmailViernes, EmailSabado, CollaborateLunes, CollaborateMartes, CollaborateMiercoles, CollaborateJueves, CollaborateViernes, CollaborateSabado, PresencialLunes, PresencialMartes, PresencialMiercoles, PresencialJueves, PresencialViernes, PresencialSabado FROM SemanaTable WHERE Id=@Id";

                SqlCommand command = new SqlCommand(sqlString, cnn);
                command.Parameters.AddWithValue("Id", SelectedId.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TelefonoLunes.Content = reader["TelefonoLunes"].ToString();
                    TelefonoMartes.Content = reader["TelefonoMartes"].ToString();
                    TelefonoMiercoles.Content = reader["TelefonoMiercoles"].ToString();
                    TelefonoJueves.Content = reader["TelefonoJueves"].ToString();
                    TelefonoViernes.Content = reader["TelefonoViernes"].ToString();
                    TelefonoSabado.Content = reader["TelefonoSabado"].ToString();
                    EmailLunes.Content = reader["EmailLunes"].ToString();
                    EmailMartes.Content = reader["EmailMartes"].ToString();
                    EmailMiercoles.Content = reader["EmailMiercoles"].ToString();
                    EmailJueves.Content = reader["EmailJueves"].ToString();
                    EmailViernes.Content = reader["EmailViernes"].ToString();
                    EmailSabado.Content = reader["EmailSabado"].ToString();
                    CollaborateLunes.Content = reader["CollaborateLunes"].ToString();
                    CollaborateMartes.Content = reader["CollaborateMartes"].ToString();
                    CollaborateMiercoles.Content = reader["CollaborateMiercoles"].ToString();
                    CollaborateJueves.Content = reader["CollaborateJueves"].ToString();
                    CollaborateViernes.Content = reader["CollaborateViernes"].ToString();
                    CollaborateSabado.Content = reader["CollaborateSabado"].ToString();
                    PresencialLunes.Content = reader["PresencialLunes"].ToString();
                    PresencialMartes.Content = reader["PresencialMartes"].ToString();
                    PresencialMiercoles.Content = reader["PresencialMiercoles"].ToString();
                    PresencialJueves.Content = reader["PresencialJueves"].ToString();
                    PresencialViernes.Content = reader["PresencialViernes"].ToString();
                    PresencialSabado.Content = reader["PresencialSabado"].ToString();
                }
                reader.DisposeAsync();
                reader.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BuscarOpciones fmain = new BuscarOpciones();
            fmain.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime? date = DateRec.SelectedDate;
            DateTime? date2 = DateRec2.SelectedDate;

            if (date == null || date2 == null)
            {
                MessageBox.Show("Por favor escoge una fecha!");
            }
            else
            {
                string connetionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=BibliotecaDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                var con = new SqlConnection(connetionString);

                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("select Id from SemanaTable where DateRec between @DateRec and @DateRec2", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("DateRec", date);
                cmd.Parameters.AddWithValue("DateRec2", date2);
                adapter.Fill(dt);
                SelectedId.ItemsSource = dt.DefaultView;
                SelectedId.DisplayMemberPath = dt.Columns["Id"].ToString();
                SelectedId.SelectedValuePath = dt.Columns["Id"].ToString();
                MessageBox.Show("Se encontro los IDs!");
            }
        }

        private void FirstDatePicker(object sender, SelectionChangedEventArgs e)
        {
            SelectedId.ItemsSource = null;
        }

        private void SecondDatePicker(object sender, SelectionChangedEventArgs e)
        {
            SelectedId.ItemsSource = null;
        }
    }
}
