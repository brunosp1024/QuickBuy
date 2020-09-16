using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        protected List<string> mensagemValidacao 
        { 
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); } //Verifica se _mensagensValidacao está vazia, e  então retorna um cconjunto vazio de strings
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate(); //O abstract força as classes filhas a usarem
        protected bool EhValido
        {
            get { return (!mensagemValidacao.Any()); } //Se não houver nenhuma mensagem de validação
        }
    }
}
