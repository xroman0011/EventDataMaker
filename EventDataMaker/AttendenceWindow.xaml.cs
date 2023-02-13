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
    /// Interaction logic for AttendenceWindow.xaml
    /// </summary>
    public partial class AttendenceWindow : Window
    {
        public AttendenceWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connetionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=BibliotecaDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
            var cnn = new SqlConnection(connetionString);

            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.Open();
            }
            string sqlString = $"INSERT INTO Attendencetable (ProntuariosCotejosMes, ProntuariosCotejosAcumulado, FacultadMes, FacultadAcumulado, AdministracionMes, AdministracionAcumulado, EstudiantesMes, EstudiantesAcumulado, ComunidadMes, ComunidadAcumulado, TitulosMes, TitulosAcumulado, VolumenesMes, VolumenesAcumulado, TitulosMes2, TitulosAcumulado2, VolumenesMes2, VolumenesAcumulado2, TitulosMes3, TitulosAcumulado3, VolumenesMes3, VolumenesAcumulado3, TitulosMes4, TitulosAcumulado4, VolumenesMes4, VolumenesAcumulado4, TitulosMes5, TitulosAcumulado5, VolumenesMes5, VolumenesAcumulado5, OtrosAcumulado, AdquiridosMes, AdquiridosAcumulado, EvaluadosMes, EvaluadosAcumulado, PaginaMes, PaginaAcumulado, IndizacionMes, IndizacionAcumulado, DigitalizadosMes, DigitalizadosAcumulado, ReparadosMes, ReparadosAcumulado, ProducidosMes, ProducidosAcumulado, TalleresEstudiantesMes, TalleresEstudiantesAcumulado, ParticipantesMes, ParticipantesAcumulado, TalleresFacultadMes, TalleresFacultadAcumulado, ParticipantesMes2, ParticipantesAcumulado2, TalleresAdministracionAcumulado, ParticipantesMes3, ParticipantesAcumulado3, recursosMes, recursosAcumulado, FacultadMes2, FacultadAcumulado2, AdministracionMes2, AdministracionAcumulado2, SalasGrupalMes, SalasGrupalAcumulado, SalasProyeccionesMes, SalasProyeccionesAcumulado, PrestadosMes, PrestadosAcumulado, SolicitadosMes, SolicitadosAcumulado, AsistenciaMes, AsistenciaAcumulado, HorasServicioMes, HorasServicioAcumulado, PromediosMes, PromediosAcumulado, ExposicionesMes, ExposicionesAcumulado, ExhibicionesMes, ExhibicionesAcumulado, OtrasMes, OtrasAcumulado, PublicacionesNuevasMes, PublicacionesNuevasAcumulado, PublicacionesDistribuidasMes, PublicacionesDistribuidasAcumulado, PrestamosExternaAcumulado, TalleresOfrecidosMes, TalleresOfrecidosAcumulado, DesarolloPersonalAcumulado, AnadidoMes, AnadidoAcumulado, DecomisadoMes, DecomisadoAcumulado, EncuadernacionesAcumulado, TotalParticipantesMes, TotalParticipantesAcumulado, TalleresAdministracionMes, EstudiantesMes2, EstudiantesAcumulado2) VALUES ('{ProntuariosCotejosMes.Text}','{ProntuariosCotejosAcumulado.Text}','{FacultadMes.Text}','{FacultadAcumulado.Text}','{AdministracionMes.Text}','{AdministracionAcumulado.Text}','{EstudiantesMes.Text}','{EstudiantesAcumulado.Text}','{ComunidadMes.Text}','{ComunidadAcumulado.Text}', '{TitulosMes.Text}', '{TitulosAcumulado.Text}', '{VolumenesMes.Text}', '{VolumenesAcumulado.Text}', '{TitulosMes2.Text}','{TitulosAcumulado2.Text}', '{VolumenesMes2.Text}','{VolumenesAcumulado2.Text}', '{TitulosMes3.Text}', '{TitulosAcumulado3.Text}','{VolumenesMes3.Text}','{VolumenesAcumulado3.Text}', '{TitulosMes4.Text}', '{TitulosAcumulado4.Text}','{VolumenesMes4.Text}', '{VolumenesAcumulado4.Text}', '{TitulosMes5.Text}', '{TitulosAcumulado5.Text}', '{VolumenesMes5.Text}', '{VolumenesAcumulado5.Text}', '{OtrosAcumulado.Text}','{AdquiridosMes.Text}', '{AdquiridosAcumulado.Text}', '{EvaluadosMes.Text}','{EvaluadosAcumulado.Text}','{PaginaMes.Text}', '{PaginaAcumulado.Text}','{IndizacionMes.Text}','{IndizacionAcumulado.Text}','{DigitalizadosMes.Text}','{DigitalizadosAcumulado.Text}','{ReparadosMes.Text}','{ReparadosAcumulado.Text}','{ProducidosMes.Text}','{ProducidosAcumulado.Text}','{TalleresEstudiantesMes.Text}','{TalleresEstudiantesAcumulado.Text}','{ParticipantesMes.Text}','{ParticipantesAcumulado.Text}','{TalleresFacultadMes.Text}','{TalleresFacultadAcumulado.Text}','{ParticipantesMes2.Text}','{ParticipantesAcumulado2.Text}','{TalleresAdministracionAcumulado.Text}','{ParticipantesMes3.Text}','{ParticipantesAcumulado3.Text}','{recursosMes.Text}','{recursosAcumulado.Text}','{FacultadMes2.Text}','{FacultadAcumulado2.Text}','{AdministracionMes2.Text}','{AdministracionAcumulado2.Text}','{SalasGrupalMes.Text}','{SalasGrupalAcumulado.Text}','{SalasProyeccionesMes.Text}','{SalasProyeccionesAcumulado.Text}','{PrestadosMes.Text}','{PrestadosAcumulado.Text}','{SolicitadosMes.Text}','{SolicitadosAcumulado.Text}','{AsistenciaMes.Text}','{AsistenciaAcumulado.Text}','{HorasServicioMes.Text}','{HorasServicioAcumulado.Text}','{PromediosMes.Text}','{PromediosAcumulado.Text}','{ExposicionesMes.Text}','{ExposicionesAcumulado.Text}','{ExhibicionesMes.Text}','{ExhibicionesAcumulado.Text}','{OtrasMes.Text}','{OtrasAcumulado.Text}','{PublicacionesNuevasMes.Text}','{PublicacionesNuevasAcumulado.Text}','{PublicacionesDistribuidasMes.Text}','{PublicacionesDistribuidasAcumulado.Text}','{PrestamosExternaAcumulado.Text}','{TalleresOfrecidosMes.Text}','{TalleresOfrecidosAcumulado.Text}','{DesarolloAcumulado.Text}','{AnadidoMes.Text}','{AnadidoAcumulado.Text}','{DecomisadoMes.Text}', '{DecomisadoAcumulado.Text}', '{EncuadernacionesAcumulado.Text}', '{TotalParticipantesMes.Text}', '{TotalParticipantesAcumulado.Text}', '{TalleresAdministracionMes.Text}', '{EstudiantesMes2.Text}', '{EstudiantesAcumulado2.Text}')";

            SqlCommand command = new SqlCommand(sqlString, cnn);

            var affectedRows = command.ExecuteNonQuery();

            cnn.Close();

            if (affectedRows > 0)
            {
                MessageBox.Show("Se guardo todo ! ");
                ProntuariosCotejosMes.Clear();
                ProntuariosCotejosAcumulado.Clear();
                FacultadMes.Clear();
                FacultadAcumulado.Clear();
                AdministracionMes.Clear();
                AdministracionAcumulado.Clear();
                EstudiantesMes.Clear();
                EstudiantesAcumulado.Clear();
                ComunidadMes.Clear();
                ComunidadAcumulado.Clear();
                TitulosMes.Clear();
                TitulosAcumulado.Clear();
                VolumenesMes.Clear();
                VolumenesAcumulado.Clear();
                TitulosMes2.Clear();
                TitulosAcumulado2.Clear();
                VolumenesMes2.Clear();
                VolumenesAcumulado2.Clear();
                TitulosMes3.Clear();
                TitulosAcumulado3.Clear();
                VolumenesMes3.Clear();
                VolumenesAcumulado3.Clear();
                TitulosMes4.Clear();
                TitulosAcumulado4.Clear();
                VolumenesMes4.Clear();
                VolumenesAcumulado4.Clear();
                EncuadernacionesAcumulado.Clear();
                TitulosMes5.Clear();
                TitulosAcumulado5.Clear();
                VolumenesMes5.Clear();
                VolumenesAcumulado5.Clear();
                AdquiridosMes.Clear();
                AdquiridosAcumulado.Clear();
                EvaluadosMes.Clear();
                EvaluadosAcumulado.Clear();
                PaginaMes.Clear();
                PaginaAcumulado.Clear();
                IndizacionMes.Clear();
                IndizacionAcumulado.Clear();
                DigitalizadosMes.Clear();
                DigitalizadosAcumulado.Clear();
                ReparadosMes.Clear();
                ReparadosAcumulado.Clear();
                ProducidosMes.Clear();
                ProducidosAcumulado.Clear();
                TalleresEstudiantesMes.Clear();
                TalleresEstudiantesAcumulado.Clear();
                ParticipantesMes.Clear();
                ParticipantesAcumulado.Clear();
                TalleresFacultadMes.Clear();
                TalleresFacultadAcumulado.Clear();
                ParticipantesMes2.Clear();
                ParticipantesAcumulado2.Clear();
                TalleresAdministracionMes.Clear();
                TalleresAdministracionAcumulado.Clear();
                recursosMes.Clear();
                recursosAcumulado.Clear();
                FacultadMes2.Clear();
                FacultadAcumulado2.Clear();
                AdministracionMes2.Clear();
                AdministracionAcumulado2.Clear();
                SalasGrupalMes.Clear();
                SalasGrupalAcumulado.Clear();
                SalasProyeccionesMes.Clear();
                SalasProyeccionesAcumulado.Clear();
                PrestadosMes.Clear();
                PrestadosAcumulado.Clear();
                SolicitadosMes.Clear();
                SolicitadosAcumulado.Clear();
                AsistenciaMes.Clear();
                AsistenciaAcumulado.Clear();
                HorasServicioMes.Clear();
                HorasServicioAcumulado.Clear();
                PromediosMes.Clear();
                PromediosAcumulado.Clear();
                ExposicionesMes.Clear();
                ExposicionesAcumulado.Clear();
                ExhibicionesMes.Clear();
                ExhibicionesAcumulado.Clear();
                OtrasMes.Clear();
                OtrasAcumulado.Clear();
                PublicacionesNuevasMes.Clear();
                PublicacionesNuevasAcumulado.Clear();
                PublicacionesDistribuidasMes.Clear();
                PublicacionesDistribuidasAcumulado.Clear();
                PrestamosExternaAcumulado.Clear();
                TalleresOfrecidosMes.Clear();
                TalleresOfrecidosAcumulado.Clear();
                TotalParticipantesMes.Clear();
                TotalParticipantesAcumulado.Clear();
                DesarolloAcumulado.Clear();
                AnadidoMes.Clear();
                AnadidoAcumulado.Clear();
                DecomisadoMes.Clear();
                DecomisadoAcumulado.Clear();
                TotalParticipantesMes.Clear();
                TotalParticipantesAcumulado.Clear();
                EstudiantesMes2.Clear();
                EstudiantesAcumulado2.Clear();
                OtrosAcumulado.Clear();
                ParticipantesMes3.Clear();
                ParticipantesAcumulado3.Clear();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
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

                SqlCommand cmd = new SqlCommand("select EntryNr from AttendenceTable where DateRec between @DateRec1 and @DateRec2", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("DateRec1", date);
                cmd.Parameters.AddWithValue("DateRec2", date2);
                adapter.Fill(dt);
                SelectedEntryNr.ItemsSource = dt.DefaultView;
                SelectedEntryNr.DisplayMemberPath = dt.Columns["EntryNr"].ToString();
                SelectedEntryNr.SelectedValuePath = dt.Columns["EntryNr"].ToString();
                MessageBox.Show("Se encontro los EntryNr");
            }
        }

        private void SelectedEntryNr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedEntryNr.ItemsSource == null)
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

                string sqlString = $"SELECT ProntuariosCotejosMes, ProntuariosCotejosAcumulado, FacultadMes, FacultadAcumulado, AdministracionMes, AdministracionAcumulado, EstudiantesMes, EstudiantesAcumulado, ComunidadMes, ComunidadAcumulado, TitulosMes, TitulosAcumulado, VolumenesMes, VolumenesAcumulado, TitulosMes2, TitulosAcumulado2, VolumenesMes2, VolumenesAcumulado2, TitulosMes3, TitulosAcumulado3, VolumenesMes3, VolumenesAcumulado3, TitulosMes4, TitulosAcumulado4, VolumenesMes4, VolumenesAcumulado4, TitulosMes5, TitulosAcumulado5, VolumenesMes5, VolumenesAcumulado5, OtrosMes, OtrosAcumulado, AdquiridosMes, AdquiridosAcumulado, EvaluadosMes, EvaluadosAcumulado, PaginaMes, PaginaAcumulado, IndizacionMes, IndizacionAcumulado, DigitalizadosMes, DigitalizadosAcumulado, ReparadosMes, ReparadosAcumulado, ProducidosMes, ProducidosAcumulado, TalleresEstudiantesMes, TalleresEstudiantesAcumulado, ParticipantesMes, ParticipantesAcumulado, TalleresFacultadMes, TalleresFacultadAcumulado, ParticipantesMes2, ParticipantesAcumulado2, TalleresAdministracionMes, TalleresAdministracionAcumulado, ParticipantesMes3, ParticipantesAcumulado3, recursosMes, recursosAcumulado, FacultadMes2, FacultadAcumulado2, AdministracionMes2, AdministracionAcumulado2, SalasGrupalMes, SalasGrupalAcumulado, SalasProyeccionesMes, SalasProyeccionesAcumulado, PrestadosMes, PrestadosAcumulado, SolicitadosMes, SolicitadosAcumulado, AsistenciaMes, AsistenciaAcumulado, HorasServicioMes, HorasServicioAcumulado, PromediosMes, PromediosAcumulado, ExposicionesMes, ExposicionesAcumulado, ExhibicionesMes, ExhibicionesAcumulado, OtrasMes, OtrasAcumulado, PublicacionesNuevasMes, PublicacionesNuevasAcumulado, PublicacionesDistribuidasMes, PublicacionesDistribuidasAcumulado, PrestamosExternaMes, PrestamosExternaAcumulado, TalleresOfrecidosMes, TalleresOfrecidosAcumulado, DesarolloPersonalMes, DesarolloPersonalAcumulado, AnadidoMes, AnadidoAcumulado, DecomisadoMes, DecomisadoAcumulado, EncuadernacionesAcumulado, TotalParticipantesMes, TotalParticipantesAcumulado, EstudiantesMes2, EstudiantesAcumulado2 FROM AttendenceTable WHERE EntryNr=@EntryNr";

                SqlCommand command = new SqlCommand(sqlString, cnn);
                command.Parameters.AddWithValue("EntryNr", SelectedEntryNr.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProntuariosCotejosMes.Text = reader["ProntuariosCotejosMes"].ToString();
                    ProntuariosCotejosAcumulado.Text = reader["ProntuariosCotejosAcumulado"].ToString();
                    FacultadMes.Text = reader["FacultadMes"].ToString();
                    FacultadAcumulado.Text = reader["FacultadAcumulado"].ToString();
                    AdministracionMes.Text = reader["AdministracionMes"].ToString();
                    AdministracionAcumulado.Text = reader["AdministracionAcumulado"].ToString();
                    EstudiantesMes.Text = reader["EstudiantesMes"].ToString();
                    EstudiantesAcumulado.Text = reader["EstudiantesAcumulado"].ToString();
                    ComunidadMes.Text = reader["ComunidadMes"].ToString();
                    ComunidadAcumulado.Text = reader["ComunidadAcumulado"].ToString();
                    TitulosMes.Text = reader["TitulosMes"].ToString();
                    TitulosAcumulado.Text = reader["TitulosAcumulado"].ToString();
                    VolumenesMes.Text = reader["VolumenesMes"].ToString();
                    VolumenesAcumulado.Text = reader["VolumenesAcumulado"].ToString();
                    TitulosMes2.Text = reader["TitulosMes2"].ToString();
                    TitulosAcumulado2.Text = reader["TitulosAcumulado2"].ToString();
                    VolumenesMes2.Text = reader["VolumenesMes2"].ToString();
                    VolumenesAcumulado2.Text = reader["VolumenesAcumulado2"].ToString();
                    TitulosMes3.Text = reader["TitulosMes3"].ToString();
                    TitulosAcumulado3.Text = reader["TitulosAcumulado3"].ToString();
                    VolumenesMes3.Text = reader["VolumenesMes3"].ToString();
                    VolumenesAcumulado3.Text = reader["VolumenesAcumulado3"].ToString();
                    TitulosMes4.Text = reader["TitulosMes4"].ToString();
                    TitulosAcumulado4.Text = reader["TitulosAcumulado4"].ToString();
                    VolumenesMes4.Text = reader["VolumenesMes4"].ToString();
                    VolumenesAcumulado4.Text = reader["VolumenesAcumulado4"].ToString();
                    EncuadernacionesAcumulado.Text = reader["EncuadernacionesAcumulado"].ToString();
                    TitulosMes5.Text = reader["TitulosMes5"].ToString();
                    TitulosAcumulado5.Text = reader["TitulosAcumulado5"].ToString();
                    VolumenesMes5.Text = reader["VolumenesMes5"].ToString();
                    VolumenesAcumulado5.Text = reader["VolumenesAcumulado5"].ToString();
                    OtrosAcumulado.Text = reader["OtrosAcumulado"].ToString();
                    AdquiridosMes.Text = reader["AdquiridosMes"].ToString();
                    AdquiridosAcumulado.Text = reader["AdquiridosAcumulado"].ToString();
                    EvaluadosMes.Text = reader["EvaluadosMes"].ToString();
                    EvaluadosAcumulado.Text = reader["EvaluadosAcumulado"].ToString();
                    PaginaMes.Text = reader["PaginaMes"].ToString();
                    PaginaAcumulado.Text = reader["PaginaAcumulado"].ToString();
                    IndizacionMes.Text = reader["IndizacionMes"].ToString();
                    IndizacionAcumulado.Text = reader["IndizacionAcumulado"].ToString();
                    DigitalizadosMes.Text = reader["DigitalizadosMes"].ToString();
                    DigitalizadosAcumulado.Text = reader["DigitalizadosAcumulado"].ToString();
                    ReparadosMes.Text = reader["ReparadosMes"].ToString();
                    ReparadosAcumulado.Text = reader["ReparadosAcumulado"].ToString();
                    ProducidosMes.Text = reader["ProducidosMes"].ToString();
                    ProducidosAcumulado.Text = reader["ProducidosAcumulado"].ToString();
                    TalleresEstudiantesMes.Text = reader["TalleresEstudiantesMes"].ToString();
                    TalleresEstudiantesAcumulado.Text = reader["TalleresEstudiantesAcumulado"].ToString();
                    ParticipantesMes.Text = reader["ParticipantesMes"].ToString();
                    ParticipantesAcumulado.Text = reader["ParticipantesAcumulado"].ToString();
                    TalleresFacultadMes.Text = reader["TalleresFacultadMes"].ToString();
                    TalleresFacultadAcumulado.Text = reader["TalleresFacultadAcumulado"].ToString();
                    ParticipantesMes2.Text = reader["ParticipantesMes2"].ToString();
                    ParticipantesAcumulado2.Text = reader["ParticipantesAcumulado2"].ToString();
                    TalleresAdministracionMes.Text = reader["TalleresAdministracionMes"].ToString();
                    TalleresAdministracionAcumulado.Text = reader["TalleresAdministracionAcumulado"].ToString();
                    ParticipantesMes3.Text = reader["ParticipantesMes3"].ToString();
                    ParticipantesAcumulado3.Text = reader["ParticipantesAcumulado3"].ToString();
                    recursosMes.Text = reader["recursosMes"].ToString();
                    recursosAcumulado.Text = reader["recursosAcumulado"].ToString();
                    EstudiantesMes2.Text = reader["EstudiantesMes2"].ToString();
                    EstudiantesAcumulado2.Text = reader["EstudiantesAcumulado2"].ToString();
                    FacultadMes2.Text = reader["FacultadMes2"].ToString();
                    FacultadAcumulado2.Text = reader["FacultadAcumulado2"].ToString();
                    AdministracionMes2.Text = reader["AdministracionMes2"].ToString();
                    AdministracionAcumulado2.Text = reader["AdministracionAcumulado2"].ToString();
                    SalasGrupalMes.Text = reader["SalasGrupalMes"].ToString();
                    SalasGrupalAcumulado.Text = reader["SalasGrupalAcumulado"].ToString();
                    SalasProyeccionesMes.Text = reader["SalasProyeccionesMes"].ToString();
                    SalasProyeccionesAcumulado.Text = reader["SalasProyeccionesAcumulado"].ToString();
                    PrestadosMes.Text = reader["PrestadosMes"].ToString();
                    PrestadosAcumulado.Text = reader["PrestadosAcumulado"].ToString();
                    SolicitadosMes.Text = reader["SolicitadosMes"].ToString();
                    SolicitadosAcumulado.Text = reader["SolicitadosAcumulado"].ToString();
                    AsistenciaMes.Text = reader["AsistenciaMes"].ToString();
                    AsistenciaAcumulado.Text = reader["AsistenciaAcumulado"].ToString();
                    HorasServicioMes.Text = reader["HorasServicioMes"].ToString();
                    HorasServicioAcumulado.Text = reader["HorasServicioAcumulado"].ToString();
                    PromediosMes.Text = reader["PromediosMes"].ToString();
                    PromediosAcumulado.Text = reader["PromediosAcumulado"].ToString();
                    ExposicionesMes.Text = reader["ExposicionesMes"].ToString();
                    ExposicionesAcumulado.Text = reader["ExposicionesAcumulado"].ToString();
                    OtrasMes.Text = reader["OtrasMes"].ToString();
                    OtrasAcumulado.Text = reader["OtrasAcumulado"].ToString();
                    PublicacionesNuevasMes.Text = reader["PublicacionesNuevasMes"].ToString();
                    PublicacionesNuevasAcumulado.Text = reader["PublicacionesNuevasAcumulado"].ToString();
                    PublicacionesDistribuidasMes.Text = reader["PublicacionesDistribuidasMes"].ToString();
                    PublicacionesDistribuidasAcumulado.Text = reader["PublicacionesDistribuidasAcumulado"].ToString();
                    PrestamosExternaAcumulado.Text = reader["PrestamosExternaAcumulado"].ToString();
                    TalleresOfrecidosMes.Text = reader["TalleresOfrecidosMes"].ToString();
                    TalleresOfrecidosAcumulado.Text = reader["TalleresOfrecidosAcumulado"].ToString();
                    DesarolloAcumulado.Text = reader["DesarolloPersonalMes"].ToString();
                    AnadidoMes.Text = reader["AnadidoMes"].ToString();
                    AnadidoAcumulado.Text = reader["AnadidoAcumulado"].ToString();
                    DecomisadoMes.Text = reader["DecomisadoMes"].ToString();
                    DecomisadoAcumulado.Text = reader["DecomisadoAcumulado"].ToString();
                    TotalParticipantesMes.Text = reader["TotalParticipantesMes"].ToString();
                    TotalParticipantesAcumulado.Text = reader["TotalParticipantesAcumulado"].ToString();
                    ExhibicionesMes.Text = reader["ExhibicionesMes"].ToString();
                    ExhibicionesAcumulado.Text = reader["ExhibicionesAcumulado"].ToString();

                }
                reader.DisposeAsync();
                reader.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            CrearOpciones crearOpciones = new CrearOpciones();
            crearOpciones.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (SelectedEntryNr.SelectedItem == null)
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

                string sqlString = $"UPDATE AttendenceTable SET ProntuariosCotejosMes='" + this.ProntuariosCotejosMes.Text + "', ProntuariosCotejosAcumulado='" + this.ProntuariosCotejosAcumulado.Text + "', FacultadMes='" + this.FacultadMes.Text + "', FacultadAcumulado='" + this.FacultadAcumulado.Text + "', AdministracionMes='" + this.AdministracionMes.Text + "', AdministracionAcumulado='" + this.AdministracionAcumulado.Text + "', EstudiantesMes='" + this.EstudiantesMes.Text + "', EstudiantesAcumulado='" + this.EstudiantesAcumulado.Text + "', ComunidadMes='" + this.ComunidadMes.Text + "', ComunidadAcumulado='" + this.ComunidadAcumulado.Text + "', TitulosMes='" + this.TitulosMes.Text + "', TitulosAcumulado='" + this.TitulosAcumulado.Text + "', VolumenesMes='" + this.VolumenesMes.Text + "', VolumenesAcumulado='" + this.VolumenesAcumulado.Text + "', TitulosMes2='" + this.TitulosMes2.Text + "', TitulosAcumulado2='" + this.TitulosAcumulado2.Text + "', VolumenesMes2='" + this.VolumenesMes2.Text + "', VolumenesAcumulado2='" + this.VolumenesAcumulado2.Text + "', TitulosMes3='" + this.TitulosMes3.Text + "', TitulosAcumulado3='" + this.TitulosAcumulado3.Text + "', VolumenesMes3='" + this.VolumenesMes3.Text + "', VolumenesAcumulado3='" + this.VolumenesAcumulado3.Text + "', TitulosMes4='" + this.TitulosMes4.Text + "', TitulosAcumulado4='" + this.TitulosAcumulado4.Text + "', VolumenesMes4='" + this.VolumenesMes4.Text + "', VolumenesAcumulado4='" + this.VolumenesAcumulado4.Text + "', EncuadernacionesAcumulado='" + this.EncuadernacionesAcumulado.Text + "', TitulosMes5='" + this.TitulosMes5.Text + "', TitulosAcumulado5='" + this.TitulosAcumulado5.Text + "', VolumenesMes5='" + this.VolumenesMes5.Text + "', VolumenesAcumulado5='" + this.VolumenesAcumulado5.Text + "', OtrosAcumulado='" + this.OtrosAcumulado.Text + "', AdquiridosMes='" + this.AdquiridosMes.Text + "', AdquiridosAcumulado='" + this.AdquiridosAcumulado.Text + "', EvaluadosMes='" + this.EvaluadosMes.Text + "', EvaluadosAcumulado='" + this.EvaluadosAcumulado.Text + "', PaginaMes='" + this.PaginaMes.Text + "', PaginaAcumulado='" + this.PaginaAcumulado.Text + "', IndizacionMes='" + this.IndizacionMes.Text + "', IndizacionAcumulado='" + this.IndizacionAcumulado.Text + "', DigitalizadosMes='" + this.DigitalizadosMes.Text + "', DigitalizadosAcumulado='" + this.DigitalizadosAcumulado.Text + "', ReparadosMes='" + this.ReparadosMes.Text + "', ReparadosAcumulado='" + this.ReparadosAcumulado.Text + "', ProducidosMes='" + this.ProducidosMes.Text + "', ProducidosAcumulado='" + this.ProducidosAcumulado.Text + "', TalleresEstudiantesMes='" + this.TalleresEstudiantesMes.Text + "', TalleresEstudiantesAcumulado='" + this.TalleresEstudiantesAcumulado.Text + "', ParticipantesMes='" + this.ParticipantesMes.Text + "', ParticipantesAcumulado='" + this.ParticipantesAcumulado.Text + "', TalleresFacultadMes='" + this.TalleresFacultadMes.Text + "', TalleresFacultadAcumulado='" + this.TalleresFacultadAcumulado.Text + "', ParticipantesMes2='" + this.ParticipantesMes2.Text + "', ParticipantesAcumulado2='" + this.ParticipantesAcumulado2.Text + "', TalleresAdministracionAcumulado='" + this.TalleresAdministracionAcumulado.Text + "', ParticipantesMes3='" + this.ParticipantesMes3.Text + "', ParticipantesAcumulado3='" + this.ParticipantesAcumulado3.Text + "', recursosMes='" + this.recursosMes.Text + "', recursosAcumulado='" + this.recursosAcumulado.Text + "', FacultadMes2='" + this.FacultadMes2.Text + "', FacultadAcumulado2='" + this.FacultadAcumulado2.Text + "', AdministracionMes2='" + this.AdministracionMes2.Text + "', AdministracionAcumulado2='" + this.AdministracionAcumulado2.Text + "', SalasGrupalMes='" + this.SalasGrupalMes.Text + "', SalasGrupalAcumulado='" + this.SalasGrupalAcumulado.Text + "', SalasProyeccionesMes='" + this.SalasProyeccionesMes.Text + "', SalasProyeccionesAcumulado='" + this.SalasProyeccionesAcumulado.Text + "', PrestadosMes='" + this.PrestadosMes.Text + "', PrestadosAcumulado='" + this.PrestadosAcumulado.Text + "', SolicitadosMes='" + this.SolicitadosMes.Text + "', SolicitadosAcumulado='" + this.SolicitadosAcumulado.Text + "', AsistenciaMes='" + this.AsistenciaMes.Text + "', AsistenciaAcumulado='" + this.AsistenciaAcumulado.Text + "', HorasServicioMes='" + this.HorasServicioMes.Text + "', HorasServicioAcumulado='" + this.HorasServicioAcumulado.Text + "', PromediosMes='" + this.PromediosMes.Text + "', PromediosAcumulado='" + this.PromediosAcumulado.Text + "', ExposicionesMes='" + this.ExposicionesMes.Text + "', ExposicionesAcumulado='" + this.ExposicionesAcumulado.Text + "', ExhibicionesMes='" + this.ExhibicionesMes.Text + "', ExhibicionesAcumulado='" + this.ExhibicionesAcumulado.Text + "', OtrasMes='" + this.OtrasMes.Text + "', OtrasAcumulado='" + this.OtrasAcumulado.Text + "', PublicacionesNuevasMes='" + this.PublicacionesNuevasMes.Text + "', PublicacionesNuevasAcumulado='" + this.PublicacionesNuevasAcumulado.Text + "', PublicacionesDistribuidasMes='" + this.PublicacionesDistribuidasMes.Text + "', PublicacionesDistribuidasAcumulado='" + this.PublicacionesDistribuidasAcumulado.Text + "', PrestamosExternaAcumulado='" + this.PrestamosExternaAcumulado.Text + "', TalleresOfrecidosMes='" + this.TalleresOfrecidosMes.Text + "', TalleresOfrecidosAcumulado='" + this.TalleresOfrecidosAcumulado.Text + "', DesarolloPersonalAcumulado='" + this.DesarolloAcumulado.Text + "', AnadidoMes='" + this.AnadidoMes.Text + "', AnadidoAcumulado='" + this.AnadidoAcumulado.Text + "', DecomisadoMes='" + this.DecomisadoMes.Text + "', DecomisadoAcumulado='" + this.DecomisadoAcumulado.Text + "', TotalParticipantesMes='" + this.TotalParticipantesMes.Text + "', TotalParticipantesAcumulado='" + this.TotalParticipantesAcumulado.Text + "', TalleresAdministracionMes='" + this.TalleresAdministracionMes.Text + "', EstudiantesMes2='" + this.EstudiantesMes2.Text + "', EstudiantesAcumulado2='" + this.EstudiantesAcumulado2.Text + "' WHERE EntryNr=@EntryNr";

                SqlCommand command = new SqlCommand(sqlString, cnn);
                command.Parameters.AddWithValue("EntryNr", SelectedEntryNr.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();
                reader.DisposeAsync();
                reader.Close();

                var affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Se guardo todo ! ");
                    ProntuariosCotejosMes.Clear();
                    ProntuariosCotejosAcumulado.Clear();
                    FacultadMes.Clear();
                    FacultadAcumulado.Clear();
                    AdministracionMes.Clear();
                    AdministracionAcumulado.Clear();
                    EstudiantesMes.Clear();
                    EstudiantesAcumulado.Clear();
                    ComunidadMes.Clear();
                    ComunidadAcumulado.Clear();
                    TitulosMes.Clear();
                    TitulosAcumulado.Clear();
                    VolumenesMes.Clear();
                    VolumenesAcumulado.Clear();
                    TitulosMes2.Clear();
                    TitulosAcumulado2.Clear();
                    VolumenesMes2.Clear();
                    VolumenesAcumulado2.Clear();
                    TitulosMes3.Clear();
                    TitulosAcumulado3.Clear();
                    VolumenesMes3.Clear();
                    VolumenesAcumulado3.Clear();
                    TitulosMes4.Clear();
                    TitulosAcumulado4.Clear();
                    VolumenesMes4.Clear();
                    VolumenesAcumulado4.Clear();
                    EncuadernacionesAcumulado.Clear();
                    TitulosMes5.Clear();
                    TitulosAcumulado5.Clear();
                    VolumenesMes5.Clear();
                    VolumenesAcumulado5.Clear();
                    AdquiridosMes.Clear();
                    AdquiridosAcumulado.Clear();
                    EvaluadosMes.Clear();
                    EvaluadosAcumulado.Clear();
                    PaginaMes.Clear();
                    PaginaAcumulado.Clear();
                    IndizacionMes.Clear();
                    IndizacionAcumulado.Clear();
                    DigitalizadosMes.Clear();
                    DigitalizadosAcumulado.Clear();
                    ReparadosMes.Clear();
                    ReparadosAcumulado.Clear();
                    ProducidosMes.Clear();
                    ProducidosAcumulado.Clear();
                    TalleresEstudiantesMes.Clear();
                    TalleresEstudiantesAcumulado.Clear();
                    ParticipantesMes.Clear();
                    ParticipantesAcumulado.Clear();
                    TalleresFacultadMes.Clear();
                    TalleresFacultadAcumulado.Clear();
                    ParticipantesMes2.Clear();
                    ParticipantesAcumulado2.Clear();
                    TalleresAdministracionMes.Clear();
                    TalleresAdministracionAcumulado.Clear();
                    recursosMes.Clear();
                    recursosAcumulado.Clear();
                    FacultadMes2.Clear();
                    FacultadAcumulado2.Clear();
                    AdministracionMes2.Clear();
                    AdministracionAcumulado2.Clear();
                    SalasGrupalMes.Clear();
                    SalasGrupalAcumulado.Clear();
                    SalasProyeccionesMes.Clear();
                    SalasProyeccionesAcumulado.Clear();
                    PrestadosMes.Clear();
                    PrestadosAcumulado.Clear();
                    SolicitadosMes.Clear();
                    SolicitadosAcumulado.Clear();
                    AsistenciaMes.Clear();
                    AsistenciaAcumulado.Clear();
                    HorasServicioMes.Clear();
                    HorasServicioAcumulado.Clear();
                    PromediosMes.Clear();
                    PromediosAcumulado.Clear();
                    ExposicionesMes.Clear();
                    ExposicionesAcumulado.Clear();
                    ExhibicionesMes.Clear();
                    ExhibicionesAcumulado.Clear();
                    OtrasMes.Clear();
                    OtrasAcumulado.Clear();
                    PublicacionesNuevasMes.Clear();
                    PublicacionesNuevasAcumulado.Clear();
                    PublicacionesDistribuidasMes.Clear();
                    PublicacionesDistribuidasAcumulado.Clear();
                    PrestamosExternaAcumulado.Clear();
                    TalleresOfrecidosMes.Clear();
                    TalleresOfrecidosAcumulado.Clear();
                    TotalParticipantesMes.Clear();
                    TotalParticipantesAcumulado.Clear();
                    DesarolloAcumulado.Clear();
                    AnadidoMes.Clear();
                    AnadidoAcumulado.Clear();
                    DecomisadoMes.Clear();
                    DecomisadoAcumulado.Clear();
                    TotalParticipantesMes.Clear();
                    TotalParticipantesAcumulado.Clear();
                    EstudiantesMes2.Clear();
                    EstudiantesAcumulado2.Clear();
                    OtrosAcumulado.Clear();
                    ParticipantesMes3.Clear();
                    ParticipantesAcumulado3.Clear();
                    SelectedEntryNr.ItemsSource = null;
                }
            }
        }

        private void FirstDatePicker(object sender, SelectionChangedEventArgs e)
        {
            SelectedEntryNr.ItemsSource = null;
        }

        private void SecondDatePicker(object sender, SelectionChangedEventArgs e)
        {
            SelectedEntryNr.ItemsSource = null;
        }
    }
}
