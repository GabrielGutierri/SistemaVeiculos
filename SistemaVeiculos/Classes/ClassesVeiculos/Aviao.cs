using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Aviao : AviaoBase, ILimpador, IPassageiro
    {
        public bool LimpadorLigado { get; set; }
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

        public Aviao(string identificacao, int capacidadePasageiros, Modelo modelo) : base(identificacao, modelo)
        {
            CapacidadePassageiros = capacidadePasageiros;
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
