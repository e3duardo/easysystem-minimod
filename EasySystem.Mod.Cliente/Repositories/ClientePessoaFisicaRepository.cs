using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasySystem.Mod.Cliente.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace EasySystem.Mod.Cliente.Repositories
{
    public class ClientePessoaFisicaRepository : IClientePessoaFisicaRepository
    {
        public void Add(ClientePessoaFisica cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(cliente);
                transaction.Commit();
            }
        }

        public void Update(ClientePessoaFisica cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(cliente);
                transaction.Commit();
            }
        }

        public void Remove(ClientePessoaFisica cliente)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(cliente);
                transaction.Commit();
            }
        }

        public ClientePessoaFisica GetById(long clienteId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<ClientePessoaFisica>(clienteId);
        }

        public ICollection<ClientePessoaFisica> GetByNome(string nome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaFisica))
                    .Add(Restrictions.Like("Nome", string.Format("%{0}%", nome)))
                    .List<ClientePessoaFisica>();
                return clientes;
            }
        }

        public ICollection<ClientePessoaFisica> GetBySobrenome(string sobrenome)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaFisica))
                    .Add(Restrictions.Like("Sobrenome", sobrenome))
                    .List<ClientePessoaFisica>();
                return clientes;
            }
        }

        public ICollection<ClientePessoaFisica> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaFisica))
                    .List<ClientePessoaFisica>();
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


        public ICollection<ClientePessoaFisica> GetByCpf(string cpf)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaFisica))
                    .Add(Restrictions.Like("Cpf", cpf))
                    .List<ClientePessoaFisica>();
                return clientes;
            }
        }





        public ICollection<ClientePessoaFisica> GetByCustonValue(params object[] values)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var clientes = session
                    .CreateCriteria(typeof(ClientePessoaFisica))
                    .Add(Restrictions.Or(
                        Restrictions.Like("Id", values[0]),
                            Restrictions.Or(
                                Restrictions.Like("Nome", values[1]),
                                Restrictions.Like("Cpf", values[2]))
                            )
                    )
                    .List<ClientePessoaFisica>();
                return clientes;
            }
        }
    }
}
