using System;

namespace Radication
{
    public class Radicacion
    {
        public int potency;
        public Radicacion(int potency)
        {
            if (potency == 0)
            {
                throw new ArgumentException("0 no puede ser una potencia para una raiz");
            }

            this.potency = potency;
        }

        public double DoRadicacion(int number)
        {
            if (potency % 2 == 0 && number < 0)
            {
                throw new ArgumentException("No puede tener como potencia u nnumero par y sacarle la raiz a un numero positivo");
            }

            double answer = Math.Pow((double)number, 1 / (double)potency);

            return answer;
        }
    }
}
