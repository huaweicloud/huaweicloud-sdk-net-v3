using Newtonsoft.Json;

namespace HuaweiCloud.SDK.Sidecar
{
    public class SidecarException
    {
        [JsonProperty("errorMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode;
    }
}