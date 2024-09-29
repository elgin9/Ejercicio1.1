using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._1.Modelos
{
    public class OperacionesMatematicas
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                throw new DivideByZeroException("No se puede dividir por cero");
        }
    }
}
