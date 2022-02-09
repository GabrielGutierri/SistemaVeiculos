using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Moto : Veiculos, IPassageiro, IPagaPedagio
    {
        private int _capacidadePassageiros;
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiros;
            set
            {
                if (value != 2)
                    throw new Exception("Uma moto só tem capacidade para 2 passageiros");
                _capacidadePassageiros = value;
            }
        }
        public bool Empinando { get; private set; }

        public Moto(string identificacao, Modelo modelo, int capacidadePassageiros) : base(identificacao, modelo)
        {
            CapacidadePassageiros = capacidadePassageiros;
        }

        public string Empinar()
        {
            if (Empinando)
            {
                Empinando = false;
                return $"A moto {Identificacao} está empinando.";
            }
            else
            {
                Empinando = true;
                return $"A moto {Identificacao} não está empinando.";
            }
        }

        public double PagaPedagio()
        {
            return 3;
        }
    }
}
