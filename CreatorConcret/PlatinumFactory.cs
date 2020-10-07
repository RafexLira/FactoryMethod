using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;
using FactoryMethodExample.ProductConcret;

namespace FactoryMethodExample.CreatorConcret
{
    public class PlatinumFactory:CartaoFactory
    {
        private int _LimiteCredito;
        private int _CobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            _LimiteCredito = limiteCredito;
            _CobrancaAnual = cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_LimiteCredito, _CobrancaAnual);
        }
    }
}
