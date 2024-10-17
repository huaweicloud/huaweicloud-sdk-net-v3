using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 地址组成员信息
    /// </summary>
    public class AddAddressItemsInfoDto 
    {

        /// <summary>
        /// 地址组id
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 地址组成员信息
        /// </summary>
        [JsonProperty("address_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddAddressItemsInfoDtoAddressItems> AddressItems { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddAddressItemsInfoDto {\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  addressItems: ").Append(AddressItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddAddressItemsInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddAddressItemsInfoDto input)
        {
            if (input == null) return false;
            if (this.SetId != input.SetId || (this.SetId != null && !this.SetId.Equals(input.SetId))) return false;
            if (this.AddressItems != input.AddressItems || (this.AddressItems != null && input.AddressItems != null && !this.AddressItems.SequenceEqual(input.AddressItems))) return false;

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
                if (this.SetId != null) hashCode = hashCode * 59 + this.SetId.GetHashCode();
                if (this.AddressItems != null) hashCode = hashCode * 59 + this.AddressItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
