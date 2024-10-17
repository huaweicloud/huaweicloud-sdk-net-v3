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
    public class HostInfoDetail 
    {

        /// <summary>
        /// 主机id
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

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
        /// 端口号
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
        public PermissionHostDetailNew Permission { get; set; }

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
        /// 主机所属人名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proxy_host", NullValueHandling = NullValueHandling.Ignore)]
        public HostInfoDetail ProxyHost { get; set; }

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
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

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
        /// 免费启用应用运维服务（AOM），提供指标监控、日志查询、告警功能（自动安装数据采集器 ICAgent，仅支持华为云linux主机）
        /// </summary>
        [JsonProperty("install_icagent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstallIcagent { get; set; }

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
            sb.Append("class HostInfoDetail {\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("  proxyHostId: ").Append(ProxyHostId).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  proxyHost: ").Append(ProxyHost).Append("\n");
            sb.Append("  connectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  lastestConnectionTime: ").Append(LastestConnectionTime).Append("\n");
            sb.Append("  connectionResult: ").Append(ConnectionResult).Append("\n");
            sb.Append("  installIcagent: ").Append(InstallIcagent).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HostInfoDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HostInfoDetail input)
        {
            if (input == null) return false;
            if (this.HostId != input.HostId || (this.HostId != null && !this.HostId.Equals(input.HostId))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.Permission != input.Permission || (this.Permission != null && !this.Permission.Equals(input.Permission))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.HostName != input.HostName || (this.HostName != null && !this.HostName.Equals(input.HostName))) return false;
            if (this.AsProxy != input.AsProxy || (this.AsProxy != null && !this.AsProxy.Equals(input.AsProxy))) return false;
            if (this.ProxyHostId != input.ProxyHostId || (this.ProxyHostId != null && !this.ProxyHostId.Equals(input.ProxyHostId))) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.ProxyHost != input.ProxyHost || (this.ProxyHost != null && !this.ProxyHost.Equals(input.ProxyHost))) return false;
            if (this.ConnectionStatus != input.ConnectionStatus || (this.ConnectionStatus != null && !this.ConnectionStatus.Equals(input.ConnectionStatus))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.LastestConnectionTime != input.LastestConnectionTime || (this.LastestConnectionTime != null && !this.LastestConnectionTime.Equals(input.LastestConnectionTime))) return false;
            if (this.ConnectionResult != input.ConnectionResult || (this.ConnectionResult != null && !this.ConnectionResult.Equals(input.ConnectionResult))) return false;
            if (this.InstallIcagent != input.InstallIcagent || (this.InstallIcagent != null && !this.InstallIcagent.Equals(input.InstallIcagent))) return false;
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
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.Permission != null) hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HostName != null) hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.AsProxy != null) hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                if (this.ProxyHostId != null) hashCode = hashCode * 59 + this.ProxyHostId.GetHashCode();
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.ProxyHost != null) hashCode = hashCode * 59 + this.ProxyHost.GetHashCode();
                if (this.ConnectionStatus != null) hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.LastestConnectionTime != null) hashCode = hashCode * 59 + this.LastestConnectionTime.GetHashCode();
                if (this.ConnectionResult != null) hashCode = hashCode * 59 + this.ConnectionResult.GetHashCode();
                if (this.InstallIcagent != null) hashCode = hashCode * 59 + this.InstallIcagent.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                return hashCode;
            }
        }
    }
}
