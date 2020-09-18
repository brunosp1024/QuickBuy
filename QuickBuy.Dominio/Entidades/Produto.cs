using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade //Herda da classe Entidade
    {

        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate() //Método de validação
        {
            if (string.IsNullOrEmpty(Nome)) //Se o atributo Nome for nulo ou vazio
                AdicionarMensagem("O Nome do produto não foi informado!");

            if (Preco == 0)
                AdicionarMensagem("O Preço não foi informado!");
        }
    }
}
