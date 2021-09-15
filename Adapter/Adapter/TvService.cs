using Adapter.Target;

namespace Adapter.Adapter
{
    public class TvService
    {
        private readonly ITv _tv;

        public TvService(ITv tv)
        {
            _tv = tv;
        }

        public void MostrarCanais()
        {
            _tv.TvInfo("Emissora");
        }
    }
}
