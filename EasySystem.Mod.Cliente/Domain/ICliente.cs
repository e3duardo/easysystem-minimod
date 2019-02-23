using System;

namespace EasySystem.Mod.Cliente.Domain
{
    public interface ICliente
    {
        long Id { get; set; }

        string Bairro { get; set; }

        string Cep { get; set; }

        string Cidade { get; set; }

        string Complemento { get; set; }

        string Estado { get; set; }

        string Logadouro { get; set; }

        string Celular { get; set; }

        string Telefone { get; set; }

        string Fax { get; set; }

        string TelefonesAdicionais { get; set; }

        string Email { get; set; }

        string Site { get; set; }

        string Observacoes { get; set; }

        decimal LimiteParcelamento { get; set; }

        bool AptoParcelamento { get; set; }

        int DiaVencimentoParcelamento { get; set; }

        #region Sys
        DateTime Sys_DataCadastro { get; set; }
        DateTime Sys_DataModificado { get; set; }
        bool Sys_Ativo { get; set; }
        string Sys_Ativo_Descricao { get; set; }
        #endregion
    }
}
