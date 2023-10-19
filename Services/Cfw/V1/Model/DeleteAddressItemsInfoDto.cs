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
    /// 
    /// </summary>
    public class DeleteAddressItemsInfoDto 
    {

        /// <summary>
        /// 地址组id
        /// </summary>
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 地址组成员id列表
        /// </summary>
        [JsonProperty("address_item_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddressItemIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAddressItemsInfoDto {\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  addressItemIds: ").Append(AddressItemIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAddressItemsInfoDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAddressItemsInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SetId == input.SetId ||
                    (this.SetId != null &&
                    this.SetId.Equals(input.SetId))
                ) && 
                (
                    this.AddressItemIds == input.AddressItemIds ||
                    this.AddressItemIds != null &&
                    input.AddressItemIds != null &&
                    this.AddressItemIds.SequenceEqual(input.AddressItemIds)
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
                if (this.SetId != null)
                    hashCode = hashCode * 59 + this.SetId.GetHashCode();
                if (this.AddressItemIds != null)
                    hashCode = hashCode * 59 + this.AddressItemIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
