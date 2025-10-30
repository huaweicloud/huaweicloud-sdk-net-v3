using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BillSumRecordInfoV2 
    {

        /// <summary>
        /// 消费汇总数据所在账期，东八区时间，格式：YYYY-MM。
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 资源类型名称。例如ECS的资源类型名称为“云主机”。
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// 计费模式。 1：包年/包月3：按需10：预留实例11：节省计划
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 官网价。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialAmount { get; set; }

        /// <summary>
        /// 折扣金额。
        /// </summary>
        [JsonProperty("official_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialDiscountAmount { get; set; }

        /// <summary>
        /// 抹零金额。
        /// </summary>
        [JsonProperty("truncated_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TruncatedAmount { get; set; }

        /// <summary>
        /// 应付金额。 应付金额&#x3D;官网价-折扣金额-抹零金额
        /// </summary>
        [JsonProperty("consume_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeAmount { get; set; }

        /// <summary>
        /// 代金券金额。
        /// </summary>
        [JsonProperty("coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CouponAmount { get; set; }

        /// <summary>
        /// 现金券金额，预留。
        /// </summary>
        [JsonProperty("flexipurchase_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FlexipurchaseCouponAmount { get; set; }

        /// <summary>
        /// 储值卡金额，预留。
        /// </summary>
        [JsonProperty("stored_value_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoredValueCardAmount { get; set; }

        /// <summary>
        /// 欠费金额。即伙伴从客户账户扣费时，客户账户金额不足，欠费的金额。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 欠费核销金额。
        /// </summary>
        [JsonProperty("writeoff_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WriteoffAmount { get; set; }

        /// <summary>
        /// 现金账户金额。
        /// </summary>
        [JsonProperty("cash_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CashAmount { get; set; }

        /// <summary>
        /// 信用账户金额。
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// 金额单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 账单类型。 1：消费2：退款3：调账
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 消费的客户账号ID。 如果是普通客户或者企业子客户查询消费记录，只能查询到客户自己的消费记录，且此处显示的是客户自己的客户ID。如果是企业主查询消费记录，可以查询到企业主以及企业子客户的消费记录，此处为消费的实际客户ID。如果是企业主自己的消费记录，则为企业主ID；如果是某个企业子客户的消费记录，则此处为企业子账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// |参数名称：消费的客户登录名称。| |参数约束及描述：范围限制：0-128，如果是普通客户或者企业子客户查询消费记录，只能查询到客户自己的消费记录，且此处显示的是客户自己的客户登录名称。 如果是企业主查询消费记录，可以查询到企业主以及企业子客户的消费记录，此处为消费的实际客户登录名称。如果是企业主自己的消费记录，则为企业主的客户登录名称；如果是某个企业子客户的消费记录，则此处为企业子的客户登录名称。|
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillSumRecordInfoV2 {\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  officialDiscountAmount: ").Append(OfficialDiscountAmount).Append("\n");
            sb.Append("  truncatedAmount: ").Append(TruncatedAmount).Append("\n");
            sb.Append("  consumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  storedValueCardAmount: ").Append(StoredValueCardAmount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  writeoffAmount: ").Append(WriteoffAmount).Append("\n");
            sb.Append("  cashAmount: ").Append(CashAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
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
            return this.Equals(input as BillSumRecordInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillSumRecordInfoV2 input)
        {
            if (input == null) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.OfficialDiscountAmount != input.OfficialDiscountAmount || (this.OfficialDiscountAmount != null && !this.OfficialDiscountAmount.Equals(input.OfficialDiscountAmount))) return false;
            if (this.TruncatedAmount != input.TruncatedAmount || (this.TruncatedAmount != null && !this.TruncatedAmount.Equals(input.TruncatedAmount))) return false;
            if (this.ConsumeAmount != input.ConsumeAmount || (this.ConsumeAmount != null && !this.ConsumeAmount.Equals(input.ConsumeAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.StoredValueCardAmount != input.StoredValueCardAmount || (this.StoredValueCardAmount != null && !this.StoredValueCardAmount.Equals(input.StoredValueCardAmount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.WriteoffAmount != input.WriteoffAmount || (this.WriteoffAmount != null && !this.WriteoffAmount.Equals(input.WriteoffAmount))) return false;
            if (this.CashAmount != input.CashAmount || (this.CashAmount != null && !this.CashAmount.Equals(input.CashAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
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
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.OfficialDiscountAmount != null) hashCode = hashCode * 59 + this.OfficialDiscountAmount.GetHashCode();
                if (this.TruncatedAmount != null) hashCode = hashCode * 59 + this.TruncatedAmount.GetHashCode();
                if (this.ConsumeAmount != null) hashCode = hashCode * 59 + this.ConsumeAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.StoredValueCardAmount != null) hashCode = hashCode * 59 + this.StoredValueCardAmount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.WriteoffAmount != null) hashCode = hashCode * 59 + this.WriteoffAmount.GetHashCode();
                if (this.CashAmount != null) hashCode = hashCode * 59 + this.CashAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
