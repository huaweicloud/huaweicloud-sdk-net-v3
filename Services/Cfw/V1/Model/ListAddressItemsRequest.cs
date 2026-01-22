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
    public class ListAddressItemsRequest 
    {

        /// <summary>
        /// 地址组id，可通过[查询地址组列表接口](ListAddressSets.xml)查询获得，通过返回值中的data.records.set_id（.表示各对象之间层级的区分）获得。
        /// </summary>
        [SDKProperty("set_id", IsQuery = true)]
        [JsonProperty("set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SetId { get; set; }

        /// <summary>
        /// 关键字，包括地址组成员名称或描述的一部分
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
        /// 查询地址组类型，0表示自定义地址组，1表示预定义地址组
        /// </summary>
        [SDKProperty("query_address_set_type", IsQuery = true)]
        [JsonProperty("query_address_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QueryAddressSetType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAddressItemsRequest {\n");
            sb.Append("  setId: ").Append(SetId).Append("\n");
            sb.Append("  keyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  queryAddressSetType: ").Append(QueryAddressSetType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAddressItemsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAddressItemsRequest input)
        {
            if (input == null) return false;
            if (this.SetId != input.SetId || (this.SetId != null && !this.SetId.Equals(input.SetId))) return false;
            if (this.KeyWord != input.KeyWord || (this.KeyWord != null && !this.KeyWord.Equals(input.KeyWord))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.QueryAddressSetType != input.QueryAddressSetType || (this.QueryAddressSetType != null && !this.QueryAddressSetType.Equals(input.QueryAddressSetType))) return false;

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
                if (this.KeyWord != null) hashCode = hashCode * 59 + this.KeyWord.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.QueryAddressSetType != null) hashCode = hashCode * 59 + this.QueryAddressSetType.GetHashCode();
                return hashCode;
            }
        }
    }
}
