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
    public class UpdateBandwidthInfoRequest 
    {

        /// <summary>
        /// 分片带宽列表。
        /// </summary>
        [JsonProperty("group_bandwidths", NullValueHandling = NullValueHandling.Ignore)]
        public List<UpdateGroupBandwidthInfoRequest> GroupBandwidths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBandwidthInfoRequest {\n");
            sb.Append("  groupBandwidths: ").Append(GroupBandwidths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBandwidthInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBandwidthInfoRequest input)
        {
            if (input == null) return false;
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
                if (this.GroupBandwidths != null) hashCode = hashCode * 59 + this.GroupBandwidths.GetHashCode();
                return hashCode;
            }
        }
    }
}
