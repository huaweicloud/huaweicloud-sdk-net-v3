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
    public class TargetCluster 
    {

        /// <summary>
        /// 目标集群名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 在该集群创建的副本数
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public string Replicas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetCluster {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TargetCluster);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TargetCluster input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Replicas != input.Replicas || (this.Replicas != null && !this.Replicas.Equals(input.Replicas))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Replicas != null) hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                return hashCode;
            }
        }
    }
}
