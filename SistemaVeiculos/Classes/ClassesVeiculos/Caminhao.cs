using SistemaVeiculos.Exceptions;
using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public class Caminhao : VeiculoComEixos, IPassageiro, IPagaPedagio
    {
        private double _pesoCarregado = 0;
        public double PesoCarregado
        {
            get => _pesoCarregado;
            private set
            {
                if (value + PesoCarregado > CargaMaxima)
                {
                    try
                    {
                        VelocidadeAtual = -1;
                    }
                    catch
                    {
                        throw new CapacidadeMaximaException();
                    }
                }
                if (value < 0)
                    throw new Exception("não se pode carregar uma carga negativa");
                _pesoCarregado += value;
            }
        }


        private double _cargaMaxima;
        public double CargaMaxima
        {
            get => _cargaMaxima;
            private set
            {
                if (value <= 0)
                    throw new Exception("Carga máxima não pode ser negativa");
                _cargaMaxima = value;
            }
        }
        private int _capacidadePassageiros;
        public int CapacidadePassageiros
        {
            get => _capacidadePassageiros;
            set
            {
                if (value > 3 || value < 1)
                    throw new Exception("Um caminhão deve ter no máximo 3 passageiros");
                _capacidadePassageiros = value;
            }
        }

        public Caminhao(string identificacao, Modelo modelo, int qtdEixos, double cargaMaxima, int capacidadePassageiros) : base(identificacao, modelo, qtdEixos)
        {
            PesoCarregado = 0;
            CargaMaxima = cargaMaxima;
            CapacidadePassageiros = capacidadePassageiros;
        }

        public double PagaPedagio()
        {
            return 8.5 * QuantidadeEixos;
        }

        public void Carregar(double peso)
        {
            PesoCarregado += peso;
        }

        public void Descarregar()
        {
            PesoCarregado = 0;
        }

    }
}
