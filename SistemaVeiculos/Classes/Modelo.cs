using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes
{
    public class Modelo
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
                if (!AuxiliarModelo.VerificaCodigoModelo(value))
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
                if (!AuxiliarModelo.ProcuraModelo(value))
                {
                    throw new Exception("esse modelo já existe.");
                }
                _descricao = value;
            }
        }
        public Marca Marca { get; private set; }
        public EnumVeiculos Tipo { get; private set; }

        public Modelo(string descricao, Marca marca, EnumVeiculos tipo, int codigo)
        {
            Codigo = codigo;
            Descricao = descricao;
            Marca = marca;
            Tipo = tipo;
            //MetodosAuxiliares.listaModelos.Add(this);
        }
    }
}
