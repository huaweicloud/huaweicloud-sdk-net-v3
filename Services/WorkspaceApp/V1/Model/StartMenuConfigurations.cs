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
    /// “开始菜单”文件夹重定向配置
    /// </summary>
    public class StartMenuConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("start_menu_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartMenuStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("start_menu_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartMenuRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("start_menu_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string StartMenuStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("start_menu_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string StartMenuRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("start_menu_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartMenuExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("start_menu_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartMenuMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("start_menu_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartMenuMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartMenuConfigurations {\n");
            sb.Append("  startMenuStatus: ").Append(StartMenuStatus).Append("\n");
            sb.Append("  startMenuRedirectionType: ").Append(StartMenuRedirectionType).Append("\n");
            sb.Append("  startMenuStoragePath: ").Append(StartMenuStoragePath).Append("\n");
            sb.Append("  startMenuRelativePath: ").Append(StartMenuRelativePath).Append("\n");
            sb.Append("  startMenuExclusiveRights: ").Append(StartMenuExclusiveRights).Append("\n");
            sb.Append("  startMenuMoveContents: ").Append(StartMenuMoveContents).Append("\n");
            sb.Append("  startMenuMoveContentOnPolicyRemoval: ").Append(StartMenuMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartMenuConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartMenuConfigurations input)
        {
            if (input == null) return false;
            if (this.StartMenuStatus != input.StartMenuStatus || (this.StartMenuStatus != null && !this.StartMenuStatus.Equals(input.StartMenuStatus))) return false;
            if (this.StartMenuRedirectionType != input.StartMenuRedirectionType || (this.StartMenuRedirectionType != null && !this.StartMenuRedirectionType.Equals(input.StartMenuRedirectionType))) return false;
            if (this.StartMenuStoragePath != input.StartMenuStoragePath || (this.StartMenuStoragePath != null && !this.StartMenuStoragePath.Equals(input.StartMenuStoragePath))) return false;
            if (this.StartMenuRelativePath != input.StartMenuRelativePath || (this.StartMenuRelativePath != null && !this.StartMenuRelativePath.Equals(input.StartMenuRelativePath))) return false;
            if (this.StartMenuExclusiveRights != input.StartMenuExclusiveRights || (this.StartMenuExclusiveRights != null && !this.StartMenuExclusiveRights.Equals(input.StartMenuExclusiveRights))) return false;
            if (this.StartMenuMoveContents != input.StartMenuMoveContents || (this.StartMenuMoveContents != null && !this.StartMenuMoveContents.Equals(input.StartMenuMoveContents))) return false;
            if (this.StartMenuMoveContentOnPolicyRemoval != input.StartMenuMoveContentOnPolicyRemoval || (this.StartMenuMoveContentOnPolicyRemoval != null && !this.StartMenuMoveContentOnPolicyRemoval.Equals(input.StartMenuMoveContentOnPolicyRemoval))) return false;

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
                if (this.StartMenuStatus != null) hashCode = hashCode * 59 + this.StartMenuStatus.GetHashCode();
                if (this.StartMenuRedirectionType != null) hashCode = hashCode * 59 + this.StartMenuRedirectionType.GetHashCode();
                if (this.StartMenuStoragePath != null) hashCode = hashCode * 59 + this.StartMenuStoragePath.GetHashCode();
                if (this.StartMenuRelativePath != null) hashCode = hashCode * 59 + this.StartMenuRelativePath.GetHashCode();
                if (this.StartMenuExclusiveRights != null) hashCode = hashCode * 59 + this.StartMenuExclusiveRights.GetHashCode();
                if (this.StartMenuMoveContents != null) hashCode = hashCode * 59 + this.StartMenuMoveContents.GetHashCode();
                if (this.StartMenuMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.StartMenuMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
