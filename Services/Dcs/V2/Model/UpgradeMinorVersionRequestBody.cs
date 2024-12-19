using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 升级实例小版本请求体，proxy_minor_version和engine_minor_version不能同时为空
    /// </summary>
    public class UpgradeMinorVersionRequestBody 
    {

        /// <summary>
        /// Proxy代理节点目标版本号，设置为latest时，即升级到最新版本。
        /// </summary>
        [JsonProperty("proxy_minor_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyMinorVersion { get; set; }

        /// <summary>
        /// 引擎目标小版本号，设置为latest时，即升级到最新版本。
        /// </summary>
        [JsonProperty("engine_minor_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineMinorVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeMinorVersionRequestBody {\n");
            sb.Append("  proxyMinorVersion: ").Append(ProxyMinorVersion).Append("\n");
            sb.Append("  engineMinorVersion: ").Append(EngineMinorVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeMinorVersionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeMinorVersionRequestBody input)
        {
            if (input == null) return false;
            if (this.ProxyMinorVersion != input.ProxyMinorVersion || (this.ProxyMinorVersion != null && !this.ProxyMinorVersion.Equals(input.ProxyMinorVersion))) return false;
            if (this.EngineMinorVersion != input.EngineMinorVersion || (this.EngineMinorVersion != null && !this.EngineMinorVersion.Equals(input.EngineMinorVersion))) return false;

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
                if (this.ProxyMinorVersion != null) hashCode = hashCode * 59 + this.ProxyMinorVersion.GetHashCode();
                if (this.EngineMinorVersion != null) hashCode = hashCode * 59 + this.EngineMinorVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
