using Adapter.Adaptee;
using Adapter.Adapter;
using Adapter.Target;

namespace Adapter.Client
{
    public class ClientAdapter
    {
        public static void Exibir()
        {
            var tv = new TvService(new Tv());
            tv.MostrarCanais();

            var tvCustomizado = new TvService(new TvAdapter(new TvCustomizado()));
            tvCustomizado.MostrarCanais();
        }
    }
}
