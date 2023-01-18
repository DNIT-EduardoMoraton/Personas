using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajeria.Difusion;
using Personas.Mensajeria.Solicitud;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista.UserControls.ConsultaPersonaUserControl
{


    class ConsultaPersonaUserControlVM : ObservableRecipient
    {
        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { SetProperty(ref persona, value); }
        }

        public ConsultaPersonaUserControlVM()
        {
            Initialize();
        }

        private void Initialize()
        {
            Persona = WeakReferenceMessenger.Default.Send<CurrPersonaRequestMessage>();
        }
    }
}
