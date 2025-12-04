using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 支持的集群类型（BareMetal，VirtualMachine，windows等）和支持的集群版本（支持正则表达式，如\&quot;.*\&quot;匹配所有集群版本 ）信息等
    /// </summary>
    public class SupportVersion 
    {

        /// <summary>
        /// 支持的集群类型
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 支持的集群类型（BareMetal，VirtualMachine，windows等）
        /// </summary>
        [JsonProperty("clusterType", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterType { get; set; }

        /// <summary>
        /// 支持的集群版本，支持正则表达式，如\&quot;.*\&quot;匹配所有集群版本
        /// </summary>
        [JsonProperty("clusterVersion", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClusterVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportVersion {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
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
            return this.Equals(input as SupportVersion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportVersion input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.ClusterType != input.ClusterType || (this.ClusterType != null && !this.ClusterType.Equals(input.ClusterType))) return false;
            if (this.ClusterVersion != input.ClusterVersion || (this.ClusterVersion != null && input.ClusterVersion != null && !this.ClusterVersion.SequenceEqual(input.ClusterVersion))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ClusterType != null) hashCode = hashCode * 59 + this.ClusterType.GetHashCode();
                if (this.ClusterVersion != null) hashCode = hashCode * 59 + this.ClusterVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
