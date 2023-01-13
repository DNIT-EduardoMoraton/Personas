using Personas.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.Servicios
{
    
    class PersonaServicio
    {
        public ObservableCollection<Persona> getList()
        {
            ObservableCollection<Persona> personas = null;

            personas = new ObservableCollection<Persona>()
            {
                new Persona("Trinity", "España", 22),
                new Persona("Neo", "Francia", 34),
                new Persona("Teodoro", "Italia", 43)
            };

            return personas;
        }

    }
}
