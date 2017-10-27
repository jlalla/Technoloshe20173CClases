using System;

namespace Ejemplo
{
    /// <summary>
    /// Clase Figura
    /// </summary>
    public class Figura
    {
        /// <summary>
        /// Se define virtual permitiendo que una clase
        /// que herede de Figura, pueda redifinirlo
        /// </summary>
        /// <returns></returns>
        public virtual int CalcularPerimetro()
        {
            return 0;
        }
    }

    /// <summary>
    /// Clase Rectangulo que hereda de Figura
    /// Es una figura
    /// </summary>
    public class Rectangulo : Figura
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        /// <summary>
        /// Se pisa el método definido en Figura
        /// </summary>
        /// <returns>el perímetro</returns>
        public override int CalcularPerimetro()
        {
            return (Alto + Ancho) * 2;
        }
    }
    
    /// <summary>
    /// Clase Triangulo que hereda de Figura
    /// </summary>
    public class Triangulo : Figura
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }

        /// <summary>
        /// Se pisa el método de CalcularPerímetro
        /// definido en Figura
        /// </summary>
        /// <returns>el perímetro</returns>
        public override int CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}

