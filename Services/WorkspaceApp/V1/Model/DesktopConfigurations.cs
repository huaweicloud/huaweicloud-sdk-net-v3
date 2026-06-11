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
    /// “桌面”文件夹重定向配置
    /// </summary>
    public class DesktopConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("desktop_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("desktop_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("desktop_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("desktop_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("desktop_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("desktop_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("desktop_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopConfigurations {\n");
            sb.Append("  desktopStatus: ").Append(DesktopStatus).Append("\n");
            sb.Append("  desktopRedirectionType: ").Append(DesktopRedirectionType).Append("\n");
            sb.Append("  desktopStoragePath: ").Append(DesktopStoragePath).Append("\n");
            sb.Append("  desktopRelativePath: ").Append(DesktopRelativePath).Append("\n");
            sb.Append("  desktopExclusiveRights: ").Append(DesktopExclusiveRights).Append("\n");
            sb.Append("  desktopMoveContents: ").Append(DesktopMoveContents).Append("\n");
            sb.Append("  desktopMoveContentOnPolicyRemoval: ").Append(DesktopMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopConfigurations input)
        {
            if (input == null) return false;
            if (this.DesktopStatus != input.DesktopStatus || (this.DesktopStatus != null && !this.DesktopStatus.Equals(input.DesktopStatus))) return false;
            if (this.DesktopRedirectionType != input.DesktopRedirectionType || (this.DesktopRedirectionType != null && !this.DesktopRedirectionType.Equals(input.DesktopRedirectionType))) return false;
            if (this.DesktopStoragePath != input.DesktopStoragePath || (this.DesktopStoragePath != null && !this.DesktopStoragePath.Equals(input.DesktopStoragePath))) return false;
            if (this.DesktopRelativePath != input.DesktopRelativePath || (this.DesktopRelativePath != null && !this.DesktopRelativePath.Equals(input.DesktopRelativePath))) return false;
            if (this.DesktopExclusiveRights != input.DesktopExclusiveRights || (this.DesktopExclusiveRights != null && !this.DesktopExclusiveRights.Equals(input.DesktopExclusiveRights))) return false;
            if (this.DesktopMoveContents != input.DesktopMoveContents || (this.DesktopMoveContents != null && !this.DesktopMoveContents.Equals(input.DesktopMoveContents))) return false;
            if (this.DesktopMoveContentOnPolicyRemoval != input.DesktopMoveContentOnPolicyRemoval || (this.DesktopMoveContentOnPolicyRemoval != null && !this.DesktopMoveContentOnPolicyRemoval.Equals(input.DesktopMoveContentOnPolicyRemoval))) return false;

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
                if (this.DesktopStatus != null) hashCode = hashCode * 59 + this.DesktopStatus.GetHashCode();
                if (this.DesktopRedirectionType != null) hashCode = hashCode * 59 + this.DesktopRedirectionType.GetHashCode();
                if (this.DesktopStoragePath != null) hashCode = hashCode * 59 + this.DesktopStoragePath.GetHashCode();
                if (this.DesktopRelativePath != null) hashCode = hashCode * 59 + this.DesktopRelativePath.GetHashCode();
                if (this.DesktopExclusiveRights != null) hashCode = hashCode * 59 + this.DesktopExclusiveRights.GetHashCode();
                if (this.DesktopMoveContents != null) hashCode = hashCode * 59 + this.DesktopMoveContents.GetHashCode();
                if (this.DesktopMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.DesktopMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
