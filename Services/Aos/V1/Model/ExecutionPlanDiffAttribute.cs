using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 执行计划的更多细节
    /// </summary>
    public class ExecutionPlanDiffAttribute 
    {

        /// <summary>
        /// 当前资源被修改的参数的名字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 当前资源被修改前参数的值，新创建时为空。
        /// </summary>
        [JsonProperty("previous_value", NullValueHandling = NullValueHandling.Ignore)]
        public string PreviousValue { get; set; }

        /// <summary>
        /// 当前资源被修改的参数的目的值，删除时为空。
        /// </summary>
        [JsonProperty("target_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecutionPlanDiffAttribute {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  previousValue: ").Append(PreviousValue).Append("\n");
            sb.Append("  targetValue: ").Append(TargetValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecutionPlanDiffAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecutionPlanDiffAttribute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PreviousValue == input.PreviousValue ||
                    (this.PreviousValue != null &&
                    this.PreviousValue.Equals(input.PreviousValue))
                ) && 
                (
                    this.TargetValue == input.TargetValue ||
                    (this.TargetValue != null &&
                    this.TargetValue.Equals(input.TargetValue))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PreviousValue != null)
                    hashCode = hashCode * 59 + this.PreviousValue.GetHashCode();
                if (this.TargetValue != null)
                    hashCode = hashCode * 59 + this.TargetValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
