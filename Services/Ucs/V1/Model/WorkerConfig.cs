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
    public class WorkerConfig 
    {

        /// <summary>
        /// 节点个数
        /// </summary>
        [JsonProperty("replicas", NullValueHandling = NullValueHandling.Ignore)]
        public int? Replicas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public NodeUpgradeStrategy Strategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkerConfig {\n");
            sb.Append("  replicas: ").Append(Replicas).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkerConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkerConfig input)
        {
            if (input == null) return false;
            if (this.Replicas != input.Replicas || (this.Replicas != null && !this.Replicas.Equals(input.Replicas))) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;

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
                if (this.Replicas != null) hashCode = hashCode * 59 + this.Replicas.GetHashCode();
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
