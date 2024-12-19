using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 插件支持升级的集群版本
    /// </summary>
    public class SupportVersions 
    {

        /// <summary>
        /// 支持的集群类型
        /// </summary>
        [JsonProperty("clusterType", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 支持的集群版本（正则表达式）
        /// </summary>
        [JsonProperty("clusterVersion", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClusterVersion { get; set; }

        /// <summary>
        /// 作用的集群类型 **取值范围：** - CCE：CCE Standard集群 - Turbo：CCE Turbo集群 - Autopilot：CCE Autopilot集群  **默认取值** 为空时默认为CCE Standard，CCE Turbo集群
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Category { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportVersions {\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  clusterVersion: ").Append(ClusterVersion).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportVersions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportVersions input)
        {
            if (input == null) return false;
            if (this.ClusterType != input.ClusterType || (this.ClusterType != null && !this.ClusterType.Equals(input.ClusterType))) return false;
            if (this.ClusterVersion != input.ClusterVersion || (this.ClusterVersion != null && input.ClusterVersion != null && !this.ClusterVersion.SequenceEqual(input.ClusterVersion))) return false;
            if (this.Category != input.Category || (this.Category != null && input.Category != null && !this.Category.SequenceEqual(input.Category))) return false;

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
                if (this.ClusterType != null) hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.ClusterVersion != null) hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                return hashCode;
            }
        }
    }
}
