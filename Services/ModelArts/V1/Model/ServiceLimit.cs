using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 服务限制信息。 **约束限制：** 不涉及。
    /// </summary>
    public class ServiceLimit 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rate_limit", NullValueHandling = NullValueHandling.Ignore)]
        public RateLimit RateLimit { get; set; }

        /// <summary>
        /// **参数解释：** 请求大小限制。 **约束限制：** 不涉及。 **取值范围：** 1-50M。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("request_size_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestSizeLimit { get; set; }

        /// <summary>
        /// **参数解释：** 超时时间。 **约束限制：** 不涉及。 **取值范围：** 1到7200秒。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("request_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// **参数解释：** IP白名单。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("ip_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpWhiteList { get; set; }

        /// <summary>
        /// **参数解释：** IP黑名单。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("ip_black_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpBlackList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLimit {\n");
            sb.Append("  rateLimit: ").Append(RateLimit).Append("\n");
            sb.Append("  requestSizeLimit: ").Append(RequestSizeLimit).Append("\n");
            sb.Append("  requestTimeout: ").Append(RequestTimeout).Append("\n");
            sb.Append("  ipWhiteList: ").Append(IpWhiteList).Append("\n");
            sb.Append("  ipBlackList: ").Append(IpBlackList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceLimit);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceLimit input)
        {
            if (input == null) return false;
            if (this.RateLimit != input.RateLimit || (this.RateLimit != null && !this.RateLimit.Equals(input.RateLimit))) return false;
            if (this.RequestSizeLimit != input.RequestSizeLimit || (this.RequestSizeLimit != null && !this.RequestSizeLimit.Equals(input.RequestSizeLimit))) return false;
            if (this.RequestTimeout != input.RequestTimeout || (this.RequestTimeout != null && !this.RequestTimeout.Equals(input.RequestTimeout))) return false;
            if (this.IpWhiteList != input.IpWhiteList || (this.IpWhiteList != null && input.IpWhiteList != null && !this.IpWhiteList.SequenceEqual(input.IpWhiteList))) return false;
            if (this.IpBlackList != input.IpBlackList || (this.IpBlackList != null && input.IpBlackList != null && !this.IpBlackList.SequenceEqual(input.IpBlackList))) return false;

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
                if (this.RateLimit != null) hashCode = hashCode * 59 + this.RateLimit.GetHashCode();
                if (this.RequestSizeLimit != null) hashCode = hashCode * 59 + this.RequestSizeLimit.GetHashCode();
                if (this.RequestTimeout != null) hashCode = hashCode * 59 + this.RequestTimeout.GetHashCode();
                if (this.IpWhiteList != null) hashCode = hashCode * 59 + this.IpWhiteList.GetHashCode();
                if (this.IpBlackList != null) hashCode = hashCode * 59 + this.IpBlackList.GetHashCode();
                return hashCode;
            }
        }
    }
}
