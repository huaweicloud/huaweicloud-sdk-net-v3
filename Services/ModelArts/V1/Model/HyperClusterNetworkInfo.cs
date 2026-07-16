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
    public class HyperClusterNetworkInfo 
    {

        /// <summary>
        /// **参数解释**：hyper cluster的子网名称。 **取值范围**：^[-_.a-zA-Z0-9]{1,64}$。
        /// </summary>
        [JsonProperty("hyper_cluster_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperClusterSubnetId { get; set; }

        /// <summary>
        /// **参数解释**：是否默认。 **约束限制**：不涉及。 **取值范围**： - true：默认网络 - false：非默认网络
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperClusterNetworkInfo {\n");
            sb.Append("  hyperClusterSubnetId: ").Append(HyperClusterSubnetId).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HyperClusterNetworkInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperClusterNetworkInfo input)
        {
            if (input == null) return false;
            if (this.HyperClusterSubnetId != input.HyperClusterSubnetId || (this.HyperClusterSubnetId != null && !this.HyperClusterSubnetId.Equals(input.HyperClusterSubnetId))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;

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
                if (this.HyperClusterSubnetId != null) hashCode = hashCode * 59 + this.HyperClusterSubnetId.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
