using System;

namespace Ejemplo
{
    /// <summary>
    /// Clase Persona
    /// </summary>
    public class Persona
    {
        public long DNI { get; set; }
        //public string Nombre { get; set; }
        
        private string nombre;

        /// <summary>
        /// Getter del Nombre.
        /// Hacemos esto para mostrar como sería sin usar properties.
        /// </summary>
        /// <returns>El nombre de la Persona</returns>
        public string GetNombre()
        {
            return nombre;
        }

        /// <summary>
        /// Setter del nombre. Se asigna el valor a la propiedad privada.
        /// Hacemos esto para mostrar como sería sin usar properties.
        /// </summary>
        /// <param name="value"></param>
        public void SetNombre(string value)
        {
            //el this. se refiere al mismo objeto al que se le llamó al método
            this.nombre = value; 
        }

        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        public string NombreCompleto()
        {
            return string.Format("{0} {1}", this.GetNombre(), this.Apellido);
        }

        public int CalcularEdad()
        {
            DateTime ahora = DateTime.Now;
            int edad = ahora.Year - this.FechaDeNacimiento.Year;

            if (ahora.Month < FechaDeNacimiento.Month
                || (ahora.Month == FechaDeNacimiento.Month
                    && ahora.Day < FechaDeNacimiento.Day))
                edad--;

            return edad;
        }
    }
}