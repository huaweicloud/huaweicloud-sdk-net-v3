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
    /// “音乐”文件夹重定向配置
    /// </summary>
    public class MusicConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("music_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? MusicStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("music_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MusicRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("music_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MusicStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("music_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MusicRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("music_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? MusicExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("music_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? MusicMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("music_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? MusicMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MusicConfigurations {\n");
            sb.Append("  musicStatus: ").Append(MusicStatus).Append("\n");
            sb.Append("  musicRedirectionType: ").Append(MusicRedirectionType).Append("\n");
            sb.Append("  musicStoragePath: ").Append(MusicStoragePath).Append("\n");
            sb.Append("  musicRelativePath: ").Append(MusicRelativePath).Append("\n");
            sb.Append("  musicExclusiveRights: ").Append(MusicExclusiveRights).Append("\n");
            sb.Append("  musicMoveContents: ").Append(MusicMoveContents).Append("\n");
            sb.Append("  musicMoveContentOnPolicyRemoval: ").Append(MusicMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MusicConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MusicConfigurations input)
        {
            if (input == null) return false;
            if (this.MusicStatus != input.MusicStatus || (this.MusicStatus != null && !this.MusicStatus.Equals(input.MusicStatus))) return false;
            if (this.MusicRedirectionType != input.MusicRedirectionType || (this.MusicRedirectionType != null && !this.MusicRedirectionType.Equals(input.MusicRedirectionType))) return false;
            if (this.MusicStoragePath != input.MusicStoragePath || (this.MusicStoragePath != null && !this.MusicStoragePath.Equals(input.MusicStoragePath))) return false;
            if (this.MusicRelativePath != input.MusicRelativePath || (this.MusicRelativePath != null && !this.MusicRelativePath.Equals(input.MusicRelativePath))) return false;
            if (this.MusicExclusiveRights != input.MusicExclusiveRights || (this.MusicExclusiveRights != null && !this.MusicExclusiveRights.Equals(input.MusicExclusiveRights))) return false;
            if (this.MusicMoveContents != input.MusicMoveContents || (this.MusicMoveContents != null && !this.MusicMoveContents.Equals(input.MusicMoveContents))) return false;
            if (this.MusicMoveContentOnPolicyRemoval != input.MusicMoveContentOnPolicyRemoval || (this.MusicMoveContentOnPolicyRemoval != null && !this.MusicMoveContentOnPolicyRemoval.Equals(input.MusicMoveContentOnPolicyRemoval))) return false;

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
                if (this.MusicStatus != null) hashCode = hashCode * 59 + this.MusicStatus.GetHashCode();
                if (this.MusicRedirectionType != null) hashCode = hashCode * 59 + this.MusicRedirectionType.GetHashCode();
                if (this.MusicStoragePath != null) hashCode = hashCode * 59 + this.MusicStoragePath.GetHashCode();
                if (this.MusicRelativePath != null) hashCode = hashCode * 59 + this.MusicRelativePath.GetHashCode();
                if (this.MusicExclusiveRights != null) hashCode = hashCode * 59 + this.MusicExclusiveRights.GetHashCode();
                if (this.MusicMoveContents != null) hashCode = hashCode * 59 + this.MusicMoveContents.GetHashCode();
                if (this.MusicMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.MusicMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
