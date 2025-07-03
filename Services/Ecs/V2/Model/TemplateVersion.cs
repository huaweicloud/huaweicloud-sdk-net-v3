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
    public class TemplateVersion 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("template_data", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateData TemplateData { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// 版本id
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 版本描述
        /// </summary>
        [JsonProperty("version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("launch_template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LaunchTemplateId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateVersion {\n");
            sb.Append("  templateData: ").Append(TemplateData).Append("\n");
            sb.Append("  versionNumber: ").Append(VersionNumber).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  versionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  launchTemplateId: ").Append(LaunchTemplateId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateVersion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateVersion input)
        {
            if (input == null) return false;
            if (this.TemplateData != input.TemplateData || (this.TemplateData != null && !this.TemplateData.Equals(input.TemplateData))) return false;
            if (this.VersionNumber != input.VersionNumber || (this.VersionNumber != null && !this.VersionNumber.Equals(input.VersionNumber))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.VersionDescription != input.VersionDescription || (this.VersionDescription != null && !this.VersionDescription.Equals(input.VersionDescription))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
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
                if (this.TemplateData != null) hashCode = hashCode * 59 + this.TemplateData.GetHashCode();
                if (this.VersionNumber != null) hashCode = hashCode * 59 + this.VersionNumber.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.VersionDescription != null) hashCode = hashCode * 59 + this.VersionDescription.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.LaunchTemplateId != null) hashCode = hashCode * 59 + this.LaunchTemplateId.GetHashCode();
                return hashCode;
            }
        }
    }
}
