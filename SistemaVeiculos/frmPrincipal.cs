using SistemaVeiculos.Classes;
using SistemaVeiculos.Classes.ClassesEstaticas;
using SistemaVeiculos.Classes.ClassesVeiculos;
using SistemaVeiculos.Enumeradores;
using SistemaVeiculos.Formularios;
using SistemaVeiculos.Formularios.frmPedagio;
using SistemaVeiculos.Formularios.frmVeiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeiculos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarVeiculos_Click(object sender, EventArgs e)
        {
            frmCadastroVeiculos f = new frmCadastroVeiculos();
            f.Show();
        }

        private void btnCadastrarPedagio_Click(object sender, EventArgs e)
        {
            frmCadastraPedagio f = new frmCadastraPedagio();
            f.Show();
        }

        private void btnAcoesPedagio_Click(object sender, EventArgs e)
        {
            frmAcoesPedagio f = new frmAcoesPedagio();
            f.Show();
        }

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            frmCadastraMarca f = new frmCadastraMarca();
            f.Show();
        }

        private void btnCadastrarModelo_Click(object sender, EventArgs e)
        {
            frmCadastraModelo f = new frmCadastraModelo();
            f.Show();
        }

        private void btnInstanciarVeiculos_Click(object sender, EventArgs e)
        {
            //Marcas
            Marca volks = new Marca("VolksWagen", 001);
            Marca mercedes = new Marca("Mercedes", 002);
            Marca honda = new Marca("Honda", 003);
            Marca msc = new Marca("MSC", 004);
            Marca iate = new Marca("Iate", 005);
            Marca embraer = new Marca("Embraer", 006);
            Marca army = new Marca("Army", 007);
            Marca hogwartsExpress = new Marca("Expresso Hogwarts", 008);
            Marca bus = new Marca("Bus", 009);

            ListasAuxiliares.listaMarcas.Add(volks);
            ListasAuxiliares.listaMarcas.Add(mercedes);
            ListasAuxiliares.listaMarcas.Add(honda);
            ListasAuxiliares.listaMarcas.Add(msc);
            ListasAuxiliares.listaMarcas.Add(iate);
            ListasAuxiliares.listaMarcas.Add(embraer);
            ListasAuxiliares.listaMarcas.Add(army);
            ListasAuxiliares.listaMarcas.Add(hogwartsExpress);
            ListasAuxiliares.listaMarcas.Add(bus);
            //Modelos
            Modelo amg = new Modelo("AMG", mercedes, EnumVeiculos.Carro, 001);
            Modelo truck = new Modelo("Truck", volks, EnumVeiculos.Caminhao, 002);
            Modelo byke = new Modelo("Byke", honda, EnumVeiculos.Moto, 003);
            Modelo cruzeiro = new Modelo("Cruzeiro", msc, EnumVeiculos.Navio, 004);
            Modelo fancy = new Modelo("Fancy", iate, EnumVeiculos.Navio_de_Guerra, 005);
            Modelo killer = new Modelo("Killers", army, EnumVeiculos.Aviao_de_Guerra, 006);
            Modelo boeing = new Modelo("Boeing", embraer, EnumVeiculos.Aviao, 007);
            Modelo expresso = new Modelo("Trem para Hogwarts", hogwartsExpress, EnumVeiculos.Trem, 008);
            Modelo onibus = new Modelo("Onibus", bus, EnumVeiculos.Onibus, 009);

            ListasAuxiliares.listaModelos.Add(amg);
            ListasAuxiliares.listaModelos.Add(truck);
            ListasAuxiliares.listaModelos.Add(byke);
            ListasAuxiliares.listaModelos.Add(cruzeiro);
            ListasAuxiliares.listaModelos.Add(fancy);
            ListasAuxiliares.listaModelos.Add(killer);
            ListasAuxiliares.listaModelos.Add(boeing);
            ListasAuxiliares.listaModelos.Add(expresso);
            ListasAuxiliares.listaModelos.Add(onibus);
            //Veiculos
            Carro carro = new Carro("BBB-2222", amg, 4, 4);
            Caminhao caminhao = new Caminhao("AAA-1111", truck, 2, 2000, 2);
            Moto moto = new Moto("CCC-3333", byke, 2);
            Navio navio = new Navio("DDD-4444", cruzeiro, 1000);
            NavioGuerra navioGuerra = new NavioGuerra("EEE-5555", fancy, 3);
            AviaoGuerra aviaoGuerra = new AviaoGuerra("FFF-6666", 2, killer);
            Aviao aviao = new Aviao("GGG-7777", 300, boeing);
            Trem trem = new Trem("HHH-8888", expresso, 100, 2000);
            Onibus school = new Onibus("III-9999", onibus, 3, true, 100);

            ListasAuxiliares.listaVeiculos.Add(carro);
            ListasAuxiliares.listaVeiculos.Add(caminhao);
            ListasAuxiliares.listaVeiculos.Add(moto);
            ListasAuxiliares.listaVeiculos.Add(navio);
            ListasAuxiliares.listaVeiculos.Add(navioGuerra);
            ListasAuxiliares.listaVeiculos.Add(aviaoGuerra);
            ListasAuxiliares.listaVeiculos.Add(aviao);
            ListasAuxiliares.listaVeiculos.Add(trem);
            ListasAuxiliares.listaVeiculos.Add(school);

            btnAcoesVeiculo.Enabled = false;
        }
    }
}
