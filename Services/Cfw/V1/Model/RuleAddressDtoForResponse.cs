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
    public class RuleAddressDtoForResponse 
    {

        /// <summary>
        /// 源类型0手工输入,1关联IP地址组,2域名，3地理位置，4域名组，5多对象，6域名组-DNS解析，7域名组-URL过滤。
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
        /// 规则region列表json值
        /// </summary>
        [JsonProperty("region_list_json", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionListJson { get; set; }

        /// <summary>
        /// 规则region列表
        /// </summary>
        [JsonProperty("region_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpRegionDto> RegionList { get; set; }

        /// <summary>
        /// 域名组id
        /// </summary>
        [JsonProperty("domain_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainSetId { get; set; }

        /// <summary>
        /// 域名组名称
        /// </summary>
        [JsonProperty("domain_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainSetName { get; set; }

        /// <summary>
        /// IP地址列表
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddress { get; set; }

        /// <summary>
        /// 地址组列表
        /// </summary>
        [JsonProperty("address_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddressGroup { get; set; }

        /// <summary>
        /// 地址组名称列表
        /// </summary>
        [JsonProperty("address_group_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressGroupVO> AddressGroupNames { get; set; }

        /// <summary>
        /// 地址组类型，0表示自定义地址组，1表示WAF回源IP地址组，2表示DDoS回源IP地址组，3表示NAT64转换地址组
        /// </summary>
        [JsonProperty("address_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressSetType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAddressDtoForResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  addressSetId: ").Append(AddressSetId).Append("\n");
            sb.Append("  addressSetName: ").Append(AddressSetName).Append("\n");
            sb.Append("  domainAddressName: ").Append(DomainAddressName).Append("\n");
            sb.Append("  regionListJson: ").Append(RegionListJson).Append("\n");
            sb.Append("  regionList: ").Append(RegionList).Append("\n");
            sb.Append("  domainSetId: ").Append(DomainSetId).Append("\n");
            sb.Append("  domainSetName: ").Append(DomainSetName).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  addressGroup: ").Append(AddressGroup).Append("\n");
            sb.Append("  addressGroupNames: ").Append(AddressGroupNames).Append("\n");
            sb.Append("  addressSetType: ").Append(AddressSetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleAddressDtoForResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RuleAddressDtoForResponse input)
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
                ) && 
                (
                    this.RegionListJson == input.RegionListJson ||
                    (this.RegionListJson != null &&
                    this.RegionListJson.Equals(input.RegionListJson))
                ) && 
                (
                    this.RegionList == input.RegionList ||
                    this.RegionList != null &&
                    input.RegionList != null &&
                    this.RegionList.SequenceEqual(input.RegionList)
                ) && 
                (
                    this.DomainSetId == input.DomainSetId ||
                    (this.DomainSetId != null &&
                    this.DomainSetId.Equals(input.DomainSetId))
                ) && 
                (
                    this.DomainSetName == input.DomainSetName ||
                    (this.DomainSetName != null &&
                    this.DomainSetName.Equals(input.DomainSetName))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    this.IpAddress != null &&
                    input.IpAddress != null &&
                    this.IpAddress.SequenceEqual(input.IpAddress)
                ) && 
                (
                    this.AddressGroup == input.AddressGroup ||
                    this.AddressGroup != null &&
                    input.AddressGroup != null &&
                    this.AddressGroup.SequenceEqual(input.AddressGroup)
                ) && 
                (
                    this.AddressGroupNames == input.AddressGroupNames ||
                    this.AddressGroupNames != null &&
                    input.AddressGroupNames != null &&
                    this.AddressGroupNames.SequenceEqual(input.AddressGroupNames)
                ) && 
                (
                    this.AddressSetType == input.AddressSetType ||
                    (this.AddressSetType != null &&
                    this.AddressSetType.Equals(input.AddressSetType))
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
                if (this.RegionListJson != null)
                    hashCode = hashCode * 59 + this.RegionListJson.GetHashCode();
                if (this.RegionList != null)
                    hashCode = hashCode * 59 + this.RegionList.GetHashCode();
                if (this.DomainSetId != null)
                    hashCode = hashCode * 59 + this.DomainSetId.GetHashCode();
                if (this.DomainSetName != null)
                    hashCode = hashCode * 59 + this.DomainSetName.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.AddressGroup != null)
                    hashCode = hashCode * 59 + this.AddressGroup.GetHashCode();
                if (this.AddressGroupNames != null)
                    hashCode = hashCode * 59 + this.AddressGroupNames.GetHashCode();
                if (this.AddressSetType != null)
                    hashCode = hashCode * 59 + this.AddressSetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
