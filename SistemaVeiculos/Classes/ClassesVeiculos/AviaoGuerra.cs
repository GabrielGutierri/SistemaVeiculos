using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class AviaoGuerra : AviaoBase, IPassageiro, IVeiculoGuerra
    {
        private int _capacidadePassageiros;
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiros;
            set
            {
                if (value > 2 || value < 1)
                    throw new Exception("Um avião de guerra deve ter no máximo 2 passageiros");
                _capacidadePassageiros = value;
            }
        }

        public bool Ejetado { get; private set; }

        public AviaoGuerra(string identificacao, int capacidadePassageiros, Modelo modelo) : base(identificacao, modelo)
        {
            CapacidadePassageiros = capacidadePassageiros;
        }
        public string Atacar()
        {
            if (!Ejetado)
                return $"O Avião {Identificacao} está atacando.";
            else
                return $"O aviao {Identificacao} não pode atacar pois já foi ejetado";
        }

        public string Ejetar()
        {
            if (!Ejetado)
            {
                Ejetado = true;
                return $"O avião {Identificacao} ejetou";
            }
            else
                return $"Mayday mayday... O aviao {Identificacao} já foi ejetado";
        }
    }
}
