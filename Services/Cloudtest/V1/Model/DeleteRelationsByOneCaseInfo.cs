using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteRelationsByOneCaseInfo 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("work_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WorkItemIds { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 版本uri
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }

        /// <summary>
        /// 关联关系类型
        /// </summary>
        [JsonProperty("relate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelateType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRelationsByOneCaseInfo {\n");
            sb.Append("  workItemIds: ").Append(WorkItemIds).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("  relateType: ").Append(RelateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteRelationsByOneCaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteRelationsByOneCaseInfo input)
        {
            if (input == null) return false;
            if (this.WorkItemIds != input.WorkItemIds || (this.WorkItemIds != null && input.WorkItemIds != null && !this.WorkItemIds.SequenceEqual(input.WorkItemIds))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;
            if (this.RelateType != input.RelateType || (this.RelateType != null && !this.RelateType.Equals(input.RelateType))) return false;

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
                if (this.WorkItemIds != null) hashCode = hashCode * 59 + this.WorkItemIds.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                if (this.RelateType != null) hashCode = hashCode * 59 + this.RelateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
