using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Navio : Veiculos, IPassageiro
    {
        public bool Atracado { get; private set; }

        private int _capacidadePassageiro;
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiro;
            set
            {
                if (value <= 0)
                    throw new Exception("número de passageiros deve ser maior do que zero.");
                _capacidadePassageiro = value;
            }
        }

        public Navio(string identificacao, Modelo modelo, int capacidadePassageiro) : base(identificacao, modelo)
        {
            CapacidadePassageiros = capacidadePassageiro;
        }

        public string Atracar()
        {
            if (Atracado)
            {
                Atracado = false;
                return $"O navio {Identificacao} atracou.";
            }
            else
            {
                Atracado = true;
                return $"O navio {Identificacao} desatracou";
            }
        }
    }
}
