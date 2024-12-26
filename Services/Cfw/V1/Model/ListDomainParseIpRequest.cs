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
    public class ListDomainParseIpRequest 
    {

        /// <summary>
        /// 地址类型，0 ipv4,1 ipv6
        /// </summary>
        [SDKProperty("address_type", IsQuery = true)]
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// 域名id，域名id可通过[获取域名组下域名列表接口](ListDomains.xml)查询获得，通过返回值中的data.records.domain_address_id（.表示各对象之间层级的区分）获取
        /// </summary>
        [SDKProperty("domain_address_id", IsPath = true)]
        [JsonProperty("domain_address_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainAddressId { get; set; }

        /// <summary>
        /// 域名组ID，可通过[查询域名组列表接口](ListDomainSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获取
        /// </summary>
        [SDKProperty("domain_set_id", IsQuery = true)]
        [JsonProperty("domain_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainSetId { get; set; }

        /// <summary>
        /// 防火墙ID，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取，用户未开启企业项目时为0
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDomainParseIpRequest {\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  domainAddressId: ").Append(DomainAddressId).Append("\n");
            sb.Append("  domainSetId: ").Append(DomainSetId).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDomainParseIpRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDomainParseIpRequest input)
        {
            if (input == null) return false;
            if (this.AddressType != input.AddressType || (this.AddressType != null && !this.AddressType.Equals(input.AddressType))) return false;
            if (this.DomainAddressId != input.DomainAddressId || (this.DomainAddressId != null && !this.DomainAddressId.Equals(input.DomainAddressId))) return false;
            if (this.DomainSetId != input.DomainSetId || (this.DomainSetId != null && !this.DomainSetId.Equals(input.DomainSetId))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;

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
                if (this.AddressType != null) hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.DomainAddressId != null) hashCode = hashCode * 59 + this.DomainAddressId.GetHashCode();
                if (this.DomainSetId != null) hashCode = hashCode * 59 + this.DomainSetId.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
