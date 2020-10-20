using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 弹性ip，同publicips
    /// </summary>
    public class EipInfo 
    {

        /// <summary>
        /// eip_id
        /// </summary>
        [JsonProperty("eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EipId { get; set; }

        /// <summary>
        /// eip_address
        /// </summary>
        [JsonProperty("eip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string EipAddress { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipInfo {\n");
            sb.Append("  eipId: ").Append(EipId).Append("\n");
            sb.Append("  eipAddress: ").Append(EipAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EipId == input.EipId ||
                    (this.EipId != null &&
                    this.EipId.Equals(input.EipId))
                ) && 
                (
                    this.EipAddress == input.EipAddress ||
                    (this.EipAddress != null &&
                    this.EipAddress.Equals(input.EipAddress))
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
                if (this.EipId != null)
                    hashCode = hashCode * 59 + this.EipId.GetHashCode();
                if (this.EipAddress != null)
                    hashCode = hashCode * 59 + this.EipAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
