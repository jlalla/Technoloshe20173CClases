using System;
using System.Collections.Generic;
using Ejemplo;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Persona> listaPersonas = new List<Persona>();

            Empleado empleado = new Empleado();
            empleado.DNI = 152232323;
            empleado.SetNombre("Rick");
            empleado.Apellido = "Sanchez";
            empleado.Sueldo = 45000;

            listaPersonas.Add(empleado);

            Persona nuevaPersona = new Persona();
            nuevaPersona.DNI = 35939434;
            nuevaPersona.SetNombre("Morty");
            nuevaPersona.Apellido = "Smith";

            listaPersonas.Add(nuevaPersona);

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(empleado);
            //listaEmpleados.Add(nuevaPersona);//ESTO NO SE PUEDE

            Console.WriteLine(empleado.GetNombre());
            Console.WriteLine(empleado.Apellido);

            // OTRO EJEMPLO //

            // si queremos setear las propiedades al construirlo
            Rectangulo rect1 = new Rectangulo { Alto = 2, Ancho = 4};
            Triangulo tri1 = new Triangulo { Lado1=3, Lado2=2, Lado3= 5};
            List<Figura> listaFiguras = new List<Figura>();
            listaFiguras.Add(rect1);
            listaFiguras.Add(tri1);

            foreach(Figura figura in listaFiguras)
            {
                Console.WriteLine("Tiene un perímetro de:" 
                    + figura.CalcularPerimetro());
            }



            Console.ReadKey();
        }
    }
}
