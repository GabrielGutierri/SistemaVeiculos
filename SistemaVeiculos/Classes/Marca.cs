using SistemaVeiculos.Classes.ClassesEstaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes
{
    public class Marca
    {
        private int _codigo;
        private string _descricao;
        public int Codigo
        {
            get => _codigo;
            set
            {
                if (value <= 0)
                    throw new Exception("código deve ser maior que zero.");
                if (!AuxiliarModelo.VerificaCodigoMarca(value))
                    throw new Exception("código dessa marca já existe");
                _codigo = value;
            }
        }

        public string Descricao
        {
            get => _descricao;
            set
            {
                if (!AuxiliarConversoes.VerificaString(value))
                    throw new Exception("Descricao obrigatória.");
                if (!AuxiliarModelo.ProcuraMarca(value))
                {
                    throw new Exception("Essa marca já existe");
                }
                _descricao = value;
            }
        }

        public Marca(string descricao, int codigo)
        {
            Codigo = codigo;
            Descricao = descricao;
            //MetodosAuxiliares.listaMarcas.Add(this);
        }
    }
}
