using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeiculos.Classes.ClassesEstaticas
{
    public static class AuxiliarConversoes
    {
        public static bool VerificaPlaca(string placa)
        {
            Regex regex = new Regex(@"[A-Z]{3}-?[0-9]{4}");
            if (regex.IsMatch(placa))
                return true;
            return false;
        }

        public static bool VerificaString(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return false;
            return true;
        }

        public static bool VerificaDouble(string texto)
        {
            double d;
            bool c = double.TryParse(texto, out d);
            if (!c)
                return false;

            if (d < 0)
                return false;

            return true;

        }

        public static bool VerificaInt(string texto)
        {
            int i;
            bool c = int.TryParse(texto, out i);
            if (!c)
                return false;

            if (i < 0)
                return false;

            return true;
        }


        public static bool NumerosNegativo(int n)
        {
            if (n <= 0)
                return false;
            return true;
        }
    }
}
