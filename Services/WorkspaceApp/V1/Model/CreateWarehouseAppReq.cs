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
    /// 先上传应用文件，再提交向应用仓库中添加应用的请求。
    /// </summary>
    public class CreateWarehouseAppReq 
    {

        /// <summary>
        /// 应用名称,名称需满足如下规则: 1. 由中文，英文大小写，数字，_-组成。 2. 长度范围1~64个字符。
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
        /// 版本号,名称需满足如下规则: 1. 由可见字符组成。 2. 长度范围1~64个字符。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// 应用仓库中的应用描述。
        /// </summary>
        [JsonProperty("app_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AppDescription { get; set; }

        /// <summary>
        /// 版本描述,名称需满足如下规则: 1. 由可见字符组成。 2. 长度范围1~255个字符。
        /// </summary>
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 应用在obs桶的存储路径。
        /// </summary>
        [JsonProperty("appfile_store_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AppfileStorePath { get; set; }

        /// <summary>
        /// &gt; - 图片的默认大小当前限制为8KB，即1024 * 8字节。 &gt; - 如果数据格式为data;image/png;base64,iVBORw0KGgoAAAANS时实际大小约为字段约为：size * 4/3 + 4bytes。
        /// </summary>
        [JsonProperty("app_icon", NullValueHandling = NullValueHandling.Ignore)]
        public string AppIcon { get; set; }

        /// <summary>
        /// 应用文件大小，单位为KB。
        /// </summary>
        [JsonProperty("app_file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppFileSize { get; set; }

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
            sb.Append("class CreateWarehouseAppReq {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appCategory: ").Append(AppCategory).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  appDescription: ").Append(AppDescription).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  appfileStorePath: ").Append(AppfileStorePath).Append("\n");
            sb.Append("  appIcon: ").Append(AppIcon).Append("\n");
            sb.Append("  appFileSize: ").Append(AppFileSize).Append("\n");
            sb.Append("  appExtendedInfo: ").Append(AppExtendedInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWarehouseAppReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateWarehouseAppReq input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppCategory != input.AppCategory) return false;
            if (this.OsType != input.OsType) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.AppDescription != input.AppDescription || (this.AppDescription != null && !this.AppDescription.Equals(input.AppDescription))) return false;
            if (this.VersionName != input.VersionName || (this.VersionName != null && !this.VersionName.Equals(input.VersionName))) return false;
            if (this.AppfileStorePath != input.AppfileStorePath || (this.AppfileStorePath != null && !this.AppfileStorePath.Equals(input.AppfileStorePath))) return false;
            if (this.AppIcon != input.AppIcon || (this.AppIcon != null && !this.AppIcon.Equals(input.AppIcon))) return false;
            if (this.AppFileSize != input.AppFileSize || (this.AppFileSize != null && !this.AppFileSize.Equals(input.AppFileSize))) return false;
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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                hashCode = hashCode * 59 + this.AppCategory.GetHashCode();
                hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.AppDescription != null) hashCode = hashCode * 59 + this.AppDescription.GetHashCode();
                if (this.VersionName != null) hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.AppfileStorePath != null) hashCode = hashCode * 59 + this.AppfileStorePath.GetHashCode();
                if (this.AppIcon != null) hashCode = hashCode * 59 + this.AppIcon.GetHashCode();
                if (this.AppFileSize != null) hashCode = hashCode * 59 + this.AppFileSize.GetHashCode();
                if (this.AppExtendedInfo != null) hashCode = hashCode * 59 + this.AppExtendedInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
