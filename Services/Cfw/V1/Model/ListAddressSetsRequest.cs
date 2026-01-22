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
    /// Request Object
    /// </summary>
    public class ListAddressSetsRequest 
    {

        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID，type可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得
        /// </summary>
        [SDKProperty("object_id", IsQuery = true)]
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 关键字，包括地址组名称或描述的一部分
        /// </summary>
        [SDKProperty("key_word", IsQuery = true)]
        [JsonProperty("key_word", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 每页显示个数，范围为1-1024
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于或等于0，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [SDKProperty("address", IsQuery = true)]
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 地址类型0 ipv4，1 ipv6
        /// </summary>
        [SDKProperty("address_type", IsQuery = true)]
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取，用户未开启企业项目时为0
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 防火墙ID，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 查询地址组类型，0表示自定义地址组，1表示预定义地址组，当address_set_type不为0时，query_address_set_type为1时才可以生效。
        /// </summary>
        [SDKProperty("query_address_set_type", IsQuery = true)]
        [JsonProperty("query_address_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryAddressSetType { get; set; }

        /// <summary>
        /// 地址组类型，0表示自定义地址组，1表示WAF回源IP地址组，2表示DDoS回源IP地址组，3表示NAT64转换地址组
        /// </summary>
        [SDKProperty("address_set_type", IsQuery = true)]
        [JsonProperty("address_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressSetType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAddressSetsRequest {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  queryAddressSetType: ").Append(QueryAddressSetType).Append("\n");
            sb.Append("  addressSetType: ").Append(AddressSetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAddressSetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAddressSetsRequest input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.QueryAddressSetType != input.QueryAddressSetType || (this.QueryAddressSetType != null && !this.QueryAddressSetType.Equals(input.QueryAddressSetType))) return false;
            if (this.AddressSetType != input.AddressSetType || (this.AddressSetType != null && !this.AddressSetType.Equals(input.AddressSetType))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.QueryAddressSetType != null) hashCode = hashCode * 59 + this.QueryAddressSetType.GetHashCode();
                if (this.AddressSetType != null) hashCode = hashCode * 59 + this.AddressSetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
