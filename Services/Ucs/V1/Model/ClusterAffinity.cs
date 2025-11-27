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
    /// 
    /// </summary>
    public class ClusterAffinity 
    {

        /// <summary>
        /// 指定要选择的集群名称列表
        /// </summary>
        [JsonProperty("clusterNames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClusterNames { get; set; }

        /// <summary>
        /// 指定要排除的集群名称列表
        /// </summary>
        [JsonProperty("exclude", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exclude { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClusterAffinity {\n");
            sb.Append("  clusterNames: ").Append(ClusterNames).Append("\n");
            sb.Append("  exclude: ").Append(Exclude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClusterAffinity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClusterAffinity input)
        {
            if (input == null) return false;
            if (this.ClusterNames != input.ClusterNames || (this.ClusterNames != null && input.ClusterNames != null && !this.ClusterNames.SequenceEqual(input.ClusterNames))) return false;
            if (this.Exclude != input.Exclude || (this.Exclude != null && input.Exclude != null && !this.Exclude.SequenceEqual(input.Exclude))) return false;

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
                if (this.ClusterNames != null) hashCode = hashCode * 59 + this.ClusterNames.GetHashCode();
                if (this.Exclude != null) hashCode = hashCode * 59 + this.Exclude.GetHashCode();
                return hashCode;
            }
        }
    }
}
