using CommunityToolkit.Mvvm.Messaging.Messages;
using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajeria.Difusion
{
    class NuevaPersonaValueChangedMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaValueChangedMessage(Persona p) : base(p) { }
    }
}
