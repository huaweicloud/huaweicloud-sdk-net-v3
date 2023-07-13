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
    public class DeploymentHostRequest 
    {

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// IP，请输入弹性ip格式：161.17.101.12
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// ssh端口，如：22
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

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
        /// 
        /// </summary>
        [JsonProperty("authorization", NullValueHandling = NullValueHandling.Ignore)]
        public DeploymentHostAuthorizationBody Authorization { get; set; }

        /// <summary>
        /// 免费启用应用运维服务（AOM），提供指标监控、日志查询、告警功能（自动安装数据采集器 ICAgent，仅支持华为云linux主机）
        /// </summary>
        [JsonProperty("install_icagent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstallIcagent { get; set; }

        /// <summary>
        /// 是否将当前主机的密码信息同步到同一项目下其他主机集群中具有相同IP、用户名、端口的主机。
        /// </summary>
        [JsonProperty("sync", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentHostRequest {\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("  proxyHostId: ").Append(ProxyHostId).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  installIcagent: ").Append(InstallIcagent).Append("\n");
            sb.Append("  sync: ").Append(Sync).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentHostRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentHostRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.AsProxy == input.AsProxy ||
                    (this.AsProxy != null &&
                    this.AsProxy.Equals(input.AsProxy))
                ) && 
                (
                    this.ProxyHostId == input.ProxyHostId ||
                    (this.ProxyHostId != null &&
                    this.ProxyHostId.Equals(input.ProxyHostId))
                ) && 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.InstallIcagent == input.InstallIcagent ||
                    (this.InstallIcagent != null &&
                    this.InstallIcagent.Equals(input.InstallIcagent))
                ) && 
                (
                    this.Sync == input.Sync ||
                    (this.Sync != null &&
                    this.Sync.Equals(input.Sync))
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
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.AsProxy != null)
                    hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                if (this.ProxyHostId != null)
                    hashCode = hashCode * 59 + this.ProxyHostId.GetHashCode();
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.InstallIcagent != null)
                    hashCode = hashCode * 59 + this.InstallIcagent.GetHashCode();
                if (this.Sync != null)
                    hashCode = hashCode * 59 + this.Sync.GetHashCode();
                return hashCode;
            }
        }
    }
}
