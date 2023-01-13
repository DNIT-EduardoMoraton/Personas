using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Personas
{


    class MainWindowVM : ObservableObject
    {
        private UserControl mainContentControl;

        public UserControl MainContentControl
        {
            get { return mainContentControl; }
            set { SetProperty(ref mainContentControl, value); }
        }

        // Commands
        public RelayCommand GoToListaPersonasCommand { get;  }
        public RelayCommand GoToNuevaPersonaCommand { get;  }




        // Servicios
        MainNavigationService nv;

        public MainWindowVM()
        {
            nv = new MainNavigationService();
            MainContentControl = nv.GoToNewNuevaPersona();

            GoToListaPersonasCommand = new RelayCommand(GoToListaPersonas);
            GoToNuevaPersonaCommand = new RelayCommand(GoToNuevaPersona);

        }

        // Commands

        private void GoToListaPersonas()
        {
            MainContentControl = nv.GoToSavedListadoPersonas();
        }
        private void GoToNuevaPersona()
        {
            MainContentControl = nv.GoToNewNuevaPersona();
        }


    }
}
