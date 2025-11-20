using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSmartLiveUserConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_exit_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveExitConfig LiveExitConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_event_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveEventCallBackConfig LiveEventCallbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_notify_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveNotifyConfig LiveNotifyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSmartLiveUserConfigResponse {\n");
            sb.Append("  liveExitConfig: ").Append(LiveExitConfig).Append("\n");
            sb.Append("  liveEventCallbackConfig: ").Append(LiveEventCallbackConfig).Append("\n");
            sb.Append("  liveNotifyConfig: ").Append(LiveNotifyConfig).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSmartLiveUserConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSmartLiveUserConfigResponse input)
        {
            if (input == null) return false;
            if (this.LiveExitConfig != input.LiveExitConfig || (this.LiveExitConfig != null && !this.LiveExitConfig.Equals(input.LiveExitConfig))) return false;
            if (this.LiveEventCallbackConfig != input.LiveEventCallbackConfig || (this.LiveEventCallbackConfig != null && !this.LiveEventCallbackConfig.Equals(input.LiveEventCallbackConfig))) return false;
            if (this.LiveNotifyConfig != input.LiveNotifyConfig || (this.LiveNotifyConfig != null && !this.LiveNotifyConfig.Equals(input.LiveNotifyConfig))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.LiveExitConfig != null) hashCode = hashCode * 59 + this.LiveExitConfig.GetHashCode();
                if (this.LiveEventCallbackConfig != null) hashCode = hashCode * 59 + this.LiveEventCallbackConfig.GetHashCode();
                if (this.LiveNotifyConfig != null) hashCode = hashCode * 59 + this.LiveNotifyConfig.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
