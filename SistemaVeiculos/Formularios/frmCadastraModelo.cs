using SistemaVeiculos.Classes;
using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Enumeradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeiculos.Formularios
{
    public partial class frmCadastraModelo : Form
    {
        public frmCadastraModelo()
        {
            InitializeComponent();
            cbMarca.DataSource = ListasAuxiliares.listaMarcas;
            cbMarca.DisplayMember = "Descricao";
            cbMarca.SelectedIndex = 0;

            cbTipo.DataSource = Enum.GetValues(typeof(EnumVeiculos));
            cbTipo.SelectedIndex = 0;
        }

        private void btnCadastraModelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AuxiliarConversoes.VerificaInt(txtCodigoModelo.Text))
                    throw new Exception("Código do modelo deve ser um número inteiro");
                int codigo = Convert.ToInt32(txtCodigoModelo.Text);
                string descricao = txtDescricaoModelo.Text;

                Modelo novoModelo = new Modelo(descricao, cbMarca.SelectedItem as Marca, (EnumVeiculos)cbTipo.SelectedIndex, codigo);
                ListasAuxiliares.listaModelos.Add(novoModelo);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
