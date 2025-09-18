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
    public class ServerHdaDetails 
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
        /// 是否是维护状态。
        /// </summary>
        [JsonProperty("maintain_status", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MaintainStatus { get; set; }

        /// <summary>
        /// 服务器名称。
        /// </summary>
        [JsonProperty("server_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerName { get; set; }

        /// <summary>
        /// 服务器组id。
        /// </summary>
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

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
        /// 会话数量。
        /// </summary>
        [JsonProperty("session_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public ServerStatus? Status { get; set; }

        /// <summary>
        /// 当前的accessAgent版本。
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerHdaDetails {\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  maintainStatus: ").Append(MaintainStatus).Append("\n");
            sb.Append("  serverName: ").Append(ServerName).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  serverGroupName: ").Append(ServerGroupName).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  sessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerHdaDetails);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerHdaDetails input)
        {
            if (input == null) return false;
            if (this.ServerId != input.ServerId || (this.ServerId != null && !this.ServerId.Equals(input.ServerId))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.MaintainStatus != input.MaintainStatus || (this.MaintainStatus != null && !this.MaintainStatus.Equals(input.MaintainStatus))) return false;
            if (this.ServerName != input.ServerName || (this.ServerName != null && !this.ServerName.Equals(input.ServerName))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.ServerGroupName != input.ServerGroupName || (this.ServerGroupName != null && !this.ServerGroupName.Equals(input.ServerGroupName))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.SessionCount != input.SessionCount || (this.SessionCount != null && !this.SessionCount.Equals(input.SessionCount))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CurrentVersion != input.CurrentVersion || (this.CurrentVersion != null && !this.CurrentVersion.Equals(input.CurrentVersion))) return false;

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
                if (this.MaintainStatus != null) hashCode = hashCode * 59 + this.MaintainStatus.GetHashCode();
                if (this.ServerName != null) hashCode = hashCode * 59 + this.ServerName.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.ServerGroupName != null) hashCode = hashCode * 59 + this.ServerGroupName.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.SessionCount != null) hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CurrentVersion != null) hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
