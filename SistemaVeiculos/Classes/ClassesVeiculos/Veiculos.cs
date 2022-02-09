using SistemaVeiculos.Classes.ClassesEstaticas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public abstract class Veiculos
    {
        private string _identificacao;
        public string Identificacao
        {
            get => _identificacao;
            set
            {
                if (!AuxiliarConversoes.VerificaString(value))
                    throw new Exception("Identificação obrigatória.");
                if (!AuxiliarVeiculo.ProcuraIdentificacao(value))
                    throw new Exception("Essa identificação já existe.");
                _identificacao = value;
            }
        }

        public Modelo Modelo { get; private set; }

        private int _velocidade;
        public int VelocidadeAtual
        {
            get => _velocidade;
            protected set
            {
                if (value < 0)
                    throw new Exception("A velocidade não pode ser negativa.");
                _velocidade = value;
            }
        }

        public Veiculos(string identificacao, Modelo modelo)
        {
            VelocidadeAtual = 0;
            Modelo = modelo;
            Identificacao = identificacao;
            //MetodosAuxiliares.listaVeiculos.Add(this);
        }

        public virtual void Acelera()
        {
            VelocidadeAtual++;
        }

        public virtual void Desacelera()
        {
            VelocidadeAtual--;
        }
    }
}
