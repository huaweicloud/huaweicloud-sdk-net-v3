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
    public class CreateExecutionPlanResponse : SdkResponse
    {

        /// <summary>
        /// 栈的名字
        /// </summary>
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 栈的唯一Id
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 执行计划的名字。如果未指定，则使用execution_plan_id作为execution_plan_name。
        /// </summary>
        [JsonProperty("execution_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanName { get; set; }

        /// <summary>
        /// 执行计划的唯一Id，由IaC随机生成
        /// </summary>
        [JsonProperty("execution_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateExecutionPlanResponse {\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  executionPlanName: ").Append(ExecutionPlanName).Append("\n");
            sb.Append("  executionPlanId: ").Append(ExecutionPlanId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateExecutionPlanResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateExecutionPlanResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackName == input.StackName ||
                    (this.StackName != null &&
                    this.StackName.Equals(input.StackName))
                ) && 
                (
                    this.StackId == input.StackId ||
                    (this.StackId != null &&
                    this.StackId.Equals(input.StackId))
                ) && 
                (
                    this.ExecutionPlanName == input.ExecutionPlanName ||
                    (this.ExecutionPlanName != null &&
                    this.ExecutionPlanName.Equals(input.ExecutionPlanName))
                ) && 
                (
                    this.ExecutionPlanId == input.ExecutionPlanId ||
                    (this.ExecutionPlanId != null &&
                    this.ExecutionPlanId.Equals(input.ExecutionPlanId))
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
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.ExecutionPlanName != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanName.GetHashCode();
                if (this.ExecutionPlanId != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
