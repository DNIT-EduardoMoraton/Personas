using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Mensajeria.Difusion
{
    public class NacionalidadValueChangedMessage : ValueChangedMessage<string>
    {
        public NacionalidadValueChangedMessage(string text) : base(text) { }
    }
}   
