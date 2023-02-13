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
    /// Interaction logic for CrearOpciones.xaml
    /// </summary>
    public partial class CrearOpciones : Window
    {
        public CrearOpciones()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SemanaRadioBtn.IsChecked == true)
            {
                this.Hide();
                WeekTable fweek = new WeekTable();
                fweek.Show();
            }
            if(AtendenciaRadioBtn.IsChecked == true)
            {
                this.Hide();
                AttendenceWindow attendenceWindow = new AttendenceWindow();
                attendenceWindow.Show();
            }
            if (SemanaRadioBtn.IsChecked == false && AtendenciaRadioBtn.IsChecked == false)
            {
                MessageBox.Show("Por favor escoge un opcion");
            }
        }

        private void Button_Click_Regresar(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
