using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
   
        public class EmpleadosTiempoCompleto : ITipoEmpleado
        {
           
        public int CantidadHorasTrabajadas { get; set; }
        public int TipoAfp { get; set; }
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

                Console.WriteLine($"La cantidad de horas trabajadas es: {CantidadHorasTrabajadas}");
                Console.WriteLine($"La bonificación para el empelado es S/.: {Bonificacion}");            
            
            }
        
            public void CalcularSueldo(Empleado empleado)
            {
                    //Console.WriteLine($"Id: {empleado.Id}");
                    //Console.WriteLine($"Nombre:  {empleado.Nombre}");
                    //Console.WriteLine(" ");
                    double DescuentoAfp = 0;
                    double SueldoBase = 0;
                    string Afp =string.Empty;
            SueldoBase = CantidadHorasTrabajadas * empleado.SalarioPorHora;
                    if (TipoAfp == 1)
                        DescuentoAfp = ((CantidadHorasTrabajadas * empleado.SalarioPorHora) + Bonificacion) * 0.12;
                        Afp = "Prima";
                    if (TipoAfp == 2)
                        DescuentoAfp = ((CantidadHorasTrabajadas * empleado.SalarioPorHora) + Bonificacion) * 0.13;
                        Afp = "Integra";

                    Sueldo = ((CantidadHorasTrabajadas * empleado.SalarioPorHora) + Bonificacion)-DescuentoAfp;

                    Console.WriteLine($"El aporte del AFP es: S/. {DescuentoAfp}");
                    Console.WriteLine($"La AFP es           : {Afp}");
                    Console.WriteLine($"***********************************");
                    Console.WriteLine($"El sueldo Base              : S/. {SueldoBase}   +");
                    Console.WriteLine($"Bonificación                : S/. {Bonificacion} -");
                    Console.WriteLine($"Descuento por AFP es        : S/. {DescuentoAfp}");
                    Console.WriteLine($"                              ==================");
                    Console.WriteLine($"El sueldo a pagar del mes es: S/. {Sueldo}");
            }
        }
    
}
