using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Exceptions
{
    public class CapacidadeMaximaException: Exception
    {
        public CapacidadeMaximaException(double pesoExcedido)
            : base("Capacidade excedida em " + pesoExcedido + " kg")
        {

        }

        public CapacidadeMaximaException()
            : base("O veículo está sobrecarregado e não pode acelerar.")
        {

        }
    }
}
