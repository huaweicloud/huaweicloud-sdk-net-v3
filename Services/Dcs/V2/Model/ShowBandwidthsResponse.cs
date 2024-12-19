using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBandwidthsResponse : SdkResponse
    {

        /// <summary>
        /// 实例当前带宽(Mbit/s)。
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// 实例最大带宽(Mbit/s)。
        /// </summary>
        [JsonProperty("max_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBandwidth { get; set; }

        /// <summary>
        /// 是否支持调带宽。
        /// </summary>
        [JsonProperty("allow_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowModify { get; set; }

        /// <summary>
        /// 分片带宽列表。
        /// </summary>
        [JsonProperty("group_bandwidths", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupBandwidthInfo> GroupBandwidths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBandwidthsResponse {\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  maxBandwidth: ").Append(MaxBandwidth).Append("\n");
            sb.Append("  allowModify: ").Append(AllowModify).Append("\n");
            sb.Append("  groupBandwidths: ").Append(GroupBandwidths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBandwidthsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBandwidthsResponse input)
        {
            if (input == null) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.MaxBandwidth != input.MaxBandwidth || (this.MaxBandwidth != null && !this.MaxBandwidth.Equals(input.MaxBandwidth))) return false;
            if (this.AllowModify != input.AllowModify || (this.AllowModify != null && !this.AllowModify.Equals(input.AllowModify))) return false;
            if (this.GroupBandwidths != input.GroupBandwidths || (this.GroupBandwidths != null && input.GroupBandwidths != null && !this.GroupBandwidths.SequenceEqual(input.GroupBandwidths))) return false;

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
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.MaxBandwidth != null) hashCode = hashCode * 59 + this.MaxBandwidth.GetHashCode();
                if (this.AllowModify != null) hashCode = hashCode * 59 + this.AllowModify.GetHashCode();
                if (this.GroupBandwidths != null) hashCode = hashCode * 59 + this.GroupBandwidths.GetHashCode();
                return hashCode;
            }
        }
    }
}
