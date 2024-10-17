using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AgentRegister 
    {

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 客户端所在的主机名
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 客户端所在主机的IP
        /// </summary>
        [JsonProperty("host_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIp { get; set; }

        /// <summary>
        /// 客户端所在主机的操作系统
        /// </summary>
        [JsonProperty("host_os", NullValueHandling = NullValueHandling.Ignore)]
        public string HostOs { get; set; }

        /// <summary>
        /// 客户端所在主机的主机别名
        /// </summary>
        [JsonProperty("host_nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string HostNickname { get; set; }

        /// <summary>
        /// 客户端版本
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 客户端类型，分本地客户端和云上客户端(cloud/native)
        /// </summary>
        [JsonProperty("agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgentRegister {\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  hostIp: ").Append(HostIp).Append("\n");
            sb.Append("  hostOs: ").Append(HostOs).Append("\n");
            sb.Append("  hostNickname: ").Append(HostNickname).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  agentType: ").Append(AgentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgentRegister);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgentRegister input)
        {
            if (input == null) return false;
            if (this.AgentId != input.AgentId || (this.AgentId != null && !this.AgentId.Equals(input.AgentId))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.HostIp != input.HostIp || (this.HostIp != null && !this.HostIp.Equals(input.HostIp))) return false;
            if (this.HostOs != input.HostOs || (this.HostOs != null && !this.HostOs.Equals(input.HostOs))) return false;
            if (this.HostNickname != input.HostNickname || (this.HostNickname != null && !this.HostNickname.Equals(input.HostNickname))) return false;
            if (this.AgentVersion != input.AgentVersion || (this.AgentVersion != null && !this.AgentVersion.Equals(input.AgentVersion))) return false;
            if (this.AgentType != input.AgentType || (this.AgentType != null && !this.AgentType.Equals(input.AgentType))) return false;

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
                if (this.AgentId != null) hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.HostIp != null) hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                if (this.HostOs != null) hashCode = hashCode * 59 + this.HostOs.GetHashCode();
                if (this.HostNickname != null) hashCode = hashCode * 59 + this.HostNickname.GetHashCode();
                if (this.AgentVersion != null) hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.AgentType != null) hashCode = hashCode * 59 + this.AgentType.GetHashCode();
                return hashCode;
            }
        }
    }
}
