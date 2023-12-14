using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListDelayConfigResponse : SdkResponse
    {

        /// <summary>
        /// 播放域名
        /// </summary>
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// 直播延时配置
        /// </summary>
        [JsonProperty("delay_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<DelayConfig> DelayConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDelayConfigResponse {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
            sb.Append("  delayConfig: ").Append(DelayConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDelayConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDelayConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayDomain == input.PlayDomain ||
                    (this.PlayDomain != null &&
                    this.PlayDomain.Equals(input.PlayDomain))
                ) && 
                (
                    this.DelayConfig == input.DelayConfig ||
                    this.DelayConfig != null &&
                    input.DelayConfig != null &&
                    this.DelayConfig.SequenceEqual(input.DelayConfig)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PlayDomain != null)
                    hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                if (this.DelayConfig != null)
                    hashCode = hashCode * 59 + this.DelayConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
