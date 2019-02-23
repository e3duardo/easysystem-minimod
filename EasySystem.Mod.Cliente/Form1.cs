using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using EasySystem.Mod.Shared.Interface;
using EasySystem.Mod.Cliente.Repositories;
using EasySystem.Mod.Cliente.Domain;
using EasySystem.Mod.Shared.Domain;
using EasySystem.Mod.Shared.Repositories;
using System.Windows.Forms;

namespace EasySystem.Mod.Cliente
{
    public partial class Form1 : Form, IFormBase
    {
        private IClientePessoaFisicaRepository repository;
        private IConfiguracaoRepository cfgrepository;
        private Configuracao Configuracao;

        public bool IsCollapsed { get; set; }
        public bool IsAddingOrEditing { get; set; }

        public ClientePessoaFisica Cliente { get; set; }


        public Form1()
        {
            InitializeComponent();

            cfgrepository = new ConfiguracaoRepository();
            repository = new ClientePessoaFisicaRepository();
            ICollection<Configuracao> cfg = cfgrepository.GetAll();
            Configuracao = cfg.First();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsAddingOrEditing)
            {
                ICollection<ClientePessoaFisica> cpf = new List<ClientePessoaFisica>();
                cpf.Add(Cliente);

                splitContainer1.Panel2Collapsed = IsCollapsed;
                if (IsCollapsed)
                    this.Width -= 200;

                clientePessoaFisicaView1.SetCliente(Cliente);

                this.clientePessoaFisicaView1.ReadOnly = true;

                MenuEnable(false, false, true, true, false);
            }
            else
            {
                dataGridView1.AutoGenerateColumns = false;

                IsCollapsed = !Configuracao.ClienteFormularioMostrarFiltros;

                splitContainer1.Panel2Collapsed = IsCollapsed;
                if (IsCollapsed)
                    this.Width -= 200;

                //atualiza formulario
                Atualizar();
            }
        }



        //funcoes IFormBase
        public void Atualizar()
        {
            if (!IsCollapsed)
            {
                //get all clientes
                var fromDb = repository.GetAll();

                //guardando id selecionado
                long idSelecionado = 0;
                if (this.dataGridView1.SelectedRows.Count >= 1)
                    idSelecionado = (long)this.dataGridView1.SelectedRows[0].Cells[0].Value;

                //atualizando grid
                this.dataGridView1.DataSource = fromDb;
                this.label6.Text = string.Format("{0} linhas.", fromDb.Count);

                //selecionando id previamente selecionado
                if (idSelecionado > 0)
                    foreach (DataGridViewRow t in dataGridView1.Rows)
                    {
                        if ((long)t.Cells[0].Value == idSelecionado)
                        {
                            t.Selected = true;
                            break;
                        }
                    }
            }

            //desabilitando edicao
            this.clientePessoaFisicaView1.ReadOnly = false;

            //desabilitando menu
            MenuEnable(true, true, false, false, true);

            //colorindo grid
            this.dataGridView1.DefaultCellStyle.BackColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
        }
        public void MenuEnable(bool novo, bool editar, bool cancelar, bool salvar, bool excluir)
        {
            IsAddingOrEditing = false;

            this.buttonNovo.Enabled = novo;
            this.buttonEditar.Enabled = editar;
            this.buttonCancelar.Enabled = cancelar;
            this.buttonSalvar.Enabled = salvar;
            this.buttonExcluir.Enabled = excluir;

            if (!novo | !editar)
            {
                timer1.Start();
                clientePessoaFisicaView1.Controls["textBoxNome"].Select();
                IsAddingOrEditing = true;
            }
            else
                timer1.Stop();

            if (IsCollapsed)
                this.buttonEditar.Enabled = false;
        }




        //acoes
        #region buttons
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            this.clientePessoaFisicaView1.ReadOnly = true;
            this.clientePessoaFisicaView1.Clean();

            MenuEnable(false, false, true, true, false);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            this.dataGridView1.SelectedRows[0].DefaultCellStyle.SelectionBackColor = Color.DarkSlateGray;

            this.clientePessoaFisicaView1.ReadOnly = true;

            MenuEnable(false, false, true, true, false);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            ClientePessoaFisica cliente = clientePessoaFisicaView1.GetCliente();

            ICollection<Configuracao> cfg = cfgrepository.GetAll();
            Configuracao = cfg.First();

            bool salva = true;

            if (Configuracao.ClienteFormularioPermitirCadastroComCpfDuplicado)
            {
                if (repository.GetByCpf(cliente.Cpf).Count > 0)
                {
                    if (MessageBox.Show("O CPF informado já esta cadastrado! Deseja cadastra-lo novamente?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                        salva = false;
                }
            }
            else
            {
                if (repository.GetByCpf(cliente.Cpf).Count > 0)
                {
                    MessageBox.Show("O CPF informado já esta cadastrado!", "Atenção", MessageBoxButtons.OK);
                    salva = false;
                }
            }

            if (salva)
                this.Salvar();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        #endregion

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (buttonNovo.Enabled | buttonEditar.Enabled)
            {
                if (e.RowIndex > -1)
                {
                    long id = (long)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    ClientePessoaFisica cpf = repository.GetById(id);
                    clientePessoaFisicaView1.SetCliente(cpf);
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonEditar.PerformClick();
        }

        private void textBoxFiltroNome_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxFiltroCpf.Text = "";

            long id = 0;
            long.TryParse(textBoxFiltroNome.Text, out id);

            List<ClientePessoaFisica> list = new List<ClientePessoaFisica>();

            //se for por codigo
            if (id > 0)
            {
                list.Add(repository.GetById(id));
            }
            //se for por nome
            else
            {
                if (textBoxFiltroNome.Text == "")
                    list = (List<ClientePessoaFisica>)repository.GetAll();
                else
                    list = (List<ClientePessoaFisica>)repository.GetByNome(textBoxFiltroNome.Text);
            }

            dataGridView1.DataSource = list;
        }

        private void textBoxFiltroCpf_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxFiltroNome.Text = "";

            List<ClientePessoaFisica> list = new List<ClientePessoaFisica>();

            if (textBoxFiltroCpf.Text == "")
                list = (List<ClientePessoaFisica>)repository.GetAll();
            else
                list = (List<ClientePessoaFisica>)repository.GetByCpf(textBoxFiltroCpf.Text);

            dataGridView1.DataSource = list;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = clientePessoaFisicaView1.TabTip;
        }

        EasySystem.Windows.Forms.MessageBoxAll mba;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.IsAddingOrEditing)
            {
                if (Configuracao.ClienteFormularioSalvarAutomaticamenteAoSair)
                    this.buttonSalvar.PerformClick();
                else
                {
                    mba = new EasySystem.Windows.Forms.MessageBoxAll();
                    mba.button1.Text = "Não";
                    mba.button1.Click += new EventHandler(button1_Click);
                    mba.button2.Text = "Sim para todos";
                    mba.button2.Click += new EventHandler(button2_Click);
                    mba.button3.Text = "Sim";
                    mba.button3.Click += new EventHandler(button3_Click);
                    mba.Message.Text = "Deseja salvar antes de sair?\n\nSim para todos salva uma configuração para sempre salvar quando você estiver editando um cliente.";
                    mba.Text = "Atenção";

                    mba.ShowDialog(this);
                }
            }
        }
        void button1_Click(object sender, EventArgs e)
        {
            mba.Close();
        }
        void button2_Click(object sender, EventArgs e)
        {
            this.Configuracao.ClienteFormularioSalvarAutomaticamenteAoSair = true;
            cfgrepository.Update(Configuracao);

            buttonSalvar.PerformClick();
            mba.Close();
        }
        void button3_Click(object sender, EventArgs e)
        {
            buttonSalvar.PerformClick();
            mba.Close();
        }

        public void Salvar()
        {
            ClientePessoaFisica cliente = clientePessoaFisicaView1.GetCliente();

            if (cliente.Id == 0)
                repository.Add(cliente);
            else
                repository.Update(cliente);

            Atualizar();
        }
    }
}
