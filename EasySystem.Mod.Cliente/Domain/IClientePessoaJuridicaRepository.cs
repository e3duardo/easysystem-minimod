using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySystem.Mod.Cliente.Domain
{
    public interface IClientePessoaJuridicaRepository
    {
        void Add(ClientePessoaJuridica cliente);

        void Update(ClientePessoaJuridica cliente);

        void Remove(ClientePessoaJuridica cliente);


        ClientePessoaJuridica GetById(long clienteId);

        ICollection<ClientePessoaJuridica> GetByNome(string nome);

        ICollection<ClientePessoaJuridica> GetBySobrenome(string sobrenome);

        ICollection<ClientePessoaJuridica> GetAll();
    }
}
