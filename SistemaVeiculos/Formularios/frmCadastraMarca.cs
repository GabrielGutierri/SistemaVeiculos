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

namespace SistemaVeiculos.Formularios
{
    public partial class frmCadastraMarca : Form
    {
        public frmCadastraMarca()
        {
            InitializeComponent();
        }

        private void btnCadastraMarca_Click(object sender, EventArgs e)
        {
            try
            {
                if (!AuxiliarConversoes.VerificaInt(txtCodigoMarca.Text))
                    throw new Exception("Código deve ser um número inteiro.");

                int codigo = Convert.ToInt32(txtCodigoMarca.Text);
                string descricao = txtDescricaoMarca.Text;
                Marca novaMarca = new Marca(descricao, codigo);

                ListasAuxiliares.listaMarcas.Add(novaMarca);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        

        private void frmCadastraMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
