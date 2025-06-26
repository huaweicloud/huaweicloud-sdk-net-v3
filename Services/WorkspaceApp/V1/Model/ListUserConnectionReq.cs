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
    /// 请求用户登录记录响应体。
    /// </summary>
    public class ListUserConnectionReq 
    {

        /// <summary>
        /// 登录记录唯一标识ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户连接类别。
        /// </summary>
        [JsonProperty("connect_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectType { get; set; }

        /// <summary>
        /// 登录用户名称。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 应用服务器sid。
        /// </summary>
        [JsonProperty("machine_sid", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineSid { get; set; }

        /// <summary>
        /// 应用服务器名称。
        /// </summary>
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 连接失败原因。
        /// </summary>
        [JsonProperty("failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedReason { get; set; }

        /// <summary>
        /// 连接失败状态码。
        /// </summary>
        [JsonProperty("failed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedCode { get; set; }

        /// <summary>
        /// 客户端名称。
        /// </summary>
        [JsonProperty("client_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientName { get; set; }

        /// <summary>
        /// 客户端版本。
        /// </summary>
        [JsonProperty("client_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientVersion { get; set; }

        /// <summary>
        /// 客户端操作系统类型。
        /// </summary>
        [JsonProperty("client_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientType { get; set; }

        /// <summary>
        /// aps hda版本。
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 应用服务器ip。
        /// </summary>
        [JsonProperty("vm_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VmIp { get; set; }

        /// <summary>
        /// 连接标志，目前值为0。
        /// </summary>
        [JsonProperty("connect_flag", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectFlag { get; set; }

        /// <summary>
        /// 连接IP。
        /// </summary>
        [JsonProperty("wi_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string WiIp { get; set; }

        /// <summary>
        /// 客户端出口ip。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 登录应用开始时间，格式 2022-10-31 08:07:39。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 登录应用开始时间，格式 2022-10-31 08:07:39。
        /// </summary>
        [JsonProperty("login_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LoginStartTime { get; set; }

        /// <summary>
        /// 登录应用结束时间，格式 2022-10-31 08:07:39。
        /// </summary>
        [JsonProperty("login_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LoginEndTime { get; set; }

        /// <summary>
        /// 会话虚拟ip。
        /// </summary>
        [JsonProperty("virtual_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string VirtualIp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUserConnectionReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  connectType: ").Append(ConnectType).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  machineSid: ").Append(MachineSid).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  failedReason: ").Append(FailedReason).Append("\n");
            sb.Append("  failedCode: ").Append(FailedCode).Append("\n");
            sb.Append("  clientName: ").Append(ClientName).Append("\n");
            sb.Append("  clientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  vmIp: ").Append(VmIp).Append("\n");
            sb.Append("  connectFlag: ").Append(ConnectFlag).Append("\n");
            sb.Append("  wiIp: ").Append(WiIp).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  loginStartTime: ").Append(LoginStartTime).Append("\n");
            sb.Append("  loginEndTime: ").Append(LoginEndTime).Append("\n");
            sb.Append("  virtualIp: ").Append(VirtualIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUserConnectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUserConnectionReq input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ConnectType != input.ConnectType || (this.ConnectType != null && !this.ConnectType.Equals(input.ConnectType))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.MachineSid != input.MachineSid || (this.MachineSid != null && !this.MachineSid.Equals(input.MachineSid))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.FailedReason != input.FailedReason || (this.FailedReason != null && !this.FailedReason.Equals(input.FailedReason))) return false;
            if (this.FailedCode != input.FailedCode || (this.FailedCode != null && !this.FailedCode.Equals(input.FailedCode))) return false;
            if (this.ClientName != input.ClientName || (this.ClientName != null && !this.ClientName.Equals(input.ClientName))) return false;
            if (this.ClientVersion != input.ClientVersion || (this.ClientVersion != null && !this.ClientVersion.Equals(input.ClientVersion))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.VmIp != input.VmIp || (this.VmIp != null && !this.VmIp.Equals(input.VmIp))) return false;
            if (this.ConnectFlag != input.ConnectFlag || (this.ConnectFlag != null && !this.ConnectFlag.Equals(input.ConnectFlag))) return false;
            if (this.WiIp != input.WiIp || (this.WiIp != null && !this.WiIp.Equals(input.WiIp))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.LoginStartTime != input.LoginStartTime || (this.LoginStartTime != null && !this.LoginStartTime.Equals(input.LoginStartTime))) return false;
            if (this.LoginEndTime != input.LoginEndTime || (this.LoginEndTime != null && !this.LoginEndTime.Equals(input.LoginEndTime))) return false;
            if (this.VirtualIp != input.VirtualIp || (this.VirtualIp != null && !this.VirtualIp.Equals(input.VirtualIp))) return false;

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
                if (this.ConnectType != null) hashCode = hashCode * 59 + this.ConnectType.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.MachineSid != null) hashCode = hashCode * 59 + this.MachineSid.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.FailedReason != null) hashCode = hashCode * 59 + this.FailedReason.GetHashCode();
                if (this.FailedCode != null) hashCode = hashCode * 59 + this.FailedCode.GetHashCode();
                if (this.ClientName != null) hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ClientVersion != null) hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.VmIp != null) hashCode = hashCode * 59 + this.VmIp.GetHashCode();
                if (this.ConnectFlag != null) hashCode = hashCode * 59 + this.ConnectFlag.GetHashCode();
                if (this.WiIp != null) hashCode = hashCode * 59 + this.WiIp.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.LoginStartTime != null) hashCode = hashCode * 59 + this.LoginStartTime.GetHashCode();
                if (this.LoginEndTime != null) hashCode = hashCode * 59 + this.LoginEndTime.GetHashCode();
                if (this.VirtualIp != null) hashCode = hashCode * 59 + this.VirtualIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
