using System;
using Adapter.Adaptee;
using Adapter.Target;

namespace Adapter.Adapter
{
    public class TvAdapter : ITv
    {
        private readonly ITvCustomizado _tvCustomizado;

        public TvAdapter(ITvCustomizado tvCustomizado)
        {
            _tvCustomizado = tvCustomizado;
        }
        
        public void TvInfo(string emissora)
        {
            _tvCustomizado.TvCustomInfo(emissora);
        }

        public void TvException(Exception exception)
        {
            _tvCustomizado.TvCustomException(exception);
        }        
    }
}
