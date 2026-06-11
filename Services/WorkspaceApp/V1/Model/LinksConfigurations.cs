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
    /// “链接”文件夹重定向配置
    /// </summary>
    public class LinksConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("links_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinksStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("links_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinksRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("links_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LinksStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("links_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string LinksRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("links_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinksExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("links_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinksMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("links_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? LinksMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinksConfigurations {\n");
            sb.Append("  linksStatus: ").Append(LinksStatus).Append("\n");
            sb.Append("  linksRedirectionType: ").Append(LinksRedirectionType).Append("\n");
            sb.Append("  linksStoragePath: ").Append(LinksStoragePath).Append("\n");
            sb.Append("  linksRelativePath: ").Append(LinksRelativePath).Append("\n");
            sb.Append("  linksExclusiveRights: ").Append(LinksExclusiveRights).Append("\n");
            sb.Append("  linksMoveContents: ").Append(LinksMoveContents).Append("\n");
            sb.Append("  linksMoveContentOnPolicyRemoval: ").Append(LinksMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LinksConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LinksConfigurations input)
        {
            if (input == null) return false;
            if (this.LinksStatus != input.LinksStatus || (this.LinksStatus != null && !this.LinksStatus.Equals(input.LinksStatus))) return false;
            if (this.LinksRedirectionType != input.LinksRedirectionType || (this.LinksRedirectionType != null && !this.LinksRedirectionType.Equals(input.LinksRedirectionType))) return false;
            if (this.LinksStoragePath != input.LinksStoragePath || (this.LinksStoragePath != null && !this.LinksStoragePath.Equals(input.LinksStoragePath))) return false;
            if (this.LinksRelativePath != input.LinksRelativePath || (this.LinksRelativePath != null && !this.LinksRelativePath.Equals(input.LinksRelativePath))) return false;
            if (this.LinksExclusiveRights != input.LinksExclusiveRights || (this.LinksExclusiveRights != null && !this.LinksExclusiveRights.Equals(input.LinksExclusiveRights))) return false;
            if (this.LinksMoveContents != input.LinksMoveContents || (this.LinksMoveContents != null && !this.LinksMoveContents.Equals(input.LinksMoveContents))) return false;
            if (this.LinksMoveContentOnPolicyRemoval != input.LinksMoveContentOnPolicyRemoval || (this.LinksMoveContentOnPolicyRemoval != null && !this.LinksMoveContentOnPolicyRemoval.Equals(input.LinksMoveContentOnPolicyRemoval))) return false;

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
                if (this.LinksStatus != null) hashCode = hashCode * 59 + this.LinksStatus.GetHashCode();
                if (this.LinksRedirectionType != null) hashCode = hashCode * 59 + this.LinksRedirectionType.GetHashCode();
                if (this.LinksStoragePath != null) hashCode = hashCode * 59 + this.LinksStoragePath.GetHashCode();
                if (this.LinksRelativePath != null) hashCode = hashCode * 59 + this.LinksRelativePath.GetHashCode();
                if (this.LinksExclusiveRights != null) hashCode = hashCode * 59 + this.LinksExclusiveRights.GetHashCode();
                if (this.LinksMoveContents != null) hashCode = hashCode * 59 + this.LinksMoveContents.GetHashCode();
                if (this.LinksMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.LinksMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
