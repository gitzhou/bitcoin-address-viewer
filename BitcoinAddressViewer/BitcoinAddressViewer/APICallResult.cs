namespace BitcoinAddressViewer
{
    public class APICallResult
    {
        public int ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }

        public bool IsSuccessServerResponse()
        {
            return ErrorNumber == 0;
        }
    }
}
