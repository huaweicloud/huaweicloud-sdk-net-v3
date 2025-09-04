using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 创建更新分组请求体
    /// </summary>
    public class RolePermissionsRequestBody 
    {

        /// <summary>
        /// CodeArts项目ID。获取方式请参考[获取CodeArts项目ID](https://support.huaweicloud.com/api-codeci/cloudbuild_03_0022.html)。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 任务id集合
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// 是否同步最新项目权限
        /// </summary>
        [JsonProperty("project_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProjectSwitch { get; set; }

        /// <summary>
        /// 角色权限信息
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobRolePermission> Permissions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RolePermissionsRequestBody {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("  projectSwitch: ").Append(ProjectSwitch).Append("\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RolePermissionsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RolePermissionsRequestBody input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.JobIds != input.JobIds || (this.JobIds != null && input.JobIds != null && !this.JobIds.SequenceEqual(input.JobIds))) return false;
            if (this.ProjectSwitch != input.ProjectSwitch || (this.ProjectSwitch != null && !this.ProjectSwitch.Equals(input.ProjectSwitch))) return false;
            if (this.Permissions != input.Permissions || (this.Permissions != null && input.Permissions != null && !this.Permissions.SequenceEqual(input.Permissions))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.JobIds != null) hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.ProjectSwitch != null) hashCode = hashCode * 59 + this.ProjectSwitch.GetHashCode();
                if (this.Permissions != null) hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                return hashCode;
            }
        }
    }
}
