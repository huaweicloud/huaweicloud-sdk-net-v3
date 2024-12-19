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
    /// Response Object
    /// </summary>
    public class ShowInstanceVersionResponse : SdkResponse
    {

        /// <summary>
        /// 当前实例内核小版本信息。
        /// </summary>
        [JsonProperty("engine_minor_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineMinorVersion { get; set; }

        /// <summary>
        /// DCS实例最新的内核小版本信息。
        /// </summary>
        [JsonProperty("latest_engine_minor_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestEngineMinorVersion { get; set; }

        /// <summary>
        /// 当前实例proxy代理节点版本信息。
        /// </summary>
        [JsonProperty("proxy_minor_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyMinorVersion { get; set; }

        /// <summary>
        /// DCS实例最新的proxy代理节点版本信息。
        /// </summary>
        [JsonProperty("latest_proxy_minor_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LatestProxyMinorVersion { get; set; }

        /// <summary>
        /// 当前实例内核是否可以升级。
        /// </summary>
        [JsonProperty("engine_minor_version_upgradable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EngineMinorVersionUpgradable { get; set; }

        /// <summary>
        /// 当前实例proxy代理节点是否可以升级。
        /// </summary>
        [JsonProperty("proxy_minor_version_upgradable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProxyMinorVersionUpgradable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceVersionResponse {\n");
            sb.Append("  engineMinorVersion: ").Append(EngineMinorVersion).Append("\n");
            sb.Append("  latestEngineMinorVersion: ").Append(LatestEngineMinorVersion).Append("\n");
            sb.Append("  proxyMinorVersion: ").Append(ProxyMinorVersion).Append("\n");
            sb.Append("  latestProxyMinorVersion: ").Append(LatestProxyMinorVersion).Append("\n");
            sb.Append("  engineMinorVersionUpgradable: ").Append(EngineMinorVersionUpgradable).Append("\n");
            sb.Append("  proxyMinorVersionUpgradable: ").Append(ProxyMinorVersionUpgradable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceVersionResponse input)
        {
            if (input == null) return false;
            if (this.EngineMinorVersion != input.EngineMinorVersion || (this.EngineMinorVersion != null && !this.EngineMinorVersion.Equals(input.EngineMinorVersion))) return false;
            if (this.LatestEngineMinorVersion != input.LatestEngineMinorVersion || (this.LatestEngineMinorVersion != null && !this.LatestEngineMinorVersion.Equals(input.LatestEngineMinorVersion))) return false;
            if (this.ProxyMinorVersion != input.ProxyMinorVersion || (this.ProxyMinorVersion != null && !this.ProxyMinorVersion.Equals(input.ProxyMinorVersion))) return false;
            if (this.LatestProxyMinorVersion != input.LatestProxyMinorVersion || (this.LatestProxyMinorVersion != null && !this.LatestProxyMinorVersion.Equals(input.LatestProxyMinorVersion))) return false;
            if (this.EngineMinorVersionUpgradable != input.EngineMinorVersionUpgradable || (this.EngineMinorVersionUpgradable != null && !this.EngineMinorVersionUpgradable.Equals(input.EngineMinorVersionUpgradable))) return false;
            if (this.ProxyMinorVersionUpgradable != input.ProxyMinorVersionUpgradable || (this.ProxyMinorVersionUpgradable != null && !this.ProxyMinorVersionUpgradable.Equals(input.ProxyMinorVersionUpgradable))) return false;

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
                if (this.EngineMinorVersion != null) hashCode = hashCode * 59 + this.EngineMinorVersion.GetHashCode();
                if (this.LatestEngineMinorVersion != null) hashCode = hashCode * 59 + this.LatestEngineMinorVersion.GetHashCode();
                if (this.ProxyMinorVersion != null) hashCode = hashCode * 59 + this.ProxyMinorVersion.GetHashCode();
                if (this.LatestProxyMinorVersion != null) hashCode = hashCode * 59 + this.LatestProxyMinorVersion.GetHashCode();
                if (this.EngineMinorVersionUpgradable != null) hashCode = hashCode * 59 + this.EngineMinorVersionUpgradable.GetHashCode();
                if (this.ProxyMinorVersionUpgradable != null) hashCode = hashCode * 59 + this.ProxyMinorVersionUpgradable.GetHashCode();
                return hashCode;
            }
        }
    }
}
