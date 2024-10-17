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
    /// 
    /// </summary>
    public class PartitionSpecContainerNetwork 
    {

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("subnetID", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartitionSpecContainerNetwork {\n");
            sb.Append("  subnetID: ").Append(SubnetID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartitionSpecContainerNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PartitionSpecContainerNetwork input)
        {
            if (input == null) return false;
            if (this.SubnetID != input.SubnetID || (this.SubnetID != null && !this.SubnetID.Equals(input.SubnetID))) return false;

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
                if (this.SubnetID != null) hashCode = hashCode * 59 + this.SubnetID.GetHashCode();
                return hashCode;
            }
        }
    }
}
