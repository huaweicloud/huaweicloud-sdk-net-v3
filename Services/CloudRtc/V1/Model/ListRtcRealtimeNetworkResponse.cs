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
    public class ListRtcRealtimeNetworkResponse : SdkResponse
    {

        /// <summary>
        /// 时间戳及相应时间的指标数值列表
        /// </summary>
        [JsonProperty("network", NullValueHandling = NullValueHandling.Ignore)]
        public List<TimeDoubleValueData> Network { get; set; }

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
            sb.Append("class ListRtcRealtimeNetworkResponse {\n");
            sb.Append("  network: ").Append(Network).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcRealtimeNetworkResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcRealtimeNetworkResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Network == input.Network ||
                    this.Network != null &&
                    input.Network != null &&
                    this.Network.SequenceEqual(input.Network)
                ) && 
                (
                    this.XRequestId == input.XRequestId ||
                    (this.XRequestId != null &&
                    this.XRequestId.Equals(input.XRequestId))
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
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
