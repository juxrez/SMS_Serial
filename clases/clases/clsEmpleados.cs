using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class clsEmpleados
    {
        public string nombre;
        public double sueldoDiario;
        public int edad;
        
        public double CalcularSalario(int numeroDias)
        {
            return sueldoDiario * numeroDias;
        }
    }
}
