using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTenantVersionConfigResponse : SdkResponse
    {

        /// <summary>
        /// 租户版本配置ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 关联版本配置表ID
        /// </summary>
        [JsonProperty("version_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionConfigId { get; set; }

        /// <summary>
        /// 自定义版本说明
        /// </summary>
        [JsonProperty("custom_release_note", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomReleaseNote { get; set; }

        /// <summary>
        /// 更新说明
        /// </summary>
        [JsonProperty("release_note", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// 版本下载地址
        /// </summary>
        [JsonProperty("version_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDownloadUrl { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTenantVersionConfigResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  versionConfigId: ").Append(VersionConfigId).Append("\n");
            sb.Append("  customReleaseNote: ").Append(CustomReleaseNote).Append("\n");
            sb.Append("  releaseNote: ").Append(ReleaseNote).Append("\n");
            sb.Append("  versionDownloadUrl: ").Append(VersionDownloadUrl).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTenantVersionConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTenantVersionConfigResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.VersionConfigId != input.VersionConfigId || (this.VersionConfigId != null && !this.VersionConfigId.Equals(input.VersionConfigId))) return false;
            if (this.CustomReleaseNote != input.CustomReleaseNote || (this.CustomReleaseNote != null && !this.CustomReleaseNote.Equals(input.CustomReleaseNote))) return false;
            if (this.ReleaseNote != input.ReleaseNote || (this.ReleaseNote != null && !this.ReleaseNote.Equals(input.ReleaseNote))) return false;
            if (this.VersionDownloadUrl != input.VersionDownloadUrl || (this.VersionDownloadUrl != null && !this.VersionDownloadUrl.Equals(input.VersionDownloadUrl))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.VersionConfigId != null) hashCode = hashCode * 59 + this.VersionConfigId.GetHashCode();
                if (this.CustomReleaseNote != null) hashCode = hashCode * 59 + this.CustomReleaseNote.GetHashCode();
                if (this.ReleaseNote != null) hashCode = hashCode * 59 + this.ReleaseNote.GetHashCode();
                if (this.VersionDownloadUrl != null) hashCode = hashCode * 59 + this.VersionDownloadUrl.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
