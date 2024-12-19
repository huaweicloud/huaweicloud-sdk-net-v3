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
    /// 
    /// </summary>
    public class GroupBandwidthInfo 
    {

        /// <summary>
        /// 分片ID。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 更新时间，UTC时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 当前带宽(Mbit/s)。
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// 最大带宽(Mbit/s)。
        /// </summary>
        [JsonProperty("max_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBandwidth { get; set; }

        /// <summary>
        /// 基准带宽(Mbit/s)。
        /// </summary>
        [JsonProperty("assured_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssuredBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupBandwidthInfo {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  maxBandwidth: ").Append(MaxBandwidth).Append("\n");
            sb.Append("  assuredBandwidth: ").Append(AssuredBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupBandwidthInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupBandwidthInfo input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.MaxBandwidth != input.MaxBandwidth || (this.MaxBandwidth != null && !this.MaxBandwidth.Equals(input.MaxBandwidth))) return false;
            if (this.AssuredBandwidth != input.AssuredBandwidth || (this.AssuredBandwidth != null && !this.AssuredBandwidth.Equals(input.AssuredBandwidth))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.MaxBandwidth != null) hashCode = hashCode * 59 + this.MaxBandwidth.GetHashCode();
                if (this.AssuredBandwidth != null) hashCode = hashCode * 59 + this.AssuredBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
