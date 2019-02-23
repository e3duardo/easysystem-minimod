using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySystem.Mod.Cliente.Domain
{
    public interface IClientePessoaFisicaRepository
    {
        void Add(ClientePessoaFisica cliente);

        void Update(ClientePessoaFisica cliente);

        void Remove(ClientePessoaFisica cliente);


        ClientePessoaFisica GetById(long clienteId);

        ICollection<ClientePessoaFisica> GetByNome(string nome);

        ICollection<ClientePessoaFisica> GetBySobrenome(string sobrenome);

        ICollection<ClientePessoaFisica> GetByCpf(string sobrenome);

        ICollection<ClientePessoaFisica> GetAll();

        ICollection<ClientePessoaFisica> GetByCustonValue(params object[] values);
    }
}
