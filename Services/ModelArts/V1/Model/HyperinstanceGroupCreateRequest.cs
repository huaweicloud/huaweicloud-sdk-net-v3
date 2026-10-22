using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HyperinstanceGroupCreateRequest 
    {

        /// <summary>
        /// **参数解释**：hyperinstance-group名称。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：超节点集群ID。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceClusterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperinstanceGroupCreateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  hyperinstanceClusterId: ").Append(HyperinstanceClusterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HyperinstanceGroupCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperinstanceGroupCreateRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.HyperinstanceClusterId != input.HyperinstanceClusterId || (this.HyperinstanceClusterId != null && !this.HyperinstanceClusterId.Equals(input.HyperinstanceClusterId))) return false;

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
                if (this.HyperinstanceClusterId != null) hashCode = hashCode * 59 + this.HyperinstanceClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
