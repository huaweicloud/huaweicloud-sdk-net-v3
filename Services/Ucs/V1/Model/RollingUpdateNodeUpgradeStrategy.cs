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
    public class RollingUpdateNodeUpgradeStrategy 
    {

        /// <summary>
        /// 最大不可用个数
        /// </summary>
        [JsonProperty("maxUnavailable", NullValueHandling = NullValueHandling.Ignore)]
        public Object MaxUnavailable { get; set; }

        /// <summary>
        /// 允许超出期望的最大个数
        /// </summary>
        [JsonProperty("maxSurge", NullValueHandling = NullValueHandling.Ignore)]
        public Object MaxSurge { get; set; }

        /// <summary>
        /// 删除策略：Random、Oldest、Newest
        /// </summary>
        [JsonProperty("deletePolicy", NullValueHandling = NullValueHandling.Ignore)]
        public string DeletePolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RollingUpdateNodeUpgradeStrategy {\n");
            sb.Append("  maxUnavailable: ").Append(MaxUnavailable).Append("\n");
            sb.Append("  maxSurge: ").Append(MaxSurge).Append("\n");
            sb.Append("  deletePolicy: ").Append(DeletePolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RollingUpdateNodeUpgradeStrategy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RollingUpdateNodeUpgradeStrategy input)
        {
            if (input == null) return false;
            if (this.MaxUnavailable != input.MaxUnavailable || (this.MaxUnavailable != null && !this.MaxUnavailable.Equals(input.MaxUnavailable))) return false;
            if (this.MaxSurge != input.MaxSurge || (this.MaxSurge != null && !this.MaxSurge.Equals(input.MaxSurge))) return false;
            if (this.DeletePolicy != input.DeletePolicy || (this.DeletePolicy != null && !this.DeletePolicy.Equals(input.DeletePolicy))) return false;

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
                if (this.MaxUnavailable != null) hashCode = hashCode * 59 + this.MaxUnavailable.GetHashCode();
                if (this.MaxSurge != null) hashCode = hashCode * 59 + this.MaxSurge.GetHashCode();
                if (this.DeletePolicy != null) hashCode = hashCode * 59 + this.DeletePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
