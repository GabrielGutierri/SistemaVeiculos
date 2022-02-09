using SistemaVeiculos.Classes;
using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Classes.ClassesVeiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeiculos.Formularios.frmPedagio
{
    public partial class frmAcoesPedagio : Form
    {
        public frmAcoesPedagio()
        {
            InitializeComponent();
            ListasAuxiliares.listaPedagios.Add(new Pedagio("Rodoanel", "SP"));
            ListasAuxiliares.listaPedagios.Add(new Pedagio("Ecovias", "RJ"));
            cbPedagios.DataSource = ListasAuxiliares.listaPedagios;
            cbPedagios.DisplayMember = "Identificacao";

            cbVeiculos.DataSource = ListasAuxiliares.listaVeiculos;
            cbVeiculos.DisplayMember = "Identificacao";
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            Pedagio pedagio = ListasAuxiliares.listaPedagios.Find(x => x.Identificacao == Convert.ToString(cbPedagios.SelectedItem));
            Veiculos v = cbVeiculos.SelectedItem as Veiculos;
            Veiculos veiculo = ListasAuxiliares.listaVeiculos.Find(y => y.Identificacao == v.Identificacao);
            pedagio.Receber(veiculo as Interfaces.IPagaPedagio);
        }

        private void btnVerTodosPedagios_Click(object sender, EventArgs e)
        {
            foreach (var c in ListasAuxiliares.listaPedagios)
            {
                txtVisualizaPedagios.Text += $"Identificação: {c.Identificacao} - Localização: {c.Localizacao} - Valor Acumulado: {c.ValorAcumulado}";
            }
        }
    }
}
