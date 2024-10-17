using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TemplateListV4ResponseBodyTemplates 
    {

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectId { get; set; }

        /// <summary>
        /// 工作项类型id
        /// </summary>
        [JsonProperty("tracker_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TrackerId { get; set; }

        /// <summary>
        /// 工作项详情模板描述内容
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 模板配置
        /// </summary>
        [JsonProperty("issue_field_config", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueFieldConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateListV4ResponseBodyTemplates {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  trackerId: ").Append(TrackerId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  issueFieldConfig: ").Append(IssueFieldConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateListV4ResponseBodyTemplates);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateListV4ResponseBodyTemplates input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.TrackerId != input.TrackerId || (this.TrackerId != null && !this.TrackerId.Equals(input.TrackerId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IssueFieldConfig != input.IssueFieldConfig || (this.IssueFieldConfig != null && !this.IssueFieldConfig.Equals(input.IssueFieldConfig))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TrackerId != null) hashCode = hashCode * 59 + this.TrackerId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IssueFieldConfig != null) hashCode = hashCode * 59 + this.IssueFieldConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
