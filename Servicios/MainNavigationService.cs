using Personas.Vista.Dialogs;
using Personas.Vista.UserControls.ConsultaPersonaUserControl;
using Personas.Vista.UserControls.ListadoPersonasUserControl;
using Personas.Vista.UserControls.NuevaPersonaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    class MainNavigationService
    {
        private ListadoPersonasUserControl listadoPersonasUserControl;
        public MainNavigationService()
        {
            listadoPersonasUserControl = null;
        }

        public ListadoPersonasUserControl GoToSavedListadoPersonas()
        {
            if (listadoPersonasUserControl == null)
            {
                listadoPersonasUserControl = new ListadoPersonasUserControl();
            }

            return listadoPersonasUserControl;
        }

        public NuevaPersonaUserControl GoToNewNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }
        
        public ConsultaPersonaUserControl GoToConsultaPersona()
        {
            return new ConsultaPersonaUserControl();
        }

        public bool? OpenNuevaNacionalidadDialog()
        {
            DialogNuevaNacionalidad v = new DialogNuevaNacionalidad();
            v.ShowInTaskbar = false;
            return v.ShowDialog();
        }
        

    }
}
