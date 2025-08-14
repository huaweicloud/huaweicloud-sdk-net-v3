using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProjectConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project_config", NullValueHandling = NullValueHandling.Ignore)]
        public ProjectConfig ProjectConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProjectConfigResponse {\n");
            sb.Append("  projectConfig: ").Append(ProjectConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProjectConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProjectConfigResponse input)
        {
            if (input == null) return false;
            if (this.ProjectConfig != input.ProjectConfig || (this.ProjectConfig != null && !this.ProjectConfig.Equals(input.ProjectConfig))) return false;

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
                if (this.ProjectConfig != null) hashCode = hashCode * 59 + this.ProjectConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
