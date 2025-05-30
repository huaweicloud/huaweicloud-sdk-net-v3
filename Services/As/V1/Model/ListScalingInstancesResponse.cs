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
    public class ListScalingInstancesResponse : SdkResponse
    {

        /// <summary>
        /// 总记录数。
        /// </summary>
        [JsonProperty("total_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNumber { get; set; }

        /// <summary>
        /// 查询的起始行号。
        /// </summary>
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 伸缩组实例详情。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 伸缩组实例详情。
        /// </summary>
        [JsonProperty("scaling_group_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScalingGroupInstance> ScalingGroupInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingInstancesResponse {\n");
            sb.Append("  totalNumber: ").Append(TotalNumber).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  scalingGroupInstances: ").Append(ScalingGroupInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingInstancesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingInstancesResponse input)
        {
            if (input == null) return false;
            if (this.TotalNumber != input.TotalNumber || (this.TotalNumber != null && !this.TotalNumber.Equals(input.TotalNumber))) return false;
            if (this.StartNumber != input.StartNumber || (this.StartNumber != null && !this.StartNumber.Equals(input.StartNumber))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ScalingGroupInstances != input.ScalingGroupInstances || (this.ScalingGroupInstances != null && input.ScalingGroupInstances != null && !this.ScalingGroupInstances.SequenceEqual(input.ScalingGroupInstances))) return false;

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
                if (this.TotalNumber != null) hashCode = hashCode * 59 + this.TotalNumber.GetHashCode();
                if (this.StartNumber != null) hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ScalingGroupInstances != null) hashCode = hashCode * 59 + this.ScalingGroupInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
