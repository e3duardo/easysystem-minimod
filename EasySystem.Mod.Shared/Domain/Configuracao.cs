using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySystem.Mod.Shared.Domain
{
    public class Configuracao
    {
        public virtual long Id { get; set; }

        public virtual bool ClienteFormularioMostrarFiltros { get; set; }
        public virtual bool ClienteFormularioSalvarAutomaticamenteAoSair { get; set; }
        public virtual bool ClienteFormularioSalvarArquivoEnquandoCadastra { get; set; }
        public virtual string ClienteFormularioLocalArquivoEnquantoCadastra { get; set; }
        public virtual bool ClienteFormularioPermitirCadastroComCpfDuplicado { get; set; }

        #region Sys
        public virtual DateTime Sys_DataCadastro { get; set; }
        public virtual DateTime Sys_DataModificado { get; set; }
        public virtual bool Sys_Ativo { get; set; }
        public virtual string Sys_Ativo_Descricao { get; set; }
        #endregion
    }
}
