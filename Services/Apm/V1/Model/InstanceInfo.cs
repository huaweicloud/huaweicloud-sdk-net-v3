using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class InstanceInfo 
    {

        /// <summary>
        /// 实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessName { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 主机名称。
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 主机ip地址。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// 环境ID。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// Javaagent版本。
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 最后心跳时间。
        /// </summary>
        [JsonProperty("last_heartbeat", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastHeartbeat { get; set; }

        /// <summary>
        /// 注册时间。
        /// </summary>
        [JsonProperty("register_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? RegisterTime { get; set; }

        /// <summary>
        /// 最后修改用户id。
        /// </summary>
        [JsonProperty("last_modify_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifyUserId { get; set; }

        /// <summary>
        /// 实例状态。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceStatus { get; set; }

        /// <summary>
        /// 最后修改用户名称。
        /// </summary>
        [JsonProperty("last_modify_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifyUserName { get; set; }

        /// <summary>
        /// 最后修改时间。
        /// </summary>
        [JsonProperty("last_modify_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastModifyTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceInfo {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  businessName: ").Append(BusinessName).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  lastHeartbeat: ").Append(LastHeartbeat).Append("\n");
            sb.Append("  registerTime: ").Append(RegisterTime).Append("\n");
            sb.Append("  lastModifyUserId: ").Append(LastModifyUserId).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  lastModifyUserName: ").Append(LastModifyUserName).Append("\n");
            sb.Append("  lastModifyTime: ").Append(LastModifyTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceInfo input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.BusinessName != input.BusinessName || (this.BusinessName != null && !this.BusinessName.Equals(input.BusinessName))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && !this.IpAddress.Equals(input.IpAddress))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.LastHeartbeat != input.LastHeartbeat || (this.LastHeartbeat != null && !this.LastHeartbeat.Equals(input.LastHeartbeat))) return false;
            if (this.RegisterTime != input.RegisterTime || (this.RegisterTime != null && !this.RegisterTime.Equals(input.RegisterTime))) return false;
            if (this.LastModifyUserId != input.LastModifyUserId || (this.LastModifyUserId != null && !this.LastModifyUserId.Equals(input.LastModifyUserId))) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.LastModifyUserName != input.LastModifyUserName || (this.LastModifyUserName != null && !this.LastModifyUserName.Equals(input.LastModifyUserName))) return false;
            if (this.LastModifyTime != input.LastModifyTime || (this.LastModifyTime != null && !this.LastModifyTime.Equals(input.LastModifyTime))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BusinessName != null) hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.LastHeartbeat != null) hashCode = hashCode * 59 + this.LastHeartbeat.GetHashCode();
                if (this.RegisterTime != null) hashCode = hashCode * 59 + this.RegisterTime.GetHashCode();
                if (this.LastModifyUserId != null) hashCode = hashCode * 59 + this.LastModifyUserId.GetHashCode();
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.LastModifyUserName != null) hashCode = hashCode * 59 + this.LastModifyUserName.GetHashCode();
                if (this.LastModifyTime != null) hashCode = hashCode * 59 + this.LastModifyTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
