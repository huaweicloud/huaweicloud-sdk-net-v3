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
    public class UpdateGroupBandwidthInfoRequest 
    {

        /// <summary>
        /// 分片ID。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 目标带宽（Mbit/s）。
        /// </summary>
        [JsonProperty("target_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetBandwidth { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateGroupBandwidthInfoRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  targetBandwidth: ").Append(TargetBandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateGroupBandwidthInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateGroupBandwidthInfoRequest input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.TargetBandwidth != input.TargetBandwidth || (this.TargetBandwidth != null && !this.TargetBandwidth.Equals(input.TargetBandwidth))) return false;

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
                if (this.TargetBandwidth != null) hashCode = hashCode * 59 + this.TargetBandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
