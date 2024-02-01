using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 查询数据库代理详情信息返回体。
    /// </summary>
    public class QueryProxyResponseV3 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proxy", NullValueHandling = NullValueHandling.Ignore)]
        public ProxyInfo Proxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("master_instance", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceInfo MasterInstance { get; set; }

        /// <summary>
        /// 数据库只读实例信息。
        /// </summary>
        [JsonProperty("readonly_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceInfo> ReadonlyInstances { get; set; }

        /// <summary>
        /// 安全组是否放通该数据库代理到数据库的网络地址。
        /// </summary>
        [JsonProperty("proxy_security_group_check_result", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProxySecurityGroupCheckResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryProxyResponseV3 {\n");
            sb.Append("  proxy: ").Append(Proxy).Append("\n");
            sb.Append("  masterInstance: ").Append(MasterInstance).Append("\n");
            sb.Append("  readonlyInstances: ").Append(ReadonlyInstances).Append("\n");
            sb.Append("  proxySecurityGroupCheckResult: ").Append(ProxySecurityGroupCheckResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryProxyResponseV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryProxyResponseV3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Proxy == input.Proxy ||
                    (this.Proxy != null &&
                    this.Proxy.Equals(input.Proxy))
                ) && 
                (
                    this.MasterInstance == input.MasterInstance ||
                    (this.MasterInstance != null &&
                    this.MasterInstance.Equals(input.MasterInstance))
                ) && 
                (
                    this.ReadonlyInstances == input.ReadonlyInstances ||
                    this.ReadonlyInstances != null &&
                    input.ReadonlyInstances != null &&
                    this.ReadonlyInstances.SequenceEqual(input.ReadonlyInstances)
                ) && 
                (
                    this.ProxySecurityGroupCheckResult == input.ProxySecurityGroupCheckResult ||
                    (this.ProxySecurityGroupCheckResult != null &&
                    this.ProxySecurityGroupCheckResult.Equals(input.ProxySecurityGroupCheckResult))
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
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.MasterInstance != null)
                    hashCode = hashCode * 59 + this.MasterInstance.GetHashCode();
                if (this.ReadonlyInstances != null)
                    hashCode = hashCode * 59 + this.ReadonlyInstances.GetHashCode();
                if (this.ProxySecurityGroupCheckResult != null)
                    hashCode = hashCode * 59 + this.ProxySecurityGroupCheckResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
