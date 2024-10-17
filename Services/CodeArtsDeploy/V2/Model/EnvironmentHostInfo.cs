using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 主机详情信息
    /// </summary>
    public class EnvironmentHostInfo 
    {

        /// <summary>
        /// 主机id
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 主机ip，如：161.17.101.12
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// ssh端口，如：22
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentHostPermission Permission { get; set; }

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 是否为代理机
        /// </summary>
        [JsonProperty("as_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsProxy { get; set; }

        /// <summary>
        /// 代理机id
        /// </summary>
        [JsonProperty("proxy_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyHostId { get; set; }

        /// <summary>
        /// 代理机名称
        /// </summary>
        [JsonProperty("proxy_host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyHostName { get; set; }

        /// <summary>
        /// 主机所属人id
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 主机所属人名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 连通性状态
        /// </summary>
        [JsonProperty("connection_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// 上次连通时间
        /// </summary>
        [JsonProperty("lastest_connection_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastestConnectionTime { get; set; }

        /// <summary>
        /// 连通性验证结果
        /// </summary>
        [JsonProperty("connection_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionResult { get; set; }

        /// <summary>
        /// 创建人昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvironmentHostInfo {\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("  proxyHostId: ").Append(ProxyHostId).Append("\n");
            sb.Append("  proxyHostName: ").Append(ProxyHostName).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  connectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  lastestConnectionTime: ").Append(LastestConnectionTime).Append("\n");
            sb.Append("  connectionResult: ").Append(ConnectionResult).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvironmentHostInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvironmentHostInfo input)
        {
            if (input == null) return false;
            if (this.HostId != input.HostId || (this.HostId != null && !this.HostId.Equals(input.HostId))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Permission != input.Permission || (this.Permission != null && !this.Permission.Equals(input.Permission))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.AsProxy != input.AsProxy || (this.AsProxy != null && !this.AsProxy.Equals(input.AsProxy))) return false;
            if (this.ProxyHostId != input.ProxyHostId || (this.ProxyHostId != null && !this.ProxyHostId.Equals(input.ProxyHostId))) return false;
            if (this.ProxyHostName != input.ProxyHostName || (this.ProxyHostName != null && !this.ProxyHostName.Equals(input.ProxyHostName))) return false;
            if (this.OwnerId != input.OwnerId || (this.OwnerId != null && !this.OwnerId.Equals(input.OwnerId))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.ConnectionStatus != input.ConnectionStatus || (this.ConnectionStatus != null && !this.ConnectionStatus.Equals(input.ConnectionStatus))) return false;
            if (this.LastestConnectionTime != input.LastestConnectionTime || (this.LastestConnectionTime != null && !this.LastestConnectionTime.Equals(input.LastestConnectionTime))) return false;
            if (this.ConnectionResult != input.ConnectionResult || (this.ConnectionResult != null && !this.ConnectionResult.Equals(input.ConnectionResult))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;

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
                if (this.HostId != null) hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Permission != null) hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.AsProxy != null) hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                if (this.ProxyHostId != null) hashCode = hashCode * 59 + this.ProxyHostId.GetHashCode();
                if (this.ProxyHostName != null) hashCode = hashCode * 59 + this.ProxyHostName.GetHashCode();
                if (this.OwnerId != null) hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.ConnectionStatus != null) hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.LastestConnectionTime != null) hashCode = hashCode * 59 + this.LastestConnectionTime.GetHashCode();
                if (this.ConnectionResult != null) hashCode = hashCode * 59 + this.ConnectionResult.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                return hashCode;
            }
        }
    }
}
