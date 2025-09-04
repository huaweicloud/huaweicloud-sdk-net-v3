using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEnterpriseSubCustomersRequest 
    {

        /// <summary>
        /// 企业子账号的账号名。根据fuzzy_query取值决定是否按模糊查询。仅支持前缀匹配、后缀匹配、中间匹配；不支持携带空格查询。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("sub_customer_account_name", IsQuery = true)]
        [JsonProperty("sub_customer_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCustomerAccountName { get; set; }

        /// <summary>
        /// 企业子账号的显示名称。根据fuzzy_query取值决定是否按模糊查询。仅支持前缀匹配、后缀匹配、中间匹配；不支持携带空格查询。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串时，作为筛选条件。
        /// </summary>
        [SDKProperty("sub_customer_display_name", IsQuery = true)]
        [JsonProperty("sub_customer_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubCustomerDisplayName { get; set; }

        /// <summary>
        /// 企业子账号的显示名称、用户名是否按模糊查询。默认值为“0：不按模糊查询”。0：不按模糊查询1：按模糊查询
        /// </summary>
        [SDKProperty("fuzzy_query", IsQuery = true)]
        [JsonProperty("fuzzy_query", NullValueHandling = NullValueHandling.Ignore)]
        public int? FuzzyQuery { get; set; }

        /// <summary>
        /// 偏移量，从0开始，默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询记录数，默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 子账号归属的组织单元ID。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("org_id", IsQuery = true)]
        [JsonProperty("org_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrgId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnterpriseSubCustomersRequest {\n");
            sb.Append("  subCustomerAccountName: ").Append(SubCustomerAccountName).Append("\n");
            sb.Append("  subCustomerDisplayName: ").Append(SubCustomerDisplayName).Append("\n");
            sb.Append("  fuzzyQuery: ").Append(FuzzyQuery).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  orgId: ").Append(OrgId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnterpriseSubCustomersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnterpriseSubCustomersRequest input)
        {
            if (input == null) return false;
            if (this.SubCustomerAccountName != input.SubCustomerAccountName || (this.SubCustomerAccountName != null && !this.SubCustomerAccountName.Equals(input.SubCustomerAccountName))) return false;
            if (this.SubCustomerDisplayName != input.SubCustomerDisplayName || (this.SubCustomerDisplayName != null && !this.SubCustomerDisplayName.Equals(input.SubCustomerDisplayName))) return false;
            if (this.FuzzyQuery != input.FuzzyQuery || (this.FuzzyQuery != null && !this.FuzzyQuery.Equals(input.FuzzyQuery))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.OrgId != input.OrgId || (this.OrgId != null && !this.OrgId.Equals(input.OrgId))) return false;

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
                if (this.SubCustomerAccountName != null) hashCode = hashCode * 59 + this.SubCustomerAccountName.GetHashCode();
                if (this.SubCustomerDisplayName != null) hashCode = hashCode * 59 + this.SubCustomerDisplayName.GetHashCode();
                if (this.FuzzyQuery != null) hashCode = hashCode * 59 + this.FuzzyQuery.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.OrgId != null) hashCode = hashCode * 59 + this.OrgId.GetHashCode();
                return hashCode;
            }
        }
    }
}
