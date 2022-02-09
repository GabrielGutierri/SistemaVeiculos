using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Carro : Veiculos, IPassageiro, ILimpador, IPagaPedagio
    {
        private int _qtdPortas;
        private int _capacidadePassageiros;
        public int QuantidadePortas
        {
            get => _qtdPortas;
            set
            {
                if (value < 2 || value > 4)
                    throw new Exception("Número de portas deve ser maior que 1 e menor que 5.");
                _qtdPortas = value;
            }
        }
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiros;
            set
            {
                if (value < 1 || value > 10)
                    throw new Exception("Carro pode ter mais que 1 e no máximo 10 passageiros");
                _capacidadePassageiros = value;
            }
        }
        public bool LimpadorLigado { get; set; }

        public Carro(string identificacao, Modelo modelo, int capacidadePassageiros, int qtdPortas) : base(identificacao, modelo)
        {
            CapacidadePassageiros = capacidadePassageiros;
            QuantidadePortas = qtdPortas;
        }

        public double PagaPedagio()
        {
            return 7;
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
