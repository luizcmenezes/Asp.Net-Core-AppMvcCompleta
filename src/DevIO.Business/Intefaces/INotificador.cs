using DevIO.Business.Notificacoes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
