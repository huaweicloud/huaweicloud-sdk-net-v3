using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Sidecar
{
    public class SidecarResponse
    {
        [JsonProperty("httpStatusCode", NullValueHandling = NullValueHandling.Ignore)]
        public int HttpStatusCode { get; set; }

        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content;

        [JsonProperty("exception", NullValueHandling = NullValueHandling.Ignore)]
        public SidecarException Exception;

        [JsonProperty("httpLog", NullValueHandling = NullValueHandling.Ignore)]
        public SdkHttpLog HttpLog;
    }
}