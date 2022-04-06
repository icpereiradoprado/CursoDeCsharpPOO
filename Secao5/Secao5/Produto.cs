using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao5
{
    class Produto
    {
        //atributos
        private string Nome;
        private double Preco;
        private int Quantidade;

        // Construtor
        
        public Produto()
        {
            this.Quantidade = 0;
        }
        public Produto(string nome, double preco) : this()
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            this.Quantidade = quantidade;
        }

        

            
        //gets e sets

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                this.Nome = nome;
            }
            
        }

        public double GetPreco()
        {
            return this.Preco;
        }

        public void SetPreco(double preco)
        {
            if (preco > 0)
            {
                this.Preco = preco;
            }
        }

        public int GetQuantidade()
        {
            return this.Quantidade;
        }

        public void SetQuantidade(int quantidade)
        {
            if (quantidade > 0)
            {
                this.Quantidade = quantidade;
            }
        }

        //demais métodos
        public double ValorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            this.Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            this.Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"Nome do produto: {this.Nome} | Preço: R$ {this.Preco:F2} | Quantidade: {this.Quantidade} unidades | Preço Total: {ValorTotalEmEstoque():F2}";
        }

    }
}
