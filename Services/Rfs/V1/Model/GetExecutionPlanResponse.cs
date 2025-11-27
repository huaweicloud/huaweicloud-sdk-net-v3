using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetExecutionPlanResponse : SdkResponse
    {

        /// <summary>
        /// 执行计划项目的列表
        /// </summary>
        [JsonProperty("execution_plan_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExecutionPlanItem> ExecutionPlanItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetExecutionPlanResponse {\n");
            sb.Append("  executionPlanItems: ").Append(ExecutionPlanItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetExecutionPlanResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetExecutionPlanResponse input)
        {
            if (input == null) return false;
            if (this.ExecutionPlanItems != input.ExecutionPlanItems || (this.ExecutionPlanItems != null && input.ExecutionPlanItems != null && !this.ExecutionPlanItems.SequenceEqual(input.ExecutionPlanItems))) return false;

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
                if (this.ExecutionPlanItems != null) hashCode = hashCode * 59 + this.ExecutionPlanItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
