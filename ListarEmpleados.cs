using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using Examen2A;
namespace Examen2A
{
    public class ListarEmpleados
    {  
        public void listarEmpleados(int id,string nombre, double salarioxHora, string tipo, int horasTrabajadas,int tipoAfp)
    {
            if (tipo == "PorProyecto")
            {
                ///Empleado por Proyectos
                EmpleadoPorProyecto EmpleadoProyecto = new EmpleadoPorProyecto
                {
                    CantidadHorasTrabajadas = horasTrabajadas
                };
                GestorRecursosHumanos GestorRRHHProyectos = new GestorRecursosHumanos(EmpleadoProyecto);

                Empleado empleado1 = new Empleado
                {
                    Id = id,
                    Nombre = nombre,
                    SalarioPorHora = salarioxHora,
                    Tipo = tipo

                };
                EmpleadoProyecto.CantidadHorasTrabajadas = horasTrabajadas;
                GestorRRHHProyectos.CalcularPagos(empleado1);
                Console.WriteLine(" ");
            }
            else
            {
                ///Empleado por tiempo completo
                EmpleadosTiempoCompleto empleadoCompleto = new EmpleadosTiempoCompleto
                {

                    CantidadHorasTrabajadas = horasTrabajadas,
                    TipoAfp=tipoAfp
                    
                    
                };
                GestorRecursosHumanos GestorRRHHTiempoCompleto = new GestorRecursosHumanos(empleadoCompleto);

                Empleado empleado = new Empleado
                {
                    Id = id,
                    Nombre = nombre,
                    SalarioPorHora = salarioxHora,
                    Tipo = tipo

                };
                //empleadoCompleto.CantidadHorasTrabajadas = horasTrabajadas;
                GestorRRHHTiempoCompleto.CalcularPagos(empleado);
                Console.WriteLine(" ");
            }


    
    }
      



    }
}
