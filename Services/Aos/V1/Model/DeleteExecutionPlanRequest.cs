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
    /// Request Object
    /// </summary>
    public class DeleteExecutionPlanRequest 
    {

        /// <summary>
        /// 用户指定的，对于此请求的唯一ID，用于定位某个请求，推荐使用UUID
        /// </summary>
        [SDKProperty("Client-Request-Id", IsHeader = true)]
        [JsonProperty("Client-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// 资源栈的名称。此名字在domain_id+区域+project_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [SDKProperty("stack_name", IsPath = true)]
        [JsonProperty("stack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StackName { get; set; }

        /// <summary>
        /// 执行计划的名称。此名字在domain_id+区域+project_id+stack_id下应唯一，可以使用中文、大小写英文、数字、下划线、中划线。首字符需为中文或者英文，区分大小写。
        /// </summary>
        [SDKProperty("execution_plan_name", IsPath = true)]
        [JsonProperty("execution_plan_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanName { get; set; }

        /// <summary>
        /// 资源栈（stack）的唯一Id。  此Id由资源编排服务在生成资源栈的时候生成，为UUID。  由于资源栈名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈，删除，再重新创建一个同名资源栈。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈就是我认为的那个，而不是其他队友删除后创建的同名资源栈。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈所对应的ID都不相同，更新不会影响ID。如果给与的stack_id和当前资源栈的ID不一致，则返回400
        /// </summary>
        [SDKProperty("stack_id", IsQuery = true)]
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }

        /// <summary>
        /// 执行计划（execution_plan）的唯一Id。  此Id由资源编排服务在生成执行计划的时候生成，为UUID。  由于执行计划名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的执行计划，删除，再重新创建一个同名执行计划。  对于团队并行开发，用户可能希望确保，当前我操作的执行计划就是我认为的那个，而不是其他队友删除后创建的同名执行计划。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的执行计划所对应的ID都不相同，更新不会影响ID。如果给与的execution_plan_id和当前执行计划的ID不一致，则返回400
        /// </summary>
        [SDKProperty("execution_plan_id", IsQuery = true)]
        [JsonProperty("execution_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionPlanId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteExecutionPlanRequest {\n");
            sb.Append("  clientRequestId: ").Append(ClientRequestId).Append("\n");
            sb.Append("  stackName: ").Append(StackName).Append("\n");
            sb.Append("  executionPlanName: ").Append(ExecutionPlanName).Append("\n");
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
            return this.Equals(input as DeleteExecutionPlanRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteExecutionPlanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ClientRequestId == input.ClientRequestId ||
                    (this.ClientRequestId != null &&
                    this.ClientRequestId.Equals(input.ClientRequestId))
                ) && 
                (
                    this.StackName == input.StackName ||
                    (this.StackName != null &&
                    this.StackName.Equals(input.StackName))
                ) && 
                (
                    this.ExecutionPlanName == input.ExecutionPlanName ||
                    (this.ExecutionPlanName != null &&
                    this.ExecutionPlanName.Equals(input.ExecutionPlanName))
                ) && 
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
                if (this.ClientRequestId != null)
                    hashCode = hashCode * 59 + this.ClientRequestId.GetHashCode();
                if (this.StackName != null)
                    hashCode = hashCode * 59 + this.StackName.GetHashCode();
                if (this.ExecutionPlanName != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanName.GetHashCode();
                if (this.StackId != null)
                    hashCode = hashCode * 59 + this.StackId.GetHashCode();
                if (this.ExecutionPlanId != null)
                    hashCode = hashCode * 59 + this.ExecutionPlanId.GetHashCode();
                return hashCode;
            }
        }
    }
}
