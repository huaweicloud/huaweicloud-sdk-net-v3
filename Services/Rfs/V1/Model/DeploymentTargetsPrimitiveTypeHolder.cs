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
    /// 
    /// </summary>
    public class DeploymentTargetsPrimitiveTypeHolder 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deployment_targets", NullValueHandling = NullValueHandling.Ignore)]
        public DeploymentTargets DeploymentTargets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentTargetsPrimitiveTypeHolder {\n");
            sb.Append("  deploymentTargets: ").Append(DeploymentTargets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentTargetsPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentTargetsPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.DeploymentTargets != input.DeploymentTargets || (this.DeploymentTargets != null && !this.DeploymentTargets.Equals(input.DeploymentTargets))) return false;

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
                if (this.DeploymentTargets != null) hashCode = hashCode * 59 + this.DeploymentTargets.GetHashCode();
                return hashCode;
            }
        }
    }
}
