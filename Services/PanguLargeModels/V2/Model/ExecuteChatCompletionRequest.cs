using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.PanguLargeModels.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ExecuteChatCompletionRequest 
    {

        /// <summary>
        /// 资源池ID
        /// </summary>
        [SDKProperty("pool_id", IsPath = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 模型的部署ID
        /// </summary>
        [SDKProperty("deployment_id", IsPath = true)]
        [JsonProperty("deployment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ChatCompletionReq Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteChatCompletionRequest {\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  deploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteChatCompletionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteChatCompletionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoolId == input.PoolId ||
                    (this.PoolId != null &&
                    this.PoolId.Equals(input.PoolId))
                ) && 
                (
                    this.DeploymentId == input.DeploymentId ||
                    (this.DeploymentId != null &&
                    this.DeploymentId.Equals(input.DeploymentId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.PoolId != null)
                    hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.DeploymentId != null)
                    hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
