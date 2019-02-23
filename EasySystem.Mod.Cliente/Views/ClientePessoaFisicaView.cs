using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EasySystem.Mod.Cliente.Repositories;
using EasySystem.Mod.Cliente.Domain;
using EasySystem.Mod.Shared.Enum;

namespace EasySystem.Mod.Cliente.Views
{
    public partial class ClientePessoaFisicaView : UserControl
    {
        public string TabTip { get; set; }
        public string PrevTabTip { get; set; }

        private bool _ReadOnly;
        public bool ReadOnly
        {
            get
            {
                return this._ReadOnly;
            }
            set
            {
                this._ReadOnly = value;

                this.Enabled = this._ReadOnly;
            }
        }


        public ClientePessoaFisicaView()
        {
            InitializeComponent();
        }

        private void ClientePessoaFisicaView_Load(object sender, EventArgs e)
        {
            try
            {
                AddEvent();
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro" + ex);
            }
        }


        public void Clean()
        {
            textBoxCodigo.Text = "";
            numericUpDownVencimentoParcelamento.Value = 1;
            dateTimePickerNascimento.Value = new DateTime(1990, 1, 1);
            checkBoxAptoParcelamento.Checked = false;
            textBoxEstado.Text = "";
            textBoxLimiteParcelamento.Text = "";
            textBoxCelular.Text = "";
            textBoxObservacao.Text = "";
            textBoxCep.Text = "";
            textBoxSite.Text = "";
            textBoxTelefone.Text = "";
            textBoxEmail.Text = "";
            textBoxReferenciaComercial.Text = "";
            textBoxCpf.Text = "";
            textBoxCidade.Text = "";
            textBoxMaternidade.Text = "";
            textBoxNome.Text = "";
            textBoxRg.Text = "";
            textBoxBairro.Text = "";
            textBoxLogadouro.Text = "";
            textBoxPaternidade.Text = "";
            textBoxComplemento.Text = "";
            textBoxTelefones.Text = "";
            textBoxFax.Text = "";
            textBoxSobrenome.Text = "";
            textBoxRgUf.Text = "";
            textBoxRgOrgaoExpeditor.Text = "";
            textBoxRenda.Text = "";
            textBoxProfissao.Text = "";
            radioButtonSexoFeminino.Checked = false;
            radioButtonSexoMasculino.Checked = false;
        }

        public void AddEvent()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                //controls dentro de groupbox
                if (this.Controls[i].GetType() == typeof(EasySystem.Windows.Forms.GroupBox))
                {
                    for (int j = 0; j < this.Controls[i].Controls.Count; j++)
                    {
                        if (this.Controls[i].Controls[j].GetType().GetInterface("ITabItem") == typeof(EasySystem.Windows.Forms.ITabItem))
                        {
                            this.Controls[i].Controls[j].GotFocus += new EventHandler(tb_GotFocus);
                            this.Controls[i].Controls[j].LostFocus += new EventHandler(tb_LostFocus);

                            //this.Controls[i].Controls[j].MouseHover += new EventHandler(tb_GotFocus);
                            //this.Controls[i].Controls[j].MouseLeave += new EventHandler(tb_LostFocus);
                        }
                    }
                }

                //controls 
                if (this.Controls[i].GetType().GetInterface("ITabItem") == typeof(EasySystem.Windows.Forms.ITabItem))
                {
                    this.Controls[i].GotFocus += new EventHandler(tb_GotFocus);
                    this.Controls[i].LostFocus += new EventHandler(tb_LostFocus);

                    //this.Controls[i].MouseHover += new EventHandler(tb_GotFocus);
                    //this.Controls[i].MouseLeave += new EventHandler(tb_LostFocus);
                }
            }
        }

        public ClientePessoaFisica GetCliente()
        {
            ClientePessoaFisica _Cliente;

            try
            {
                //todo: codigo errado
                long TempId = 0;
                long.TryParse(textBoxCodigo.Text, out TempId);

                IClientePessoaFisicaRepository repository = new ClientePessoaFisicaRepository();
                ClientePessoaFisica fromDb = repository.GetById(TempId);

                if (fromDb != null)
                    _Cliente = fromDb;
                else
                {
                    _Cliente = new ClientePessoaFisica();

                    _Cliente.Sys_DataCadastro = DateTime.Now;
                    _Cliente.Sys_DataModificado = DateTime.Now;
                    _Cliente.Sys_Ativo = true;
                    _Cliente.Sys_Ativo_Descricao = "Cadastrado";
                }


                //_Cliente.Id =                                 textBoxCodigo.Text;
                _Cliente.DiaVencimentoParcelamento = int.Parse(numericUpDownVencimentoParcelamento.Value.ToString());
                _Cliente.AptoParcelamento = checkBoxAptoParcelamento.Checked;
                _Cliente.Estado = textBoxEstado.Text;
                decimal temp = 0;
                decimal.TryParse(textBoxLimiteParcelamento.Text, out temp);
                _Cliente.LimiteParcelamento = temp;
                _Cliente.Celular = textBoxCelular.Text;
                _Cliente.Observacoes = textBoxObservacao.Text;
                _Cliente.Cep = textBoxCep.Text;
                _Cliente.Site = textBoxSite.Text;
                _Cliente.Telefone = textBoxTelefone.Text;
                _Cliente.Email = textBoxEmail.Text;
                _Cliente.ReferenciaComercial = textBoxReferenciaComercial.Text;
                _Cliente.Cpf = textBoxCpf.Text;
                _Cliente.Cidade = textBoxCidade.Text;
                _Cliente.Maternidade = textBoxMaternidade.Text;
                _Cliente.Nome = textBoxNome.Text;
                _Cliente.Rg = textBoxRg.Text;
                _Cliente.Bairro = textBoxBairro.Text;
                _Cliente.Logadouro = textBoxLogadouro.Text;
                _Cliente.Paternidade = textBoxPaternidade.Text;
                _Cliente.Complemento = textBoxComplemento.Text;
                _Cliente.TelefonesAdicionais = textBoxTelefones.Text;
                _Cliente.Fax = textBoxFax.Text;
                _Cliente.Sobrenome = textBoxSobrenome.Text;
                _Cliente.RgEstado = textBoxRgUf.Text;
                _Cliente.RgOrgaoExpeditor = textBoxRgOrgaoExpeditor.Text;
                _Cliente.RendaMensal = textBoxRenda.Text;
                _Cliente.Profissao = textBoxProfissao.Text;

                if (dateTimePickerNascimento.Value < new DateTime(1800, 1, 1))
                    _Cliente.Nascimento = null;
                else
                    _Cliente.Nascimento = dateTimePickerNascimento.Value;

                if (_Cliente.Sexo == Sexo.Feminino)
                    radioButtonSexoFeminino.Checked = true;
                else
                    radioButtonSexoMasculino.Checked = true;

                return _Cliente;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            return null;
        }

        public void SetCliente(ClientePessoaFisica cliente)
        {
            if (cliente != null)
            {
                textBoxCodigo.Text = cliente.Id.ToString();
                numericUpDownVencimentoParcelamento.Value = cliente.DiaVencimentoParcelamento;
                dateTimePickerNascimento.Value = cliente.Nascimento.Value.Date;
                checkBoxAptoParcelamento.Checked = cliente.AptoParcelamento;
                textBoxEstado.Text = cliente.Estado;
                textBoxLimiteParcelamento.Text = cliente.LimiteParcelamento.ToString();
                textBoxCelular.Text = cliente.Celular;
                textBoxObservacao.Text = cliente.Observacoes;
                textBoxCep.Text = cliente.Cep;
                textBoxSite.Text = cliente.Site;
                textBoxTelefone.Text = cliente.Telefone;
                textBoxEmail.Text = cliente.Email;
                textBoxReferenciaComercial.Text = cliente.ReferenciaComercial;
                textBoxCpf.Text = cliente.Cpf;
                textBoxCidade.Text = cliente.Cidade;
                textBoxMaternidade.Text = cliente.Maternidade;
                textBoxNome.Text = cliente.Nome;
                textBoxRg.Text = cliente.Rg;
                textBoxBairro.Text = cliente.Bairro;
                textBoxLogadouro.Text = cliente.Logadouro;
                textBoxPaternidade.Text = cliente.Paternidade;
                textBoxComplemento.Text = cliente.Complemento;
                textBoxTelefones.Text = cliente.TelefonesAdicionais;
                textBoxFax.Text = cliente.Fax;
                textBoxSobrenome.Text = cliente.Sobrenome;
                textBoxRgUf.Text = cliente.RgEstado;
                textBoxRgOrgaoExpeditor.Text = cliente.RgOrgaoExpeditor;
                textBoxRenda.Text = cliente.RendaMensal;
                textBoxProfissao.Text = cliente.Profissao;

                if (radioButtonSexoFeminino.Checked)
                    cliente.Sexo = Sexo.Feminino;
                else
                    cliente.Sexo = Sexo.Masculino;
            }
        }

        private void checkBoxAptoParcelamento_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownVencimentoParcelamento.Enabled = checkBoxAptoParcelamento.Checked;
            textBoxLimiteParcelamento.Enabled = checkBoxAptoParcelamento.Checked;
        }

        private void tb_LostFocus(object sender, EventArgs e)
        {
            try
            {
                //PrevTabTip = TabTip;
                TabTip = PrevTabTip;
            }
            catch (Exception ex)
            {
                Console.WriteLine("erro lostfocus" + ex);
            }
        }

        private void tb_GotFocus(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(EasySystem.Windows.Forms.TextBox))
            {
                EasySystem.Windows.Forms.TextBox tmp = (EasySystem.Windows.Forms.TextBox)sender;
                PrevTabTip = TabTip;
                TabTip = tmp.TabTip;
                return;
            }
            if (sender.GetType() == typeof(EasySystem.Windows.Forms.CheckBox))
            {
                EasySystem.Windows.Forms.CheckBox tmp = (EasySystem.Windows.Forms.CheckBox)sender;
                PrevTabTip = TabTip;
                TabTip = tmp.TabTip;
                return;
            }
            if (sender.GetType() == typeof(EasySystem.Windows.Forms.ComboBox))
            {
                EasySystem.Windows.Forms.ComboBox tmp = (EasySystem.Windows.Forms.ComboBox)sender;
                PrevTabTip = TabTip;
                TabTip = tmp.TabTip;
                return;
            }
            if (sender.GetType() == typeof(EasySystem.Windows.Forms.DateTimePicker))
            {
                EasySystem.Windows.Forms.DateTimePicker tmp = (EasySystem.Windows.Forms.DateTimePicker)sender;
                PrevTabTip = TabTip;
                TabTip = tmp.TabTip;
                return;
            }
            if (sender.GetType() == typeof(EasySystem.Windows.Forms.RadioButton))
            {
                EasySystem.Windows.Forms.RadioButton tmp = (EasySystem.Windows.Forms.RadioButton)sender;
                PrevTabTip = TabTip;
                TabTip = tmp.TabTip;
                return;
            }
            TabTip = PrevTabTip;
        }
    }
}
