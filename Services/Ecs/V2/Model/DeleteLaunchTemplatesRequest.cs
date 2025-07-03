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
    /// Request Object
    /// </summary>
    public class DeleteLaunchTemplatesRequest 
    {

        /// <summary>
        /// 模板ID。
        /// </summary>
        [SDKProperty("launch_template_id", IsPath = true)]
        [JsonProperty("launch_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LaunchTemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteLaunchTemplatesRequest {\n");
            sb.Append("  launchTemplateId: ").Append(LaunchTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteLaunchTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteLaunchTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.LaunchTemplateId != input.LaunchTemplateId || (this.LaunchTemplateId != null && !this.LaunchTemplateId.Equals(input.LaunchTemplateId))) return false;

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
                if (this.LaunchTemplateId != null) hashCode = hashCode * 59 + this.LaunchTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
