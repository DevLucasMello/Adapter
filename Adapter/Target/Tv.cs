using System;

namespace Adapter.Target
{
    public class Tv : ITv
    {
        public void TvInfo(string emissora)
        {
            Console.WriteLine("Canal de exibição Padrão Y - " + emissora);
        }

        public void TvException(Exception exception)
        {
            Console.WriteLine("Canal de exibição Padrão Y - " + exception.Message);
        }        
    }
}
