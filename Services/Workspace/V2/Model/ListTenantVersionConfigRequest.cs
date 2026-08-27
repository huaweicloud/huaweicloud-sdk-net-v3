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
    /// Request Object
    /// </summary>
    public class ListTenantVersionConfigRequest 
    {

        /// <summary>
        /// 版本类型：0-服务端 1-客户端（必传）
        /// </summary>
        [SDKProperty("version_type", IsQuery = true)]
        [JsonProperty("version_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionType { get; set; }

        /// <summary>
        /// 版本号（支持模糊查询）
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 操作系统类型：0-windows 1-android 2-mac 3-linux_UOS 4-linux_ubuntu 5-linux_Kylin 6-linux
        /// </summary>
        [SDKProperty("os_type", IsQuery = true)]
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? OsType { get; set; }

        /// <summary>
        /// 版本状态：PREVIEW-预览 RELEASED-已发布 OFFLINE-已下线 OBSOLETE-已废弃
        /// </summary>
        [SDKProperty("version_status", IsQuery = true)]
        [JsonProperty("version_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionStatus { get; set; }

        /// <summary>
        /// 发布时间开始（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [SDKProperty("publish_time_begin", IsQuery = true)]
        [JsonProperty("publish_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTimeBegin { get; set; }

        /// <summary>
        /// 发布时间结束（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [SDKProperty("publish_time_end", IsQuery = true)]
        [JsonProperty("publish_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishTimeEnd { get; set; }

        /// <summary>
        /// 版本说明（支持模糊查询，会同时搜索SRE配置的版本说明和租户自定义的版本说明）
        /// </summary>
        [SDKProperty("release_note", IsQuery = true)]
        [JsonProperty("release_note", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseNote { get; set; }

        /// <summary>
        /// 偏移量，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页数量，默认10，最大20000
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantVersionConfigRequest {\n");
            sb.Append("  versionType: ").Append(VersionType).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  versionStatus: ").Append(VersionStatus).Append("\n");
            sb.Append("  publishTimeBegin: ").Append(PublishTimeBegin).Append("\n");
            sb.Append("  publishTimeEnd: ").Append(PublishTimeEnd).Append("\n");
            sb.Append("  releaseNote: ").Append(ReleaseNote).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantVersionConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantVersionConfigRequest input)
        {
            if (input == null) return false;
            if (this.VersionType != input.VersionType || (this.VersionType != null && !this.VersionType.Equals(input.VersionType))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.VersionStatus != input.VersionStatus || (this.VersionStatus != null && !this.VersionStatus.Equals(input.VersionStatus))) return false;
            if (this.PublishTimeBegin != input.PublishTimeBegin || (this.PublishTimeBegin != null && !this.PublishTimeBegin.Equals(input.PublishTimeBegin))) return false;
            if (this.PublishTimeEnd != input.PublishTimeEnd || (this.PublishTimeEnd != null && !this.PublishTimeEnd.Equals(input.PublishTimeEnd))) return false;
            if (this.ReleaseNote != input.ReleaseNote || (this.ReleaseNote != null && !this.ReleaseNote.Equals(input.ReleaseNote))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.VersionType != null) hashCode = hashCode * 59 + this.VersionType.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.VersionStatus != null) hashCode = hashCode * 59 + this.VersionStatus.GetHashCode();
                if (this.PublishTimeBegin != null) hashCode = hashCode * 59 + this.PublishTimeBegin.GetHashCode();
                if (this.PublishTimeEnd != null) hashCode = hashCode * 59 + this.PublishTimeEnd.GetHashCode();
                if (this.ReleaseNote != null) hashCode = hashCode * 59 + this.ReleaseNote.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
