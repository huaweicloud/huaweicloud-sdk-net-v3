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
    /// 主机信息
    /// </summary>
    public class HostInfo 
    {

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 主机操作系统
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization", NullValueHandling = NullValueHandling.Ignore)]
        public HostAuthorizationBody Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionHostDetail Permission { get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 是否为代理机
        /// </summary>
        [JsonProperty("as_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsProxy { get; set; }

        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 代理机ID
        /// </summary>
        [JsonProperty("proxy_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyHostId { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("proxy_host", NullValueHandling = NullValueHandling.Ignore)]
        public HostInfo ProxyHost { get; set; }

        /// <summary>
        /// 连通性状态
        /// </summary>
        [JsonProperty("connection_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

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
        /// 主机所属人昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 导入状态
        /// </summary>
        [JsonProperty("import_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportStatus { get; set; }

        /// <summary>
        /// 关联环境数量
        /// </summary>
        [JsonProperty("env_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnvCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HostInfo {\n");
            sb.Append("  uuid: ").Append(Uuid).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  proxyHostId: ").Append(ProxyHostId).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  proxyHost: ").Append(ProxyHost).Append("\n");
            sb.Append("  connectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastestConnectionTime: ").Append(LastestConnectionTime).Append("\n");
            sb.Append("  connectionResult: ").Append(ConnectionResult).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  importStatus: ").Append(ImportStatus).Append("\n");
            sb.Append("  envCount: ").Append(EnvCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Uuid == input.Uuid ||
                    (this.Uuid != null &&
                    this.Uuid.Equals(input.Uuid))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.AsProxy == input.AsProxy ||
                    (this.AsProxy != null &&
                    this.AsProxy.Equals(input.AsProxy))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.ProxyHostId == input.ProxyHostId ||
                    (this.ProxyHostId != null &&
                    this.ProxyHostId.Equals(input.ProxyHostId))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.ProxyHost == input.ProxyHost ||
                    (this.ProxyHost != null &&
                    this.ProxyHost.Equals(input.ProxyHost))
                ) && 
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.LastestConnectionTime == input.LastestConnectionTime ||
                    (this.LastestConnectionTime != null &&
                    this.LastestConnectionTime.Equals(input.LastestConnectionTime))
                ) && 
                (
                    this.ConnectionResult == input.ConnectionResult ||
                    (this.ConnectionResult != null &&
                    this.ConnectionResult.Equals(input.ConnectionResult))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.ImportStatus == input.ImportStatus ||
                    (this.ImportStatus != null &&
                    this.ImportStatus.Equals(input.ImportStatus))
                ) && 
                (
                    this.EnvCount == input.EnvCount ||
                    (this.EnvCount != null &&
                    this.EnvCount.Equals(input.EnvCount))
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
                if (this.Uuid != null)
                    hashCode = hashCode * 59 + this.Uuid.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.AsProxy != null)
                    hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ProxyHostId != null)
                    hashCode = hashCode * 59 + this.ProxyHostId.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.ProxyHost != null)
                    hashCode = hashCode * 59 + this.ProxyHost.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastestConnectionTime != null)
                    hashCode = hashCode * 59 + this.LastestConnectionTime.GetHashCode();
                if (this.ConnectionResult != null)
                    hashCode = hashCode * 59 + this.ConnectionResult.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.ImportStatus != null)
                    hashCode = hashCode * 59 + this.ImportStatus.GetHashCode();
                if (this.EnvCount != null)
                    hashCode = hashCode * 59 + this.EnvCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
