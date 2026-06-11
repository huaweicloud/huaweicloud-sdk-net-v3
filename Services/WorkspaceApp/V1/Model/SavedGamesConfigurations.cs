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
    /// “保存的游戏”文件夹重定向配置
    /// </summary>
    public class SavedGamesConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("saved_games_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? SavedGamesStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("saved_games_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SavedGamesRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("saved_games_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SavedGamesStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("saved_games_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SavedGamesRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("saved_games_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? SavedGamesExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("saved_games_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? SavedGamesMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("saved_games_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? SavedGamesMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SavedGamesConfigurations {\n");
            sb.Append("  savedGamesStatus: ").Append(SavedGamesStatus).Append("\n");
            sb.Append("  savedGamesRedirectionType: ").Append(SavedGamesRedirectionType).Append("\n");
            sb.Append("  savedGamesStoragePath: ").Append(SavedGamesStoragePath).Append("\n");
            sb.Append("  savedGamesRelativePath: ").Append(SavedGamesRelativePath).Append("\n");
            sb.Append("  savedGamesExclusiveRights: ").Append(SavedGamesExclusiveRights).Append("\n");
            sb.Append("  savedGamesMoveContents: ").Append(SavedGamesMoveContents).Append("\n");
            sb.Append("  savedGamesMoveContentOnPolicyRemoval: ").Append(SavedGamesMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SavedGamesConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SavedGamesConfigurations input)
        {
            if (input == null) return false;
            if (this.SavedGamesStatus != input.SavedGamesStatus || (this.SavedGamesStatus != null && !this.SavedGamesStatus.Equals(input.SavedGamesStatus))) return false;
            if (this.SavedGamesRedirectionType != input.SavedGamesRedirectionType || (this.SavedGamesRedirectionType != null && !this.SavedGamesRedirectionType.Equals(input.SavedGamesRedirectionType))) return false;
            if (this.SavedGamesStoragePath != input.SavedGamesStoragePath || (this.SavedGamesStoragePath != null && !this.SavedGamesStoragePath.Equals(input.SavedGamesStoragePath))) return false;
            if (this.SavedGamesRelativePath != input.SavedGamesRelativePath || (this.SavedGamesRelativePath != null && !this.SavedGamesRelativePath.Equals(input.SavedGamesRelativePath))) return false;
            if (this.SavedGamesExclusiveRights != input.SavedGamesExclusiveRights || (this.SavedGamesExclusiveRights != null && !this.SavedGamesExclusiveRights.Equals(input.SavedGamesExclusiveRights))) return false;
            if (this.SavedGamesMoveContents != input.SavedGamesMoveContents || (this.SavedGamesMoveContents != null && !this.SavedGamesMoveContents.Equals(input.SavedGamesMoveContents))) return false;
            if (this.SavedGamesMoveContentOnPolicyRemoval != input.SavedGamesMoveContentOnPolicyRemoval || (this.SavedGamesMoveContentOnPolicyRemoval != null && !this.SavedGamesMoveContentOnPolicyRemoval.Equals(input.SavedGamesMoveContentOnPolicyRemoval))) return false;

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
                if (this.SavedGamesStatus != null) hashCode = hashCode * 59 + this.SavedGamesStatus.GetHashCode();
                if (this.SavedGamesRedirectionType != null) hashCode = hashCode * 59 + this.SavedGamesRedirectionType.GetHashCode();
                if (this.SavedGamesStoragePath != null) hashCode = hashCode * 59 + this.SavedGamesStoragePath.GetHashCode();
                if (this.SavedGamesRelativePath != null) hashCode = hashCode * 59 + this.SavedGamesRelativePath.GetHashCode();
                if (this.SavedGamesExclusiveRights != null) hashCode = hashCode * 59 + this.SavedGamesExclusiveRights.GetHashCode();
                if (this.SavedGamesMoveContents != null) hashCode = hashCode * 59 + this.SavedGamesMoveContents.GetHashCode();
                if (this.SavedGamesMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.SavedGamesMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
