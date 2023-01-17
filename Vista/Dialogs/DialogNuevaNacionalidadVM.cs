using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using Personas.Mensajeria.Difusion;
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
            WeakReferenceMessenger.Default.Send(new NacionalidadValueChangedMessage(Nacionalidad));
        }
    }
}
