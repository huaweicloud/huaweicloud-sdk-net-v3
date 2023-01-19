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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportVersions {\n");
            sb.Append("  clusterType: ").Append(ClusterType).Append("\n");
            sb.Append("  clusterVersion: ").Append(ClusterVersion).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.ClusterType == input.ClusterType ||
                    (this.ClusterType != null &&
                    this.ClusterType.Equals(input.ClusterType))
                ) && 
                (
                    this.ClusterVersion == input.ClusterVersion ||
                    this.ClusterVersion != null &&
                    input.ClusterVersion != null &&
                    this.ClusterVersion.SequenceEqual(input.ClusterVersion)
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
                if (this.ClusterType != null)
                    hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.ClusterVersion != null)
                    hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
