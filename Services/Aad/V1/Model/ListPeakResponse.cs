using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListPeakResponse : SdkResponse
    {

        /// <summary>
        /// 攻击峰值
        /// </summary>
        [JsonProperty("attack_kbps_peak", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AttackKbpsPeak { get; set; }

        /// <summary>
        /// 流量峰值
        /// </summary>
        [JsonProperty("in_kbps_peak", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? InKbpsPeak { get; set; }

        /// <summary>
        /// 攻击次数
        /// </summary>
        [JsonProperty("ddos_count", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DdosCount { get; set; }

        /// <summary>
        /// 攻击峰值发生时间点
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Timestamp { get; set; }

        /// <summary>
        /// 高防IP
        /// </summary>
        [JsonProperty("vip", NullValueHandling = NullValueHandling.Ignore)]
        public string Vip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPeakResponse {\n");
            sb.Append("  attackKbpsPeak: ").Append(AttackKbpsPeak).Append("\n");
            sb.Append("  inKbpsPeak: ").Append(InKbpsPeak).Append("\n");
            sb.Append("  ddosCount: ").Append(DdosCount).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  vip: ").Append(Vip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPeakResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPeakResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AttackKbpsPeak == input.AttackKbpsPeak ||
                    (this.AttackKbpsPeak != null &&
                    this.AttackKbpsPeak.Equals(input.AttackKbpsPeak))
                ) && 
                (
                    this.InKbpsPeak == input.InKbpsPeak ||
                    (this.InKbpsPeak != null &&
                    this.InKbpsPeak.Equals(input.InKbpsPeak))
                ) && 
                (
                    this.DdosCount == input.DdosCount ||
                    (this.DdosCount != null &&
                    this.DdosCount.Equals(input.DdosCount))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Vip == input.Vip ||
                    (this.Vip != null &&
                    this.Vip.Equals(input.Vip))
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
                if (this.AttackKbpsPeak != null)
                    hashCode = hashCode * 59 + this.AttackKbpsPeak.GetHashCode();
                if (this.InKbpsPeak != null)
                    hashCode = hashCode * 59 + this.InKbpsPeak.GetHashCode();
                if (this.DdosCount != null)
                    hashCode = hashCode * 59 + this.DdosCount.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Vip != null)
                    hashCode = hashCode * 59 + this.Vip.GetHashCode();
                return hashCode;
            }
        }
    }
}
