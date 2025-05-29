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
    /// 
    /// </summary>
    public class ShowJobRolePermissionResult 
    {

        /// <summary>
        /// 数据库中ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RoleId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [JsonProperty("role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleName { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 是否有修改任务权限
        /// </summary>
        [JsonProperty("is_modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsModify { get; set; }

        /// <summary>
        /// 是否有删除任务权限
        /// </summary>
        [JsonProperty("is_delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDelete { get; set; }

        /// <summary>
        /// 是否有查看任务权限
        /// </summary>
        [JsonProperty("is_view", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsView { get; set; }

        /// <summary>
        /// 是否有执行任务权限
        /// </summary>
        [JsonProperty("is_execute", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExecute { get; set; }

        /// <summary>
        /// 是否有复制任务权限
        /// </summary>
        [JsonProperty("is_copy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCopy { get; set; }

        /// <summary>
        /// 是否有禁用任务权限
        /// </summary>
        [JsonProperty("is_forbidden", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsForbidden { get; set; }

        /// <summary>
        /// 是否有管理任务权限
        /// </summary>
        [JsonProperty("is_manager", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsManager { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务最后修改时间
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobRolePermissionResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  roleName: ").Append(RoleName).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isModify: ").Append(IsModify).Append("\n");
            sb.Append("  isDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  isView: ").Append(IsView).Append("\n");
            sb.Append("  isExecute: ").Append(IsExecute).Append("\n");
            sb.Append("  isCopy: ").Append(IsCopy).Append("\n");
            sb.Append("  isForbidden: ").Append(IsForbidden).Append("\n");
            sb.Append("  isManager: ").Append(IsManager).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobRolePermissionResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobRolePermissionResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RoleId != input.RoleId || (this.RoleId != null && !this.RoleId.Equals(input.RoleId))) return false;
            if (this.RoleName != input.RoleName || (this.RoleName != null && !this.RoleName.Equals(input.RoleName))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.IsModify != input.IsModify || (this.IsModify != null && !this.IsModify.Equals(input.IsModify))) return false;
            if (this.IsDelete != input.IsDelete || (this.IsDelete != null && !this.IsDelete.Equals(input.IsDelete))) return false;
            if (this.IsView != input.IsView || (this.IsView != null && !this.IsView.Equals(input.IsView))) return false;
            if (this.IsExecute != input.IsExecute || (this.IsExecute != null && !this.IsExecute.Equals(input.IsExecute))) return false;
            if (this.IsCopy != input.IsCopy || (this.IsCopy != null && !this.IsCopy.Equals(input.IsCopy))) return false;
            if (this.IsForbidden != input.IsForbidden || (this.IsForbidden != null && !this.IsForbidden.Equals(input.IsForbidden))) return false;
            if (this.IsManager != input.IsManager || (this.IsManager != null && !this.IsManager.Equals(input.IsManager))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;

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
                if (this.RoleId != null) hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.RoleName != null) hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsModify != null) hashCode = hashCode * 59 + this.IsModify.GetHashCode();
                if (this.IsDelete != null) hashCode = hashCode * 59 + this.IsDelete.GetHashCode();
                if (this.IsView != null) hashCode = hashCode * 59 + this.IsView.GetHashCode();
                if (this.IsExecute != null) hashCode = hashCode * 59 + this.IsExecute.GetHashCode();
                if (this.IsCopy != null) hashCode = hashCode * 59 + this.IsCopy.GetHashCode();
                if (this.IsForbidden != null) hashCode = hashCode * 59 + this.IsForbidden.GetHashCode();
                if (this.IsManager != null) hashCode = hashCode * 59 + this.IsManager.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
