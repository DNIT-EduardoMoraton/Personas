using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajeria.Difusion;
using Personas.Mensajeria.Solicitud;
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

        private Persona currPersona;

        public Persona CurrPersona
        {
            get { return currPersona; }
            set { SetProperty(ref currPersona, value);  }
        }


        // Services

        PersonaServicio personaServicio;

        public ListadoPersonasUserControlVM()
        {
            personaServicio = new PersonaServicio();

            ListPersonas = personaServicio.getList();
            manageMessages();
        }

        // Messaging
        private void manageMessages()
        {
            WeakReferenceMessenger.Default.Register<NuevaPersonaValueChangedMessage>(this, (r, m) =>
            {
                ListPersonas.Add(m.Value);
            });

            WeakReferenceMessenger.Default.Register<ListadoPersonasUserControlVM, CurrPersonaRequestMessage>(this, (r, m) =>
            {
                m.Reply(CurrPersona);
            });
            
        }

    }
}
