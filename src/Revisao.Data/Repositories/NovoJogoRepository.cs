using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class NovoJogoRepository : INovoJogoRepository
    {

        private readonly string _produtoCaminhoArquivo;

        public NovoJogoRepository()
        {
            _produtoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "Data", "produto.json");
        }

        public List<NovoJogo> ObterTodosOsJogos()
        {
            //gravar no arquivo no json
            throw new NotImplementedException();
        }

        public void RegistrarNovoJogo(NovoJogo novoJogo)
        {
            throw new NotImplementedException();
        }

        #region Métodos arquivo
        private List<NovoJogo> LerProdutosDoArquivo()
        {
            if (!System.IO.File.Exists(_produtoCaminhoArquivo))
            {
                return new List<NovoJogo>();
            }

            string json = System.IO.File.ReadAllText(_produtoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<NovoJogo>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<NovoJogo> produtos = LerProdutosDoArquivo();
            if (produtos.Any())
            {
                return produtos.Max(p => p.Codigo) + 1;
            }
            else
            {
                return 1;
            }
        }

        private void EscreverProdutosNoArquivo(List<NovoJogo> produtos)
        {
            string json = JsonConvert.SerializeObject(produtos);
            System.IO.File.WriteAllText(_produtoCaminhoArquivo, json);
        }
        #endregion
    }
}
