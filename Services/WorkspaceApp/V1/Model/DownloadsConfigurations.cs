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
    /// “下载”文件夹重定向配置
    /// </summary>
    public class DownloadsConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("downloads_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? DownloadsStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("downloads_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DownloadsRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("downloads_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadsStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("downloads_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadsRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("downloads_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? DownloadsExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("downloads_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? DownloadsMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("downloads_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? DownloadsMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadsConfigurations {\n");
            sb.Append("  downloadsStatus: ").Append(DownloadsStatus).Append("\n");
            sb.Append("  downloadsRedirectionType: ").Append(DownloadsRedirectionType).Append("\n");
            sb.Append("  downloadsStoragePath: ").Append(DownloadsStoragePath).Append("\n");
            sb.Append("  downloadsRelativePath: ").Append(DownloadsRelativePath).Append("\n");
            sb.Append("  downloadsExclusiveRights: ").Append(DownloadsExclusiveRights).Append("\n");
            sb.Append("  downloadsMoveContents: ").Append(DownloadsMoveContents).Append("\n");
            sb.Append("  downloadsMoveContentOnPolicyRemoval: ").Append(DownloadsMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadsConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadsConfigurations input)
        {
            if (input == null) return false;
            if (this.DownloadsStatus != input.DownloadsStatus || (this.DownloadsStatus != null && !this.DownloadsStatus.Equals(input.DownloadsStatus))) return false;
            if (this.DownloadsRedirectionType != input.DownloadsRedirectionType || (this.DownloadsRedirectionType != null && !this.DownloadsRedirectionType.Equals(input.DownloadsRedirectionType))) return false;
            if (this.DownloadsStoragePath != input.DownloadsStoragePath || (this.DownloadsStoragePath != null && !this.DownloadsStoragePath.Equals(input.DownloadsStoragePath))) return false;
            if (this.DownloadsRelativePath != input.DownloadsRelativePath || (this.DownloadsRelativePath != null && !this.DownloadsRelativePath.Equals(input.DownloadsRelativePath))) return false;
            if (this.DownloadsExclusiveRights != input.DownloadsExclusiveRights || (this.DownloadsExclusiveRights != null && !this.DownloadsExclusiveRights.Equals(input.DownloadsExclusiveRights))) return false;
            if (this.DownloadsMoveContents != input.DownloadsMoveContents || (this.DownloadsMoveContents != null && !this.DownloadsMoveContents.Equals(input.DownloadsMoveContents))) return false;
            if (this.DownloadsMoveContentOnPolicyRemoval != input.DownloadsMoveContentOnPolicyRemoval || (this.DownloadsMoveContentOnPolicyRemoval != null && !this.DownloadsMoveContentOnPolicyRemoval.Equals(input.DownloadsMoveContentOnPolicyRemoval))) return false;

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
                if (this.DownloadsStatus != null) hashCode = hashCode * 59 + this.DownloadsStatus.GetHashCode();
                if (this.DownloadsRedirectionType != null) hashCode = hashCode * 59 + this.DownloadsRedirectionType.GetHashCode();
                if (this.DownloadsStoragePath != null) hashCode = hashCode * 59 + this.DownloadsStoragePath.GetHashCode();
                if (this.DownloadsRelativePath != null) hashCode = hashCode * 59 + this.DownloadsRelativePath.GetHashCode();
                if (this.DownloadsExclusiveRights != null) hashCode = hashCode * 59 + this.DownloadsExclusiveRights.GetHashCode();
                if (this.DownloadsMoveContents != null) hashCode = hashCode * 59 + this.DownloadsMoveContents.GetHashCode();
                if (this.DownloadsMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.DownloadsMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
