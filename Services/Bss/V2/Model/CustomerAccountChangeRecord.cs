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
    public class CustomerAccountChangeRecord 
    {

        /// <summary>
        /// |参数名称：收支明细流水号| |参数约束及描述：收支明细流水号|
        /// </summary>
        [JsonProperty("account_change_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountChangeId { get; set; }

        /// <summary>
        /// |参数名称：交易详细类型| |参数约束及描述：交易详细类型|
        /// </summary>
        [JsonProperty("trade_detail_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeDetailType { get; set; }

        /// <summary>
        /// |参数名称：交易时间| |参数约束及描述：交易时间|
        /// </summary>
        [JsonProperty("trade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTime { get; set; }

        /// <summary>
        /// |参数名称：交易ID/订单ID| |参数约束及描述：交易ID/订单ID|
        /// </summary>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// |参数名称：变更金额| |参数约束及描述：变更金额|
        /// </summary>
        [JsonProperty("change_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeAmount { get; set; }

        /// <summary>
        /// |参数名称：变更后余额| |参数约束及描述：变更后余额|
        /// </summary>
        [JsonProperty("balance_after_change", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceAfterChange { get; set; }

        /// <summary>
        /// |参数名称：收支类型| |参数约束及描述：收支类型|
        /// </summary>
        [JsonProperty("revenue_expense_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueExpenseType { get; set; }

        /// <summary>
        /// |参数名称：账期| |参数约束及描述：账期|
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// |参数名称：交易渠道| |参数约束及描述：交易渠道|
        /// </summary>
        [JsonProperty("payment_channel_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentChannelId { get; set; }

        /// <summary>
        /// |参数名称：交易渠道流水号| |参数约束及描述：交易渠道流水号|
        /// </summary>
        [JsonProperty("payment_channel_no", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentChannelNo { get; set; }

        /// <summary>
        /// |参数名称：消费时间| |参数约束及描述：消费时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ。包年/包月：与账单交易时间一致（交易类型为调帐时为账单的计费开始时间和结束时间），按需/分期：为账单的计费开始时间和结束时间。|
        /// </summary>
        [JsonProperty("consume_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// |参数名称：账号名称| |参数约束及描述：账号名称，范围限制：0-128|
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// |参数名称：云服务类型名称| |参数约束及描述：产品的云服务名称，范围限制：0-200|
        /// </summary>
        [JsonProperty("cloud_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeName { get; set; }

        /// <summary>
        /// |参数名称：资源类型名称，该字段为预留字段。| |参数约束及描述：产品的资源类型名称，范围限制：0-200|
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerAccountChangeRecord {\n");
            sb.Append("  accountChangeId: ").Append(AccountChangeId).Append("\n");
            sb.Append("  tradeDetailType: ").Append(TradeDetailType).Append("\n");
            sb.Append("  tradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  changeAmount: ").Append(ChangeAmount).Append("\n");
            sb.Append("  balanceAfterChange: ").Append(BalanceAfterChange).Append("\n");
            sb.Append("  revenueExpenseType: ").Append(RevenueExpenseType).Append("\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  paymentChannelId: ").Append(PaymentChannelId).Append("\n");
            sb.Append("  paymentChannelNo: ").Append(PaymentChannelNo).Append("\n");
            sb.Append("  consumeTime: ").Append(ConsumeTime).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerAccountChangeRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerAccountChangeRecord input)
        {
            if (input == null) return false;
            if (this.AccountChangeId != input.AccountChangeId || (this.AccountChangeId != null && !this.AccountChangeId.Equals(input.AccountChangeId))) return false;
            if (this.TradeDetailType != input.TradeDetailType || (this.TradeDetailType != null && !this.TradeDetailType.Equals(input.TradeDetailType))) return false;
            if (this.TradeTime != input.TradeTime || (this.TradeTime != null && !this.TradeTime.Equals(input.TradeTime))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.ChangeAmount != input.ChangeAmount || (this.ChangeAmount != null && !this.ChangeAmount.Equals(input.ChangeAmount))) return false;
            if (this.BalanceAfterChange != input.BalanceAfterChange || (this.BalanceAfterChange != null && !this.BalanceAfterChange.Equals(input.BalanceAfterChange))) return false;
            if (this.RevenueExpenseType != input.RevenueExpenseType || (this.RevenueExpenseType != null && !this.RevenueExpenseType.Equals(input.RevenueExpenseType))) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.PaymentChannelId != input.PaymentChannelId || (this.PaymentChannelId != null && !this.PaymentChannelId.Equals(input.PaymentChannelId))) return false;
            if (this.PaymentChannelNo != input.PaymentChannelNo || (this.PaymentChannelNo != null && !this.PaymentChannelNo.Equals(input.PaymentChannelNo))) return false;
            if (this.ConsumeTime != input.ConsumeTime || (this.ConsumeTime != null && !this.ConsumeTime.Equals(input.ConsumeTime))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;

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
                if (this.AccountChangeId != null) hashCode = hashCode * 59 + this.AccountChangeId.GetHashCode();
                if (this.TradeDetailType != null) hashCode = hashCode * 59 + this.TradeDetailType.GetHashCode();
                if (this.TradeTime != null) hashCode = hashCode * 59 + this.TradeTime.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.ChangeAmount != null) hashCode = hashCode * 59 + this.ChangeAmount.GetHashCode();
                if (this.BalanceAfterChange != null) hashCode = hashCode * 59 + this.BalanceAfterChange.GetHashCode();
                if (this.RevenueExpenseType != null) hashCode = hashCode * 59 + this.RevenueExpenseType.GetHashCode();
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.PaymentChannelId != null) hashCode = hashCode * 59 + this.PaymentChannelId.GetHashCode();
                if (this.PaymentChannelNo != null) hashCode = hashCode * 59 + this.PaymentChannelNo.GetHashCode();
                if (this.ConsumeTime != null) hashCode = hashCode * 59 + this.ConsumeTime.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
