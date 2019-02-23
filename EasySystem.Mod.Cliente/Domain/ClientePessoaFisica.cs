using System;
using EasySystem.Mod.Shared.Enum;

namespace EasySystem.Mod.Cliente.Domain
{
    public class ClientePessoaFisica : ICliente
    {
        public virtual long Id { get; set; }

        public virtual string Bairro { get; set; }

        public virtual string Cep { get; set; }

        public virtual string Cidade { get; set; }

        public virtual string Complemento { get; set; }

        public virtual string Estado { get; set; }

        public virtual string Logadouro { get; set; }

        public virtual string Celular { get; set; }

        public virtual string Telefone { get; set; }

        public virtual string Fax { get; set; }

        public virtual string TelefonesAdicionais { get; set; }

        public virtual string Email { get; set; }

        public virtual string Site { get; set; }

        public virtual string Observacoes { get; set; }

        public virtual decimal LimiteParcelamento { get; set; }

        public virtual bool AptoParcelamento { get; set; }

        public virtual int DiaVencimentoParcelamento { get; set; }

        #region PessoaFisica
        public virtual string Nome { get; set; }

        public virtual string Sobrenome { get; set; }

        public virtual string Cpf { get; set; }

        public virtual string Rg { get; set; }

        public virtual string RgEstado { get; set; }

        public virtual string RgOrgaoExpeditor { get; set; }

        public virtual string Paternidade { get; set; }

        public virtual string Maternidade { get; set; }

        public virtual DateTime? Nascimento { get; set; }

        public virtual string ReferenciaComercial { get; set; }

        public virtual string EstadoCivil { get; set; }

        public virtual Sexo Sexo { get; set; }

        public virtual string RendaMensal { get; set; }

        public virtual string Profissao { get; set; }
        #endregion

        #region Sys
        public virtual DateTime Sys_DataCadastro { get; set; }
        public virtual DateTime Sys_DataModificado { get; set; }
        public virtual bool Sys_Ativo { get; set; }
        public virtual string Sys_Ativo_Descricao { get; set; }
        #endregion
    }
}
