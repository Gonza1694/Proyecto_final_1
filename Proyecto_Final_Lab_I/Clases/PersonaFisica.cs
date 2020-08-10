using System;

namespace Proyecto_Final_Lab_I.Clases
{
    internal class PersonaFisica : Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CUIL { get; set; }
        public DateTime FechaNac { get; set; }
    }
}