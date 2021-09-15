using System;

namespace Adapter.Adaptee
{
    public interface ITvCustomizado
    {
        void TvCustomInfo(string emissora);
        void TvCustomException(Exception exception);
    }
}
