using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class NavioGuerra : Navio, IVeiculoGuerra
    {
        public NavioGuerra(string identificacao, Modelo modelo, int capacidadePassageiro) : base(identificacao, modelo, capacidadePassageiro)
        {

        }

        public string Atacar()
        {
            return $"O navio {Identificacao} atacou";
        }
    }
}
