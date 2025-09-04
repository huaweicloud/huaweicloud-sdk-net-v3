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
    public class ListPartnerAccountChangeRecordsRequest 
    {

        /// <summary>
        /// 账户类型。BALANCE_TYPE_DEBIT：现金账户,BALANCE_TYPE_CREDIT：信用账户
        /// </summary>
        [SDKProperty("balance_type", IsQuery = true)]
        [JsonProperty("balance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceType { get; set; }

        /// <summary>
        /// 交易类型。RECHARGE：充值,DEDEUCT：消费,REFUND：退款,RFROZEN：冻结,TRANS：转账，余额和保证金互换（老商务模式，当前已无保证金账户）,ADJUST：调账（华为核销等）,BEADJUST：经销商拨款,BERETRIEVE：经销商回收,BEUNBIND：解绑/关联模式切换导致的回收,BONUSCONVERT：奖励金转换（老商务模式，当前已无奖励金账户）,TRADE_MODE_TRANSFER：交易模式变更, 此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("trade_type", IsQuery = true)]
        [JsonProperty("trade_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeType { get; set; }

        /// <summary>
        /// 查询收支明细的开始日期。 说明： 东八区时间，格式为YYYY-MM-DD，如“2017-10-21”。默认值为一年前的当天日期。
        /// </summary>
        [SDKProperty("trade_time_begin", IsQuery = true)]
        [JsonProperty("trade_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTimeBegin { get; set; }

        /// <summary>
        /// 查询收支明细的结束日期。 说明： 东八区时间，格式为YYYY-MM-DD，如“2017-12-21”。默认值为当前日期。
        /// </summary>
        [SDKProperty("trade_time_end", IsQuery = true)]
        [JsonProperty("trade_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTimeEnd { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的数量，默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。  说明： 华为云总经销商（一级经销商）查询云经销商（二级经销商）的收支明细时，需携带此参数；除此之外，此参数不作处理。否则只能查询自身的收支明细。
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
            sb.Append("class ListPartnerAccountChangeRecordsRequest {\n");
            sb.Append("  balanceType: ").Append(BalanceType).Append("\n");
            sb.Append("  tradeType: ").Append(TradeType).Append("\n");
            sb.Append("  tradeTimeBegin: ").Append(TradeTimeBegin).Append("\n");
            sb.Append("  tradeTimeEnd: ").Append(TradeTimeEnd).Append("\n");
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
            return this.Equals(input as ListPartnerAccountChangeRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPartnerAccountChangeRecordsRequest input)
        {
            if (input == null) return false;
            if (this.BalanceType != input.BalanceType || (this.BalanceType != null && !this.BalanceType.Equals(input.BalanceType))) return false;
            if (this.TradeType != input.TradeType || (this.TradeType != null && !this.TradeType.Equals(input.TradeType))) return false;
            if (this.TradeTimeBegin != input.TradeTimeBegin || (this.TradeTimeBegin != null && !this.TradeTimeBegin.Equals(input.TradeTimeBegin))) return false;
            if (this.TradeTimeEnd != input.TradeTimeEnd || (this.TradeTimeEnd != null && !this.TradeTimeEnd.Equals(input.TradeTimeEnd))) return false;
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
                if (this.BalanceType != null) hashCode = hashCode * 59 + this.BalanceType.GetHashCode();
                if (this.TradeType != null) hashCode = hashCode * 59 + this.TradeType.GetHashCode();
                if (this.TradeTimeBegin != null) hashCode = hashCode * 59 + this.TradeTimeBegin.GetHashCode();
                if (this.TradeTimeEnd != null) hashCode = hashCode * 59 + this.TradeTimeEnd.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
