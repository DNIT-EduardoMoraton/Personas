using CommunityToolkit.Mvvm.ComponentModel;
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

        public NuevaPersonaUserControlVM()
        {

        }



    }
}
