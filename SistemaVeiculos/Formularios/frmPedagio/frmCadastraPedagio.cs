using SistemaVeiculos.Classes;
using SistemaVeiculos.Classes.ClassesEstaticas;
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
    public partial class frmCadastraPedagio : Form
    {
        public frmCadastraPedagio()
        {
            InitializeComponent();
        }

        private void btnCadastraPedagio_Click(object sender, EventArgs e)
        {
            string identificacao = txtIdentificacao.Text;
            string localizacao = txtLocalizacao.Text;

            Pedagio novoPedagio = new Pedagio(identificacao, localizacao);
            ListasAuxiliares.listaPedagios.Add(novoPedagio);

            txtIdentificacao.Clear();
            txtLocalizacao.Clear();
        }
    }
}
