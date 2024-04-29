using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
    public interface ITipoEmpleado
    {
        public void CalcularSueldo(Empleado empleado);
        public void CalcularBonificacion(Empleado empleado);
    }
}
