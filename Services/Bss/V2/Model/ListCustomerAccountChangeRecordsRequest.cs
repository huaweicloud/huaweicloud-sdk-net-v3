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
    public class ListCustomerAccountChangeRecordsRequest 
    {

        /// <summary>
        /// |参数名称：账户类型。BALANCE_TYPE_DEBIT：现金账户BALANCE_TYPE_CREDIT：信用账户| |参数的约束及描述：必填|
        /// </summary>
        [SDKProperty("balance_type", IsQuery = true)]
        [JsonProperty("balance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceType { get; set; }

        /// <summary>
        /// |参数名称：收支类型。REVENUE：收入EXPENSE：支出| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("revenue_expense_type", IsQuery = true)]
        [JsonProperty("revenue_expense_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueExpenseType { get; set; }

        /// <summary>
        /// |参数名称：交易类型| |参数的约束及描述：该参数非必填，RECHARGE：充值 DEDEUCT：消费 REFUND：退款 RFROZEN：冻结 TRANS：转账，余额和保证金互换（老商务模式，当前已无保证金账户） ADJUST：调账（华为核销等） BEUNBIND：解绑/关联模式切换导致的回收 EXPIRED：过期清零 BONUSCONVERT：奖励金转换（老商务模式，当前已无奖励金账户） TRADE_MODE_TRANSFER：交易模式变更 DEPOSIT：保证金 BEADJUST：经销商拨款 BERETRIEVE：经销商回收。此参数不携带、携带值为空时，不作为筛选条件。|
        /// </summary>
        [SDKProperty("trade_type", IsQuery = true)]
        [JsonProperty("trade_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeType { get; set; }

        /// <summary>
        /// |参数名称：查询收支明细的开始日期| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("trade_time_begin", IsQuery = true)]
        [JsonProperty("trade_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTimeBegin { get; set; }

        /// <summary>
        /// |参数名称：查询收支明细的结束日期| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("trade_time_end", IsQuery = true)]
        [JsonProperty("trade_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTimeEnd { get; set; }

        /// <summary>
        /// |参数名称：交易ID/订单ID| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("trade_id", IsQuery = true)]
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// |参数名称：交易渠道。可以一次查询多个，用逗号分隔。1：支付宝2：银行转账4：支付宝/网银5：微信支付6：提现7：激励返点10：交易模式变更11：调账317：银联（统一支付平台）319：Huawei Pay320：华为支付| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("payment_channel_id", IsQuery = true)]
        [JsonProperty("payment_channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentChannelId { get; set; }

        /// <summary>
        /// |参数名称：交易渠道流水号| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("payment_channel_no", IsQuery = true)]
        [JsonProperty("payment_channel_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentChannelNo { get; set; }

        /// <summary>
        /// |参数名称：偏移量| |参数的约束及描述：非必填|
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// |参数名称：每页的显示条数| |参数的约束及描述：非必填|
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
            sb.Append("class ListCustomerAccountChangeRecordsRequest {\n");
            sb.Append("  balanceType: ").Append(BalanceType).Append("\n");
            sb.Append("  revenueExpenseType: ").Append(RevenueExpenseType).Append("\n");
            sb.Append("  tradeType: ").Append(TradeType).Append("\n");
            sb.Append("  tradeTimeBegin: ").Append(TradeTimeBegin).Append("\n");
            sb.Append("  tradeTimeEnd: ").Append(TradeTimeEnd).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  paymentChannelId: ").Append(PaymentChannelId).Append("\n");
            sb.Append("  paymentChannelNo: ").Append(PaymentChannelNo).Append("\n");
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
            return this.Equals(input as ListCustomerAccountChangeRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerAccountChangeRecordsRequest input)
        {
            if (input == null) return false;
            if (this.BalanceType != input.BalanceType || (this.BalanceType != null && !this.BalanceType.Equals(input.BalanceType))) return false;
            if (this.RevenueExpenseType != input.RevenueExpenseType || (this.RevenueExpenseType != null && !this.RevenueExpenseType.Equals(input.RevenueExpenseType))) return false;
            if (this.TradeType != input.TradeType || (this.TradeType != null && !this.TradeType.Equals(input.TradeType))) return false;
            if (this.TradeTimeBegin != input.TradeTimeBegin || (this.TradeTimeBegin != null && !this.TradeTimeBegin.Equals(input.TradeTimeBegin))) return false;
            if (this.TradeTimeEnd != input.TradeTimeEnd || (this.TradeTimeEnd != null && !this.TradeTimeEnd.Equals(input.TradeTimeEnd))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.PaymentChannelId != input.PaymentChannelId || (this.PaymentChannelId != null && !this.PaymentChannelId.Equals(input.PaymentChannelId))) return false;
            if (this.PaymentChannelNo != input.PaymentChannelNo || (this.PaymentChannelNo != null && !this.PaymentChannelNo.Equals(input.PaymentChannelNo))) return false;
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
                if (this.TradeTimeBegin != null) hashCode = hashCode * 59 + this.TradeTimeBegin.GetHashCode();
                if (this.TradeTimeEnd != null) hashCode = hashCode * 59 + this.TradeTimeEnd.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.PaymentChannelId != null) hashCode = hashCode * 59 + this.PaymentChannelId.GetHashCode();
                if (this.PaymentChannelNo != null) hashCode = hashCode * 59 + this.PaymentChannelNo.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
