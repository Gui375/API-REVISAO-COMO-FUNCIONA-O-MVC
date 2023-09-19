using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface INovoJogoRepository
    {
        //o que e que registro novo jovo? Nao como é (data) !!
        public void RegistrarNovoJogo(NovoJogo novoJogo);
        public List<NovoJogo> ObterTodosOsJogos();


    }
}
