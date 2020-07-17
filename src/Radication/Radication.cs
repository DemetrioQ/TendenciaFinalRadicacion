using System;

namespace Radication
{
    public class Radicacion
    {
        public Radicacion()
        {

        }

        public double DoRadicacion(string number_s, string potency_s)
        {
            double number;
            double potency;
            bool valid_number = double.TryParse(number_s, out number);
            bool valid_potency = double.TryParse(potency_s, out potency);

            if (!valid_number)
            {
                throw new ArgumentException("Invalid number");
            }

            if (!valid_potency)
            {
                throw new ArgumentException("Invalid potency");
            }


            if (potency == 0)
            {
                throw new ArgumentException("0 no puede ser una potencia para una raiz");
            }
            if (potency % 2 == 0 && number < 0)
            {
                throw new ArgumentException("No puede tener como potencia u nnumero par y sacarle la raiz a un numero positivo");
            }

            double answer = Math.Pow(number, (double)1 / potency);
            string s = answer.ToString();
            if (s.Contains("e") || s.Contains("E"))
            {
                throw new ArgumentException("Numbers are too big");
            }
            return answer;
        }
    }
}
