using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;
using FactoryMethodExample.ProductConcret;

namespace FactoryMethodExample.ConcretCreator
{
    public class TitaniumFactory : CartaoFactory
    {

        private int _LimiteCredito;
        private int _CobrancaAnual;

        public TitaniumFactory(int limiteCredito, int cobrancaAnual)
        {
            _LimiteCredito = limiteCredito;
            _CobrancaAnual = cobrancaAnual;
        }

        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoTitanium(_LimiteCredito, _CobrancaAnual);
        }
    }
}
