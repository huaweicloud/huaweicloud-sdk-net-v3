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
    /// 请求应用使用记录响应体。
    /// </summary>
    public class ListAppConnectionReq 
    {

        /// <summary>
        /// 主键。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 应用服务器sid。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// 应用服务器名称。
        /// </summary>
        [JsonProperty("machine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineName { get; set; }

        /// <summary>
        /// 登录用户，模糊查询。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 应用组名称。
        /// </summary>
        [JsonProperty("app_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupName { get; set; }

        /// <summary>
        /// 应用组id。
        /// </summary>
        [JsonProperty("app_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppGroupId { get; set; }

        /// <summary>
        /// 应用名称，模糊查询。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 连接失败状态码。
        /// </summary>
        [JsonProperty("failed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedCode { get; set; }

        /// <summary>
        /// 连接失败原因。
        /// </summary>
        [JsonProperty("connection_failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionFailureReason { get; set; }

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
        /// 租户id。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 登录应用开始时间，格式 2022-10-31T08:07:39Z。
        /// </summary>
        [JsonProperty("brokering_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BrokeringStartTime { get; set; }

        /// <summary>
        /// 登录应用结束时间，格式 2022-10-31T08:07:39Z。
        /// </summary>
        [JsonProperty("brokering_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BrokeringEndTime { get; set; }

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
            sb.Append("class ListAppConnectionReq {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  machineName: ").Append(MachineName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  appGroupName: ").Append(AppGroupName).Append("\n");
            sb.Append("  appGroupId: ").Append(AppGroupId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  failedCode: ").Append(FailedCode).Append("\n");
            sb.Append("  connectionFailureReason: ").Append(ConnectionFailureReason).Append("\n");
            sb.Append("  clientName: ").Append(ClientName).Append("\n");
            sb.Append("  clientVersion: ").Append(ClientVersion).Append("\n");
            sb.Append("  clientType: ").Append(ClientType).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  vmIp: ").Append(VmIp).Append("\n");
            sb.Append("  wiIp: ").Append(WiIp).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  brokeringStartTime: ").Append(BrokeringStartTime).Append("\n");
            sb.Append("  brokeringEndTime: ").Append(BrokeringEndTime).Append("\n");
            sb.Append("  virtualIp: ").Append(VirtualIp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAppConnectionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAppConnectionReq input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.MachineName != input.MachineName || (this.MachineName != null && !this.MachineName.Equals(input.MachineName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.AppGroupName != input.AppGroupName || (this.AppGroupName != null && !this.AppGroupName.Equals(input.AppGroupName))) return false;
            if (this.AppGroupId != input.AppGroupId || (this.AppGroupId != null && !this.AppGroupId.Equals(input.AppGroupId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.FailedCode != input.FailedCode || (this.FailedCode != null && !this.FailedCode.Equals(input.FailedCode))) return false;
            if (this.ConnectionFailureReason != input.ConnectionFailureReason || (this.ConnectionFailureReason != null && !this.ConnectionFailureReason.Equals(input.ConnectionFailureReason))) return false;
            if (this.ClientName != input.ClientName || (this.ClientName != null && !this.ClientName.Equals(input.ClientName))) return false;
            if (this.ClientVersion != input.ClientVersion || (this.ClientVersion != null && !this.ClientVersion.Equals(input.ClientVersion))) return false;
            if (this.ClientType != input.ClientType || (this.ClientType != null && !this.ClientType.Equals(input.ClientType))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.VmIp != input.VmIp || (this.VmIp != null && !this.VmIp.Equals(input.VmIp))) return false;
            if (this.WiIp != input.WiIp || (this.WiIp != null && !this.WiIp.Equals(input.WiIp))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.BrokeringStartTime != input.BrokeringStartTime || (this.BrokeringStartTime != null && !this.BrokeringStartTime.Equals(input.BrokeringStartTime))) return false;
            if (this.BrokeringEndTime != input.BrokeringEndTime || (this.BrokeringEndTime != null && !this.BrokeringEndTime.Equals(input.BrokeringEndTime))) return false;
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
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.MachineName != null) hashCode = hashCode * 59 + this.MachineName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.AppGroupName != null) hashCode = hashCode * 59 + this.AppGroupName.GetHashCode();
                if (this.AppGroupId != null) hashCode = hashCode * 59 + this.AppGroupId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.FailedCode != null) hashCode = hashCode * 59 + this.FailedCode.GetHashCode();
                if (this.ConnectionFailureReason != null) hashCode = hashCode * 59 + this.ConnectionFailureReason.GetHashCode();
                if (this.ClientName != null) hashCode = hashCode * 59 + this.ClientName.GetHashCode();
                if (this.ClientVersion != null) hashCode = hashCode * 59 + this.ClientVersion.GetHashCode();
                if (this.ClientType != null) hashCode = hashCode * 59 + this.ClientType.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.VmIp != null) hashCode = hashCode * 59 + this.VmIp.GetHashCode();
                if (this.WiIp != null) hashCode = hashCode * 59 + this.WiIp.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.BrokeringStartTime != null) hashCode = hashCode * 59 + this.BrokeringStartTime.GetHashCode();
                if (this.BrokeringEndTime != null) hashCode = hashCode * 59 + this.BrokeringEndTime.GetHashCode();
                if (this.VirtualIp != null) hashCode = hashCode * 59 + this.VirtualIp.GetHashCode();
                return hashCode;
            }
        }
    }
}
