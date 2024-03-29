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
    public class CreateStackInstanceRequestBody 
    {

        /// <summary>
        /// 资源栈集（stack_set）的唯一ID。  此ID由资源编排服务在生成资源栈集的时候生成，为UUID。  由于资源栈集名仅仅在同一时间下唯一，即用户允许先生成一个叫HelloWorld的资源栈集，删除，在重新创建一个同名资源栈集。  对于团队并行开发，用户可能希望确保，当前我操作的资源栈集就是我以为的那个，而不是又其他队友删除后创建的同名资源栈集。因此，使用ID就可以做到强匹配。  资源编排服务保证每次创建的资源栈集所对应的ID都不相同，更新不会影响ID。如果给予的stack_set_id和当前资源栈集的ID不一致，则返回400
        /// </summary>
        [JsonProperty("stack_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackSetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deployment_targets", NullValueHandling = NullValueHandling.Ignore)]
        public DeploymentTargets DeploymentTargets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("var_overrides", NullValueHandling = NullValueHandling.Ignore)]
        public VarOverridesPrimitiveTypeHolderVarOverrides VarOverrides { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateStackInstanceRequestBody {\n");
            sb.Append("  stackSetId: ").Append(StackSetId).Append("\n");
            sb.Append("  deploymentTargets: ").Append(DeploymentTargets).Append("\n");
            sb.Append("  varOverrides: ").Append(VarOverrides).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateStackInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateStackInstanceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StackSetId == input.StackSetId ||
                    (this.StackSetId != null &&
                    this.StackSetId.Equals(input.StackSetId))
                ) && 
                (
                    this.DeploymentTargets == input.DeploymentTargets ||
                    (this.DeploymentTargets != null &&
                    this.DeploymentTargets.Equals(input.DeploymentTargets))
                ) && 
                (
                    this.VarOverrides == input.VarOverrides ||
                    (this.VarOverrides != null &&
                    this.VarOverrides.Equals(input.VarOverrides))
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
                if (this.StackSetId != null)
                    hashCode = hashCode * 59 + this.StackSetId.GetHashCode();
                if (this.DeploymentTargets != null)
                    hashCode = hashCode * 59 + this.DeploymentTargets.GetHashCode();
                if (this.VarOverrides != null)
                    hashCode = hashCode * 59 + this.VarOverrides.GetHashCode();
                return hashCode;
            }
        }
    }
}
