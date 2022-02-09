using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Onibus : VeiculoComEixos, IPagaPedagio, IPassageiro
    {
        private int _capacidadePassageiros;
        public bool Leito { get; private set; }
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiros;
            set
            {
                if (value < 10 || value > 60)
                {
                    throw new Exception("Um onibus deve ter entre 10 e 60 passageiros.");
                }
                _capacidadePassageiros = value;
            }
        }

        public Onibus(string identificacao, Modelo modelo, int qtdEixos, bool leito, int capacidadePassageiros) : base(identificacao, modelo, qtdEixos)
        {
            CapacidadePassageiros = capacidadePassageiros;
            Leito = leito;
        }

        public double PagaPedagio()
        {
            return 8.5 * QuantidadeEixos;
        }
    }
}
