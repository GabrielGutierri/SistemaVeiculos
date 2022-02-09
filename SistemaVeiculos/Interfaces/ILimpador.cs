using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeiculos.Interfaces
{
    public interface ILimpador
    {
        bool LimpadorLigado { get; set; }
        string LigaDesligaLimpador();
    }
}
