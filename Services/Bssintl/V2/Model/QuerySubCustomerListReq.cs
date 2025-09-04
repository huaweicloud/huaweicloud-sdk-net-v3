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
    /// 
    /// </summary>
    public class QuerySubCustomerListReq 
    {

        /// <summary>
        /// 客户登录名称（如果客户创建了IAM用户，此处需要填写主账号登录名称。关于主账号和IAM用户的具体介绍请参见身份管理中“账号”和“IAM用户”的描述）。 支持模糊查询。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 客户的实名认证名称，支持模糊查询。
        /// </summary>
        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public string Customer { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。  说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。 例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的客户数量。默认值为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 标签，支持模糊查找。
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// 关联类型： 1：顾问销售3：转售
        /// </summary>
        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationType { get; set; }

        /// <summary>
        /// 关联时间区间段开始，UTC时间。 格式：YYYY-MM-DD&#39;T&#39;hh:mm:ss&#39;Z&#39;，例如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("associated_on_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedOnBegin { get; set; }

        /// <summary>
        /// 关联时间区间段结束，UTC时间。 格式：YYYY-MM-DD&#39;T&#39;hh:mm:ss&#39;Z&#39;，例如“2019-05-06T08:05:01Z”。
        /// </summary>
        [JsonProperty("associated_on_end", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedOnEnd { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/intl/zh-cn/api-bpconsole/mc_00021.html)接口获取customer_id，或者可以从创建客户接口的响应获取domain_id。此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见查询云经销商列表。如果需要查询云经销商的子客户列表，必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuerySubCustomerListReq {\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  customer: ").Append(Customer).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  label: ").Append(Label).Append("\n");
            sb.Append("  associationType: ").Append(AssociationType).Append("\n");
            sb.Append("  associatedOnBegin: ").Append(AssociatedOnBegin).Append("\n");
            sb.Append("  associatedOnEnd: ").Append(AssociatedOnEnd).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuerySubCustomerListReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuerySubCustomerListReq input)
        {
            if (input == null) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.Customer != input.Customer || (this.Customer != null && !this.Customer.Equals(input.Customer))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Label != input.Label || (this.Label != null && !this.Label.Equals(input.Label))) return false;
            if (this.AssociationType != input.AssociationType || (this.AssociationType != null && !this.AssociationType.Equals(input.AssociationType))) return false;
            if (this.AssociatedOnBegin != input.AssociatedOnBegin || (this.AssociatedOnBegin != null && !this.AssociatedOnBegin.Equals(input.AssociatedOnBegin))) return false;
            if (this.AssociatedOnEnd != input.AssociatedOnEnd || (this.AssociatedOnEnd != null && !this.AssociatedOnEnd.Equals(input.AssociatedOnEnd))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;

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
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Customer != null) hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Label != null) hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.AssociationType != null) hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.AssociatedOnBegin != null) hashCode = hashCode * 59 + this.AssociatedOnBegin.GetHashCode();
                if (this.AssociatedOnEnd != null) hashCode = hashCode * 59 + this.AssociatedOnEnd.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
