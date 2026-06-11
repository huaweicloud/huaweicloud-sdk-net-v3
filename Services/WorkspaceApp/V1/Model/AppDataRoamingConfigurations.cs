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
    /// “AppData(Roaming)”文件夹重定向配置
    /// </summary>
    public class AppDataRoamingConfigurations 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 未选取 1: 已选取
        /// </summary>
        [JsonProperty("app_data_roaming_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppDataRoamingStatus { get; set; }

        /// <summary>
        /// 配置文件夹重定向类型： 0: 远程 1: 本地
        /// </summary>
        [JsonProperty("app_data_roaming_redirection_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppDataRoamingRedirectionType { get; set; }

        /// <summary>
        /// 文件夹重定向(v2)用户存储路径。
        /// </summary>
        [JsonProperty("app_data_roaming_storage_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AppDataRoamingStoragePath { get; set; }

        /// <summary>
        /// 目标文件夹位置。
        /// </summary>
        [JsonProperty("app_data_roaming_relative_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AppDataRoamingRelativePath { get; set; }

        /// <summary>
        /// 是否开启用户对该文件夹的独占控制权限： 0: 禁用 1: 开启
        /// </summary>
        [JsonProperty("app_data_roaming_exclusive_rights", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppDataRoamingExclusiveRights { get; set; }

        /// <summary>
        /// 启用文件夹重定向策略时，是否将现有内容移动到新位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("app_data_roaming_move_contents", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppDataRoamingMoveContents { get; set; }

        /// <summary>
        /// 禁用或删除策略时，是否将内容移回本地用户配置文件位置： 0: 否 1: 是
        /// </summary>
        [JsonProperty("app_data_roaming_move_content_on_policy_removal", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppDataRoamingMoveContentOnPolicyRemoval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppDataRoamingConfigurations {\n");
            sb.Append("  appDataRoamingStatus: ").Append(AppDataRoamingStatus).Append("\n");
            sb.Append("  appDataRoamingRedirectionType: ").Append(AppDataRoamingRedirectionType).Append("\n");
            sb.Append("  appDataRoamingStoragePath: ").Append(AppDataRoamingStoragePath).Append("\n");
            sb.Append("  appDataRoamingRelativePath: ").Append(AppDataRoamingRelativePath).Append("\n");
            sb.Append("  appDataRoamingExclusiveRights: ").Append(AppDataRoamingExclusiveRights).Append("\n");
            sb.Append("  appDataRoamingMoveContents: ").Append(AppDataRoamingMoveContents).Append("\n");
            sb.Append("  appDataRoamingMoveContentOnPolicyRemoval: ").Append(AppDataRoamingMoveContentOnPolicyRemoval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppDataRoamingConfigurations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppDataRoamingConfigurations input)
        {
            if (input == null) return false;
            if (this.AppDataRoamingStatus != input.AppDataRoamingStatus || (this.AppDataRoamingStatus != null && !this.AppDataRoamingStatus.Equals(input.AppDataRoamingStatus))) return false;
            if (this.AppDataRoamingRedirectionType != input.AppDataRoamingRedirectionType || (this.AppDataRoamingRedirectionType != null && !this.AppDataRoamingRedirectionType.Equals(input.AppDataRoamingRedirectionType))) return false;
            if (this.AppDataRoamingStoragePath != input.AppDataRoamingStoragePath || (this.AppDataRoamingStoragePath != null && !this.AppDataRoamingStoragePath.Equals(input.AppDataRoamingStoragePath))) return false;
            if (this.AppDataRoamingRelativePath != input.AppDataRoamingRelativePath || (this.AppDataRoamingRelativePath != null && !this.AppDataRoamingRelativePath.Equals(input.AppDataRoamingRelativePath))) return false;
            if (this.AppDataRoamingExclusiveRights != input.AppDataRoamingExclusiveRights || (this.AppDataRoamingExclusiveRights != null && !this.AppDataRoamingExclusiveRights.Equals(input.AppDataRoamingExclusiveRights))) return false;
            if (this.AppDataRoamingMoveContents != input.AppDataRoamingMoveContents || (this.AppDataRoamingMoveContents != null && !this.AppDataRoamingMoveContents.Equals(input.AppDataRoamingMoveContents))) return false;
            if (this.AppDataRoamingMoveContentOnPolicyRemoval != input.AppDataRoamingMoveContentOnPolicyRemoval || (this.AppDataRoamingMoveContentOnPolicyRemoval != null && !this.AppDataRoamingMoveContentOnPolicyRemoval.Equals(input.AppDataRoamingMoveContentOnPolicyRemoval))) return false;

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
                if (this.AppDataRoamingStatus != null) hashCode = hashCode * 59 + this.AppDataRoamingStatus.GetHashCode();
                if (this.AppDataRoamingRedirectionType != null) hashCode = hashCode * 59 + this.AppDataRoamingRedirectionType.GetHashCode();
                if (this.AppDataRoamingStoragePath != null) hashCode = hashCode * 59 + this.AppDataRoamingStoragePath.GetHashCode();
                if (this.AppDataRoamingRelativePath != null) hashCode = hashCode * 59 + this.AppDataRoamingRelativePath.GetHashCode();
                if (this.AppDataRoamingExclusiveRights != null) hashCode = hashCode * 59 + this.AppDataRoamingExclusiveRights.GetHashCode();
                if (this.AppDataRoamingMoveContents != null) hashCode = hashCode * 59 + this.AppDataRoamingMoveContents.GetHashCode();
                if (this.AppDataRoamingMoveContentOnPolicyRemoval != null) hashCode = hashCode * 59 + this.AppDataRoamingMoveContentOnPolicyRemoval.GetHashCode();
                return hashCode;
            }
        }
    }
}
