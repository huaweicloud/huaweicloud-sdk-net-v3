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
    /// Request Object
    /// </summary>
    public class ListCouponQuotasRecordsRequest 
    {

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。为空表示查询所有的代金券额度发放回收记录。不为空表示仅查询与该云经销商相关的代金券额度发放回收记录。默认查询所有云经销商的代金券额度发放回收记录。
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// 云经销商的代金券额度ID。获取方法请参见[查询优惠券额度](https://support.huaweicloud.com/api-bpconsole/mp_02003.html)。即华为云总经销商给云经销商发放代金券额度时，产生的云经销商的代金券额度ID，或者从云经销商回收代金券额度时，云经销商的代金券额度ID。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("quota_id", IsQuery = true)]
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 查询条件：操作起始时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。此参数不携带或携带值为空时，不作为筛选条件。不支持携带值为空串。
        /// </summary>
        [SDKProperty("operation_time_begin", IsQuery = true)]
        [JsonProperty("operation_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTimeBegin { get; set; }

        /// <summary>
        /// 查询条件：操作截止时间。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。此参数不携带或携带值为空时，不作为筛选条件。不支持携带值为空串。
        /// </summary>
        [SDKProperty("operation_time_end", IsQuery = true)]
        [JsonProperty("operation_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTimeEnd { get; set; }

        /// <summary>
        /// 父额度ID。这即华为云总经销商给云经销商发放代金券额度时，华为云总经销商的额度ID，或者从云经销商回收代金券额度时，回收的华为云总经销商的额度ID。此参数不携带或携带值为空时，不作为筛选条件。携带值为空串或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("parent_quota_id", IsQuery = true)]
        [JsonProperty("parent_quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentQuotaId { get; set; }

        /// <summary>
        /// 操作类型。10：发放额度11：回收额度。此参数不携带或携带值为非枚举值时，不作为筛选条件。
        /// </summary>
        [SDKProperty("operation_type", IsQuery = true)]
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// 偏移量，从0开始，默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的数目。默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCouponQuotasRecordsRequest {\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  operationTimeBegin: ").Append(OperationTimeBegin).Append("\n");
            sb.Append("  operationTimeEnd: ").Append(OperationTimeEnd).Append("\n");
            sb.Append("  parentQuotaId: ").Append(ParentQuotaId).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCouponQuotasRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCouponQuotasRecordsRequest input)
        {
            if (input == null) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.OperationTimeBegin != input.OperationTimeBegin || (this.OperationTimeBegin != null && !this.OperationTimeBegin.Equals(input.OperationTimeBegin))) return false;
            if (this.OperationTimeEnd != input.OperationTimeEnd || (this.OperationTimeEnd != null && !this.OperationTimeEnd.Equals(input.OperationTimeEnd))) return false;
            if (this.ParentQuotaId != input.ParentQuotaId || (this.ParentQuotaId != null && !this.ParentQuotaId.Equals(input.ParentQuotaId))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                if (this.QuotaId != null) hashCode = hashCode * 59 + this.QuotaId.GetHashCode();
                if (this.OperationTimeBegin != null) hashCode = hashCode * 59 + this.OperationTimeBegin.GetHashCode();
                if (this.OperationTimeEnd != null) hashCode = hashCode * 59 + this.OperationTimeEnd.GetHashCode();
                if (this.ParentQuotaId != null) hashCode = hashCode * 59 + this.ParentQuotaId.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
