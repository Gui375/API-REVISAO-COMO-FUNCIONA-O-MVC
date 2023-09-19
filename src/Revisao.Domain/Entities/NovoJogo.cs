using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class NovoJogo
    {
        #region Construtor
        public NovoJogo(string nome, string cpf, int primeiroNro, int segundoNro, int terceiroNro)
        {
            Nome = nome;
            Cpf = cpf;
            this.primeiroNro = primeiroNro;
            this.segundoNro = segundoNro;
            this.terceiroNro = terceiroNro;
        }

        #endregion

        #region Propriedades

        public string Nome { get; private set; }

        public string Cpf { get; private set; }
        public int primeiroNro { get; private set; }
        public int segundoNro { get; private set; }
        public int terceiroNro { get; private set; }

        //..

        #endregion
        #region Comportamentos 

        public void AlterarNome(string novoNome) =>  Nome = novoNome;

        public bool JogoEhValido() {            if (primeiroNro != segundoNro && segundoNro != terceiroNro) return true;
            return false;
        } 

        public void SetarPrimeiroNro(int primeiroNro)
        {
            if (primeiroNro < 0 || primeiroNro > 60)
                throw new Exception("Valor invalido para jogar na mega sena");
        }

        #endregion

    }
}
