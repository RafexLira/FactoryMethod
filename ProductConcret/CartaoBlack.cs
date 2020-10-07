﻿using FactoryMethodExample.Product;

namespace FactoryMethodExample.ProductConcret
{
    public class CartaoBlack : CartaoCredito
    {
            private readonly string _TipoCartao;
            private int _LimiteCredito;
            private int _CobrancaAnual;

            public CartaoBlack(int limiteCredito, int cobrancaAnual)
            {
                _TipoCartao = "Black";
                _LimiteCredito = limiteCredito;
                _CobrancaAnual = cobrancaAnual;
            }
            public override string TipoCartao
            {
                get { return _TipoCartao; }
            }
            public override int LimiteCredito
            {
                get { return _LimiteCredito; }
                set { _LimiteCredito = value; }
            }
            public override int CobrancaAnual
            {
                get { return _CobrancaAnual; }
                set { _CobrancaAnual = value; }
            }
    }
}
