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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas.Vista.UserControls.ListadoPersonasUserControl
{
    /// <summary>
    /// Lógica de interacción para ListadoPersonasUserControl.xaml
    /// </summary>
    public partial class ListadoPersonasUserControl : UserControl
    {
        private ListadoPersonasUserControlVM vm;
        public ListadoPersonasUserControl()
        {
            InitializeComponent();
            vm = new ListadoPersonasUserControlVM();
            DataContext = vm;
        }
    }
}
