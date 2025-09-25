using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// **参数解释**： 制品源参数。 **取值范围**： 不涉及。 
    /// </summary>
    public class PipelineLatestRunArtifactParams 
    {

        /// <summary>
        /// **参数解释**： 包版本。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**： 过滤分支。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("branch_filter", NullValueHandling = NullValueHandling.Ignore)]
        public string BranchFilter { get; set; }

        /// <summary>
        /// **参数解释**： 包名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("package_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageName { get; set; }

        /// <summary>
        /// **参数解释**： docker组织。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
        public string Organization { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineLatestRunArtifactParams {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  branchFilter: ").Append(BranchFilter).Append("\n");
            sb.Append("  packageName: ").Append(PackageName).Append("\n");
            sb.Append("  organization: ").Append(Organization).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineLatestRunArtifactParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineLatestRunArtifactParams input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.BranchFilter != input.BranchFilter || (this.BranchFilter != null && !this.BranchFilter.Equals(input.BranchFilter))) return false;
            if (this.PackageName != input.PackageName || (this.PackageName != null && !this.PackageName.Equals(input.PackageName))) return false;
            if (this.Organization != input.Organization || (this.Organization != null && !this.Organization.Equals(input.Organization))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.BranchFilter != null) hashCode = hashCode * 59 + this.BranchFilter.GetHashCode();
                if (this.PackageName != null) hashCode = hashCode * 59 + this.PackageName.GetHashCode();
                if (this.Organization != null) hashCode = hashCode * 59 + this.Organization.GetHashCode();
                return hashCode;
            }
        }
    }
}
