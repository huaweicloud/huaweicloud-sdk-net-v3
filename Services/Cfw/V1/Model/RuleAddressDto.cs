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
        /// 地址类型0手工输入，1关联IP地址组，2域名，3地理位置，4域名组，5多对象，6域名组-网络型，7域名组-应用型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        /// <summary>
        /// 地址类型0 ipv4，1 ipv6，当type为0手动输入类型时不能为空
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// IP地址信息，当type为0手动输入类型时不能为空
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 关联IP地址组ID，当type为1关联IP地址组类型时不能为空，可通过[查询地址组列表接口](ListAddressSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("address_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressSetId { get; set; }

        /// <summary>
        /// 关联IP地址组名称，当type为1关联IP地址组类型时不能为空，可通过[查询地址组列表接口](ListAddressSets.xml)查询获得，通过返回值中的data.records.name（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("address_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressSetName { get; set; }

        /// <summary>
        /// type为2（域名）和7（应用域名组）具体内容根据type中7修改后的类型名称
        /// </summary>
        [JsonProperty("domain_address_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAddressName { get; set; }

        /// <summary>
        /// 规则地域列表json值
        /// </summary>
        [JsonProperty("region_list_json", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionListJson { get; set; }

        /// <summary>
        /// 规则地域列表
        /// </summary>
        [JsonProperty("region_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpRegionDto> RegionList { get; set; }

        /// <summary>
        /// 域名组id，type为4（域名组）或7（域名组-应用型）时不能为空。可通过[查询域名组列表接口](ListDomainSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("domain_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainSetId { get; set; }

        /// <summary>
        /// 域名组名称，type为4（域名组）或7（域名组-应用型）时不能为空。可通过[查询域名组列表接口](ListDomainSets.xml)查询获得，通过返回值中的data.records.name（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("domain_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainSetName { get; set; }

        /// <summary>
        /// IP地址列表，当type为5（多对象）时不能为空。
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpAddress { get; set; }

        /// <summary>
        /// 地址组id列表，当type为5（多对象）时不能为空。地址组id可通过[查询地址组列表接口](ListAddressSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。查询条件中query_address_set_type需要设置为0自定义地址组。
        /// </summary>
        [JsonProperty("address_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AddressGroup { get; set; }

        /// <summary>
        /// 地址组名称列表
        /// </summary>
        [JsonProperty("address_group_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<AddressGroupVO> AddressGroupNames { get; set; }

        /// <summary>
        /// 地址组类型，当type为1（关联IP地址组）时不能为空。0表示自定义地址组，1表示WAF回源IP地址组，2表示DDoS回源IP地址组，3表示NAT64转换地址组
        /// </summary>
        [JsonProperty("address_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressSetType { get; set; }

        /// <summary>
        /// 预定义地址组id列表，当type为5（多对象）时不能为空。地址组id可通过[查询地址组列表接口](ListAddressSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。查询条件中query_address_set_type需要设置为1预定义地址组。
        /// </summary>
        [JsonProperty("predefined_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PredefinedGroup { get; set; }



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
            sb.Append("  regionListJson: ").Append(RegionListJson).Append("\n");
            sb.Append("  regionList: ").Append(RegionList).Append("\n");
            sb.Append("  domainSetId: ").Append(DomainSetId).Append("\n");
            sb.Append("  domainSetName: ").Append(DomainSetName).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  addressGroup: ").Append(AddressGroup).Append("\n");
            sb.Append("  addressGroupNames: ").Append(AddressGroupNames).Append("\n");
            sb.Append("  addressSetType: ").Append(AddressSetType).Append("\n");
            sb.Append("  predefinedGroup: ").Append(PredefinedGroup).Append("\n");
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
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AddressSetId != input.AddressSetId || (this.AddressSetId != null && !this.AddressSetId.Equals(input.AddressSetId))) return false;
            if (this.AddressSetName != input.AddressSetName || (this.AddressSetName != null && !this.AddressSetName.Equals(input.AddressSetName))) return false;
            if (this.DomainAddressName != input.DomainAddressName || (this.DomainAddressName != null && !this.DomainAddressName.Equals(input.DomainAddressName))) return false;
            if (this.RegionListJson != input.RegionListJson || (this.RegionListJson != null && !this.RegionListJson.Equals(input.RegionListJson))) return false;
            if (this.RegionList != input.RegionList || (this.RegionList != null && input.RegionList != null && !this.RegionList.SequenceEqual(input.RegionList))) return false;
            if (this.DomainSetId != input.DomainSetId || (this.DomainSetId != null && !this.DomainSetId.Equals(input.DomainSetId))) return false;
            if (this.DomainSetName != input.DomainSetName || (this.DomainSetName != null && !this.DomainSetName.Equals(input.DomainSetName))) return false;
            if (this.IpAddress != input.IpAddress || (this.IpAddress != null && input.IpAddress != null && !this.IpAddress.SequenceEqual(input.IpAddress))) return false;
            if (this.AddressGroup != input.AddressGroup || (this.AddressGroup != null && input.AddressGroup != null && !this.AddressGroup.SequenceEqual(input.AddressGroup))) return false;
            if (this.AddressGroupNames != input.AddressGroupNames || (this.AddressGroupNames != null && input.AddressGroupNames != null && !this.AddressGroupNames.SequenceEqual(input.AddressGroupNames))) return false;
            if (this.AddressSetType != input.AddressSetType || (this.AddressSetType != null && !this.AddressSetType.Equals(input.AddressSetType))) return false;
            if (this.PredefinedGroup != input.PredefinedGroup || (this.PredefinedGroup != null && input.PredefinedGroup != null && !this.PredefinedGroup.SequenceEqual(input.PredefinedGroup))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressSetId != null) hashCode = hashCode * 59 + this.AddressSetId.GetHashCode();
                if (this.AddressSetName != null) hashCode = hashCode * 59 + this.AddressSetName.GetHashCode();
                if (this.DomainAddressName != null) hashCode = hashCode * 59 + this.DomainAddressName.GetHashCode();
                if (this.RegionListJson != null) hashCode = hashCode * 59 + this.RegionListJson.GetHashCode();
                if (this.RegionList != null) hashCode = hashCode * 59 + this.RegionList.GetHashCode();
                if (this.DomainSetId != null) hashCode = hashCode * 59 + this.DomainSetId.GetHashCode();
                if (this.DomainSetName != null) hashCode = hashCode * 59 + this.DomainSetName.GetHashCode();
                if (this.IpAddress != null) hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.AddressGroup != null) hashCode = hashCode * 59 + this.AddressGroup.GetHashCode();
                if (this.AddressGroupNames != null) hashCode = hashCode * 59 + this.AddressGroupNames.GetHashCode();
                if (this.AddressSetType != null) hashCode = hashCode * 59 + this.AddressSetType.GetHashCode();
                if (this.PredefinedGroup != null) hashCode = hashCode * 59 + this.PredefinedGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
