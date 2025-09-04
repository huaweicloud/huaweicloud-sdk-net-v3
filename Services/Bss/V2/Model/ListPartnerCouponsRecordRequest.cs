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
    public class ListPartnerCouponsRecordRequest 
    {

        /// <summary>
        /// 操作类型。1：发放2：手动回收3：解绑自动回收4：过期回收5：退订回收6：退款充值撤销7：建立关联回收此参数不携带时，不作为筛选条件；携带值为空列表或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("operation_types", IsQuery = true)]
        [JsonProperty("operation_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OperationTypes { get; set; }

        /// <summary>
        /// 额度ID。请从“查询优惠券额度”接口的响应参数中获取。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("quota_id", IsQuery = true)]
        [JsonProperty("quota_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 额度类型。0：代金券额度1：现金券额度此参数不携带或携带值为空或携带值为null时，不作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("quota_type", IsQuery = true)]
        [JsonProperty("quota_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaType { get; set; }

        /// <summary>
        /// 代金券ID列表。请从“发放优惠券”接口的响应参数中获取。此参数不携带时，不作为筛选条件；携带值为空列表或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("coupon_ids", IsQuery = true)]
        [JsonProperty("coupon_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CouponIds { get; set; }

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)接口获取customer_id。此参数不携带或携带值为空时，不作为筛选条件；携带值为空串或携带值为null时，作为筛选条件。
        /// </summary>
        [SDKProperty("customer_id", IsQuery = true)]
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 操作时间（开始）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出操作时间大于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件；不支持携带值为空串和携带值为null。
        /// </summary>
        [SDKProperty("operation_time_begin", IsQuery = true)]
        [JsonProperty("operation_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTimeBegin { get; set; }

        /// <summary>
        /// 操作时间（结束）。UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。其中，HH范围是0～23，mm和ss范围是0～59。输入这个条件，会查询出操作时间小于这个时间的记录。此参数不携带或携带值为空时，不作为筛选条件；不支持携带值为空串和携带值为null。
        /// </summary>
        [SDKProperty("operation_time_end", IsQuery = true)]
        [JsonProperty("operation_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTimeEnd { get; set; }

        /// <summary>
        /// 操作结果。0：成功-1：失败（非0的记录）此参数不携带或携带值为非枚举值时，不作为筛选条件。
        /// </summary>
        [SDKProperty("result", IsQuery = true)]
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。此参数不携带或携带值为空或携带值为null时，取默认值0；不支持携带值为空串。说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页记录数。默认值为10。此参数不携带或携带值为空或携带值为null时，取默认值10；不支持携带值为空串。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。华为云总经销商（一级经销商）查询云经销商发放给子客户的优惠券发放记录时，需要携带该参数，否则只能查询发给自己子客户的优惠券发放记录。
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPartnerCouponsRecordRequest {\n");
            sb.Append("  operationTypes: ").Append(OperationTypes).Append("\n");
            sb.Append("  quotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  quotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  couponIds: ").Append(CouponIds).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  operationTimeBegin: ").Append(OperationTimeBegin).Append("\n");
            sb.Append("  operationTimeEnd: ").Append(OperationTimeEnd).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
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
            return this.Equals(input as ListPartnerCouponsRecordRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPartnerCouponsRecordRequest input)
        {
            if (input == null) return false;
            if (this.OperationTypes != input.OperationTypes || (this.OperationTypes != null && input.OperationTypes != null && !this.OperationTypes.SequenceEqual(input.OperationTypes))) return false;
            if (this.QuotaId != input.QuotaId || (this.QuotaId != null && !this.QuotaId.Equals(input.QuotaId))) return false;
            if (this.QuotaType != input.QuotaType || (this.QuotaType != null && !this.QuotaType.Equals(input.QuotaType))) return false;
            if (this.CouponIds != input.CouponIds || (this.CouponIds != null && input.CouponIds != null && !this.CouponIds.SequenceEqual(input.CouponIds))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.OperationTimeBegin != input.OperationTimeBegin || (this.OperationTimeBegin != null && !this.OperationTimeBegin.Equals(input.OperationTimeBegin))) return false;
            if (this.OperationTimeEnd != input.OperationTimeEnd || (this.OperationTimeEnd != null && !this.OperationTimeEnd.Equals(input.OperationTimeEnd))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
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
                if (this.OperationTypes != null) hashCode = hashCode * 59 + this.OperationTypes.GetHashCode();
                if (this.QuotaId != null) hashCode = hashCode * 59 + this.QuotaId.GetHashCode();
                if (this.QuotaType != null) hashCode = hashCode * 59 + this.QuotaType.GetHashCode();
                if (this.CouponIds != null) hashCode = hashCode * 59 + this.CouponIds.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.OperationTimeBegin != null) hashCode = hashCode * 59 + this.OperationTimeBegin.GetHashCode();
                if (this.OperationTimeEnd != null) hashCode = hashCode * 59 + this.OperationTimeEnd.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
