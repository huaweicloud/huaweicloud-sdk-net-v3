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
    /// 服务端版本信息
    /// </summary>
    public class TenantVersionInfo 
    {

        /// <summary>
        /// 版本ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 版本类型：0-服务端 1-客户端
        /// </summary>
        [JsonProperty("version_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionType { get; set; }

        /// <summary>
        /// 操作系统类型：0-windows 1-android 2-mac 3-linux_UOS 4-linux_ubuntu 5-linux_Kylin 6-linux 7-linux_ubuntu_soft 8-linux_kylin_v10
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OsType { get; set; }

        /// <summary>
        /// 更新说明
        /// </summary>
        [JsonProperty("release_note", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// 租户自定义更新说明
        /// </summary>
        [JsonProperty("custom_release_note", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomReleaseNote { get; set; }

        /// <summary>
        /// 版本下载地址
        /// </summary>
        [JsonProperty("version_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionDownloadUrl { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 版本状态：PREVIEW-预览 RELEASED-已发布 OFFLINE-已下线 OBSOLETE-已废弃
        /// </summary>
        [JsonProperty("version_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionStatus { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("publish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTime { get; set; }

        /// <summary>
        /// 停止服务时间
        /// </summary>
        [JsonProperty("stop_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StopTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantVersionInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionType: ").Append(VersionType).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  releaseNote: ").Append(ReleaseNote).Append("\n");
            sb.Append("  customReleaseNote: ").Append(CustomReleaseNote).Append("\n");
            sb.Append("  versionDownloadUrl: ").Append(VersionDownloadUrl).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  versionStatus: ").Append(VersionStatus).Append("\n");
            sb.Append("  publishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  stopTime: ").Append(StopTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TenantVersionInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TenantVersionInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionType != input.VersionType || (this.VersionType != null && !this.VersionType.Equals(input.VersionType))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.ReleaseNote != input.ReleaseNote || (this.ReleaseNote != null && !this.ReleaseNote.Equals(input.ReleaseNote))) return false;
            if (this.CustomReleaseNote != input.CustomReleaseNote || (this.CustomReleaseNote != null && !this.CustomReleaseNote.Equals(input.CustomReleaseNote))) return false;
            if (this.VersionDownloadUrl != input.VersionDownloadUrl || (this.VersionDownloadUrl != null && !this.VersionDownloadUrl.Equals(input.VersionDownloadUrl))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.VersionStatus != input.VersionStatus || (this.VersionStatus != null && !this.VersionStatus.Equals(input.VersionStatus))) return false;
            if (this.PublishTime != input.PublishTime || (this.PublishTime != null && !this.PublishTime.Equals(input.PublishTime))) return false;
            if (this.StopTime != input.StopTime || (this.StopTime != null && !this.StopTime.Equals(input.StopTime))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionType != null) hashCode = hashCode * 59 + this.VersionType.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ReleaseNote != null) hashCode = hashCode * 59 + this.ReleaseNote.GetHashCode();
                if (this.CustomReleaseNote != null) hashCode = hashCode * 59 + this.CustomReleaseNote.GetHashCode();
                if (this.VersionDownloadUrl != null) hashCode = hashCode * 59 + this.VersionDownloadUrl.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VersionStatus != null) hashCode = hashCode * 59 + this.VersionStatus.GetHashCode();
                if (this.PublishTime != null) hashCode = hashCode * 59 + this.PublishTime.GetHashCode();
                if (this.StopTime != null) hashCode = hashCode * 59 + this.StopTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
