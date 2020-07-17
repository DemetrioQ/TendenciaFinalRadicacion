using System;

namespace Radication
{
    public class Radicacion
    {
        public double potency;
        public Radicacion(double potency)
        {
            if (potency == 0)
            {
                throw new ArgumentException("0 no puede ser una potencia para una raiz");
            }

            this.potency = potency;
        }

        public double DoRadicacion(double number)
        {
            if (potency % 2 == 0 && number < 0)
            {
                throw new ArgumentException("No puede tener como potencia u nnumero par y sacarle la raiz a un numero positivo");
            }

            double answer = Math.Pow(number, 1 / potency);

            return answer;
        }
    }
}
