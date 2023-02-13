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
    /// Interaction logic for AttendenceViewer.xaml
    /// </summary>
    public partial class AttendenceViewer : Window
    {
        public AttendenceViewer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var eventsData = new List<EventData>()
            {
                new EventData
                {
                    AreaDeEnfasis = "DESAROLLO Y ACTUALIZACION DE LAS COLECCIONES",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Assessment de las colecciones",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Prontuarios cotejados",
                    Acumulado = ProntuariosCotejosAcumulado.Content.ToString(),
                    LogroDelMes = ProntuariosCotejosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Participacion de la comunidad academia-(total de recomendaciones)",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Facultad",
                    Acumulado = FacultadAcumulado.Content.ToString(),
                    LogroDelMes = FacultadMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Administración",
                    Acumulado = AdministracionAcumulado.Content.ToString(),
                    LogroDelMes = AdministracionMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Estudiantes",
                    Acumulado = EstudiantesAcumulado.Content.ToString(),
                    LogroDelMes = EstudiantesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Comunidad",
                    Acumulado = ComunidadAcumulado.Content.ToString(),
                    LogroDelMes = ComunidadMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Adquisiciones/Recursos nuevos (A+B)",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Titulos",
                    Acumulado = TitulosAcumulado.Content.ToString(),
                    LogroDelMes = TitulosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Volumenes",
                    Acumulado = VolumenesAcumulado.Content.ToString(),
                    LogroDelMes = VolumenesMes.Content.ToString()
                }
                ,new EventData
                {
                    AreaDeEnfasis = "   A.Compras",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Titulos",
                    Acumulado = TitulosAcumulado2.Content.ToString(),
                    LogroDelMes = TitulosMes2.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Volumenes",
                    Acumulado = VolumenesAcumulado2.Content.ToString(),
                    LogroDelMes = VolumenesMes2.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "   B.Donaciones",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Titulos",
                    Acumulado = TitulosAcumulado3.Content.ToString(),
                    LogroDelMes = TitulosMes3.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Volumenes",
                    Acumulado = VolumenesAcumulado3.Content.ToString(),
                    LogroDelMes = VolumenesMes3.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Crecimiento de las colecciones(catologados)",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Titulos",
                    Acumulado = TitulosAcumulado4.Content.ToString(),
                    LogroDelMes = TitulosMes4.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Volumenes",
                    Acumulado = VolumenesAcumulado4.Content.ToString(),
                    LogroDelMes = VolumenesMes4.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Mantenimiento de las colecciones",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "   • Encuardernaciones(volumenes procesados)",
                    Acumulado = EncuadernacionesAcumulado.Content.ToString(),
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "   • Descarte",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Titulos",
                    Acumulado = TitulosAcumulado5.Content.ToString(),
                    LogroDelMes = TitulosMes5.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Volumenes",
                    Acumulado = VolumenesAcumulado5.Content.ToString(),
                    LogroDelMes = VolumenesMes5.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "   • Otros",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Recursos virtuales de informacion",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Adquiridos",
                    Acumulado = AdquiridosAcumulado.Content.ToString(),
                    LogroDelMes = AdquiridosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Evaluados para compra",
                    Acumulado = EvaluadosAcumulado.Content.ToString(),
                    LogroDelMes = EvaluadosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Acceso a la informacion",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Pagina de Web",
                    Acumulado = PaginaAcumulado.Content.ToString(),
                    LogroDelMes = PaginaMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Indizacion",
                    Acumulado = IndizacionAcumulado.Content.ToString(),
                    LogroDelMes = IndizacionMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Recursos Audiovisuales",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Digitalizados",
                    Acumulado = DigitalizadosAcumulado.Content.ToString(),
                    LogroDelMes = DigitalizadosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Reparados",
                    Acumulado = ReparadosAcumulado.Content.ToString(),
                    LogroDelMes = ReparadosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Producidos",
                    Acumulado = ProducidosAcumulado.Content.ToString(),
                    LogroDelMes = ProducidosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "DESTREZAS PARA EL MANEJO DE LA INFORMACION",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Talleres: Estudiantes",
                    Acumulado = TalleresEstudiantesAcumulado.Content.ToString(),
                    LogroDelMes = TalleresEstudiantesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Participantes",
                    Acumulado = ParticipantesAcumulado.Content.ToString(),
                    LogroDelMes = ParticipantesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Talleres: Facultad",
                    Acumulado = TalleresFacultadAcumulado.Content.ToString(),
                    LogroDelMes = TalleresFacultadMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Participantes",
                    Acumulado = ParticipantesAcumulado2.Content.ToString(),
                    LogroDelMes = ParticipantesMes2.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Talleres: Administracion",
                    Acumulado = TalleresAdministracionAcumulado.Content.ToString(),
                    LogroDelMes = TalleresAdministracionMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Participantes",
                    Acumulado = ParticipantesAcumulado3.Content.ToString(),
                    LogroDelMes = ParticipantesMes3.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "USO DE LOS RECURSOS Y FACILIDADES",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Uso de los recursos*",
                    Acumulado = recursosAcumulado.Content.ToString(),
                    LogroDelMes = recursosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Estudiantes",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Facultad",
                    Acumulado = FacultadAcumulado2.Content.ToString(),
                    LogroDelMes = FacultadAcumulado2.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Administracion",
                    Acumulado = AdministracionAcumulado2.Content.ToString(),
                    LogroDelMes = AdministracionMes2.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Uso de las Facilidades",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Salas de Estudio Grupal (3 salas)",
                    Acumulado = SalasGrupalAcumulado.Content.ToString(),
                    LogroDelMes = SalasGrupalMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Salas de Proyecciones",
                    Acumulado = SalasProyeccionesAcumulado.Content.ToString(),
                    LogroDelMes = SalasProyeccionesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Prestamos Inter Bibliotecarios (Total)",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Prestados",
                    Acumulado = PrestadosAcumulado.Content.ToString(),
                    LogroDelMes = PrestadosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Solicitados",
                    Acumulado = SolicitadosAcumulado.Content.ToString(),
                    LogroDelMes = SolicitadosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "OTROS ASPECTOS DEL SERVICIOS",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Horario",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Asistencia",
                    Acumulado = AsistenciaAcumulado.Content.ToString(),
                    LogroDelMes = AsistenciaMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Horas de servicio",
                    Acumulado = HorasServicioAcumulado.Content.ToString(),
                    LogroDelMes = HorasServicioMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Promedio asistencia por hr.",
                    Acumulado = PromediosAcumulado.Content.ToString(),
                    LogroDelMes = PromediosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Actividades",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Exposiciones",
                    Acumulado = ExposicionesAcumulado.Content.ToString(),
                    LogroDelMes = ExposicionesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Exhibiciones",
                    Acumulado = ExhibicionesAcumulado.Content.ToString(),
                    LogroDelMes = ExhibicionesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Otras",
                    Acumulado = OtrasAcumulado.Content.ToString(),
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Promocion de Recursos y servicios",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Publicaciones nuevas",
                    Acumulado = PublicacionesNuevasAcumulado.Content.ToString(),
                    LogroDelMes = PublicacionesNuevasMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Publicaciones distribuidas",
                    Acumulado = PublicacionesDistribuidasAcumulado.Content.ToString(),
                    LogroDelMes = PublicacionesDistribuidasMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "USO DE LOS RECURSOS Y SERVICIOS",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Prestamos a la comunidad externa",
                    Acumulado = PrestamosExternaAcumulado.Content.ToString(),
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Talleres y conferencias",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Talleres ofrecidos",
                    Acumulado = TalleresOfrecidosAcumulado.Content.ToString(),
                    LogroDelMes = TalleresOfrecidosMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Total de participantes",
                    Acumulado = TotalParticipantesAcumulado.Content.ToString(),
                    LogroDelMes = TotalParticipantesMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "GERENCIA Y PLANTA FISICA",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "Desarollo de personal (talleres, seminarios cursos, etc.)",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "• Equipo",
                    Acumulado = "",
                    LogroDelMes = ""
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Anadido (comprado o donado)",
                    Acumulado = AnadidoAcumulado.Content.ToString(),
                    LogroDelMes = AnadidoMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "      _Decomisado**",
                    Acumulado = DecomisadoAcumulado.Content.ToString(),
                    LogroDelMes = DecomisadoMes.Content.ToString()
                },
                new EventData
                {
                    AreaDeEnfasis = "• Planta Fisica",
                    Acumulado = "",
                    LogroDelMes = ""
                },
            };

            try
            {
                using (var writer = new StreamWriter(@"C:\Users\lcoloc\Desktop\eventdata.csv", false, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(eventsData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong " + ex.Message);

                return;
            }

            MessageBox.Show("File evendata.csv has been downloaded in the Desktop");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DateTime? dateSelected = DateRecord1.SelectedDate;
            DateTime? dateSelected2 = DateRecord2.SelectedDate;
            if (dateSelected == null || dateSelected2 == null)
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

                SqlCommand cmd = new SqlCommand("select EntryNr from AttendenceTable where DateRec between @DateRecord1 and @DateRecord2", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                cmd.Parameters.AddWithValue("DateRecord1", dateSelected);
                cmd.Parameters.AddWithValue("DateRecord2", dateSelected2);
                adapter.Fill(dt);
                SelectedEntryNr.ItemsSource = dt.DefaultView;
                SelectedEntryNr.DisplayMemberPath = dt.Columns["EntryNr"].ToString();
                SelectedEntryNr.SelectedValuePath = dt.Columns["EntryNr"].ToString();
                MessageBox.Show("Se encontro los EntryNr!");
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

                string sqlString = $"SELECT ProntuariosCotejosMes, ProntuariosCotejosAcumulado, FacultadMes, FacultadAcumulado, AdministracionMes, AdministracionAcumulado, EstudiantesMes, EstudiantesAcumulado, ComunidadMes, ComunidadAcumulado, TitulosMes, TitulosAcumulado, VolumenesMes, VolumenesAcumulado, TitulosMes2, TitulosAcumulado2, VolumenesMes2, VolumenesAcumulado2, TitulosMes3, TitulosAcumulado3, VolumenesMes3, VolumenesAcumulado3, TitulosMes4, TitulosAcumulado4, VolumenesMes4, VolumenesAcumulado4, EncuadernacionesAcumulado, TitulosMes5, TitulosAcumulado5, VolumenesMes5, VolumenesAcumulado5, OtrosMes, OtrosAcumulado, AdquiridosMes, AdquiridosAcumulado, EvaluadosMes, EvaluadosAcumulado, PaginaMes, PaginaAcumulado, IndizacionMes, IndizacionAcumulado, DigitalizadosMes, DigitalizadosAcumulado, ReparadosMes, ReparadosAcumulado, ProducidosMes, ProducidosAcumulado, TalleresEstudiantesMes, TalleresEstudiantesAcumulado, ParticipantesMes, ParticipantesAcumulado, TalleresFacultadMes, TalleresFacultadAcumulado, ParticipantesMes2, ParticipantesAcumulado2, TalleresAdministracionMes, TalleresAdministracionAcumulado, ParticipantesMes3, ParticipantesAcumulado3, recursosMes, recursosAcumulado, FacultadMes2, FacultadAcumulado2, AdministracionMes2, AdministracionAcumulado2, SalasGrupalMes, SalasGrupalAcumulado, SalasProyeccionesMes, SalasProyeccionesAcumulado, PrestadosMes, PrestadosAcumulado, SolicitadosMes, SolicitadosAcumulado, AsistenciaMes, AsistenciaAcumulado, HorasServicioMes, HorasServicioAcumulado, PromediosMes, PromediosAcumulado, ExposicionesMes, ExposicionesAcumulado, ExhibicionesMes, ExhibicionesAcumulado, OtrasMes, OtrasAcumulado, PublicacionesNuevasMes, PublicacionesNuevasAcumulado, PublicacionesDistribuidasMes, PublicacionesDistribuidasAcumulado, PrestamosExternaMes, PrestamosExternaAcumulado, TalleresOfrecidosMes, TalleresOfrecidosAcumulado, DesarolloPersonalMes, DesarolloPersonalAcumulado, AnadidoMes, AnadidoAcumulado, DecomisadoMes, DecomisadoAcumulado, TotalParticipantesMes, TotalParticipantesAcumulado, EncuardacionesAcumulado FROM AttendenceTable WHERE EntryNr=@EntryNr";

                SqlCommand command = new SqlCommand(sqlString, cnn);
                command.Parameters.AddWithValue("EntryNr", SelectedEntryNr.SelectedValue);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProntuariosCotejosMes.Content = reader["ProntuariosCotejosMes"].ToString();
                    ProntuariosCotejosAcumulado.Content = reader["ProntuariosCotejosAcumulado"].ToString();
                    FacultadMes.Content = reader["FacultadMes"].ToString();
                    FacultadAcumulado.Content = reader["FacultadAcumulado"].ToString();
                    AdministracionMes.Content = reader["AdministracionMes"].ToString();
                    AdministracionAcumulado.Content = reader["AdministracionAcumulado"].ToString();
                    EstudiantesMes.Content = reader["EstudiantesMes"].ToString();
                    EstudiantesAcumulado.Content = reader["EstudiantesAcumulado"].ToString();
                    ComunidadMes.Content = reader["ComunidadMes"].ToString();
                    ComunidadAcumulado.Content = reader["ComunidadAcumulado"].ToString();
                    TitulosMes.Content = reader["TitulosMes"].ToString();
                    TitulosAcumulado.Content = reader["TitulosAcumulado"].ToString();
                    VolumenesMes.Content = reader["VolumenesMes"].ToString();
                    VolumenesAcumulado.Content = reader["VolumenesAcumulado"].ToString();
                    TitulosMes2.Content = reader["TitulosMes2"].ToString();
                    TitulosAcumulado2.Content = reader["TitulosAcumulado2"].ToString();
                    VolumenesMes2.Content = reader["VolumenesMes2"].ToString();
                    VolumenesAcumulado2.Content = reader["VolumenesAcumulado2"].ToString();
                    TitulosMes3.Content = reader["TitulosMes3"].ToString();
                    TitulosAcumulado3.Content = reader["TitulosAcumulado3"].ToString();
                    VolumenesMes3.Content = reader["VolumenesMes3"].ToString();
                    VolumenesAcumulado3.Content = reader["VolumenesAcumulado3"].ToString();
                    TitulosMes4.Content = reader["TitulosMes4"].ToString();
                    TitulosAcumulado4.Content = reader["TitulosAcumulado4"].ToString();
                    VolumenesMes4.Content = reader["VolumenesMes4"].ToString();
                    VolumenesAcumulado4.Content = reader["VolumenesAcumulado4"].ToString();
                    TitulosMes5.Content = reader["TitulosMes5"].ToString();
                    TitulosAcumulado5.Content = reader["TitulosAcumulado5"].ToString();
                    VolumenesMes5.Content = reader["VolumenesMes5"].ToString();
                    VolumenesAcumulado5.Content = reader["VolumenesAcumulado5"].ToString();
                    OtrasMes.Content = reader["OtrosMes"].ToString();
                    OtrasAcumulado.Content = reader["OtrosAcumulado"].ToString();
                    AdquiridosMes.Content = reader["AdquiridosMes"].ToString();
                    AdquiridosAcumulado.Content = reader["AdquiridosAcumulado"].ToString();
                    EvaluadosMes.Content = reader["EvaluadosMes"].ToString();
                    EvaluadosAcumulado.Content = reader["EvaluadosAcumulado"].ToString();
                    PaginaMes.Content = reader["PaginaMes"].ToString();
                    PaginaAcumulado.Content = reader["PaginaAcumulado"].ToString();
                    IndizacionMes.Content = reader["IndizacionMes"].ToString();
                    IndizacionAcumulado.Content = reader["IndizacionAcumulado"].ToString();
                    DigitalizadosMes.Content = reader["DigitalizadosMes"].ToString();
                    DigitalizadosAcumulado.Content = reader["DigitalizadosAcumulado"].ToString();
                    ReparadosMes.Content = reader["ReparadosMes"].ToString();
                    ReparadosAcumulado.Content = reader["ReparadosAcumulado"].ToString();
                    ProducidosMes.Content = reader["ProducidosMes"].ToString();
                    ProducidosAcumulado.Content = reader["ProducidosAcumulado"].ToString();
                    TalleresEstudiantesMes.Content = reader["TalleresEstudiantesMes"].ToString();
                    TalleresEstudiantesAcumulado.Content = reader["TalleresEstudiantesAcumulado"].ToString();
                    ParticipantesMes.Content = reader["ParticipantesMes"].ToString();
                    ParticipantesAcumulado.Content = reader["ParticipantesAcumulado"].ToString();
                    TalleresFacultadMes.Content = reader["TalleresFacultadMes"].ToString();
                    TalleresFacultadAcumulado.Content = reader["TalleresFacultadAcumulado"].ToString();
                    ParticipantesMes2.Content = reader["ParticipantesMes2"].ToString();
                    ParticipantesAcumulado2.Content = reader["ParticipantesAcumulado2"].ToString();
                    TalleresAdministracionMes.Content = reader["TalleresAdministracionMes"].ToString();
                    TalleresAdministracionAcumulado.Content = reader["TalleresAdministracionAcumulado"].ToString();
                    ParticipantesMes3.Content = reader["ParticipantesMes3"].ToString();
                    ParticipantesAcumulado3.Content = reader["ParticipantesAcumulado3"].ToString();
                    recursosMes.Content = reader["recursosMes"].ToString();
                    recursosAcumulado.Content = reader["recursosAcumulado"].ToString();
                    FacultadMes2.Content = reader["FacultadMes2"].ToString();
                    FacultadAcumulado2.Content = reader["FacultadAcumulado2"].ToString();
                    AdministracionMes2.Content = reader["AdministracionMes2"].ToString();
                    AdministracionAcumulado2.Content = reader["AdministracionAcumulado2"].ToString();
                    SalasGrupalMes.Content = reader["SalasGrupalMes"].ToString();
                    SalasGrupalAcumulado.Content = reader["SalasGrupalAcumulado"].ToString();
                    SalasProyeccionesMes.Content = reader["SalasProyeccionesMes"].ToString();
                    SalasProyeccionesAcumulado.Content = reader["SalasProyeccionesAcumulado"].ToString();
                    PrestadosMes.Content = reader["PrestadosMes"].ToString();
                    PrestadosAcumulado.Content = reader["PrestadosAcumulado"].ToString();
                    SolicitadosMes.Content = reader["SolicitadosMes"].ToString();
                    SolicitadosAcumulado.Content = reader["SolicitadosAcumulado"].ToString();
                    AsistenciaMes.Content = reader["AsistenciaMes"].ToString();
                    AsistenciaAcumulado.Content = reader["AsistenciaAcumulado"].ToString();
                    HorasServicioMes.Content = reader["HorasServicioMes"].ToString();
                    HorasServicioAcumulado.Content = reader["HorasServicioAcumulado"].ToString();
                    PromediosMes.Content = reader["PromediosMes"].ToString();
                    PromediosAcumulado.Content = reader["PromediosAcumulado"].ToString();
                    ExposicionesMes.Content = reader["ExposicionesMes"].ToString();
                    ExposicionesAcumulado.Content = reader["ExposicionesAcumulado"].ToString();
                    OtrasMes.Content = reader["OtrasMes"].ToString();
                    OtrasAcumulado.Content = reader["OtrasAcumulado"].ToString();
                    PublicacionesNuevasMes.Content = reader["PublicacionesNuevasMes"].ToString();
                    PublicacionesNuevasAcumulado.Content = reader["PublicacionesNuevasAcumulado"].ToString();
                    PublicacionesDistribuidasMes.Content = reader["PublicacionesDistribuidasMes"].ToString();
                    PublicacionesDistribuidasAcumulado.Content = reader["PublicacionesDistribuidasAcumulado"].ToString();
                    PrestamosExternaAcumulado.Content = reader["PrestamosExternaAcumulado"].ToString();
                    TalleresOfrecidosMes.Content = reader["TalleresOfrecidosMes"].ToString();
                    TalleresOfrecidosAcumulado.Content = reader["TalleresOfrecidosAcumulado"].ToString();
                    TotalParticipantesMes.Content = reader["TotalParticipantesMes"].ToString();
                    TotalParticipantesAcumulado.Content = reader["TotalParticipantesAcumulado"].ToString();
                    DesarolloAcumulado.Content = reader["DesarolloPersonalMes"].ToString();
                    AnadidoMes.Content = reader["AnadidoMes"].ToString();
                    AnadidoAcumulado.Content = reader["AnadidoAcumulado"].ToString();
                    DecomisadoMes.Content = reader["DecomisadoMes"].ToString();
                    DecomisadoAcumulado.Content = reader["DecomisadoAcumulado"].ToString();
                    EncuadernacionesAcumulado.Content = reader["EncuadernacionesAcumulado"].ToString();
                    ExhibicionesAcumulado.Content = reader["ExhibicionesAcumulado"].ToString();
                    ExhibicionesMes.Content = reader["ExhibicionesMes"].ToString();
                }
                reader.DisposeAsync();
                reader.Close();
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            BuscarOpciones buscarOpciones = new BuscarOpciones();
            buscarOpciones.Show();
        }
    }
}
