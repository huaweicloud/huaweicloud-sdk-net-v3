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
    /// 应用仓库中的应用详细信息。
    /// </summary>
    public class WarehouseApp 
    {

        /// <summary>
        /// 应用的记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_category", NullValueHandling = NullValueHandling.Ignore)]
        public AppCategoryEnum AppCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 版本号。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 版本名称。
        /// </summary>
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 应用文件的存放路径。
        /// </summary>
        [JsonProperty("appfile_store_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AppfileStorePath { get; set; }

        /// <summary>
        /// 应用文件的大小，以KB为单位。
        /// </summary>
        [JsonProperty("app_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public string AppFileSize { get; set; }

        /// <summary>
        /// 应用描述。
        /// </summary>
        [JsonProperty("app_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AppDescription { get; set; }

        /// <summary>
        /// 应用文件的存放路径。
        /// </summary>
        [JsonProperty("appicon_store_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AppiconStorePath { get; set; }

        /// <summary>
        /// 应用创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 应用修改时间。
        /// </summary>
        [JsonProperty("modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// 应用审核时间。
        /// </summary>
        [JsonProperty("verify_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? VerifyTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("verify_status", NullValueHandling = NullValueHandling.Ignore)]
        public VerifyStatusEnum VerifyStatus { get; set; }
        /// <summary>
        /// 审核的评论意见。
        /// </summary>
        [JsonProperty("verify_comment", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyComment { get; set; }

        /// <summary>
        /// app的图标文件。
        /// </summary>
        [JsonProperty("app_icon", NullValueHandling = NullValueHandling.Ignore)]
        public string AppIcon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app_extended_info", NullValueHandling = NullValueHandling.Ignore)]
        public AppExtendedInfo AppExtendedInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WarehouseApp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appCategory: ").Append(AppCategory).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  appfileStorePath: ").Append(AppfileStorePath).Append("\n");
            sb.Append("  appFileSize: ").Append(AppFileSize).Append("\n");
            sb.Append("  appDescription: ").Append(AppDescription).Append("\n");
            sb.Append("  appiconStorePath: ").Append(AppiconStorePath).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  modifyTime: ").Append(ModifyTime).Append("\n");
            sb.Append("  verifyTime: ").Append(VerifyTime).Append("\n");
            sb.Append("  verifyStatus: ").Append(VerifyStatus).Append("\n");
            sb.Append("  verifyComment: ").Append(VerifyComment).Append("\n");
            sb.Append("  appIcon: ").Append(AppIcon).Append("\n");
            sb.Append("  appExtendedInfo: ").Append(AppExtendedInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WarehouseApp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WarehouseApp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppCategory != input.AppCategory) return false;
            if (this.OsType != input.OsType) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.AppfileStorePath != input.AppfileStorePath || (this.AppfileStorePath != null && !this.AppfileStorePath.Equals(input.AppfileStorePath))) return false;
            if (this.AppFileSize != input.AppFileSize || (this.AppFileSize != null && !this.AppFileSize.Equals(input.AppFileSize))) return false;
            if (this.AppDescription != input.AppDescription || (this.AppDescription != null && !this.AppDescription.Equals(input.AppDescription))) return false;
            if (this.AppiconStorePath != input.AppiconStorePath || (this.AppiconStorePath != null && !this.AppiconStorePath.Equals(input.AppiconStorePath))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ModifyTime != input.ModifyTime || (this.ModifyTime != null && !this.ModifyTime.Equals(input.ModifyTime))) return false;
            if (this.VerifyTime != input.VerifyTime || (this.VerifyTime != null && !this.VerifyTime.Equals(input.VerifyTime))) return false;
            if (this.VerifyStatus != input.VerifyStatus) return false;
            if (this.VerifyComment != input.VerifyComment || (this.VerifyComment != null && !this.VerifyComment.Equals(input.VerifyComment))) return false;
            if (this.AppIcon != input.AppIcon || (this.AppIcon != null && !this.AppIcon.Equals(input.AppIcon))) return false;
            if (this.AppExtendedInfo != input.AppExtendedInfo || (this.AppExtendedInfo != null && !this.AppExtendedInfo.Equals(input.AppExtendedInfo))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                hashCode = hashCode * 59 + this.AppCategory.GetHashCode();
                hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.AppfileStorePath != null) hashCode = hashCode * 59 + this.AppfileStorePath.GetHashCode();
                if (this.AppFileSize != null) hashCode = hashCode * 59 + this.AppFileSize.GetHashCode();
                if (this.AppDescription != null) hashCode = hashCode * 59 + this.AppDescription.GetHashCode();
                if (this.AppiconStorePath != null) hashCode = hashCode * 59 + this.AppiconStorePath.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ModifyTime != null) hashCode = hashCode * 59 + this.ModifyTime.GetHashCode();
                if (this.VerifyTime != null) hashCode = hashCode * 59 + this.VerifyTime.GetHashCode();
                hashCode = hashCode * 59 + this.VerifyStatus.GetHashCode();
                if (this.VerifyComment != null) hashCode = hashCode * 59 + this.VerifyComment.GetHashCode();
                if (this.AppIcon != null) hashCode = hashCode * 59 + this.AppIcon.GetHashCode();
                if (this.AppExtendedInfo != null) hashCode = hashCode * 59 + this.AppExtendedInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
