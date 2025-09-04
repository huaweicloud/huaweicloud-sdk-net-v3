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
    public class BillSumInfoV2 
    {

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("cloud_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeName { get; set; }

        /// <summary>
        /// 账单类型。 0：正常1：退订2：华为核销
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BillType { get; set; }

        /// <summary>
        /// 计费模式。 1：包年/包月3: 按需
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 金额。 对于billType&#x3D;1或者2的账单，该金额为负值。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 欠费金额，指从客户账户扣费的时候，客户账户金额不足，欠费的金额，华为核销或者退订的时候没有该字段。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 核销欠款，华为核销或者退订的时候没有该字段。
        /// </summary>
        [JsonProperty("adjustment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdjustmentAmount { get; set; }

        /// <summary>
        /// 折扣金额，华为核销或者退订的时候没有该字段。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 金额单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 按不同账户消费类型和付费方式区分的支付总金额。 具体请参见表3。
        /// </summary>
        [JsonProperty("account_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<BalanceTypeDeductSumV2> AccountDetails { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 资源类型名称。例如ECS的资源类型名称为“云主机”。
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillSumInfoV2 {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  adjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  accountDetails: ").Append(AccountDetails).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillSumInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillSumInfoV2 input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.AdjustmentAmount != input.AdjustmentAmount || (this.AdjustmentAmount != null && !this.AdjustmentAmount.Equals(input.AdjustmentAmount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.AccountDetails != input.AccountDetails || (this.AccountDetails != null && input.AccountDetails != null && !this.AccountDetails.SequenceEqual(input.AccountDetails))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.AdjustmentAmount != null) hashCode = hashCode * 59 + this.AdjustmentAmount.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.AccountDetails != null) hashCode = hashCode * 59 + this.AccountDetails.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                return hashCode;
            }
        }
    }
}
