using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteTransitSubnetRequest 
    {

        /// <summary>
        /// 中转子网ID。
        /// </summary>
        [SDKProperty("transit_subnet_id", IsPath = true)]
        [JsonProperty("transit_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitSubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTransitSubnetRequest {\n");
            sb.Append("  transitSubnetId: ").Append(TransitSubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTransitSubnetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTransitSubnetRequest input)
        {
            if (input == null) return false;
            if (this.TransitSubnetId != input.TransitSubnetId || (this.TransitSubnetId != null && !this.TransitSubnetId.Equals(input.TransitSubnetId))) return false;

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
                if (this.TransitSubnetId != null) hashCode = hashCode * 59 + this.TransitSubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
