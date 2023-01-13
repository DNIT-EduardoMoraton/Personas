using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista.UserControls.NuevaPersonaUserControl
{
    class NuevaPersonaUserControlVM : ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private ObservableCollection<String> nacionalidadList;

        public ObservableCollection<String> NacionalidadList
        {
            get { return nacionalidadList; }
            set { SetProperty(ref nacionalidadList, value); }
        }

        private String currNacionalidad;

        public String CurrNacionalidad
        {
            get { return currNacionalidad; }
            set { SetProperty(ref currNacionalidad, value); }
        }

        // Commands

        public RelayCommand NuevaNacionalidadCommand { get; }

        // Servicios

        MainNavigationService nv;

        public NuevaPersonaUserControlVM()
        {
            nv = new MainNavigationService();


            // Commands
            NuevaNacionalidadCommand = new RelayCommand(NuevaNacionalidad);


            // Hardcodeed

            NacionalidadList = new ObservableCollection<string>()
            {
                "España", "Italia", "Francia"
            };
        }


        // Commands
        private void NuevaNacionalidad()
        {
            nv.OpenNuevaNacionalidadDialog();
        }

    }
}
