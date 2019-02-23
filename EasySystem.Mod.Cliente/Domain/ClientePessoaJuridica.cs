using System;

namespace EasySystem.Mod.Cliente.Domain
{
    public class ClientePessoaJuridica : ICliente
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

        #region PessoaJuridica
        public virtual string NomeContato { get; set; }

        public virtual string NomeFantasia { get; set; }

        public virtual string Cnpj { get; set; }

        public virtual string InscricaoEstadual { get; set; }
        #endregion

        #region Sys
        public virtual DateTime Sys_DataCadastro { get; set; }
        public virtual DateTime Sys_DataModificado { get; set; }
        public virtual bool Sys_Ativo { get; set; }
        public virtual string Sys_Ativo_Descricao { get; set; }
        #endregion
    }
}
