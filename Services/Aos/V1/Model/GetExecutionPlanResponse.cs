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
    /// Response Object
    /// </summary>
    public class GetExecutionPlanResponse : SdkResponse
    {

        /// <summary>
        /// 执行计划元素的列表，只有当状态为&#39;AVAILABLE&#39;、&#39;APPLIED&#39;、’APPLY_IN_PROGRESS‘等完成创建后的状态才会被赋值，而&#39;CREATION_IN_PROGRESS&#39;或&#39;CREATION_FAILED&#39;会返回错误。
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
            if (input == null)
                return false;

            return 
                (
                    this.ExecutionPlanItems == input.ExecutionPlanItems ||
                    this.ExecutionPlanItems != null &&
                    input.ExecutionPlanItems != null &&
                    this.ExecutionPlanItems.SequenceEqual(input.ExecutionPlanItems)
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
                if (this.ExecutionPlanItems != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
