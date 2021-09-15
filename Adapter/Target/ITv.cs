using System;

namespace Adapter.Target
{
    public interface ITv
    {
        void TvInfo(string emissora);
        void TvException(Exception exception);
    }
}
