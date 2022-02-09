using SistemaVeiculos.Classes;
using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Classes.ClassesVeiculos;
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

namespace SistemaVeiculos.Formularios.frmVeiculos
{
    public partial class frmCadastroVeiculos : Form
    {
        public frmCadastroVeiculos()
        {
            InitializeComponent();
            cbTipo.DataSource = Enum.GetValues(typeof(EnumVeiculos));
            gpCarro.Visible = true;
            List<Modelo> listaModelosCarro = new List<Modelo>();
            AdicionaModelos(listaModelosCarro, cbModeloCarro);
            cbTipo.SelectedIndex = 0;
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is GroupBox)
                    c.Visible = false;
            }

            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    gpCarro.Visible = true;
                    List<Modelo> listaModelosCarro = new List<Modelo>();
                    AdicionaModelos(listaModelosCarro, cbModeloCarro);
                    break;
                case 1:
                    gpMoto.Visible = true;
                    List<Modelo> listaModelosMoto = new List<Modelo>();
                    AdicionaModelos(listaModelosMoto, cbModeloMoto);
                    break;
                case 2:
                    gpCaminhao.Visible = true;
                    List<Modelo> listaModelosCaminhao = new List<Modelo>();
                    AdicionaModelos(listaModelosCaminhao, cbModeloCaminhao);
                    break;
                case 3:
                    gpOnibus.Visible = true;
                    List<Modelo> listaModelosOnibus = new List<Modelo>();
                    AdicionaModelos(listaModelosOnibus, cbOnibus);
                    break;
                case 4:
                    gpTrem.Visible = true;
                    List<Modelo> listaModelosTrem = new List<Modelo>();
                    AdicionaModelos(listaModelosTrem, cbModeloTrem);
                    break;
                case 5:
                    gpAviao.Visible = true;
                    List<Modelo> listaModelosAviao = new List<Modelo>();
                    AdicionaModelos(listaModelosAviao, cbModeloAviao);
                    break;
                case 6:
                    gpAviaoGuerra.Visible = true;
                    List<Modelo> listaModelosAG = new List<Modelo>();
                    AdicionaModelos(listaModelosAG, cbModeloAviaoGuerra);
                    break;
                case 7:
                    gpNavio.Visible = true;
                    List<Modelo> listaModelosNavio = new List<Modelo>();
                    AdicionaModelos(listaModelosNavio, cbModeloNavio);
                    break;
                case 8:
                    gpNavioGuerra.Visible = true;
                    List<Modelo> listaModelosNavioGuerra = new List<Modelo>();
                    AdicionaModelos(listaModelosNavioGuerra, cbNavioGuerra);
                    break;
                default:
                    break;
            }
        }

        private void AdicionaModelos(List<Modelo> lista, ComboBox cb)
        {
            foreach (var item in ListasAuxiliares.listaModelos)
            {
                if (item.Tipo == (EnumVeiculos)cbTipo.SelectedIndex)
                {
                    lista.Add(item);
                }
            }
            cb.DataSource = lista;
            cb.DisplayMember = "Descricao";
        }

        private void btnCadastraCarro_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtPlacaCarro, "placa", "carro")
                    && VerificaCampoPlaca(txtPlacaCarro, "placa", "carro")
                    && VerificaCampoInt(txtPortasCarro, "portas", "carro")
                    && VerificaPassageiros())
                {
                    string idCarro = txtPlacaCarro.Text;
                    int portas = Convert.ToInt32(txtPortasCarro.Text);
                    Carro novoCarro = new Carro(idCarro, cbModeloCarro.SelectedItem as Modelo, Convert.ToInt32(txtQtdPassageiros.Text), portas);
                    ListasAuxiliares.listaVeiculos.Add(novoCarro);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frmCadastroVeiculos_Load(object sender, EventArgs e)
        {

        }

        private bool VerificaPassageiros()
        {
            if (!AuxiliarConversoes.VerificaInt(txtQtdPassageiros.Text))
            {
                throw new Exception("Quantidade de passageiros deve ser um número inteiro");
            }
            return true;
        }

        private void btnCadastraAviao_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtIdentificacaoAviao, "identificação", "avião") && VerificaPassageiros()) {
                    string idAviao = txtIdentificacaoAviao.Text;
                    Aviao novoAviao = new Aviao(idAviao, Convert.ToInt32(txtQtdPassageiros.Text), cbModeloAviao.SelectedItem as Modelo);
                    ListasAuxiliares.listaVeiculos.Add(novoAviao);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool VerificaCampoString(Control c, string campo, string tipo)
        {
            if (!AuxiliarConversoes.VerificaString(c.Text))
                throw new Exception($"Campo de {campo} do {tipo} obrigatório");
            return true;
        }

        private bool VerificaCampoInt(Control c, string campo, string tipo)
        {
            if (!AuxiliarConversoes.VerificaInt(c.Text))
                throw new Exception($"Campo de {campo} do {tipo} obrigatório");
            return true;
        }

        private bool VerificaCampoDouble(Control c, string campo, string tipo)
        {
            if (!AuxiliarConversoes.VerificaDouble(c.Text))
                throw new Exception($"Campo de {campo} do {tipo} obrigatório");
            return true;
        }

        private bool VerificaCampoPlaca(Control c, string campo, string tipo)
        {
            if(!AuxiliarConversoes.VerificaPlaca(c.Text))
                throw new Exception($"Campo de {campo} do {tipo} com o formato incorreto.");
            return true;
        }

        private void btnCadastraCaminhao_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtPlacaCaminhao, "placa", "caminhão")
                    && VerificaCampoPlaca(txtPlacaCaminhao, "placa", "caminhão")
                    &&VerificaCampoInt(txtEixoCaminhao, "eixos", "caminhão")
                    && VerificaCampoDouble(txtCargaCaminhao, "carga", "caminhão")
                    && VerificaPassageiros())
                {
                    string idCaminhao = txtPlacaCaminhao.Text;
                    int eixos = Convert.ToInt32(txtEixoCaminhao.Text);
                    double carga = Convert.ToDouble(txtCargaCaminhao.Text);
                    Caminhao novoCaminhao = new Caminhao(idCaminhao, cbModeloCaminhao.SelectedItem as Modelo, eixos, carga, Convert.ToInt32(txtQtdPassageiros.Text));
                    ListasAuxiliares.listaVeiculos.Add(novoCaminhao);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastraMoto_Click(object sender, EventArgs e)
        {
             try
            {
                if (VerificaCampoString(txtPlacaMoto, "placa", "moto")
                    && VerificaCampoPlaca(txtPlacaMoto, "placa", "moto")
                    && VerificaPassageiros())
                {
                    string idMoto = txtPlacaCarro.Text;
                    Moto novaMoto = new Moto(idMoto, cbModeloMoto.SelectedItem as Modelo, Convert.ToInt32(txtQtdPassageiros.Text));
                    ListasAuxiliares.listaVeiculos.Add(novaMoto);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastrarAviaoGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtIdentificacaoAviaoGuerra, "identificação", "avião de guerra") && VerificaPassageiros())
                {
                    string idAviao = txtIdentificacaoAviaoGuerra.Text;
                    AviaoGuerra novoAviao = new AviaoGuerra(idAviao, Convert.ToInt32(txtQtdPassageiros.Text), cbModeloAviaoGuerra.SelectedItem as Modelo);
                    ListasAuxiliares.listaVeiculos.Add(novoAviao);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastrarNavio_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtIdentificacaoNavio, "identificação", "navio") && VerificaPassageiros())
                {
                    string idNavio = txtIdentificacaoNavio.Text;
                    Navio novoNavio = new Navio(idNavio, cbModeloNavio.SelectedItem as Modelo, Convert.ToInt32(txtQtdPassageiros.Text));
                    ListasAuxiliares.listaVeiculos.Add(novoNavio);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastrarNavioGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtIdentificacaoNavioGuerra, "identificação", "navio de gurra") && VerificaPassageiros())
                {
                    string idNavio = txtIdentificacaoNavio.Text;
                    NavioGuerra novoNavio = new NavioGuerra(idNavio, cbNavioGuerra.SelectedItem as Modelo, Convert.ToInt32(txtQtdPassageiros.Text));
                    ListasAuxiliares.listaVeiculos.Add(novoNavio);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastrarOnibus_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtPlacaOnibus, "placa", "ônibus")
                    && VerificaCampoPlaca(txtPlacaOnibus, "placa", "ônibus")
                    && VerificaCampoInt(txtEixosOnibus, "eixos", "ônibus")
                    && VerificaPassageiros())
                {
                    string idOnibus = txtPlacaOnibus.Text;
                    int eixos = Convert.ToInt32(txtEixoCaminhao.Text);

                    bool leito = cbxLeito.Checked ? true : false;
                    Onibus novoOnibus = new Onibus(idOnibus, cbOnibus.SelectedItem as Modelo, eixos, leito, Convert.ToInt32(txtQtdPassageiros.Text));
                    ListasAuxiliares.listaVeiculos.Add(novoOnibus);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCadastrarTrem_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCampoString(txtIdentificacaoTrem, "identificação", "trem")
                    && VerificaCampoInt(txtVagoes, "vagões", "trem")
                    && VerificaPassageiros())
                {
                    string idTrem = txtIdentificacaoTrem.Text;
                    int vagoes = Convert.ToInt32(txtEixoCaminhao.Text);

                    Trem novoTrem = new Trem(idTrem, cbModeloTrem.SelectedItem as Modelo, vagoes, Convert.ToInt32(txtQtdPassageiros.Text));
                    ListasAuxiliares.listaVeiculos.Add(novoTrem);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
