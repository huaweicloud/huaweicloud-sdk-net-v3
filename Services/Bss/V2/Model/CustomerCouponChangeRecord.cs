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
    public class CustomerCouponChangeRecord 
    {

        /// <summary>
        /// |参数名称：优惠券ID| |参数约束及描述：优惠券ID，范围限制:0-64|
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponId { get; set; }

        /// <summary>
        /// |参数名称：交易详细类型| |参数约束及描述：交易详细类型，范围限制:0-128， SOURCE_OPERAIION_DEDEUCT：消费(包年/包月) SOURCE_OPERAIION_USAGE：消费(按需) SOURCE_OPERAIION_SAVINGS_PLANS：消费(节省计划) SOURCE_OPERAIION_WRITEOFF：消费(欠费还款) SOURCE_OPERAIION_EXPIRECLEAR：过期清零 SOURCE_OPERAIION_UNSUBSCRIBE：退券(退订) SOURCE_OPERAIION_UNFROZEN：退券(流程中) SOURCE_OPERAIION_RFROZEN：退券(流程中) SOURCE_OPERAIION_PRIZE：激活 SOURCE_OPERAIION_BILLREFUND：调账(华为核销) SOURCE_OPERATION_COUPONCANCEL：优惠券回收 SOURCE_OPERATION_DEPOSIT_FROZEN：保证金冻结 SOURCE_OPERATION_DEPOSIT_UNFROZEN：保证金解冻 SOURCE_OPERATION_RETRIEVE：回收(企业回收) SOURCE_OPERATION_TRANSFER：划拨(企业划拨)|
        /// </summary>
        [JsonProperty("trade_detail_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeDetailType { get; set; }

        /// <summary>
        /// |参数名称：交易时间| |参数约束及描述：交易时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ|
        /// </summary>
        [JsonProperty("trade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTime { get; set; }

        /// <summary>
        /// |参数名称：交易ID/订单ID| |参数约束及描述：交易ID/订单ID，范围限制：0-128|
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
        /// |参数名称：收支类型| |参数约束及描述：收支类型。REVENUE：收入 EXPENSE：支出|
        /// </summary>
        [JsonProperty("revenue_expense_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RevenueExpenseType { get; set; }

        /// <summary>
        /// |参数名称：账期| |参数约束及描述：账期|
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

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
        /// |参数名称：资源类型名称| |参数约束及描述：产品的资源类型名称，范围限制：0-200|
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerCouponChangeRecord {\n");
            sb.Append("  couponId: ").Append(CouponId).Append("\n");
            sb.Append("  tradeDetailType: ").Append(TradeDetailType).Append("\n");
            sb.Append("  tradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  changeAmount: ").Append(ChangeAmount).Append("\n");
            sb.Append("  balanceAfterChange: ").Append(BalanceAfterChange).Append("\n");
            sb.Append("  revenueExpenseType: ").Append(RevenueExpenseType).Append("\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
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
            return this.Equals(input as CustomerCouponChangeRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerCouponChangeRecord input)
        {
            if (input == null) return false;
            if (this.CouponId != input.CouponId || (this.CouponId != null && !this.CouponId.Equals(input.CouponId))) return false;
            if (this.TradeDetailType != input.TradeDetailType || (this.TradeDetailType != null && !this.TradeDetailType.Equals(input.TradeDetailType))) return false;
            if (this.TradeTime != input.TradeTime || (this.TradeTime != null && !this.TradeTime.Equals(input.TradeTime))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.ChangeAmount != input.ChangeAmount || (this.ChangeAmount != null && !this.ChangeAmount.Equals(input.ChangeAmount))) return false;
            if (this.BalanceAfterChange != input.BalanceAfterChange || (this.BalanceAfterChange != null && !this.BalanceAfterChange.Equals(input.BalanceAfterChange))) return false;
            if (this.RevenueExpenseType != input.RevenueExpenseType || (this.RevenueExpenseType != null && !this.RevenueExpenseType.Equals(input.RevenueExpenseType))) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
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
                if (this.CouponId != null) hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                if (this.TradeDetailType != null) hashCode = hashCode * 59 + this.TradeDetailType.GetHashCode();
                if (this.TradeTime != null) hashCode = hashCode * 59 + this.TradeTime.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.ChangeAmount != null) hashCode = hashCode * 59 + this.ChangeAmount.GetHashCode();
                if (this.BalanceAfterChange != null) hashCode = hashCode * 59 + this.BalanceAfterChange.GetHashCode();
                if (this.RevenueExpenseType != null) hashCode = hashCode * 59 + this.RevenueExpenseType.GetHashCode();
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
