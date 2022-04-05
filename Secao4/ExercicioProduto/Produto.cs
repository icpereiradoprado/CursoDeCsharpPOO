using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProduto
{
    class Produto
    {
        private string Nome;
        private double Preco;
        private int Quantidade;

        //gets e sets

        //get e set nome
        public string getNome()
        {
            return this.Nome;
        }

        public void setNome(string _nome)
        {
            this.Nome = _nome;
        }

        //get e set preco
        public double getPreco()
        {
            return this.Preco;
        }

        public void setPreco(double _preco)
        {
            this.Preco = _preco;
        }

        //get e set quantidade

        public int getQunatidade()
        {
            return this.Quantidade;
        }

        public void setQunatidade(int _quantidade)
        {
            this.Quantidade = _quantidade;
        }

        //demais métodos

        public double valorTotalEmEstoque()
        {
            return this.Preco * this.Quantidade;
        }

        public void adicionarProdutos(int _quantidade)
        {
            this.Quantidade += _quantidade;
        }
        public void removerProdutos(int _quantidade)
        {
            this.Quantidade -= _quantidade;
        }

        public override string ToString()
        {
            return this.Nome
                +", R$ "
                +this.Preco.ToString("F2")
                +", "
                +this.Quantidade
                +" unidades, Total: R$ "
                +valorTotalEmEstoque().ToString("F2");

        }
        /*public string retornaDadosProduto()
        {
            return $"Dados do produto: {this.Nome}, R$ {this.Preco:F2}, {this.Quantidade} unidades,";
        }*/
    }
}
