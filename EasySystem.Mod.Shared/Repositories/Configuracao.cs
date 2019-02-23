using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EasySystem.Mod.Shared.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace EasySystem.Mod.Shared.Repositories
{
    public class ConfiguracaoRepository : IConfiguracaoRepository
    {
        public void Add(Configuracao configuracao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(configuracao);
                transaction.Commit();
            }
        }

        public void Update(Configuracao configuracao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(configuracao);
                transaction.Commit();
            }
        }

        public void Remove(Configuracao configuracao)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(configuracao);
                transaction.Commit();
            }
        }

        public Configuracao GetById(long configuracaoId)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Configuracao>(configuracaoId);
        }

        public ICollection<Configuracao> GetAll()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var configuracaos = session
                    .CreateCriteria(typeof(Configuracao))
                    .List<Configuracao>();
                return configuracaos;
            }
        }


        
    }
}
