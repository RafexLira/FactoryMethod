using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;
using FactoryMethodExample.ProductConcret;

namespace FactoryMethodExample.CreatorConcret
{
    public class BlackFactory : CartaoFactory
        
    {
        // public readonly string _TipoCartao;
        private int _LimiteCredito;
        private int _CobrancaAtual;

        public BlackFactory(int limiteCredito, int cobrancaAtual)
        {
            _LimiteCredito = limiteCredito;
            _CobrancaAtual = cobrancaAtual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoBlack(_LimiteCredito, _CobrancaAtual);
        }
    }
}
