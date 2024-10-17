using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// proxy升级内核版本请求体对象。
    /// </summary>
    public class ProxyUpgradeProxyVersionRequest 
    {

        /// <summary>
        /// 升级前源内核版本号
        /// </summary>
        [JsonProperty("source_version", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// 目标升级内核版本号
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProxyUpgradeProxyVersionRequest {\n");
            sb.Append("  sourceVersion: ").Append(SourceVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProxyUpgradeProxyVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProxyUpgradeProxyVersionRequest input)
        {
            if (input == null) return false;
            if (this.SourceVersion != input.SourceVersion || (this.SourceVersion != null && !this.SourceVersion.Equals(input.SourceVersion))) return false;
            if (this.TargetVersion != input.TargetVersion || (this.TargetVersion != null && !this.TargetVersion.Equals(input.TargetVersion))) return false;

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
                if (this.SourceVersion != null) hashCode = hashCode * 59 + this.SourceVersion.GetHashCode();
                if (this.TargetVersion != null) hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
