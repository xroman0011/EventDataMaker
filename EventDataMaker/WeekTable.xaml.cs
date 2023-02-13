using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for WeekTable.xaml
    /// </summary>
    public partial class WeekTable : Window
    {
        public WeekTable()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CrearOpciones crearOpciones = new CrearOpciones();
            crearOpciones.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string connetionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=BibliotecaDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
            var cnn = new SqlConnection(connetionString);

            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }
            try
            {

                string sqlString = $"INSERT INTO SemanaTable (TelefonoLunes, TelefonoMartes, TelefonoMiercoles, TelefonoJueves, TelefonoViernes, TelefonoSabado, EmailLunes, EmailMartes, EmailMiercoles, EmailJueves, EmailViernes, EmailSabado, CollaborateLunes, CollaborateMartes, CollaborateMiercoles, CollaborateJueves, CollaborateViernes, CollaborateSabado, PresencialLunes, PresencialMartes, PresencialMiercoles, PresencialJueves, PresencialViernes, PresencialSabado) VALUES ('{TelefonoLunes.Text}','{TelefonoMartes.Text}','{TelefonoMiercoles.Text}','{TelefonoJueves.Text}','{TelefonoViernes.Text}','{TelefonoSabado.Text}','{EmailLunes.Text}','{EmailMartes.Text}','{EmailMiercoles.Text}','{EmailJueves.Text}', '{EmailViernes.Text}', '{EmailSabado.Text}', '{CollaborateLunes.Text}', '{CollaborateMartes.Text}', '{CollaborateMiercoles.Text}','{CollaborateJueves.Text}', '{CollaborateViernes.Text}','{CollaborateSabado.Text}', '{PresencialLunes.Text}', '{PresencialMartes.Text}','{PresencialMiercoles.Text}','{PresencialJueves.Text}', '{PresencialViernes.Text}', '{PresencialSabado.Text}')";

                SqlCommand command = new SqlCommand(sqlString, cnn);

                var affectedRows = command.ExecuteNonQuery();

                cnn.Close();
                TelefonoLunes.Clear();
                TelefonoMartes.Clear();
                TelefonoMiercoles.Clear();
                TelefonoJueves.Clear();
                TelefonoViernes.Clear();
                TelefonoSabado.Clear();
                EmailLunes.Clear();
                EmailMartes.Clear();
                EmailMiercoles.Clear();
                EmailJueves.Clear();
                EmailViernes.Clear();
                EmailSabado.Clear();
                CollaborateLunes.Clear();
                CollaborateMartes.Clear();
                CollaborateMiercoles.Clear();
                CollaborateJueves.Clear();
                CollaborateViernes.Clear();
                CollaborateSabado.Clear();
                PresencialLunes.Clear();
                PresencialMartes.Clear();
                PresencialMiercoles.Clear();
                PresencialJueves.Clear();
                PresencialViernes.Clear();
                PresencialSabado.Clear();
                SelectedId.ItemsSource = null;
                if (affectedRows > 0)
                {
                    MessageBox.Show("Se guardo todo ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo connectar al base de datos ! ");
            }
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
                    TelefonoLunes.Text = reader["TelefonoLunes"].ToString();
                    TelefonoMartes.Text = reader["TelefonoMartes"].ToString();
                    TelefonoMiercoles.Text = reader["TelefonoMiercoles"].ToString();
                    TelefonoJueves.Text = reader["TelefonoJueves"].ToString();
                    TelefonoViernes.Text = reader["TelefonoViernes"].ToString();
                    TelefonoSabado.Text = reader["TelefonoSabado"].ToString();
                    EmailLunes.Text = reader["EmailLunes"].ToString();
                    EmailMartes.Text = reader["EmailMartes"].ToString();
                    EmailMiercoles.Text = reader["EmailMiercoles"].ToString();
                    EmailJueves.Text = reader["EmailJueves"].ToString();
                    EmailViernes.Text = reader["EmailViernes"].ToString();
                    EmailSabado.Text = reader["EmailSabado"].ToString();
                    CollaborateLunes.Text = reader["CollaborateLunes"].ToString();
                    CollaborateMartes.Text = reader["CollaborateMartes"].ToString();
                    CollaborateMiercoles.Text = reader["CollaborateMiercoles"].ToString();
                    CollaborateJueves.Text = reader["CollaborateJueves"].ToString();
                    CollaborateViernes.Text = reader["CollaborateViernes"].ToString();
                    CollaborateSabado.Text = reader["CollaborateSabado"].ToString();
                    PresencialLunes.Text = reader["PresencialLunes"].ToString();
                    PresencialMartes.Text = reader["PresencialMartes"].ToString();
                    PresencialMiercoles.Text = reader["PresencialMiercoles"].ToString();
                    PresencialJueves.Text = reader["PresencialJueves"].ToString();
                    PresencialViernes.Text = reader["PresencialViernes"].ToString();
                    PresencialSabado.Text = reader["PresencialSabado"].ToString();
                }
                reader.DisposeAsync();
                reader.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = DateRec1.SelectedDate;
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

                SqlCommand cmd = new SqlCommand("select Id from SemanaTable where DateRec between @DateRec1 and @DateRec2", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("DateRec1", date);
                cmd.Parameters.AddWithValue("DateRec2", date2);
                adapter.Fill(dt);
                SelectedId.ItemsSource = dt.DefaultView;
                SelectedId.DisplayMemberPath = dt.Columns["Id"].ToString();
                SelectedId.SelectedValuePath = dt.Columns["Id"].ToString();
                MessageBox.Show("Se encontro los IDs!");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (SelectedId.SelectedItem == null)
            {
                MessageBox.Show("Por favor escoge un ID!");
            }
            else
            {
                string connetionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=BibliotecaDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                var cnn = new SqlConnection(connetionString);

                if (cnn.State == System.Data.ConnectionState.Closed)
                {
                    cnn.Open();
                }

                string sqlString = $"UPDATE SemanaTable SET TelefonoLunes='" + this.TelefonoLunes.Text + "', TelefonoMartes='" + this.TelefonoMartes.Text + "', TelefonoMiercoles='" + this.TelefonoMiercoles.Text + "', TelefonoJueves='" + this.TelefonoJueves.Text + "', TelefonoViernes='" + this.TelefonoViernes.Text + "', TelefonoSabado='" + this.TelefonoSabado.Text + "', EmailLunes='" + this.EmailLunes.Text + "', EmailMartes='" + this.EmailMartes.Text + "', EmailMiercoles='" + this.EmailMiercoles.Text + "', EmailJueves='" + this.EmailJueves.Text + "', EmailViernes='" + this.EmailViernes.Text + "', EmailSabado='" + this.EmailSabado.Text + "', CollaborateLunes='" + this.CollaborateLunes.Text + "', CollaborateMartes='" + this.CollaborateMartes.Text + "', CollaborateMiercoles='" + this.CollaborateMiercoles.Text + "', CollaborateJueves='" + this.CollaborateJueves.Text + "', CollaborateViernes='" + this.CollaborateViernes.Text + "', CollaborateSabado='" + this.CollaborateSabado.Text + "', PresencialLunes='" + this.PresencialLunes.Text + "', PresencialMartes='" + this.PresencialMartes.Text + "', PresencialMiercoles='" + this.PresencialMiercoles.Text + "', PresencialJueves='" + this.PresencialJueves.Text + "', PresencialViernes='" + this.PresencialViernes.Text + "', PresencialSabado='" + this.PresencialSabado.Text + "' WHERE Id=@Id";

                SqlCommand command = new SqlCommand(sqlString, cnn);
                command.Parameters.AddWithValue("Id", SelectedId.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();
                reader.DisposeAsync();
                reader.Close();
                TelefonoLunes.Clear();
                TelefonoMartes.Clear();
                TelefonoMiercoles.Clear();
                TelefonoJueves.Clear();
                TelefonoViernes.Clear();
                TelefonoSabado.Clear();
                EmailLunes.Clear();
                EmailMartes.Clear();
                EmailMiercoles.Clear();
                EmailJueves.Clear();
                EmailViernes.Clear();
                EmailSabado.Clear();
                CollaborateLunes.Clear();
                CollaborateMartes.Clear();
                CollaborateMiercoles.Clear();
                CollaborateJueves.Clear();
                CollaborateViernes.Clear();
                CollaborateSabado.Clear();
                PresencialLunes.Clear();
                PresencialMartes.Clear();
                PresencialMiercoles.Clear();
                PresencialJueves.Clear();
                PresencialViernes.Clear();
                PresencialSabado.Clear();
                SelectedId.ItemsSource = null;
                var affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Se guardo todo ! ");
                }
            }
            SelectedId.ItemsSource = null;
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