using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesEstaticas
{
    public static class AuxiliarModelo
    {
        public static bool ProcuraMarca(string descricao)
        {
            foreach (var item in ListasAuxiliares.listaMarcas)
            {
                if (item.Descricao == descricao)
                    return false;
            }
            return true;
        }

        public static bool ProcuraModelo(string descricao)
        {
            foreach (var item in ListasAuxiliares.listaModelos)
            {
                if (item.Descricao == descricao)
                    return false;
            }
            return true;
        }

        public static bool VerificaCodigoModelo(int codigo)
        {
            Modelo model = ListasAuxiliares.listaModelos.Find(m => m.Codigo == codigo);
            if (model == null)
                return true;
            return false;
        }

        public static bool VerificaCodigoMarca(int codigo)
        {
            Marca marca = ListasAuxiliares.listaMarcas.Find(m => m.Codigo == codigo);
            if (marca == null)
                return true;
            return false;
        }
    }
}
