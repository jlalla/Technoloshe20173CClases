using System;

namespace Ejemplo
{
    /// <summary>
    /// Clase Empleado, que hereda de Persona
    /// Un Empleado es una Persona
    /// </summary>
    public class Empleado : Persona
    {
        public decimal Sueldo { get; set; }

        /// <summary>
        /// Este método sobreescribe el ToString()
        /// que tiene definido la clase object
        /// Toda Clase hereda de Object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Empleado: {0} ({1})",
                    this.NombreCompleto(), this.DNI);
        }
    }
}