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
    public class SubCustomerMonthlyBillDetail 
    {

        /// <summary>
        /// 账期。 格式：YYYY-MM
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 子客户的关联类型： 1：顾问销售2：代售
        /// </summary>
        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationType { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。 ResourceType是CloudServiceType中的一种资源，CloudServiceType由多种ResourceType组合提供。
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
        /// 计费模式。 1：包周期3：按需10：预留实例11：节省计划
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargingMode { get; set; }

        /// <summary>
        /// 交易时间，即某条消费记录对应的扣费时间。 示例：2020-11-17T06:43:38Z
        /// </summary>
        [JsonProperty("trade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTime { get; set; }

        /// <summary>
        /// 订单ID或交易ID，扣费维度的唯一标识。 账单类型为1，2，3，4，8时为订单ID。其它场景下为交易ID。非月末扣费：应收ID月末扣费：账单ID
        /// </summary>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购 2：消费-续订 3：消费-变更 4：退款-退订 5：消费-使用 8：消费-自动续订 9：调账-补偿 14：消费-服务支持计划月末扣费 16：调账-扣费 18：消费-按月付费 20：退款-变更 23：消费-节省计划抵扣 24：退款-包年/包月转按需 25：消费-抹零补扣 103：消费-按年付费
        /// </summary>
        [JsonProperty("bill_detail_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillDetailType { get; set; }

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 产品的规格描述。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品名称。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("resource_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTag { get; set; }

        /// <summary>
        /// 消费时间。 包周期和预留实例订购场景下为订单支付时间；按需场景下为话单生失效时间。 格式：YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty("consume_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// 资源使用量的类型，您可以调用查询使用量类型列表接口获取。
        /// </summary>
        [JsonProperty("usage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageType { get; set; }

        /// <summary>
        /// 资源的使用量。
        /// </summary>
        [JsonProperty("usage_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? UsageAmount { get; set; }

        /// <summary>
        /// 资源使用量的度量单位，您可以调用查询度量单位列表接口获取。
        /// </summary>
        [JsonProperty("usage_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageMeasureId { get; set; }

        /// <summary>
        /// 套餐内使用量。
        /// </summary>
        [JsonProperty("free_resource_usage", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FreeResourceUsage { get; set; }

        /// <summary>
        /// 套餐内使用量的度量单位，您可以调用查询度量单位列表接口获取。
        /// </summary>
        [JsonProperty("free_resource_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? FreeResourceMeasureId { get; set; }

        /// <summary>
        /// 预留实例使用量。
        /// </summary>
        [JsonProperty("ri_usage", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RiUsage { get; set; }

        /// <summary>
        /// 预留实例使用量单位。
        /// </summary>
        [JsonProperty("ri_usage_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RiUsageMeasureId { get; set; }

        /// <summary>
        /// 官网价。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialAmount { get; set; }

        /// <summary>
        /// 对应官网价折扣金额。
        /// </summary>
        [JsonProperty("official_discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialDiscountAmount { get; set; }

        /// <summary>
        /// 应付金额。
        /// </summary>
        [JsonProperty("payment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// 现金支付金额。
        /// </summary>
        [JsonProperty("cash_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CashAmount { get; set; }

        /// <summary>
        /// 信用额度支付金额。
        /// </summary>
        [JsonProperty("credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// 代金券支付金额。
        /// </summary>
        [JsonProperty("coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CouponAmount { get; set; }

        /// <summary>
        /// 现金券支付金额。
        /// </summary>
        [JsonProperty("flexipurchase_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FlexipurchaseCouponAmount { get; set; }

        /// <summary>
        /// 储值卡支付金额。
        /// </summary>
        [JsonProperty("stored_value_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoredValueCardAmount { get; set; }

        /// <summary>
        /// 欠费金额。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 欠费核销金额。
        /// </summary>
        [JsonProperty("writeoff_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? WriteoffAmount { get; set; }

        /// <summary>
        /// 周期类型： 19：年20：月24：天25：小时5：一次性
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 客户经理标识。
        /// </summary>
        [JsonProperty("account_manager_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountManagerId { get; set; }

        /// <summary>
        /// 关联的经销商ID。
        /// </summary>
        [JsonProperty("partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 云服务区名称，例如：“华北-北京一”。具体请参见地区和终端节点对应云服务的“区域名称”列的值。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// 整机的子云服务的自身的云服务类型编码。
        /// </summary>
        [JsonProperty("sub_service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubServiceTypeCode { get; set; }

        /// <summary>
        /// 整机的子云服务的自身的云服务类型名称。
        /// </summary>
        [JsonProperty("sub_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubServiceTypeName { get; set; }

        /// <summary>
        /// 整机的子云服务的自身的资源类型编码。
        /// </summary>
        [JsonProperty("sub_resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceTypeCode { get; set; }

        /// <summary>
        /// 整机的子云服务的自身的资源类型名称。
        /// </summary>
        [JsonProperty("sub_resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceTypeName { get; set; }

        /// <summary>
        /// 整机的子云服务的自身的资源ID，资源标识。（如果为预留实例，则为预留实例标识）
        /// </summary>
        [JsonProperty("sub_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceId { get; set; }

        /// <summary>
        /// 整机的子云服务的自身的资源名称，资源标识。（如果为预留实例，则为预留实例标识）
        /// </summary>
        [JsonProperty("sub_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceName { get; set; }

        /// <summary>
        /// 周期数量，该参数非必填
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PeriodNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubCustomerMonthlyBillDetail {\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  associationType: ").Append(AssociationType).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  tradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  billDetailType: ").Append(BillDetailType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  resourceTag: ").Append(ResourceTag).Append("\n");
            sb.Append("  consumeTime: ").Append(ConsumeTime).Append("\n");
            sb.Append("  usageType: ").Append(UsageType).Append("\n");
            sb.Append("  usageAmount: ").Append(UsageAmount).Append("\n");
            sb.Append("  usageMeasureId: ").Append(UsageMeasureId).Append("\n");
            sb.Append("  freeResourceUsage: ").Append(FreeResourceUsage).Append("\n");
            sb.Append("  freeResourceMeasureId: ").Append(FreeResourceMeasureId).Append("\n");
            sb.Append("  riUsage: ").Append(RiUsage).Append("\n");
            sb.Append("  riUsageMeasureId: ").Append(RiUsageMeasureId).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  officialDiscountAmount: ").Append(OfficialDiscountAmount).Append("\n");
            sb.Append("  paymentAmount: ").Append(PaymentAmount).Append("\n");
            sb.Append("  cashAmount: ").Append(CashAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  storedValueCardAmount: ").Append(StoredValueCardAmount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  writeoffAmount: ").Append(WriteoffAmount).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  accountManagerId: ").Append(AccountManagerId).Append("\n");
            sb.Append("  partnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  subServiceTypeCode: ").Append(SubServiceTypeCode).Append("\n");
            sb.Append("  subServiceTypeName: ").Append(SubServiceTypeName).Append("\n");
            sb.Append("  subResourceTypeCode: ").Append(SubResourceTypeCode).Append("\n");
            sb.Append("  subResourceTypeName: ").Append(SubResourceTypeName).Append("\n");
            sb.Append("  subResourceId: ").Append(SubResourceId).Append("\n");
            sb.Append("  subResourceName: ").Append(SubResourceName).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubCustomerMonthlyBillDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubCustomerMonthlyBillDetail input)
        {
            if (input == null) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.AssociationType != input.AssociationType || (this.AssociationType != null && !this.AssociationType.Equals(input.AssociationType))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.TradeTime != input.TradeTime || (this.TradeTime != null && !this.TradeTime.Equals(input.TradeTime))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.BillDetailType != input.BillDetailType || (this.BillDetailType != null && !this.BillDetailType.Equals(input.BillDetailType))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.ResourceTag != input.ResourceTag || (this.ResourceTag != null && !this.ResourceTag.Equals(input.ResourceTag))) return false;
            if (this.ConsumeTime != input.ConsumeTime || (this.ConsumeTime != null && !this.ConsumeTime.Equals(input.ConsumeTime))) return false;
            if (this.UsageType != input.UsageType || (this.UsageType != null && !this.UsageType.Equals(input.UsageType))) return false;
            if (this.UsageAmount != input.UsageAmount || (this.UsageAmount != null && !this.UsageAmount.Equals(input.UsageAmount))) return false;
            if (this.UsageMeasureId != input.UsageMeasureId || (this.UsageMeasureId != null && !this.UsageMeasureId.Equals(input.UsageMeasureId))) return false;
            if (this.FreeResourceUsage != input.FreeResourceUsage || (this.FreeResourceUsage != null && !this.FreeResourceUsage.Equals(input.FreeResourceUsage))) return false;
            if (this.FreeResourceMeasureId != input.FreeResourceMeasureId || (this.FreeResourceMeasureId != null && !this.FreeResourceMeasureId.Equals(input.FreeResourceMeasureId))) return false;
            if (this.RiUsage != input.RiUsage || (this.RiUsage != null && !this.RiUsage.Equals(input.RiUsage))) return false;
            if (this.RiUsageMeasureId != input.RiUsageMeasureId || (this.RiUsageMeasureId != null && !this.RiUsageMeasureId.Equals(input.RiUsageMeasureId))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.OfficialDiscountAmount != input.OfficialDiscountAmount || (this.OfficialDiscountAmount != null && !this.OfficialDiscountAmount.Equals(input.OfficialDiscountAmount))) return false;
            if (this.PaymentAmount != input.PaymentAmount || (this.PaymentAmount != null && !this.PaymentAmount.Equals(input.PaymentAmount))) return false;
            if (this.CashAmount != input.CashAmount || (this.CashAmount != null && !this.CashAmount.Equals(input.CashAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.StoredValueCardAmount != input.StoredValueCardAmount || (this.StoredValueCardAmount != null && !this.StoredValueCardAmount.Equals(input.StoredValueCardAmount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.WriteoffAmount != input.WriteoffAmount || (this.WriteoffAmount != null && !this.WriteoffAmount.Equals(input.WriteoffAmount))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.AccountManagerId != input.AccountManagerId || (this.AccountManagerId != null && !this.AccountManagerId.Equals(input.AccountManagerId))) return false;
            if (this.PartnerId != input.PartnerId || (this.PartnerId != null && !this.PartnerId.Equals(input.PartnerId))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.SubServiceTypeCode != input.SubServiceTypeCode || (this.SubServiceTypeCode != null && !this.SubServiceTypeCode.Equals(input.SubServiceTypeCode))) return false;
            if (this.SubServiceTypeName != input.SubServiceTypeName || (this.SubServiceTypeName != null && !this.SubServiceTypeName.Equals(input.SubServiceTypeName))) return false;
            if (this.SubResourceTypeCode != input.SubResourceTypeCode || (this.SubResourceTypeCode != null && !this.SubResourceTypeCode.Equals(input.SubResourceTypeCode))) return false;
            if (this.SubResourceTypeName != input.SubResourceTypeName || (this.SubResourceTypeName != null && !this.SubResourceTypeName.Equals(input.SubResourceTypeName))) return false;
            if (this.SubResourceId != input.SubResourceId || (this.SubResourceId != null && !this.SubResourceId.Equals(input.SubResourceId))) return false;
            if (this.SubResourceName != input.SubResourceName || (this.SubResourceName != null && !this.SubResourceName.Equals(input.SubResourceName))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;

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
                if (this.AssociationType != null) hashCode = hashCode * 59 + this.AssociationType.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.TradeTime != null) hashCode = hashCode * 59 + this.TradeTime.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BillDetailType != null) hashCode = hashCode * 59 + this.BillDetailType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ResourceTag != null) hashCode = hashCode * 59 + this.ResourceTag.GetHashCode();
                if (this.ConsumeTime != null) hashCode = hashCode * 59 + this.ConsumeTime.GetHashCode();
                if (this.UsageType != null) hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.UsageAmount != null) hashCode = hashCode * 59 + this.UsageAmount.GetHashCode();
                if (this.UsageMeasureId != null) hashCode = hashCode * 59 + this.UsageMeasureId.GetHashCode();
                if (this.FreeResourceUsage != null) hashCode = hashCode * 59 + this.FreeResourceUsage.GetHashCode();
                if (this.FreeResourceMeasureId != null) hashCode = hashCode * 59 + this.FreeResourceMeasureId.GetHashCode();
                if (this.RiUsage != null) hashCode = hashCode * 59 + this.RiUsage.GetHashCode();
                if (this.RiUsageMeasureId != null) hashCode = hashCode * 59 + this.RiUsageMeasureId.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.OfficialDiscountAmount != null) hashCode = hashCode * 59 + this.OfficialDiscountAmount.GetHashCode();
                if (this.PaymentAmount != null) hashCode = hashCode * 59 + this.PaymentAmount.GetHashCode();
                if (this.CashAmount != null) hashCode = hashCode * 59 + this.CashAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.StoredValueCardAmount != null) hashCode = hashCode * 59 + this.StoredValueCardAmount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.WriteoffAmount != null) hashCode = hashCode * 59 + this.WriteoffAmount.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.AccountManagerId != null) hashCode = hashCode * 59 + this.AccountManagerId.GetHashCode();
                if (this.PartnerId != null) hashCode = hashCode * 59 + this.PartnerId.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.SubServiceTypeCode != null) hashCode = hashCode * 59 + this.SubServiceTypeCode.GetHashCode();
                if (this.SubServiceTypeName != null) hashCode = hashCode * 59 + this.SubServiceTypeName.GetHashCode();
                if (this.SubResourceTypeCode != null) hashCode = hashCode * 59 + this.SubResourceTypeCode.GetHashCode();
                if (this.SubResourceTypeName != null) hashCode = hashCode * 59 + this.SubResourceTypeName.GetHashCode();
                if (this.SubResourceId != null) hashCode = hashCode * 59 + this.SubResourceId.GetHashCode();
                if (this.SubResourceName != null) hashCode = hashCode * 59 + this.SubResourceName.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
