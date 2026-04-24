using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CompareUserInfo 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 源数据库账号名称
        /// </summary>
        [JsonProperty("src_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcUserName { get; set; }

        /// <summary>
        /// 目标数据库账号名称
        /// </summary>
        [JsonProperty("tar_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TarUserName { get; set; }

        /// <summary>
        /// 源数据库账号权限
        /// </summary>
        [JsonProperty("src_privileges", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcPrivileges { get; set; }

        /// <summary>
        /// 目标数据库账号权限
        /// </summary>
        [JsonProperty("tar_privileges", NullValueHandling = NullValueHandling.Ignore)]
        public string TarPrivileges { get; set; }

        /// <summary>
        /// 目标端是否存在，取值： - false：不存在 - true：存在
        /// </summary>
        [JsonProperty("is_target_existed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTargetExisted { get; set; }

        /// <summary>
        /// 对比结果，取值： - INCONSISTENT：不一致 - UNABLE_TO_COMPARE：无法比对 - CONSISTENT：一致 - TARGET_SCHEMA_NOT_EXIST：目标库不存在 - COMPARE_FAILED：比对失败 - COMPARING：比对中 - WAITING_COMPARE：等待比对 - UNKNOWN：未知错误
        /// </summary>
        [JsonProperty("compare_result", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompareResult { get; set; }

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
            sb.Append("class CompareUserInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  srcUserName: ").Append(SrcUserName).Append("\n");
            sb.Append("  tarUserName: ").Append(TarUserName).Append("\n");
            sb.Append("  srcPrivileges: ").Append(SrcPrivileges).Append("\n");
            sb.Append("  tarPrivileges: ").Append(TarPrivileges).Append("\n");
            sb.Append("  isTargetExisted: ").Append(IsTargetExisted).Append("\n");
            sb.Append("  compareResult: ").Append(CompareResult).Append("\n");
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
            return this.Equals(input as CompareUserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareUserInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SrcUserName != input.SrcUserName || (this.SrcUserName != null && !this.SrcUserName.Equals(input.SrcUserName))) return false;
            if (this.TarUserName != input.TarUserName || (this.TarUserName != null && !this.TarUserName.Equals(input.TarUserName))) return false;
            if (this.SrcPrivileges != input.SrcPrivileges || (this.SrcPrivileges != null && !this.SrcPrivileges.Equals(input.SrcPrivileges))) return false;
            if (this.TarPrivileges != input.TarPrivileges || (this.TarPrivileges != null && !this.TarPrivileges.Equals(input.TarPrivileges))) return false;
            if (this.IsTargetExisted != input.IsTargetExisted || (this.IsTargetExisted != null && !this.IsTargetExisted.Equals(input.IsTargetExisted))) return false;
            if (this.CompareResult != input.CompareResult || (this.CompareResult != null && !this.CompareResult.Equals(input.CompareResult))) return false;
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
                if (this.SrcUserName != null) hashCode = hashCode * 59 + this.SrcUserName.GetHashCode();
                if (this.TarUserName != null) hashCode = hashCode * 59 + this.TarUserName.GetHashCode();
                if (this.SrcPrivileges != null) hashCode = hashCode * 59 + this.SrcPrivileges.GetHashCode();
                if (this.TarPrivileges != null) hashCode = hashCode * 59 + this.TarPrivileges.GetHashCode();
                if (this.IsTargetExisted != null) hashCode = hashCode * 59 + this.IsTargetExisted.GetHashCode();
                if (this.CompareResult != null) hashCode = hashCode * 59 + this.CompareResult.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
