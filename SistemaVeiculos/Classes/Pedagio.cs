using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes
{
    public class Pedagio
    {
        private double valorTotal = 0;
        private string _identificacao;
        private string _localizacao;

        public string Identificacao 
        {
            get => _identificacao;
            private set
            {
                if (!AuxiliarConversoes.VerificaString(value))
                    throw new Exception("campo de identificação obrigatório.");
                _identificacao = value;  
            } 
        }

        public string Localizacao 
        {
            get => _localizacao;
            private set
            {
                if (!AuxiliarConversoes.VerificaString(value))
                    throw new Exception("campo de localização obrigatório.");
                _localizacao = value;
            }
        }

        public double ValorAcumulado { get => valorTotal; }

        public Pedagio(string identificacao, string localizacao)
        {
            Identificacao = identificacao;
            Localizacao = localizacao;
        }

        public void Receber(IPagaPedagio objeto)
        {
            TotalPedagio(objeto.PagaPedagio());
        }

        public double TotalPedagio(double valor)
        {
            valorTotal += valor;
            return valorTotal;
        }

    }
}
