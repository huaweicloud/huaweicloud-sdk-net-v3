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
    /// apply_execution_plan request body
    /// </summary>
    public class ApplyExecutionPlanRequestBody 
    {

        /// <summary>
        /// 资源栈id
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 执行计划Id，在domain_id+region+project_id+stack_id下应唯一
        /// </summary>
        [JsonProperty("execution_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyExecutionPlanRequestBody {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("  executionPlanId: ").Append(ExecutionPlanId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyExecutionPlanRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyExecutionPlanRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackId == input.StackId ||
                    (this.StackId != null &&
                    this.StackId.Equals(input.StackId))
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
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.ExecutionPlanId != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
