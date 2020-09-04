using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Sidecar
{
    public class SdkHttpLog
    {
        [JsonProperty("Request", NullValueHandling = NullValueHandling.Ignore)]
        public string Request { get; set; }

        [JsonProperty("Response", NullValueHandling = NullValueHandling.Ignore)]
        public string Response;
    }
}