using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasySystem.Mod.Shared.Domain;
using EasySystem.Mod.Shared.Repositories;

namespace EasySystem.Mod.Shared.Views
{
    public partial class CfgCliente : UserControl
    {
        private IConfiguracaoRepository repository;
        public Configuracao Configuracao { get; set; }

        public CfgCliente()
        {
            InitializeComponent();


        }

        private void CfgCliente_Load(object sender, EventArgs e)
        {
            repository = new ConfiguracaoRepository();
            ICollection<Configuracao> cfg = repository.GetAll();

            if (cfg.Count > 0)
                Configuracao = cfg.First();
            else
                Configuracao = new Configuracao();

            checkBox1.DataBindings.Add("Checked", Configuracao, "ClienteFormularioMostrarFiltros");
            checkBox2.DataBindings.Add("Checked", Configuracao, "ClienteFormularioSalvarAutomaticamenteAoSair");
            checkBox3.DataBindings.Add("Checked", Configuracao, "ClienteFormularioSalvarArquivoEnquandoCadastra");
            textBox1.DataBindings.Add("Text", Configuracao, "ClienteFormularioLocalArquivoEnquantoCadastra");
            checkBox4.DataBindings.Add("Checked", Configuracao, "ClienteFormularioPermitirCadastroComCpfDuplicado");
        }



        public void Save()
        {

            if (Configuracao.Id != 0)
            {
                Configuracao.Sys_DataModificado = DateTime.Today;
                repository.Update(Configuracao);
            }
            else
            {
                Configuracao.Sys_Ativo = true;
                Configuracao.Sys_Ativo_Descricao = "Cadastrado";
                Configuracao.Sys_DataCadastro = DateTime.Today;
                Configuracao.Sys_DataModificado = DateTime.Today;

                repository.Add(Configuracao);
            }
        }




    }
}
