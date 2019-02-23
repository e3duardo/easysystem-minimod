
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasySystem.Mod.Shared.Domain;
using EasySystem.Mod.Shared.Repositories;
using System;
using EasySystem.Mod.Cliente.Domain;
using EasySystem.Mod.Cliente.Repositories;
using EasySystem.Mod.Shared.Enum;

namespace EasySystem.Mod.Cliente.Tests
{
    [TestClass]
    public class GenerateSchema_Fixture
    {
        [TestMethod]
        public void Can_generate_schema_cliente()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly("EasySystem.Mod.Cliente");

            new SchemaExport(cfg).Execute(false, true, false);
        }

        [TestMethod]
        public void Can_generate_schema_shared()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly("EasySystem.Mod.Shared");

            new SchemaExport(cfg).Execute(false, true, false);
        }


        [TestMethod]
        public void Can_Insert_Configuration()
        {
            IConfiguracaoRepository repository = new ConfiguracaoRepository();
            repository.Add(new Configuracao
            {
                ClienteFormularioMostrarFiltros = true,
                ClienteFormularioSalvarAutomaticamenteAoSair = true,
                ClienteFormularioSalvarArquivoEnquandoCadastra = true,
                ClienteFormularioLocalArquivoEnquantoCadastra = "apppath\arquivo.ext",

                Sys_DataCadastro = DateTime.Today,
                Sys_DataModificado = DateTime.Today,
                Sys_Ativo = true,
                Sys_Ativo_Descricao = ""
            });
        }

        [TestMethod]
        public void Can_Insert_Cliente()
        {
            IClientePessoaFisicaRepository repository = new ClientePessoaFisicaRepository();
            for (int i = 0; i < 500; i++)
            {
                repository.Add(new ClientePessoaFisica
                {
                    Nome = "Cliente" + i.ToString() + " - " + new Random().ToString(),
                    Bairro = "",
                    Cep = "",
                    Cidade = "",
                    Complemento = "",
                    Estado = "",
                    Logadouro = "",
                    Celular = "",
                    Telefone = "",
                    Fax = "",
                    TelefonesAdicionais = "",
                    Email = "",
                    Site = "",
                    Observacoes = "",
                    LimiteParcelamento = 0,
                    AptoParcelamento = false,
                    DiaVencimentoParcelamento = 1,
                    Sobrenome = "",
                    Cpf = "",
                    Rg = "",
                    RgEstado = "",
                    RgOrgaoExpeditor = "",
                    Paternidade = "",
                    Maternidade = "",
                    Nascimento = DateTime.Today,
                    ReferenciaComercial = "",
                    Sexo = Sexo.Masculino,
                    RendaMensal = "",
                    Profissao = "",
                    Sys_DataCadastro = DateTime.Today, 
                    Sys_DataModificado = DateTime.Today, 
                    Sys_Ativo = true,
                    Sys_Ativo_Descricao = ""
                });
            }
        }
    }
}
