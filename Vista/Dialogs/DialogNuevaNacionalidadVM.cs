using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Vista.Dialogs
{

    class DialogNuevaNacionalidadVM : ObservableObject
    {

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }


        public DialogNuevaNacionalidadVM()
        {

        }

        public void AceptarButton()
        {
            
        }
    }
}
