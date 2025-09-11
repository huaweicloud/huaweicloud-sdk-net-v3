using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 实例激活信息
    /// </summary>
    public class InstanceActivateInfo 
    {

        /// <summary>
        /// 代理DOMAIN名称
        /// </summary>
        [JsonProperty("dsc_proxy_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DscProxyDomainName { get; set; }

        /// <summary>
        /// 代理IP
        /// </summary>
        [JsonProperty("dsc_proxy_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DscProxyIp { get; set; }

        /// <summary>
        /// 代理端口
        /// </summary>
        [JsonProperty("dsc_proxy_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DscProxyPort { get; set; }

        /// <summary>
        /// 主节点ID
        /// </summary>
        [JsonProperty("master_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterNodeId { get; set; }

        /// <summary>
        /// 备节点ID
        /// </summary>
        [JsonProperty("slave_node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveNodeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceActivateInfo {\n");
            sb.Append("  dscProxyDomainName: ").Append(DscProxyDomainName).Append("\n");
            sb.Append("  dscProxyIp: ").Append(DscProxyIp).Append("\n");
            sb.Append("  dscProxyPort: ").Append(DscProxyPort).Append("\n");
            sb.Append("  masterNodeId: ").Append(MasterNodeId).Append("\n");
            sb.Append("  slaveNodeId: ").Append(SlaveNodeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceActivateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceActivateInfo input)
        {
            if (input == null) return false;
            if (this.DscProxyDomainName != input.DscProxyDomainName || (this.DscProxyDomainName != null && !this.DscProxyDomainName.Equals(input.DscProxyDomainName))) return false;
            if (this.DscProxyIp != input.DscProxyIp || (this.DscProxyIp != null && !this.DscProxyIp.Equals(input.DscProxyIp))) return false;
            if (this.DscProxyPort != input.DscProxyPort || (this.DscProxyPort != null && !this.DscProxyPort.Equals(input.DscProxyPort))) return false;
            if (this.MasterNodeId != input.MasterNodeId || (this.MasterNodeId != null && !this.MasterNodeId.Equals(input.MasterNodeId))) return false;
            if (this.SlaveNodeId != input.SlaveNodeId || (this.SlaveNodeId != null && !this.SlaveNodeId.Equals(input.SlaveNodeId))) return false;

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
                if (this.DscProxyDomainName != null) hashCode = hashCode * 59 + this.DscProxyDomainName.GetHashCode();
                if (this.DscProxyIp != null) hashCode = hashCode * 59 + this.DscProxyIp.GetHashCode();
                if (this.DscProxyPort != null) hashCode = hashCode * 59 + this.DscProxyPort.GetHashCode();
                if (this.MasterNodeId != null) hashCode = hashCode * 59 + this.MasterNodeId.GetHashCode();
                if (this.SlaveNodeId != null) hashCode = hashCode * 59 + this.SlaveNodeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
