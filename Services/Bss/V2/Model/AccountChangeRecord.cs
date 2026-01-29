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
    public class AccountChangeRecord 
    {

        /// <summary>
        /// 收支明细流水号。
        /// </summary>
        [JsonProperty("account_change_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountChangeId { get; set; }

        /// <summary>
        /// 交易详细类型。 SOURCE_OPERAIION_ADJUST_CREDIT：调账(信用额度调整)SOURCE_OPERAIION_RECHARGE：充值SOURCE_OPERAIION_DEDEUCT：消费(包年/包月)SOURCE_OPERAIION_MANUALFROZE：冻结(人工冻结)SOURCE_OPERAIION_MANUALUNFROZE：冻结(人工解冻)SOURCE_OPERAIION_MANUALCLEARFROZEN：冻结(人工清零)SOURCE_OPERAIION_TRANS_TO_BALANCE：转账(保证金转余额)SOURCE_OPERATION_BEADJUST：伙伴拨款SOURCE_OPERATION_BEUNBIND：交易模式变更(切换/解除关联回收)SOURCE_OPERAIION_EXPIRECLEAR：过期清零SOURCE_OPERAIION_ONETIME：消费(一次性扣费)SOURCE_OPERAIION_REFUND：退款SOURCE_OPERAIION_UNFROZEN：退款(退款解冻)SOURCE_OPERAIION_CLEARFROZEN：退款(退款清零)SOURCE_OPERAIION_ADJUST：调账(余额调整)SOURCE_OPERAIION_USAGE：消费(按需)SOURCE_OPERAIION_WRITEOFF：消费(欠费还款)SOURCE_OPERAIION_UNSUBSCRIBE：退款SOURCE_OPERAIION_RFROZEN：退款(退款冻结)SOURCE_OPERAIION_TRANS_TO_FOREGIFT：转账(余额转保证金)SOURCE_OPERAIION_PRIZE：调账(赠送)SOURCE_OPERATION_BERETRIEVE：伙伴回收SOURCE_OPERAIION_PRECISIONCOMP：消费(精度补扣)SOURCE_OPERAIION_FREERESDEDUCT：消费(免费资源扣减)SOURCE_OPERAIION_MERGE：奖励金转换(合并)SOURCE_OPERAIION_CONVERT_BONUS：奖励金转换SOURCE_OPERAIION_RECHARGE_REBATE：充值(激励返点)SOURCE_OPERATION_COUPONCANCEL：优惠券回收SOURCE_OPERAIION_BILLREFUND：调账(华为核销)SOURCE_OPERATION_TRADEMODE_TRANSFER：交易模式变更(和伙伴关联)SOURCE_OPERATION_SYSTEM_FROZEN：系统冻结（购买标销合同的伙伴涉及该模式）SOURCE_OPERATION_SYSTEM_UNFROZEN：系统解冻（购买标销合同的伙伴涉及该模式）SOURCE_OPERATION_COUPON_QUOTA_TRANSFER：调账(兑换现金券额度)SOURCE_OPERATIION_RIDEDUCT：消费(预留实例)SOURCE_OPERATION_COUPON_QUOTA_RECLAIM：代金券回收
        /// </summary>
        [JsonProperty("trade_detail_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeDetailType { get; set; }

        /// <summary>
        /// 交易时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2016-03-28T14:45:38Z”。
        /// </summary>
        [JsonProperty("trade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易ID/订单ID。
        /// </summary>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 变更金额，单位为元。
        /// </summary>
        [JsonProperty("change_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string ChangeAmount { get; set; }

        /// <summary>
        /// 变更后余额，单位为元。
        /// </summary>
        [JsonProperty("balance_after_change", NullValueHandling = NullValueHandling.Ignore)]
        public string BalanceAfterChange { get; set; }

        /// <summary>
        /// 收支类型。 1：收入2：支出
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// |参数名称：客户账号ID| |参数约束及描述：客户账号ID。说明：交易详细类型取值为如下值时，该字段不为空 SOURCE_OPERATION_BEADJUST：伙伴拨款 SOURCE_OPERATION_BEUNBIND：交易模式变更(切换/解除关联回收) SOURCE_OPERATION_BERETRIEVE：伙伴回收|
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// |参数名称：客户登录名称| |参数约束及描述：客户登录名称。说明：客户账号ID不为空时，该字段不为空|
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountChangeRecord {\n");
            sb.Append("  accountChangeId: ").Append(AccountChangeId).Append("\n");
            sb.Append("  tradeDetailType: ").Append(TradeDetailType).Append("\n");
            sb.Append("  tradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  changeAmount: ").Append(ChangeAmount).Append("\n");
            sb.Append("  balanceAfterChange: ").Append(BalanceAfterChange).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountChangeRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountChangeRecord input)
        {
            if (input == null) return false;
            if (this.AccountChangeId != input.AccountChangeId || (this.AccountChangeId != null && !this.AccountChangeId.Equals(input.AccountChangeId))) return false;
            if (this.TradeDetailType != input.TradeDetailType || (this.TradeDetailType != null && !this.TradeDetailType.Equals(input.TradeDetailType))) return false;
            if (this.TradeTime != input.TradeTime || (this.TradeTime != null && !this.TradeTime.Equals(input.TradeTime))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.ChangeAmount != input.ChangeAmount || (this.ChangeAmount != null && !this.ChangeAmount.Equals(input.ChangeAmount))) return false;
            if (this.BalanceAfterChange != input.BalanceAfterChange || (this.BalanceAfterChange != null && !this.BalanceAfterChange.Equals(input.BalanceAfterChange))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
