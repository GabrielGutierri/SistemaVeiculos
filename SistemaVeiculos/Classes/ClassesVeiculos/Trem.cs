using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Trem : Veiculos, ILimpador, IPassageiro
    {
        private int _qtdVagoes;
        private int _capacidadePassageiros;

        public int QuantidadeVagoes
        {
            get => _qtdVagoes;
            set
            {
                if (value < 1)
                    throw new Exception("Trem deve ter no mínimo 1 vagão");
                _qtdVagoes = value;
            }
        }
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiros;
            set
            {
                if (value <= 0)
                    throw new Exception("Trem deve ter mais que 1 passageiro.");
                _capacidadePassageiros = value;
            }
        }
        public bool LimpadorLigado { get; set; }

        public Trem(string identificacao, Modelo modelo, int quantidadeVagoes, int capacidadePassageiros) : base(identificacao, modelo)
        {
            CapacidadePassageiros = capacidadePassageiros;
            QuantidadeVagoes = quantidadeVagoes;
        }

        public string LigaDesligaLimpador()
        {
            if (LimpadorLigado)
            {
                LimpadorLigado = false;
                return $"Limpador do veículo {Identificacao} desligado.";
            }
            else
            {
                LimpadorLigado = true;
                return $"Limpador do veículo {Identificacao} ligado.";
            }
        }
    }
}
