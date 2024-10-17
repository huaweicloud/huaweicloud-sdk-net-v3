using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRtcHistoryUsageResponse : SdkResponse
    {

        /// <summary>
        /// 时间戳及相应时间的指标数值列表
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public List<RtcHistoryUsage> Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-id", IsHeader = true)]
        [JsonProperty("X-request-id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcHistoryUsageResponse {\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcHistoryUsageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcHistoryUsageResponse input)
        {
            if (input == null) return false;
            if (this.Usage != input.Usage || (this.Usage != null && input.Usage != null && !this.Usage.SequenceEqual(input.Usage))) return false;
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
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
