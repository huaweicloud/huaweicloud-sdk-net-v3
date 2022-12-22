using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListScalingGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNumber { get; set; }

        /// <summary>
        /// 查询的开始记录号
        /// </summary>
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 伸缩组列表
        /// </summary>
        [JsonProperty("scaling_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingGroups> ScalingGroups { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingGroupsResponse {\n");
            sb.Append("  totalNumber: ").Append(TotalNumber).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  scalingGroups: ").Append(ScalingGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingGroupsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalNumber == input.TotalNumber ||
                    (this.TotalNumber != null &&
                    this.TotalNumber.Equals(input.TotalNumber))
                ) && 
                (
                    this.StartNumber == input.StartNumber ||
                    (this.StartNumber != null &&
                    this.StartNumber.Equals(input.StartNumber))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.ScalingGroups == input.ScalingGroups ||
                    this.ScalingGroups != null &&
                    input.ScalingGroups != null &&
                    this.ScalingGroups.SequenceEqual(input.ScalingGroups)
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
                if (this.TotalNumber != null)
                    hashCode = hashCode * 59 + this.TotalNumber.GetHashCode();
                if (this.StartNumber != null)
                    hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ScalingGroups != null)
                    hashCode = hashCode * 59 + this.ScalingGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
