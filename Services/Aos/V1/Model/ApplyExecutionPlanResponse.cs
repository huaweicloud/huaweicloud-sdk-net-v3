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
        /// 部署生成的唯一ID，由IAC生成
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
            if (input == null)
                return false;

            return 
                (
                    this.DeploymentId == input.DeploymentId ||
                    (this.DeploymentId != null &&
                    this.DeploymentId.Equals(input.DeploymentId))
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
                if (this.DeploymentId != null)
                    hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
