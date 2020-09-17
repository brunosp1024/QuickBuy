﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {

        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        //Pedido tem que ter um ou mais Itenspedido
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {

            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarMensagem("Crítica -  Pedido não pode ficar sem ítem de pedido!");

            if (string.IsNullOrEmpty(Cep))
                AdicionarMensagem("Crítica -  CEP deve estar preenchido!");

            if (FormaPagamentoId == 0)
                AdicionarMensagem("Não foi informado a forma de pagamento!");
        }
    }
}
