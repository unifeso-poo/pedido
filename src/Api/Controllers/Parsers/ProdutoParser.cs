﻿using UnifesoPoo.Pedido.Api.Controllers.Contracts;
using UnifesoPoo.Pedido.Api.Core.Application.ProductAgg.Contracts;
using UnifesoPoo.Pedido.Api.Core.Application.ProductAgg.Parsers;
using UnifesoPoo.Pedido.Api.Core.Domain.ProductAgg.Entities;

namespace UnifesoPoo.Pedido.Api.Controllers.Parsers
{
    public class ProdutoParser : IParser<Produto, IProdutoView>
    {
        public IProdutoView Parse(Produto produto) 
        {
            return new ProdutoDto
            {
                Nome = produto.Nome,
                Preco = (produto.Preco / 100M).ToString("C"),
                QuantidadeDisponivel = produto.QuantidadeDisponivel
            };
        }
    }
}