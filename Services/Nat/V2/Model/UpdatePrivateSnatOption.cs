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
    /// 更新SNAT规则的请求体。
    /// </summary>
    public class UpdatePrivateSnatOption 
    {

        /// <summary>
        /// 中转IP的ID的列表。
        /// </summary>
        [JsonProperty("transit_ip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TransitIpIds { get; set; }

        /// <summary>
        /// SNAT规则的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePrivateSnatOption {\n");
            sb.Append("  transitIpIds: ").Append(TransitIpIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePrivateSnatOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePrivateSnatOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransitIpIds == input.TransitIpIds ||
                    this.TransitIpIds != null &&
                    input.TransitIpIds != null &&
                    this.TransitIpIds.SequenceEqual(input.TransitIpIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.TransitIpIds != null)
                    hashCode = hashCode * 59 + this.TransitIpIds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
