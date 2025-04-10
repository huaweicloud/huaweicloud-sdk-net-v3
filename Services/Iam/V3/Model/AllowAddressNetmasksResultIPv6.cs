using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AllowAddressNetmasksResultIPv6 
    {

        /// <summary>
        /// IPv6地址或网段，例如： 0000:0000:0000:0000:0000:0000:0000:0000/126。
        /// </summary>
        [JsonProperty("address_netmask", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressNetmask { get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowAddressNetmasksResultIPv6 {\n");
            sb.Append("  addressNetmask: ").Append(AddressNetmask).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AllowAddressNetmasksResultIPv6);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AllowAddressNetmasksResultIPv6 input)
        {
            if (input == null) return false;
            if (this.AddressNetmask != input.AddressNetmask || (this.AddressNetmask != null && !this.AddressNetmask.Equals(input.AddressNetmask))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.AddressNetmask != null) hashCode = hashCode * 59 + this.AddressNetmask.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
