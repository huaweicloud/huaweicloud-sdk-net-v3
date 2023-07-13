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
    /// 规则地址dto
    /// </summary>
    public class RuleAddressDto 
    {

        /// <summary>
        /// 源类型0手工输入,1关联IP地址组,2域名
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 源类型0 ipv4,1 ipv6
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// 源IP，手动类型不能为空，自动及domain类型为空
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 关联IP地址组ID，自动类型不能为空，手动类型合domain类型为空
        /// </summary>
        [JsonProperty("address_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressSetId { get; set; }

        /// <summary>
        /// 地址组名称
        /// </summary>
        [JsonProperty("address_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressSetName { get; set; }

        /// <summary>
        /// 域名地址名称，域名类型时不能为空，手动类型及自动类型时为空
        /// </summary>
        [JsonProperty("domain_address_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAddressName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAddressDto {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  addressSetId: ").Append(AddressSetId).Append("\n");
            sb.Append("  addressSetName: ").Append(AddressSetName).Append("\n");
            sb.Append("  domainAddressName: ").Append(DomainAddressName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAddressDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAddressDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressSetId == input.AddressSetId ||
                    (this.AddressSetId != null &&
                    this.AddressSetId.Equals(input.AddressSetId))
                ) && 
                (
                    this.AddressSetName == input.AddressSetName ||
                    (this.AddressSetName != null &&
                    this.AddressSetName.Equals(input.AddressSetName))
                ) && 
                (
                    this.DomainAddressName == input.DomainAddressName ||
                    (this.DomainAddressName != null &&
                    this.DomainAddressName.Equals(input.DomainAddressName))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressSetId != null)
                    hashCode = hashCode * 59 + this.AddressSetId.GetHashCode();
                if (this.AddressSetName != null)
                    hashCode = hashCode * 59 + this.AddressSetName.GetHashCode();
                if (this.DomainAddressName != null)
                    hashCode = hashCode * 59 + this.DomainAddressName.GetHashCode();
                return hashCode;
            }
        }
    }
}
