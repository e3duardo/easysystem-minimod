using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasySystem.Mod.Cliente.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace EasySystem.Mod.Cliente.Repositories
{
    public class ClientePessoaJuridicaRepository : IClientePessoaJuridicaRepository
    {
        public void Add(ClientePessoaJuridica cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(cliente);
                transaction.Commit();
            }
        }

        public void Update(ClientePessoaJuridica cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(cliente);
                transaction.Commit();
            }
        }

        public void Remove(ClientePessoaJuridica cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(cliente);
                transaction.Commit();
            }
        }

        public ClientePessoaJuridica GetById(long clienteId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<ClientePessoaJuridica>(clienteId);
        }

        public ICollection<ClientePessoaJuridica> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaJuridica))
                    .Add(Restrictions.Eq("Nome", nome))
                    .List<ClientePessoaJuridica>();
                return clientes;
            }
        }

        public ICollection<ClientePessoaJuridica> GetBySobrenome(string sobrenome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaJuridica))
                    .Add(Restrictions.Eq("Sobrenome", sobrenome))
                    .List<ClientePessoaJuridica>();
                return clientes;
            }
        }

        public ICollection<ClientePessoaJuridica> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaJuridica))
                    .List<ClientePessoaJuridica>();
                return clientes;
            }
        }


        //para um resultado
        //public ICollection<Clientes> GetByNome(string nome)
        //{
        //    using (ISession session = NHibernateHelper.OpenSession())
        //    {
        //        Product product = session
        //            .CreateCriteria(typeof(Product))
        //            .Add(Restrictions.Eq("Name", name))
        //            .UniqueResult<Product>();
        //        return product;
        //    }
        //}
    }
}
