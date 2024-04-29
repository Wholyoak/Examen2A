using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
   
    public class EmpleadoPorProyecto : ITipoEmpleado
    {
       
        public int CantidadHorasTrabajadas { get; set; }
        public int Bonificacion { get; set; }
        public double Sueldo { get; set; }
        public void CalcularBonificacion(Empleado empleado)
        {

            //Console.WriteLine($"Id: {empleado.Id}");
            //Console.WriteLine($"Nombre:  {empleado.Nombre}");
            //Console.WriteLine(" ");
           

            if (CantidadHorasTrabajadas >= 270) Bonificacion = 200; else Bonificacion = 0;
            if (CantidadHorasTrabajadas >= 300) Bonificacion = 400;
            if (CantidadHorasTrabajadas >= 360) Bonificacion = 800;

            Console.WriteLine($"La cantidad de horas trabajadas es     : {CantidadHorasTrabajadas}");
            Console.WriteLine($"La el sueldo base es                S/.: {CantidadHorasTrabajadas * empleado.SalarioPorHora}");
            Console.WriteLine($"La bonificación para el empelado es S/.: {Bonificacion}");

        }
        
        public void CalcularSueldo(Empleado empleado)
        {            
            //Console.WriteLine($"Id: {empleado.Id}");
            //Console.WriteLine($"Nombre:  {empleado.Nombre}");
            //Console.WriteLine(" ");
            Sueldo = (CantidadHorasTrabajadas * empleado.SalarioPorHora) + Bonificacion;
            Console.WriteLine($"El sueldo del mes es:  {Sueldo}");
        }
    }
}
