using System;

namespace Adapter.Adaptee
{
    public class TvCustomizado : ITvCustomizado
    {
        public void TvCustomInfo(string emissora)
        {
            Console.WriteLine("Canal de exibição Customizado X - " + emissora);
        }

        public void TvCustomException(Exception exception)
        {
            Console.WriteLine("Canal de exibição Customizado X - " + exception.Message);
        }        
    }
}
