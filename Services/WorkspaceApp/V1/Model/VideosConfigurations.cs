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
    /// “视频”文件夹重定向配置
    /// </summary>
    public class VideosConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("videos_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideosStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("videos_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideosRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("videos_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string VideosStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("videos_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string VideosRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("videos_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideosExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("videos_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideosMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("videos_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideosMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideosConfigurations {\n");
            sb.Append("  videosStatus: ").Append(VideosStatus).Append("\n");
            sb.Append("  videosRedirectionType: ").Append(VideosRedirectionType).Append("\n");
            sb.Append("  videosStoragePath: ").Append(VideosStoragePath).Append("\n");
            sb.Append("  videosRelativePath: ").Append(VideosRelativePath).Append("\n");
            sb.Append("  videosExclusiveRights: ").Append(VideosExclusiveRights).Append("\n");
            sb.Append("  videosMoveContents: ").Append(VideosMoveContents).Append("\n");
            sb.Append("  videosMoveContentOnPolicyRemoval: ").Append(VideosMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideosConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideosConfigurations input)
        {
            if (input == null) return false;
            if (this.VideosStatus != input.VideosStatus || (this.VideosStatus != null && !this.VideosStatus.Equals(input.VideosStatus))) return false;
            if (this.VideosRedirectionType != input.VideosRedirectionType || (this.VideosRedirectionType != null && !this.VideosRedirectionType.Equals(input.VideosRedirectionType))) return false;
            if (this.VideosStoragePath != input.VideosStoragePath || (this.VideosStoragePath != null && !this.VideosStoragePath.Equals(input.VideosStoragePath))) return false;
            if (this.VideosRelativePath != input.VideosRelativePath || (this.VideosRelativePath != null && !this.VideosRelativePath.Equals(input.VideosRelativePath))) return false;
            if (this.VideosExclusiveRights != input.VideosExclusiveRights || (this.VideosExclusiveRights != null && !this.VideosExclusiveRights.Equals(input.VideosExclusiveRights))) return false;
            if (this.VideosMoveContents != input.VideosMoveContents || (this.VideosMoveContents != null && !this.VideosMoveContents.Equals(input.VideosMoveContents))) return false;
            if (this.VideosMoveContentOnPolicyRemoval != input.VideosMoveContentOnPolicyRemoval || (this.VideosMoveContentOnPolicyRemoval != null && !this.VideosMoveContentOnPolicyRemoval.Equals(input.VideosMoveContentOnPolicyRemoval))) return false;

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
                if (this.VideosStatus != null) hashCode = hashCode * 59 + this.VideosStatus.GetHashCode();
                if (this.VideosRedirectionType != null) hashCode = hashCode * 59 + this.VideosRedirectionType.GetHashCode();
                if (this.VideosStoragePath != null) hashCode = hashCode * 59 + this.VideosStoragePath.GetHashCode();
                if (this.VideosRelativePath != null) hashCode = hashCode * 59 + this.VideosRelativePath.GetHashCode();
                if (this.VideosExclusiveRights != null) hashCode = hashCode * 59 + this.VideosExclusiveRights.GetHashCode();
                if (this.VideosMoveContents != null) hashCode = hashCode * 59 + this.VideosMoveContents.GetHashCode();
                if (this.VideosMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.VideosMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
