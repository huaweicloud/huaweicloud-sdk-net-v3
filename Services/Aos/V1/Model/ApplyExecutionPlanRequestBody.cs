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
    /// 
    /// </summary>
    public class ApplyExecutionPlanRequestBody 
    {

        /// <summary>
        /// 执行计划（execution_plan）的唯一Id。  此Id由资源编排服务在生成执行计划的时候生成，为UUID。  由于执行计划名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的执行计划，删除，再重新创建一个同名执行计划。  对于团队并行开发，用户可能希望确保，当前我操作的执行计划就是我认为的那个，而不是其他队友删除后创建的同名执行计划。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的执行计划所对应的ID都不相同，更新不会影响ID。如果给与的execution_plan_id和当前执行计划的ID不一致，则返回400
        /// </summary>
        [JsonProperty("execution_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanId { get; set; }

        /// <summary>
        /// 资源栈（stack）的唯一Id。  此Id由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给与的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyExecutionPlanRequestBody {\n");
            sb.Append("  executionPlanId: ").Append(ExecutionPlanId).Append("\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
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
                    this.ExecutionPlanId == input.ExecutionPlanId ||
                    (this.ExecutionPlanId != null &&
                    this.ExecutionPlanId.Equals(input.ExecutionPlanId))
                ) && 
                (
                    this.StackId == input.StackId ||
                    (this.StackId != null &&
                    this.StackId.Equals(input.StackId))
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
                if (this.ExecutionPlanId != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanId.GetHashCode();
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                return hashCode;
            }
        }
    }
}
