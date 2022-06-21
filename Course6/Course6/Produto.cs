using System;
using System.Globalization;

namespace Course7
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        /*public Produto()
        {
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0; // pode ser retirado pois ja inicia com 0, mas foi deixado para ficar mais didatico
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }*/

        public Produto() // utilização de this
        {
            Quantidade = 0;
        }
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public String Nome
        {
            get { return _nome; }
            set
            {
                if (value != null)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidade(int valor)
        {
            Quantidade += valor;
        }
        public void DiminuirQuantidade(int valor)
        {
            Quantidade -= valor;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
