using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDDoSPeakResponse : SdkResponse
    {

        /// <summary>
        /// 攻击流量
        /// </summary>
        [JsonProperty("attack_kbytes_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackKbytesTotal { get; set; }

        /// <summary>
        /// 攻击流量峰值包速率
        /// </summary>
        [JsonProperty("attack_pps_peak", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackPpsPeak { get; set; }

        /// <summary>
        /// 入流量峰值包速率
        /// </summary>
        [JsonProperty("in_pps_peak", NullValueHandling = NullValueHandling.Ignore)]
        public int? InPpsPeak { get; set; }

        /// <summary>
        /// 攻击流量峰值
        /// </summary>
        [JsonProperty("attack_bps_peak", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackBpsPeak { get; set; }

        /// <summary>
        /// 入流量峰值
        /// </summary>
        [JsonProperty("in_bps_peak", NullValueHandling = NullValueHandling.Ignore)]
        public int? InBpsPeak { get; set; }

        /// <summary>
        /// 攻击数量
        /// </summary>
        [JsonProperty("ddos_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DdosCount { get; set; }

        /// <summary>
        /// 峰值时间
        /// </summary>
        [JsonProperty("utime", NullValueHandling = NullValueHandling.Ignore)]
        public int? Utime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDDoSPeakResponse {\n");
            sb.Append("  attackKbytesTotal: ").Append(AttackKbytesTotal).Append("\n");
            sb.Append("  attackPpsPeak: ").Append(AttackPpsPeak).Append("\n");
            sb.Append("  inPpsPeak: ").Append(InPpsPeak).Append("\n");
            sb.Append("  attackBpsPeak: ").Append(AttackBpsPeak).Append("\n");
            sb.Append("  inBpsPeak: ").Append(InBpsPeak).Append("\n");
            sb.Append("  ddosCount: ").Append(DdosCount).Append("\n");
            sb.Append("  utime: ").Append(Utime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDDoSPeakResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDDoSPeakResponse input)
        {
            if (input == null) return false;
            if (this.AttackKbytesTotal != input.AttackKbytesTotal || (this.AttackKbytesTotal != null && !this.AttackKbytesTotal.Equals(input.AttackKbytesTotal))) return false;
            if (this.AttackPpsPeak != input.AttackPpsPeak || (this.AttackPpsPeak != null && !this.AttackPpsPeak.Equals(input.AttackPpsPeak))) return false;
            if (this.InPpsPeak != input.InPpsPeak || (this.InPpsPeak != null && !this.InPpsPeak.Equals(input.InPpsPeak))) return false;
            if (this.AttackBpsPeak != input.AttackBpsPeak || (this.AttackBpsPeak != null && !this.AttackBpsPeak.Equals(input.AttackBpsPeak))) return false;
            if (this.InBpsPeak != input.InBpsPeak || (this.InBpsPeak != null && !this.InBpsPeak.Equals(input.InBpsPeak))) return false;
            if (this.DdosCount != input.DdosCount || (this.DdosCount != null && !this.DdosCount.Equals(input.DdosCount))) return false;
            if (this.Utime != input.Utime || (this.Utime != null && !this.Utime.Equals(input.Utime))) return false;

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
                if (this.AttackKbytesTotal != null) hashCode = hashCode * 59 + this.AttackKbytesTotal.GetHashCode();
                if (this.AttackPpsPeak != null) hashCode = hashCode * 59 + this.AttackPpsPeak.GetHashCode();
                if (this.InPpsPeak != null) hashCode = hashCode * 59 + this.InPpsPeak.GetHashCode();
                if (this.AttackBpsPeak != null) hashCode = hashCode * 59 + this.AttackBpsPeak.GetHashCode();
                if (this.InBpsPeak != null) hashCode = hashCode * 59 + this.InBpsPeak.GetHashCode();
                if (this.DdosCount != null) hashCode = hashCode * 59 + this.DdosCount.GetHashCode();
                if (this.Utime != null) hashCode = hashCode * 59 + this.Utime.GetHashCode();
                return hashCode;
            }
        }
    }
}
