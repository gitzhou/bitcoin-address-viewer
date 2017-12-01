using Newtonsoft.Json;

namespace BitcoinAddressViewer
{
    public class Address
    {
        [System.ComponentModel.DisplayName("Address")]
        [JsonProperty("Address")]
        public string Address_ { get; set; }

        [System.ComponentModel.DisplayName("Balance")]
        [JsonProperty("balance")]
        public long Balance { get; set; }

        [System.ComponentModel.DisplayName("Received")]
        [JsonProperty("received")]
        public long Received { get; set; }

        [System.ComponentModel.DisplayName("Sent")]
        [JsonProperty("sent")]
        public long Sent { get; set; }

        [System.ComponentModel.DisplayName("TX Count")]
        [JsonProperty("tx_count")]
        public long TxCount { get; set; }

        [System.ComponentModel.DisplayName("Unconfirmed TX Count")]
        [JsonProperty("unconfirmed_tx_count")]
        public long UnconfirmedTxCount { get; set; }

        [System.ComponentModel.DisplayName("Unconfirmed Received")]
        [JsonProperty("unconfirmed_received")]
        public long UnconfirmedReceived { get; set; }

        [System.ComponentModel.DisplayName("Unconfirmed Sent")]
        [JsonProperty("unconfirmed_sent")]
        public long UnconfirmedSent { get; set; }

        [System.ComponentModel.DisplayName("Unspent TX Count")]
        [JsonProperty("unspent_tx_count")]
        public long UnspentTxCount { get; set; }
    }
}
