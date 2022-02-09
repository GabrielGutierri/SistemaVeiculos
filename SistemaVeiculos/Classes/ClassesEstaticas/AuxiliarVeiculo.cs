using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesEstaticas
{
    public static class AuxiliarVeiculo
    {
        public static bool ProcuraIdentificacao(string identificacao)
        {
            foreach (var item in ListasAuxiliares.listaVeiculos)
            {
                if (item.Identificacao == identificacao)
                    return false;
            }
            return true;
        }

    }
}
