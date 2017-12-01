using System.Collections.Generic;

namespace BitcoinAddressViewer
{
    public class MultiAddressAPICallResult<T> : APICallResult
    {
        public List<T> Data { get; set; }
    }
}
