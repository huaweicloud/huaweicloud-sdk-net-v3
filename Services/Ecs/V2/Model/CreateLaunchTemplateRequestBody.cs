using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateLaunchTemplateRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("launch_template", NullValueHandling = NullValueHandling.Ignore)]
        public LaunchTemplateOption LaunchTemplate { get; set; }

        /// <summary>
        /// 预检，只校验权限等初级信息。
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLaunchTemplateRequestBody {\n");
            sb.Append("  launchTemplate: ").Append(LaunchTemplate).Append("\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLaunchTemplateRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLaunchTemplateRequestBody input)
        {
            if (input == null) return false;
            if (this.LaunchTemplate != input.LaunchTemplate || (this.LaunchTemplate != null && !this.LaunchTemplate.Equals(input.LaunchTemplate))) return false;
            if (this.DryRun != input.DryRun || (this.DryRun != null && !this.DryRun.Equals(input.DryRun))) return false;

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
                if (this.LaunchTemplate != null) hashCode = hashCode * 59 + this.LaunchTemplate.GetHashCode();
                if (this.DryRun != null) hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                return hashCode;
            }
        }
    }
}
