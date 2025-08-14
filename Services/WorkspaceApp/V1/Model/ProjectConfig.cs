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
    /// 项目配置信息。
    /// </summary>
    public class ProjectConfig 
    {

        /// <summary>
        /// 项目配置名称。
        /// </summary>
        [JsonProperty("project_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectConfigId { get; set; }

        /// <summary>
        /// 项目名称。
        /// </summary>
        [JsonProperty("project_config_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectConfigName { get; set; }

        /// <summary>
        /// 存储配额。
        /// </summary>
        [JsonProperty("storage_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? StorageQuota { get; set; }

        /// <summary>
        /// 是否已经关联
        /// </summary>
        [JsonProperty("is_relevance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRelevance { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectConfig {\n");
            sb.Append("  projectConfigId: ").Append(ProjectConfigId).Append("\n");
            sb.Append("  projectConfigName: ").Append(ProjectConfigName).Append("\n");
            sb.Append("  storageQuota: ").Append(StorageQuota).Append("\n");
            sb.Append("  isRelevance: ").Append(IsRelevance).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectConfig input)
        {
            if (input == null) return false;
            if (this.ProjectConfigId != input.ProjectConfigId || (this.ProjectConfigId != null && !this.ProjectConfigId.Equals(input.ProjectConfigId))) return false;
            if (this.ProjectConfigName != input.ProjectConfigName || (this.ProjectConfigName != null && !this.ProjectConfigName.Equals(input.ProjectConfigName))) return false;
            if (this.StorageQuota != input.StorageQuota || (this.StorageQuota != null && !this.StorageQuota.Equals(input.StorageQuota))) return false;
            if (this.IsRelevance != input.IsRelevance || (this.IsRelevance != null && !this.IsRelevance.Equals(input.IsRelevance))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.ProjectConfigId != null) hashCode = hashCode * 59 + this.ProjectConfigId.GetHashCode();
                if (this.ProjectConfigName != null) hashCode = hashCode * 59 + this.ProjectConfigName.GetHashCode();
                if (this.StorageQuota != null) hashCode = hashCode * 59 + this.StorageQuota.GetHashCode();
                if (this.IsRelevance != null) hashCode = hashCode * 59 + this.IsRelevance.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
