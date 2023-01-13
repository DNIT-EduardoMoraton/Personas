using CommunityToolkit.Mvvm.ComponentModel;
using Personas.Modelo;
using Personas.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista.UserControls.ListadoPersonasUserControl
{

    class ListadoPersonasUserControlVM : ObservableObject
    {
        private ObservableCollection<Persona> listPersonas;

        public ObservableCollection<Persona> ListPersonas
        {
            get { return listPersonas; }
            set { SetProperty(ref listPersonas, value); }
        }

        // Services

        PersonaServicio personaServicio;

        public ListadoPersonasUserControlVM()
        {
            personaServicio = new PersonaServicio();

            ListPersonas = personaServicio.getList();
        }

    }
}
