using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAddressGroupRequest 
    {

        /// <summary>
        /// 地址组的唯一标识
        /// </summary>
        [SDKProperty("address_group_id", IsPath = true)]
        [JsonProperty("address_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressGroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAddressGroupRequest {\n");
            sb.Append("  addressGroupId: ").Append(AddressGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAddressGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAddressGroupRequest input)
        {
            if (input == null) return false;
            if (this.AddressGroupId != input.AddressGroupId || (this.AddressGroupId != null && !this.AddressGroupId.Equals(input.AddressGroupId))) return false;

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
                if (this.AddressGroupId != null) hashCode = hashCode * 59 + this.AddressGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
