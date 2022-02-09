using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public abstract class VeiculoComEixos : Veiculos, ILimpador
    {
        private int _eixos;

        public int QuantidadeEixos
        {
            get => _eixos;
            set
            {
                if (value < 2 || value > 3)
                {
                    throw new Exception("Veiculo com eixo deve ter 2 ou 3 eixos");
                }
                _eixos = value;
            }
        }
        public bool LimpadorLigado { get; set; }

        public VeiculoComEixos(string identificacao, Modelo modelo, int qtdEixos) : base(identificacao, modelo)
        {
            QuantidadeEixos = qtdEixos;
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
