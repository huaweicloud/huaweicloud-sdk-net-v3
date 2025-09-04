using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryIndirectPartnersReq 
    {

        /// <summary>
        /// 云经销商伙伴的账号名。 此参数不携带或携带值为空串或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 云经销商关联华为云总经销商的开始时间。 UTC时间（包括时区），比如2016-03-28T00:00:00Z。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("associated_on_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedOnBegin { get; set; }

        /// <summary>
        /// 云经销商关联华为云总经销商的结束时间。 UTC时间（包括时区），比如2016-03-28T00:00:00Z。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("associated_on_end", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociatedOnEnd { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。  说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。 例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的数量限制。默认值为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。 如果需要查询具体某个云经销商伙伴，必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryIndirectPartnersReq {\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  associatedOnBegin: ").Append(AssociatedOnBegin).Append("\n");
            sb.Append("  associatedOnEnd: ").Append(AssociatedOnEnd).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryIndirectPartnersReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryIndirectPartnersReq input)
        {
            if (input == null) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.AssociatedOnBegin != input.AssociatedOnBegin || (this.AssociatedOnBegin != null && !this.AssociatedOnBegin.Equals(input.AssociatedOnBegin))) return false;
            if (this.AssociatedOnEnd != input.AssociatedOnEnd || (this.AssociatedOnEnd != null && !this.AssociatedOnEnd.Equals(input.AssociatedOnEnd))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
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
                if (this.AssociatedOnBegin != null) hashCode = hashCode * 59 + this.AssociatedOnBegin.GetHashCode();
                if (this.AssociatedOnEnd != null) hashCode = hashCode * 59 + this.AssociatedOnEnd.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
