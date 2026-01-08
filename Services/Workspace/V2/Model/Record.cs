using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Record 
    {

        /// <summary>
        /// 租户id，不对外展示。
        /// </summary>
        [JsonProperty("tenantId", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 桌面sid。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// 事务id。
        /// </summary>
        [JsonProperty("transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// 计算机名。
        /// </summary>
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 用户名。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 终端MAC地址。
        /// </summary>
        [JsonProperty("terminal_mac", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalMac { get; set; }

        /// <summary>
        /// 终端名称。
        /// </summary>
        [JsonProperty("terminal_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalName { get; set; }

        /// <summary>
        /// 终端IP。
        /// </summary>
        [JsonProperty("terminal_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalIp { get; set; }

        /// <summary>
        /// AccessClient版本。
        /// </summary>
        [JsonProperty("client_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 终端系统类型。
        /// </summary>
        [JsonProperty("terminal_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TerminalType { get; set; }

        /// <summary>
        /// AccessAgent版本。
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 桌面IP。
        /// </summary>
        [JsonProperty("desktop_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopIp { get; set; }

        /// <summary>
        /// 开始连接时间。
        /// </summary>
        [JsonProperty("connection_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionStartTime { get; set; }

        /// <summary>
        /// 建立连接时间。
        /// </summary>
        [JsonProperty("connection_setup_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionSetupTime { get; set; }

        /// <summary>
        /// 结束连接时间。
        /// </summary>
        [JsonProperty("connection_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionEndTime { get; set; }

        /// <summary>
        /// 是否重连。
        /// </summary>
        [JsonProperty("is_reconnect", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReconnect { get; set; }

        /// <summary>
        /// 连接失败原因。
        /// </summary>
        [JsonProperty("connection_failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionFailureReason { get; set; }

        /// <summary>
        /// 网络时延ms。
        /// </summary>
        [JsonProperty("network_rtt", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetworkRtt { get; set; }

        /// <summary>
        /// 端到端时延 ms。
        /// </summary>
        [JsonProperty("e2e_rtt", NullValueHandling = NullValueHandling.Ignore)]
        public int? E2eRtt { get; set; }

        /// <summary>
        /// 客户端源ip
        /// </summary>
        [JsonProperty("source_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 客户端出网IP
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Record {\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  transactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  terminalMac: ").Append(TerminalMac).Append("\n");
            sb.Append("  terminalName: ").Append(TerminalName).Append("\n");
            sb.Append("  terminalIp: ").Append(TerminalIp).Append("\n");
            sb.Append("  clientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  terminalType: ").Append(TerminalType).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  desktopIp: ").Append(DesktopIp).Append("\n");
            sb.Append("  connectionStartTime: ").Append(ConnectionStartTime).Append("\n");
            sb.Append("  connectionSetupTime: ").Append(ConnectionSetupTime).Append("\n");
            sb.Append("  connectionEndTime: ").Append(ConnectionEndTime).Append("\n");
            sb.Append("  isReconnect: ").Append(IsReconnect).Append("\n");
            sb.Append("  connectionFailureReason: ").Append(ConnectionFailureReason).Append("\n");
            sb.Append("  networkRtt: ").Append(NetworkRtt).Append("\n");
            sb.Append("  e2eRtt: ").Append(E2eRtt).Append("\n");
            sb.Append("  sourceIp: ").Append(SourceIp).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Record);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Record input)
        {
            if (input == null) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.TransactionId != input.TransactionId || (this.TransactionId != null && !this.TransactionId.Equals(input.TransactionId))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.TerminalMac != input.TerminalMac || (this.TerminalMac != null && !this.TerminalMac.Equals(input.TerminalMac))) return false;
            if (this.TerminalName != input.TerminalName || (this.TerminalName != null && !this.TerminalName.Equals(input.TerminalName))) return false;
            if (this.TerminalIp != input.TerminalIp || (this.TerminalIp != null && !this.TerminalIp.Equals(input.TerminalIp))) return false;
            if (this.ClientVersion != input.ClientVersion || (this.ClientVersion != null && !this.ClientVersion.Equals(input.ClientVersion))) return false;
            if (this.TerminalType != input.TerminalType || (this.TerminalType != null && !this.TerminalType.Equals(input.TerminalType))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.DesktopIp != input.DesktopIp || (this.DesktopIp != null && !this.DesktopIp.Equals(input.DesktopIp))) return false;
            if (this.ConnectionStartTime != input.ConnectionStartTime || (this.ConnectionStartTime != null && !this.ConnectionStartTime.Equals(input.ConnectionStartTime))) return false;
            if (this.ConnectionSetupTime != input.ConnectionSetupTime || (this.ConnectionSetupTime != null && !this.ConnectionSetupTime.Equals(input.ConnectionSetupTime))) return false;
            if (this.ConnectionEndTime != input.ConnectionEndTime || (this.ConnectionEndTime != null && !this.ConnectionEndTime.Equals(input.ConnectionEndTime))) return false;
            if (this.IsReconnect != input.IsReconnect || (this.IsReconnect != null && !this.IsReconnect.Equals(input.IsReconnect))) return false;
            if (this.ConnectionFailureReason != input.ConnectionFailureReason || (this.ConnectionFailureReason != null && !this.ConnectionFailureReason.Equals(input.ConnectionFailureReason))) return false;
            if (this.NetworkRtt != input.NetworkRtt || (this.NetworkRtt != null && !this.NetworkRtt.Equals(input.NetworkRtt))) return false;
            if (this.E2eRtt != input.E2eRtt || (this.E2eRtt != null && !this.E2eRtt.Equals(input.E2eRtt))) return false;
            if (this.SourceIp != input.SourceIp || (this.SourceIp != null && !this.SourceIp.Equals(input.SourceIp))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.TransactionId != null) hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.TerminalMac != null) hashCode = hashCode * 59 + this.TerminalMac.GetHashCode();
                if (this.TerminalName != null) hashCode = hashCode * 59 + this.TerminalName.GetHashCode();
                if (this.TerminalIp != null) hashCode = hashCode * 59 + this.TerminalIp.GetHashCode();
                if (this.ClientVersion != null) hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.TerminalType != null) hashCode = hashCode * 59 + this.TerminalType.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.DesktopIp != null) hashCode = hashCode * 59 + this.DesktopIp.GetHashCode();
                if (this.ConnectionStartTime != null) hashCode = hashCode * 59 + this.ConnectionStartTime.GetHashCode();
                if (this.ConnectionSetupTime != null) hashCode = hashCode * 59 + this.ConnectionSetupTime.GetHashCode();
                if (this.ConnectionEndTime != null) hashCode = hashCode * 59 + this.ConnectionEndTime.GetHashCode();
                if (this.IsReconnect != null) hashCode = hashCode * 59 + this.IsReconnect.GetHashCode();
                if (this.ConnectionFailureReason != null) hashCode = hashCode * 59 + this.ConnectionFailureReason.GetHashCode();
                if (this.NetworkRtt != null) hashCode = hashCode * 59 + this.NetworkRtt.GetHashCode();
                if (this.E2eRtt != null) hashCode = hashCode * 59 + this.E2eRtt.GetHashCode();
                if (this.SourceIp != null) hashCode = hashCode * 59 + this.SourceIp.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
