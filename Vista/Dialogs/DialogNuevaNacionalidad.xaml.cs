using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personas.Vista.Dialogs
{
    /// <summary>
    /// Lógica de interacción para DialogNuevaNacionalidad.xaml
    /// </summary>
    public partial class DialogNuevaNacionalidad : Window
    {
        DialogNuevaNacionalidadVM vm;
        public DialogNuevaNacionalidad()
        {
            InitializeComponent();
            vm = new DialogNuevaNacionalidadVM();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            vm.AceptarButton();
        }
    }
}
