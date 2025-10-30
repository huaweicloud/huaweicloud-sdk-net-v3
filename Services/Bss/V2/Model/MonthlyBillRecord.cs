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
    public class MonthlyBillRecord 
    {

        /// <summary>
        /// 流水账单所在账期，东八区时间，格式为YYYY-MM。
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 消费的客户账号ID。 如果是普通客户或者企业子客户查询消费记录，只能查询到客户自己的消费记录，且此处显示的是客户自己的客户ID。如果是企业主查询消费记录，可以查询到企业主以及企业子客户的消费记录，此处为消费的实际客户ID。如果是企业主自己的消费记录，则为企业主ID；如果是某个企业子客户的消费记录，则此处为企业子账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

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
        /// 云服务区编码，例如：“cn-north-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 企业项目标识（企业项目ID）。 default项目对应ID：0未归集（表示该云服务不支持企业项目管理能力）项目对应ID：null其余项目对应ID获取方法请参见[如何获取企业项目ID](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0126101490.html)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目的名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 计费模式。 1：包年/包月3：按需10：预留实例11：节省计划
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 消费时间。 计费模式为包年/包月和预留实例场景时为订单的支付时间。计费模式为按需场景时为话单的生/失效时间。
        /// </summary>
        [JsonProperty("consume_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// 交易时间，某条消费记录对应的扣费时间。
        /// </summary>
        [JsonProperty("trade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTime { get; set; }

        /// <summary>
        /// 服务商。 1：华为云2：云商店
        /// </summary>
        [JsonProperty("provider_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProviderType { get; set; }

        /// <summary>
        /// 订单ID或交易ID，扣费维度的唯一标识。
        /// </summary>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 唯一标识。 该字段为预留字段。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购 2：消费-续订 3：消费-变更 4：退款-退订 5：消费-使用 8：消费-自动续订 9：调账-补偿 14：消费-服务支持计划月末扣费 16：调账-扣费 18：消费-按月付费 20：退款-变更 23：消费-节省计划抵扣 24：退款-包年/包月转按需 25：消费-抹零补扣 103：消费-按年付费
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 支付状态。 1：已支付2：未结清3：未结算
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 官网价。单位：元。  说明： official_amount &#x3D; official_discount_amount + erase_amount + consume_amount
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialAmount { get; set; }

        /// <summary>
        /// 折扣金额。单位：元。
        /// </summary>
        [JsonProperty("official_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialDiscountAmount { get; set; }

        /// <summary>
        /// 抹零金额。单位：元。
        /// </summary>
        [JsonProperty("erase_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? EraseAmount { get; set; }

        /// <summary>
        /// 应付金额，包括现金券和储值卡和代金券金额。单位：元。  说明： consume_amount的值等于cash_amount，credit_amount，coupon_amount，flexipurchase_coupon_amount，stored_value_card_amount，bonus_amount，debt_amount，writeoff_amount的总和。
        /// </summary>
        [JsonProperty("consume_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeAmount { get; set; }

        /// <summary>
        /// 现金支付金额。单位：元.
        /// </summary>
        [JsonProperty("cash_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CashAmount { get; set; }

        /// <summary>
        /// 信用额度支付金额。单位：元。
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// 代金券支付金额。单位：元。
        /// </summary>
        [JsonProperty("coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CouponAmount { get; set; }

        /// <summary>
        /// 现金券支付金额。单位：元。
        /// </summary>
        [JsonProperty("flexipurchase_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FlexipurchaseCouponAmount { get; set; }

        /// <summary>
        /// 储值卡支付金额。单位：元。
        /// </summary>
        [JsonProperty("stored_value_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoredValueCardAmount { get; set; }

        /// <summary>
        /// 奖励金支付金额（奖励金已经下线，目前用于现网客户未使用完的奖励金）。单位：元。
        /// </summary>
        [JsonProperty("bonus_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BonusAmount { get; set; }

        /// <summary>
        /// 欠费金额。单位：元。  说明： 对于月结客户，欠费金额即页面上的月度结算金额。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 欠费核销金额。单位：元。
        /// </summary>
        [JsonProperty("writeoff_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WriteoffAmount { get; set; }

        /// <summary>
        /// 云服务区名称，例如：“华北-北京一”。具体请参见地区和终端节点对应云服务的“区域名称”列的值。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

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
            sb.Append("class MonthlyBillRecord {\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  consumeTime: ").Append(ConsumeTime).Append("\n");
            sb.Append("  tradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  providerType: ").Append(ProviderType).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  officialDiscountAmount: ").Append(OfficialDiscountAmount).Append("\n");
            sb.Append("  eraseAmount: ").Append(EraseAmount).Append("\n");
            sb.Append("  consumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  cashAmount: ").Append(CashAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  storedValueCardAmount: ").Append(StoredValueCardAmount).Append("\n");
            sb.Append("  bonusAmount: ").Append(BonusAmount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  writeoffAmount: ").Append(WriteoffAmount).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonthlyBillRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MonthlyBillRecord input)
        {
            if (input == null) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.ConsumeTime != input.ConsumeTime || (this.ConsumeTime != null && !this.ConsumeTime.Equals(input.ConsumeTime))) return false;
            if (this.TradeTime != input.TradeTime || (this.TradeTime != null && !this.TradeTime.Equals(input.TradeTime))) return false;
            if (this.ProviderType != input.ProviderType || (this.ProviderType != null && !this.ProviderType.Equals(input.ProviderType))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.OfficialDiscountAmount != input.OfficialDiscountAmount || (this.OfficialDiscountAmount != null && !this.OfficialDiscountAmount.Equals(input.OfficialDiscountAmount))) return false;
            if (this.EraseAmount != input.EraseAmount || (this.EraseAmount != null && !this.EraseAmount.Equals(input.EraseAmount))) return false;
            if (this.ConsumeAmount != input.ConsumeAmount || (this.ConsumeAmount != null && !this.ConsumeAmount.Equals(input.ConsumeAmount))) return false;
            if (this.CashAmount != input.CashAmount || (this.CashAmount != null && !this.CashAmount.Equals(input.CashAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.StoredValueCardAmount != input.StoredValueCardAmount || (this.StoredValueCardAmount != null && !this.StoredValueCardAmount.Equals(input.StoredValueCardAmount))) return false;
            if (this.BonusAmount != input.BonusAmount || (this.BonusAmount != null && !this.BonusAmount.Equals(input.BonusAmount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.WriteoffAmount != input.WriteoffAmount || (this.WriteoffAmount != null && !this.WriteoffAmount.Equals(input.WriteoffAmount))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.ConsumeTime != null) hashCode = hashCode * 59 + this.ConsumeTime.GetHashCode();
                if (this.TradeTime != null) hashCode = hashCode * 59 + this.TradeTime.GetHashCode();
                if (this.ProviderType != null) hashCode = hashCode * 59 + this.ProviderType.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.OfficialDiscountAmount != null) hashCode = hashCode * 59 + this.OfficialDiscountAmount.GetHashCode();
                if (this.EraseAmount != null) hashCode = hashCode * 59 + this.EraseAmount.GetHashCode();
                if (this.ConsumeAmount != null) hashCode = hashCode * 59 + this.ConsumeAmount.GetHashCode();
                if (this.CashAmount != null) hashCode = hashCode * 59 + this.CashAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.StoredValueCardAmount != null) hashCode = hashCode * 59 + this.StoredValueCardAmount.GetHashCode();
                if (this.BonusAmount != null) hashCode = hashCode * 59 + this.BonusAmount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.WriteoffAmount != null) hashCode = hashCode * 59 + this.WriteoffAmount.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
