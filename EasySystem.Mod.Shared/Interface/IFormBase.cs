using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasySystem.Mod.Shared.Interface
{
    public interface IFormBase
    {
        void Atualizar();
        void MenuEnable(bool novo, bool editar, bool cancelar, bool salvar, bool excluir);
    }
}
