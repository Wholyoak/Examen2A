using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
   public class GestorRecursosHumanos
    {
        private readonly ITipoEmpleado _empleado;

        public GestorRecursosHumanos(ITipoEmpleado tipoEmpleado)
        {
            _empleado = tipoEmpleado;
        }
        public void CalcularPagos(Empleado empleado)
        {
            Console.WriteLine($"Id: {empleado.Id}");
            Console.WriteLine($"Nombre:  {empleado.Nombre}");
            Console.WriteLine($"Costo Salario x Hora:  {empleado.SalarioPorHora}");
            Console.WriteLine($"Tipo de Empleado:  {empleado.Tipo}");
            Console.WriteLine("=================================================");
            _empleado.CalcularBonificacion(empleado);
            Console.WriteLine("=================================================");
            _empleado.CalcularSueldo(empleado);
            Console.WriteLine("*************************************************");
        }

      
    }
}
