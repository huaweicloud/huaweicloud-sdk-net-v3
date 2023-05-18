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
    public class Agent 
    {

        /// <summary>
        /// 客户端创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 客户端更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("agent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentId { get; set; }

        /// <summary>
        /// 客户端版本号
        /// </summary>
        [JsonProperty("agent_version", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// 客户端类型
        /// </summary>
        [JsonProperty("agent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AgentType { get; set; }

        /// <summary>
        /// 客户端所在的主机名
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 客户端所在的主机昵称
        /// </summary>
        [JsonProperty("host_nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string HostNickname { get; set; }

        /// <summary>
        /// 客户端所在主机的IP
        /// </summary>
        [JsonProperty("host_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIp { get; set; }

        /// <summary>
        /// 客户端主机所在的操作系统
        /// </summary>
        [JsonProperty("host_os", NullValueHandling = NullValueHandling.Ignore)]
        public string HostOs { get; set; }

        /// <summary>
        /// 客户端状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 客户端上次激活时间
        /// </summary>
        [JsonProperty("last_active_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastActiveTime { get; set; }

        /// <summary>
        /// 客户端的备份路径
        /// </summary>
        [JsonProperty("paths", NullValueHandling = NullValueHandling.Ignore)]
        public List<Path> Paths { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Agent {\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  agentId: ").Append(AgentId).Append("\n");
            sb.Append("  agentVersion: ").Append(AgentVersion).Append("\n");
            sb.Append("  agentType: ").Append(AgentType).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  hostNickname: ").Append(HostNickname).Append("\n");
            sb.Append("  hostIp: ").Append(HostIp).Append("\n");
            sb.Append("  hostOs: ").Append(HostOs).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  lastActiveTime: ").Append(LastActiveTime).Append("\n");
            sb.Append("  paths: ").Append(Paths).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Agent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Agent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.AgentVersion == input.AgentVersion ||
                    (this.AgentVersion != null &&
                    this.AgentVersion.Equals(input.AgentVersion))
                ) && 
                (
                    this.AgentType == input.AgentType ||
                    (this.AgentType != null &&
                    this.AgentType.Equals(input.AgentType))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.HostNickname == input.HostNickname ||
                    (this.HostNickname != null &&
                    this.HostNickname.Equals(input.HostNickname))
                ) && 
                (
                    this.HostIp == input.HostIp ||
                    (this.HostIp != null &&
                    this.HostIp.Equals(input.HostIp))
                ) && 
                (
                    this.HostOs == input.HostOs ||
                    (this.HostOs != null &&
                    this.HostOs.Equals(input.HostOs))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.LastActiveTime == input.LastActiveTime ||
                    (this.LastActiveTime != null &&
                    this.LastActiveTime.Equals(input.LastActiveTime))
                ) && 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.AgentVersion != null)
                    hashCode = hashCode * 59 + this.AgentVersion.GetHashCode();
                if (this.AgentType != null)
                    hashCode = hashCode * 59 + this.AgentType.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.HostNickname != null)
                    hashCode = hashCode * 59 + this.HostNickname.GetHashCode();
                if (this.HostIp != null)
                    hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                if (this.HostOs != null)
                    hashCode = hashCode * 59 + this.HostOs.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.LastActiveTime != null)
                    hashCode = hashCode * 59 + this.LastActiveTime.GetHashCode();
                if (this.Paths != null)
                    hashCode = hashCode * 59 + this.Paths.GetHashCode();
                return hashCode;
            }
        }
    }
}
