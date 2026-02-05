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
    /// 根据用户名查询当前会话-会话信息。
    /// </summary>
    public class AppSession 
    {

        /// <summary>
        /// 主键ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 会话标识。
        /// </summary>
        [JsonProperty("session_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionStamp { get; set; }

        /// <summary>
        /// 会话在hda的os中会话id。
        /// </summary>
        [JsonProperty("os_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OsSessionId { get; set; }

        /// <summary>
        /// 协议类型： - HDP
        /// </summary>
        [JsonProperty("protocol_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// 当前会话的登录用户。
        /// </summary>
        [JsonProperty("login_user", NullValueHandling = NullValueHandling.Ignore)]
        public string LoginUser { get; set; }

        /// <summary>
        /// 会话类型，1表示共享桌面，2表示应用。
        /// </summary>
        [JsonProperty("session_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionType { get; set; }

        /// <summary>
        /// App组ID。
        /// </summary>
        [JsonProperty("app_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupId { get; set; }

        /// <summary>
        /// AppServer组ID。
        /// </summary>
        [JsonProperty("app_server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppServerGroupId { get; set; }

        /// <summary>
        /// 预连接时间。
        /// </summary>
        [JsonProperty("pre_conn_time", NullValueHandling = NullValueHandling.Ignore)]
        public string PreConnTime { get; set; }

        /// <summary>
        /// 会话开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 会话结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 状态持续时间。
        /// </summary>
        [JsonProperty("status_continue_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusContinueTime { get; set; }

        /// <summary>
        /// 服务器SID。。
        /// </summary>
        [JsonProperty("machine_sid", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineSid { get; set; }

        /// <summary>
        /// 服务器名称。
        /// </summary>
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 会话状态： - Active：运行中  - Disconnecte：断开连接 - AppcInit：初始化 - SignedOut：已注销 - InitFail：初始化失败
        /// </summary>
        [JsonProperty("session_state", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionState { get; set; }

        /// <summary>
        /// 会话中的应用名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 客户端Mac地址。
        /// </summary>
        [JsonProperty("client_mac", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientMac { get; set; }

        /// <summary>
        /// 客户端名称。
        /// </summary>
        [JsonProperty("client_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        /// <summary>
        /// 客户端IP。
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 客户端出口ip。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 客户端版本。
        /// </summary>
        [JsonProperty("client_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 客户端类型。
        /// </summary>
        [JsonProperty("client_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientType { get; set; }

        /// <summary>
        /// agent版本。
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 服务器IP。
        /// </summary>
        [JsonProperty("vm_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VmIp { get; set; }

        /// <summary>
        /// 错误原因消息。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 错误原因码。
        /// </summary>
        [JsonProperty("failed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedCode { get; set; }

        /// <summary>
        /// 状态最后变化时间。
        /// </summary>
        [JsonProperty("last_update_status_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateStatusTime { get; set; }

        /// <summary>
        /// 租户ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppSession {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sessionStamp: ").Append(SessionStamp).Append("\n");
            sb.Append("  osSessionId: ").Append(OsSessionId).Append("\n");
            sb.Append("  protocolType: ").Append(ProtocolType).Append("\n");
            sb.Append("  loginUser: ").Append(LoginUser).Append("\n");
            sb.Append("  sessionType: ").Append(SessionType).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  appServerGroupId: ").Append(AppServerGroupId).Append("\n");
            sb.Append("  preConnTime: ").Append(PreConnTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  statusContinueTime: ").Append(StatusContinueTime).Append("\n");
            sb.Append("  machineSid: ").Append(MachineSid).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  sessionState: ").Append(SessionState).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  clientMac: ").Append(ClientMac).Append("\n");
            sb.Append("  clientName: ").Append(ClientName).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  clientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  vmIp: ").Append(VmIp).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  failedCode: ").Append(FailedCode).Append("\n");
            sb.Append("  lastUpdateStatusTime: ").Append(LastUpdateStatusTime).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppSession);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppSession input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SessionStamp != input.SessionStamp || (this.SessionStamp != null && !this.SessionStamp.Equals(input.SessionStamp))) return false;
            if (this.OsSessionId != input.OsSessionId || (this.OsSessionId != null && !this.OsSessionId.Equals(input.OsSessionId))) return false;
            if (this.ProtocolType != input.ProtocolType || (this.ProtocolType != null && !this.ProtocolType.Equals(input.ProtocolType))) return false;
            if (this.LoginUser != input.LoginUser || (this.LoginUser != null && !this.LoginUser.Equals(input.LoginUser))) return false;
            if (this.SessionType != input.SessionType || (this.SessionType != null && !this.SessionType.Equals(input.SessionType))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.AppServerGroupId != input.AppServerGroupId || (this.AppServerGroupId != null && !this.AppServerGroupId.Equals(input.AppServerGroupId))) return false;
            if (this.PreConnTime != input.PreConnTime || (this.PreConnTime != null && !this.PreConnTime.Equals(input.PreConnTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StatusContinueTime != input.StatusContinueTime || (this.StatusContinueTime != null && !this.StatusContinueTime.Equals(input.StatusContinueTime))) return false;
            if (this.MachineSid != input.MachineSid || (this.MachineSid != null && !this.MachineSid.Equals(input.MachineSid))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.SessionState != input.SessionState || (this.SessionState != null && !this.SessionState.Equals(input.SessionState))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.ClientMac != input.ClientMac || (this.ClientMac != null && !this.ClientMac.Equals(input.ClientMac))) return false;
            if (this.ClientName != input.ClientName || (this.ClientName != null && !this.ClientName.Equals(input.ClientName))) return false;
            if (this.ClientIp != input.ClientIp || (this.ClientIp != null && !this.ClientIp.Equals(input.ClientIp))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.ClientVersion != input.ClientVersion || (this.ClientVersion != null && !this.ClientVersion.Equals(input.ClientVersion))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.VmIp != input.VmIp || (this.VmIp != null && !this.VmIp.Equals(input.VmIp))) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;
            if (this.FailedCode != input.FailedCode || (this.FailedCode != null && !this.FailedCode.Equals(input.FailedCode))) return false;
            if (this.LastUpdateStatusTime != input.LastUpdateStatusTime || (this.LastUpdateStatusTime != null && !this.LastUpdateStatusTime.Equals(input.LastUpdateStatusTime))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SessionStamp != null) hashCode = hashCode * 59 + this.SessionStamp.GetHashCode();
                if (this.OsSessionId != null) hashCode = hashCode * 59 + this.OsSessionId.GetHashCode();
                if (this.ProtocolType != null) hashCode = hashCode * 59 + this.ProtocolType.GetHashCode();
                if (this.LoginUser != null) hashCode = hashCode * 59 + this.LoginUser.GetHashCode();
                if (this.SessionType != null) hashCode = hashCode * 59 + this.SessionType.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                if (this.AppServerGroupId != null) hashCode = hashCode * 59 + this.AppServerGroupId.GetHashCode();
                if (this.PreConnTime != null) hashCode = hashCode * 59 + this.PreConnTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StatusContinueTime != null) hashCode = hashCode * 59 + this.StatusContinueTime.GetHashCode();
                if (this.MachineSid != null) hashCode = hashCode * 59 + this.MachineSid.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.SessionState != null) hashCode = hashCode * 59 + this.SessionState.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.ClientMac != null) hashCode = hashCode * 59 + this.ClientMac.GetHashCode();
                if (this.ClientName != null) hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ClientIp != null) hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.ClientVersion != null) hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.VmIp != null) hashCode = hashCode * 59 + this.VmIp.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.FailedCode != null) hashCode = hashCode * 59 + this.FailedCode.GetHashCode();
                if (this.LastUpdateStatusTime != null) hashCode = hashCode * 59 + this.LastUpdateStatusTime.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                return hashCode;
            }
        }
    }
}
