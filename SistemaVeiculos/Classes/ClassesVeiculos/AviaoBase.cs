using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Classes.ClassesVeiculos
{
    public abstract class AviaoBase : Veiculos
    {
        public bool Voando { get; private set; }

        public AviaoBase(string identificacao, Modelo modelo) : base(identificacao, modelo)
        {

        }

        public string Pousar()
        {
            if (Voando)
            {
                Voando = false;
                return $"O avião {Identificacao} pousou";
            }
            else
            {
                return $"O avião {Identificacao} já está pousado";
            }
        }

        public string Arremeter()
        {
            return $"O avião {Identificacao} arremeteu.";
        }

        public string Decolar()
        {
            if (!Voando)
            {
                Voando = true;
                return $"O avião {Identificacao} decolou";
            }
            else
            {
                return $"O avião {Identificacao} já está voando.";
            }
        }
    }
}
