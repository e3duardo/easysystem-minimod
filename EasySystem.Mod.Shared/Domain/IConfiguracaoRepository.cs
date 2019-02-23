using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySystem.Mod.Shared.Domain
{
    public interface IConfiguracaoRepository
    {
        void Add(Configuracao configuracao);

        void Update(Configuracao configuracao);

        void Remove(Configuracao configuracao);


        Configuracao GetById(long configuracaoId);

        ICollection<Configuracao> GetAll();
    }
}
