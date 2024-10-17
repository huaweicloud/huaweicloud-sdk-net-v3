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
    public class ApplyExecutionPlanResponse : SdkResponse
    {

        /// <summary>
        /// 标识部署的唯一Id，此Id由资源编排服务在触发部署、回滚等操作时生成，为UUID。  接受请求，进行异步处理。可以调用GetStackMetadata来获取异步请求的部署状态  **注意：** * 部署资源栈后，资源编排服务持久化请求并立即返回，客户端不等待请求最终处理完成，用户无法实时感知请求处理结果 * 资源编排服务最终会将异步部署请求排队，在服务端空闲的情况下逐个处理。用户最大等待时长为6小时
        /// </summary>
        [JsonProperty("deployment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyExecutionPlanResponse {\n");
            sb.Append("  deploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyExecutionPlanResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyExecutionPlanResponse input)
        {
            if (input == null) return false;
            if (this.DeploymentId != input.DeploymentId || (this.DeploymentId != null && !this.DeploymentId.Equals(input.DeploymentId))) return false;

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
                if (this.DeploymentId != null) hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
