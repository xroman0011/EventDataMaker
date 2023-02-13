using System;
using System.Collections.Generic;
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
    /// Interaction logic for BuscarOpciones.xaml
    /// </summary>
    public partial class BuscarOpciones : Window
    {
        public BuscarOpciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TablaSemanaRadioBTN.IsChecked == true)
            {
                this.Hide();
                WeekView weekView = new WeekView();
                weekView.Show();
            }
            if(TablaAtendenciaRadioBTN.IsChecked == true)
            {
                this.Hide();
                AttendenceViewer attendenceViewer = new AttendenceViewer();
                attendenceViewer.Show();
            }
            if(TablaSemanaRadioBTN.IsChecked == false && TablaAtendenciaRadioBTN.IsChecked == false)
            {
                MessageBox.Show("Por favor escoge un opcion");
            }
        }
    }
}
