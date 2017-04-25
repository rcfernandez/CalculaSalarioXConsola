using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tarea mvc. Calculador de salarios
---------------------------------
2 vistas independientes.

1 vista programador con 
Nombre: input
Apellido:
Cantidad hs trabajadas:
El valor de la hora es propia de la clase. Es privado. Predefinido
Salario progrmaador= valor hora × cant horas + incentivos
Boton calcular. Devuelve el resultado de otra vista vista resultado. Que va a decir el programador Nombre Apellido Salario. 

Vista2
Vista administrativo
NOMBRE 
APELLIDO
No tiene valor hora. Tiene sueldo fijo q es predeterminado private
Ademas de un incentivo.
Salario administrativo = 500;
Boton calcular. Devuelve la misma vista resultado que la del programador. Ideal que sea la misma vista Resultado .. pero sino hacer otra igual.
Clases...
Calculadora tiene q estar! Y tiene el metodo unico q esCalcularsalario ()
*/

namespace ConsoleApplication1
{

    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //private double Sueldo { get; set; }

        public abstract double calcularSalario();

    }

    public class Administrativo : Empleado
    {
        public double SueldoFijo = 500;
        public double Incentivo { get; set; }

        public override double calcularSalario()
        {
            return SueldoFijo + Incentivo;
        }
    }

    public class Programador : Empleado
    {
        public double ValorHora = 45;
        public int CantidadHoras { get; set; }
        public double Incentivo { get; set; }

        public override double calcularSalario()
        {
            return (ValorHora * CantidadHoras) + Incentivo;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Empleado EA = new Administrativo() { Nombre = "roberto", Apellido = "fernandez", Incentivo = 200 };
            Empleado EP = new Programador() { Nombre = "javier", Apellido = "pulcini", CantidadHoras = 10, Incentivo = 700 };

            Console.WriteLine("Nombre : " + EA.Nombre + " tiene un sueldo de : " + EA.calcularSalario() );
            Console.WriteLine("Nombre : " + EP.Nombre + " tiene un sueldo de : " + EP.calcularSalario() );

            Console.ReadKey();
         
        }
    }
}
