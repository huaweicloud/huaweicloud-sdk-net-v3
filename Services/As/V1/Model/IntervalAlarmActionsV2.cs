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
    /// 操作告警区间
    /// </summary>
    public class IntervalAlarmActionsV2 
    {

        /// <summary>
        /// 操作选项，默认为ADD。 当scaling_resource_type为SCALING_GROUP，支持如下操作： ADD：增加 REMOVE/REDUCE：减少 SET：设置为 当scaling_resource_type为BANDWIDTH，支持如下操作： ADD：增加 REDUCE：减少
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 操作限制。当scaling_resource_type为BANDWIDTH，且operation不为SET时，limits参数生效，单位为Mbit/s。此时，当operation为ADD时，limits表示带宽可调整的上限；当operation为REDUCE时，limits表示带宽可调整的下限。
        /// </summary>
        [JsonProperty("limits", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limits { get; set; }

        /// <summary>
        /// 操作大小，取值范围为0到300的整数，默认为1。当scaling_resource_type为SCALING_GROUP时，size为实例个数,取值范围为0-300的整数，默认为1。当scaling_resource_type为BANDWIDTH时，size表示带宽大小，单位为Mbit/s，取值范围为1到300的整数，默认为1。当scaling_resource_type为SCALING_GROUP时，size和percentage参数只能选其中一个进行配置。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lower_bound", NullValueHandling = NullValueHandling.Ignore)]
        public int? LowerBound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upper_bound", NullValueHandling = NullValueHandling.Ignore)]
        public int? UpperBound { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntervalAlarmActionsV2 {\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  limits: ").Append(Limits).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  lowerBound: ").Append(LowerBound).Append("\n");
            sb.Append("  upperBound: ").Append(UpperBound).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntervalAlarmActionsV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IntervalAlarmActionsV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Limits == input.Limits ||
                    (this.Limits != null &&
                    this.Limits.Equals(input.Limits))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.LowerBound == input.LowerBound ||
                    (this.LowerBound != null &&
                    this.LowerBound.Equals(input.LowerBound))
                ) && 
                (
                    this.UpperBound == input.UpperBound ||
                    (this.UpperBound != null &&
                    this.UpperBound.Equals(input.UpperBound))
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
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.LowerBound != null)
                    hashCode = hashCode * 59 + this.LowerBound.GetHashCode();
                if (this.UpperBound != null)
                    hashCode = hashCode * 59 + this.UpperBound.GetHashCode();
                return hashCode;
            }
        }
    }
}
