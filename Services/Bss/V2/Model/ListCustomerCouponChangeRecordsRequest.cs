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
    public class ListCustomerCouponChangeRecordsRequest 
    {

        /// <summary>
        /// |参数名称：账户类型| |参数的约束及描述：该参数必填，BALANCE_TYPE_COUPON：代金券账户|
        /// </summary>
        [SDKProperty("balance_type", IsQuery = true)]
        [JsonProperty("balance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceType { get; set; }

        /// <summary>
        /// |参数名称：收支类型| |参数的约束及描述：该参数非必填，REVENUE：收入 EXPENSE：支出。此参数不携带时，不作为筛选条件；此参数携带值不允许为空、空串，有枚举值校验。|
        /// </summary>
        [SDKProperty("revenue_expense_type", IsQuery = true)]
        [JsonProperty("revenue_expense_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueExpenseType { get; set; }

        /// <summary>
        /// |参数名称：交易类型| |参数的约束及描述：该参数非必填，ADJUST：激活 DEDEUCT：消费 REFUND：退券 RFROZEN：冻结 EXPIRED：过期清零 COUPONADJUST：划拨 COUPONCANCEL：回收。此参数不携带时，不作为筛选条件；此参数携带值不允许为空、空串，有枚举值校验。|
        /// </summary>
        [SDKProperty("trade_type", IsQuery = true)]
        [JsonProperty("trade_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeType { get; set; }

        /// <summary>
        /// |参数名称：交易ID/订单ID| |参数的约束及描述：该参数非必填，范围限制：0-128。此参数不携带或携带值为空时，不作为筛选条件。|
        /// </summary>
        [SDKProperty("trade_id", IsQuery = true)]
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// |参数名称：查询收支明细的开始日期| |参数的约束及描述：该参数非必填，东八区时间，格式为YYYY-MM-DD，此参数不携带、携带值为空时，默认值为一年前的当天日期；此参数不允许携带值为空串，有参数校验。|
        /// </summary>
        [SDKProperty("trade_time_begin", IsQuery = true)]
        [JsonProperty("trade_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTimeBegin { get; set; }

        /// <summary>
        /// |参数名称：查询收支明细的结束日期| |参数的约束及描述：该参数非必填，东八区时间，格式为YYYY-MM-DD，此参数不携带、携带值为空时，默认值为当前日期；此参数不允许携带值为空串，有参数校验。|
        /// </summary>
        [SDKProperty("trade_time_end", IsQuery = true)]
        [JsonProperty("trade_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTimeEnd { get; set; }

        /// <summary>
        /// |参数名称：优惠券ID。| |参数的约束及描述：该参数非必填，范围限制：0-64。此参数不携带或携带值为空时，不作为筛选条件。|
        /// </summary>
        [SDKProperty("coupon_id", IsQuery = true)]
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// |参数名称：偏移量| |参数的约束及描述：该参数非必填，范围限制：0-2147483647，默认值为0。此参数不携带或携带值为空时，默认传参为0。|
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// |参数名称：每次查询的数量| |参数的约束及描述：该参数非必填，范围限制：1-100，默认值为10。此参数不携带或携带值为空时，默认传参为10。|
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
            sb.Append("class ListCustomerCouponChangeRecordsRequest {\n");
            sb.Append("  balanceType: ").Append(BalanceType).Append("\n");
            sb.Append("  revenueExpenseType: ").Append(RevenueExpenseType).Append("\n");
            sb.Append("  tradeType: ").Append(TradeType).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  tradeTimeBegin: ").Append(TradeTimeBegin).Append("\n");
            sb.Append("  tradeTimeEnd: ").Append(TradeTimeEnd).Append("\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
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
            return this.Equals(input as ListCustomerCouponChangeRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerCouponChangeRecordsRequest input)
        {
            if (input == null) return false;
            if (this.BalanceType != input.BalanceType || (this.BalanceType != null && !this.BalanceType.Equals(input.BalanceType))) return false;
            if (this.RevenueExpenseType != input.RevenueExpenseType || (this.RevenueExpenseType != null && !this.RevenueExpenseType.Equals(input.RevenueExpenseType))) return false;
            if (this.TradeType != input.TradeType || (this.TradeType != null && !this.TradeType.Equals(input.TradeType))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.TradeTimeBegin != input.TradeTimeBegin || (this.TradeTimeBegin != null && !this.TradeTimeBegin.Equals(input.TradeTimeBegin))) return false;
            if (this.TradeTimeEnd != input.TradeTimeEnd || (this.TradeTimeEnd != null && !this.TradeTimeEnd.Equals(input.TradeTimeEnd))) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
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
                if (this.BalanceType != null) hashCode = hashCode * 59 + this.BalanceType.GetHashCode();
                if (this.RevenueExpenseType != null) hashCode = hashCode * 59 + this.RevenueExpenseType.GetHashCode();
                if (this.TradeType != null) hashCode = hashCode * 59 + this.TradeType.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.TradeTimeBegin != null) hashCode = hashCode * 59 + this.TradeTimeBegin.GetHashCode();
                if (this.TradeTimeEnd != null) hashCode = hashCode * 59 + this.TradeTimeEnd.GetHashCode();
                if (this.CouponId != null) hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
