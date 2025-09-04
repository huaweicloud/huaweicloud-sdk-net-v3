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
    public class QueryCouponQuotasReqExt 
    {

        /// <summary>
        /// 优惠券额度ID列表。 此参数不携带或携带值为空列表或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("quota_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> QuotaIds { get; set; }

        /// <summary>
        /// 优惠券额度状态列表。 0：正常3：失效（过期失效和人工设置失效）4：额度调整中（伙伴可以查看该额度，但不能使用该额度发放优惠券）5：冻结 此参数不携带或携带值为空列表或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("quota_status_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> QuotaStatusList { get; set; }

        /// <summary>
        /// 优惠券额度的类型。 0：代金券额度1：现金券额度 此参数不携带或携带值为null时，默认值为“0：代金券额度”。
        /// </summary>
        [JsonProperty("quota_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaType { get; set; }

        /// <summary>
        /// 创建时间（开始）。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。 输入这个条件，会查询出创建时间大于这个时间的记录。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("create_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeBegin { get; set; }

        /// <summary>
        /// 创建时间（结束）。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。 输入这个条件，会查询出创建时间小于这个时间的记录。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("create_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// 生效时间（开始）。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。 输入这个条件，会查询出生效时间大于这个时间的记录。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("effective_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimeBegin { get; set; }

        /// <summary>
        /// 生效时间（结束）。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。 输入这个条件，会查询出生效时间小于这个时间的记录。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("effective_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTimeEnd { get; set; }

        /// <summary>
        /// 失效时间（开始）。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。 输入这个条件，会查询出失效时间大于这个时间的记录。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("expire_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeBegin { get; set; }

        /// <summary>
        /// 失效时间（结束）。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。 输入这个条件，会查询出失效时间小于这个时间的记录。 此参数不携带或携带值为null时，不作为筛选条件。
        /// </summary>
        [JsonProperty("expire_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeEnd { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。  说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。 例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询记录数。默认值为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商（二级经销商）ID。 华为云总经销商（一级经销商）查询云经销商的优惠券额度时，需要携带该参数；否则只能查询自己的优惠券额度。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryCouponQuotasReqExt {\n");
            sb.Append("  quotaIds: ").Append(QuotaIds).Append("\n");
            sb.Append("  quotaStatusList: ").Append(QuotaStatusList).Append("\n");
            sb.Append("  quotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  createTimeBegin: ").Append(CreateTimeBegin).Append("\n");
            sb.Append("  createTimeEnd: ").Append(CreateTimeEnd).Append("\n");
            sb.Append("  effectiveTimeBegin: ").Append(EffectiveTimeBegin).Append("\n");
            sb.Append("  effectiveTimeEnd: ").Append(EffectiveTimeEnd).Append("\n");
            sb.Append("  expireTimeBegin: ").Append(ExpireTimeBegin).Append("\n");
            sb.Append("  expireTimeEnd: ").Append(ExpireTimeEnd).Append("\n");
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
            return this.Equals(input as QueryCouponQuotasReqExt);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryCouponQuotasReqExt input)
        {
            if (input == null) return false;
            if (this.QuotaIds != input.QuotaIds || (this.QuotaIds != null && input.QuotaIds != null && !this.QuotaIds.SequenceEqual(input.QuotaIds))) return false;
            if (this.QuotaStatusList != input.QuotaStatusList || (this.QuotaStatusList != null && input.QuotaStatusList != null && !this.QuotaStatusList.SequenceEqual(input.QuotaStatusList))) return false;
            if (this.QuotaType != input.QuotaType || (this.QuotaType != null && !this.QuotaType.Equals(input.QuotaType))) return false;
            if (this.CreateTimeBegin != input.CreateTimeBegin || (this.CreateTimeBegin != null && !this.CreateTimeBegin.Equals(input.CreateTimeBegin))) return false;
            if (this.CreateTimeEnd != input.CreateTimeEnd || (this.CreateTimeEnd != null && !this.CreateTimeEnd.Equals(input.CreateTimeEnd))) return false;
            if (this.EffectiveTimeBegin != input.EffectiveTimeBegin || (this.EffectiveTimeBegin != null && !this.EffectiveTimeBegin.Equals(input.EffectiveTimeBegin))) return false;
            if (this.EffectiveTimeEnd != input.EffectiveTimeEnd || (this.EffectiveTimeEnd != null && !this.EffectiveTimeEnd.Equals(input.EffectiveTimeEnd))) return false;
            if (this.ExpireTimeBegin != input.ExpireTimeBegin || (this.ExpireTimeBegin != null && !this.ExpireTimeBegin.Equals(input.ExpireTimeBegin))) return false;
            if (this.ExpireTimeEnd != input.ExpireTimeEnd || (this.ExpireTimeEnd != null && !this.ExpireTimeEnd.Equals(input.ExpireTimeEnd))) return false;
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
                if (this.QuotaIds != null) hashCode = hashCode * 59 + this.QuotaIds.GetHashCode();
                if (this.QuotaStatusList != null) hashCode = hashCode * 59 + this.QuotaStatusList.GetHashCode();
                if (this.QuotaType != null) hashCode = hashCode * 59 + this.QuotaType.GetHashCode();
                if (this.CreateTimeBegin != null) hashCode = hashCode * 59 + this.CreateTimeBegin.GetHashCode();
                if (this.CreateTimeEnd != null) hashCode = hashCode * 59 + this.CreateTimeEnd.GetHashCode();
                if (this.EffectiveTimeBegin != null) hashCode = hashCode * 59 + this.EffectiveTimeBegin.GetHashCode();
                if (this.EffectiveTimeEnd != null) hashCode = hashCode * 59 + this.EffectiveTimeEnd.GetHashCode();
                if (this.ExpireTimeBegin != null) hashCode = hashCode * 59 + this.ExpireTimeBegin.GetHashCode();
                if (this.ExpireTimeEnd != null) hashCode = hashCode * 59 + this.ExpireTimeEnd.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
