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
    /// 服务器的accessAgent详细信息。
    /// </summary>
    public class ServerHdaUpgradeRecord 
    {

        /// <summary>
        /// 服务器id。
        /// </summary>
        [JsonProperty("server_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 机器名称。
        /// </summary>
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 服务器名称。
        /// </summary>
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }

        /// <summary>
        /// 服务器组名称。
        /// </summary>
        [JsonProperty("server_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// 服务器的sid。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// 当前的accessAgent版本。
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 目标的accessAgent版本。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// HDA升级状态。
        /// </summary>
        [JsonProperty("upgrade_status", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeStatus { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("upgrade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpgradeTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerHdaUpgradeRecord {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("  serverGroupName: ").Append(ServerGroupName).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  upgradeStatus: ").Append(UpgradeStatus).Append("\n");
            sb.Append("  upgradeTime: ").Append(UpgradeTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerHdaUpgradeRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerHdaUpgradeRecord input)
        {
            if (input == null) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.ServerName != input.ServerName || (this.ServerName != null && !this.ServerName.Equals(input.ServerName))) return false;
            if (this.ServerGroupName != input.ServerGroupName || (this.ServerGroupName != null && !this.ServerGroupName.Equals(input.ServerGroupName))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;
            if (this.UpgradeStatus != input.UpgradeStatus || (this.UpgradeStatus != null && !this.UpgradeStatus.Equals(input.UpgradeStatus))) return false;
            if (this.UpgradeTime != input.UpgradeTime || (this.UpgradeTime != null && !this.UpgradeTime.Equals(input.UpgradeTime))) return false;

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
                if (this.ServerId != null) hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.ServerName != null) hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.ServerGroupName != null) hashCode = hashCode * 59 + this.ServerGroupName.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.UpgradeStatus != null) hashCode = hashCode * 59 + this.UpgradeStatus.GetHashCode();
                if (this.UpgradeTime != null) hashCode = hashCode * 59 + this.UpgradeTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
