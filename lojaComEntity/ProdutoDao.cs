using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    public class ProdutoDao
    {
        private EntidadesContext contexto;

        public ProdutoDao(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> BuscaPorNomePrecoNomeCategoria(string nome,decimal preco,string nomeCategoria)
        {
            var busca = from p in contexto.Produtos
                        select p;

            if(!String.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
            }

            if(preco > 0.0m)
            {
                busca = busca.Where(p => p.Preco == preco);
            }

            if(!String.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
            }

            return busca.ToList();
        }
    }
}
