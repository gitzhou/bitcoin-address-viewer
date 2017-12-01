namespace BitcoinAddressViewer
{
    public class SingleAddressAPICallResult<T> : APICallResult
    {
        public T Data { get; set; }
    }
}
