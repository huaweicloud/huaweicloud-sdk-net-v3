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
    public class NvlCostAnalysedBillDetail 
    {

        /// <summary>
        /// 查询分摊成本的月份。 格式为YYYY-MM，按照东八区时间截取。
        /// </summary>
        [JsonProperty("shared_month", NullValueHandling = NullValueHandling.Ignore)]
        public string SharedMonth { get; set; }

        /// <summary>
        /// 账期。 格式：YYYY-MM。按照东八区时间截取。
        /// </summary>
        [JsonProperty("bill_cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string BillCycle { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购 2：消费-续订 3：消费-变更 4：退款-退订 5：消费-使用 8：消费-自动续订 9：调账-补偿 14：消费-服务支持计划月末扣费 16：调账-扣费 18：消费-按月付费 20：退款-变更 23：消费-节省计划抵扣 24：退款-包年/包月转按需 25：消费-抹零补扣 103：消费-按年付费
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 消费的客户账号ID。 如果是普通客户或者企业子查询消费记录，只能查询到自身的消费记录，则这个地方显示的是自身的客户ID。如果是企业主查询消费记录，可以查询到自身以及企业子的消费记录，这个地方是消费的实际客户ID，如果是企业主自身消费，为企业主ID，如果这条消费记录是某个企业子客户的消费，这个地方的ID是企业子账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 云服务区名称，例如：“华北-北京一”。具体请参见地区和终端节点对应云服务的“区域名称”列的值。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

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
        /// 费用对应的资源使用的开始时间，按需有效，包年/包月该字段保留。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 费用对应的资源使用的结束时间，按需有效，包年/包月该字段保留。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

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
        /// 资源标签。
        /// </summary>
        [JsonProperty("resource_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTag { get; set; }

        /// <summary>
        /// 产品的规格描述。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }

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
        /// 订单ID。  说明： 包年/包月资源的使用记录才有该字段，按需资源则为空。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 周期类型。 19：年20：月24：天25：小时5：一次性
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 资源使用量的类型，您可以调用查询使用量类型列表接口获取。
        /// </summary>
        [JsonProperty("usage_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageType { get; set; }

        /// <summary>
        /// 资源的使用量。
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Usage { get; set; }

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
        /// 消费金额（应付金额）。 消费金额&#x3D;期初已分摊金额+当月分摊金额+期末未分摊金额
        /// </summary>
        [JsonProperty("consume_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeAmount { get; set; }

        /// <summary>
        /// 期初已分摊金额。  说明： 包周期和预留实例预付时有效；计费类型为按需，预留实例为按时计费时该值为0。
        /// </summary>
        [JsonProperty("past_months_amortized_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? PastMonthsAmortizedAmount { get; set; }

        /// <summary>
        /// 当月分摊金额。 当月分摊金额&#x3D;现金分摊金额+信用额度分摊金额+代金券分摊金额+现金券分摊金额+储值卡分摊金额+奖励金分摊金额
        /// </summary>
        [JsonProperty("current_month_amortized_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? CurrentMonthAmortizedAmount { get; set; }

        /// <summary>
        /// 期末未分摊金额。月度成本分摊时，当月以后还未分摊的金额。  说明： 包周期和预留实例预付时有效；计费类型为按需，预留实例为按时计费时该值为0。
        /// </summary>
        [JsonProperty("future_months_amortized_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? FutureMonthsAmortizedAmount { get; set; }

        /// <summary>
        /// 月度成本分摊时，当月已分摊金额中包含的现金金额。
        /// </summary>
        [JsonProperty("amortized_cash_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmortizedCashAmount { get; set; }

        /// <summary>
        /// 月度成本分摊时，当月已分摊金额中包含的信用额度分摊金额。
        /// </summary>
        [JsonProperty("amortized_credit_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmortizedCreditAmount { get; set; }

        /// <summary>
        /// 月度成本分摊时，当月已分摊金额中包含的代金券分摊金额。
        /// </summary>
        [JsonProperty("amortized_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmortizedCouponAmount { get; set; }

        /// <summary>
        /// 月度成本分摊时，当月已分摊金额中包含的现金券分摊金额。
        /// </summary>
        [JsonProperty("amortized_flexipurchase_coupon_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmortizedFlexipurchaseCouponAmount { get; set; }

        /// <summary>
        /// 月度成本分摊时，当月已分摊金额中包含的储值卡分摊金额。
        /// </summary>
        [JsonProperty("amortized_stored_value_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmortizedStoredValueCardAmount { get; set; }

        /// <summary>
        /// 月度成本分摊时，当月已分摊金额中包含的奖励金分摊金额（用于现网未清干净的奖励金）。
        /// </summary>
        [JsonProperty("amortized_bonus_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AmortizedBonusAmount { get; set; }

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
        /// 成本标签。
        /// </summary>
        [JsonProperty("effective_tag_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagPair> EffectiveTagPairs { get; set; }

        /// <summary>
        /// 成本单元。
        /// </summary>
        [JsonProperty("cost_unit_pairs", NullValueHandling = NullValueHandling.Ignore)]
        public List<CostUnitPair> CostUnitPairs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NvlCostAnalysedBillDetail {\n");
            sb.Append("  sharedMonth: ").Append(SharedMonth).Append("\n");
            sb.Append("  billCycle: ").Append(BillCycle).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceTag: ").Append(ResourceTag).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  usageType: ").Append(UsageType).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  usageMeasureId: ").Append(UsageMeasureId).Append("\n");
            sb.Append("  freeResourceUsage: ").Append(FreeResourceUsage).Append("\n");
            sb.Append("  freeResourceMeasureId: ").Append(FreeResourceMeasureId).Append("\n");
            sb.Append("  riUsage: ").Append(RiUsage).Append("\n");
            sb.Append("  riUsageMeasureId: ").Append(RiUsageMeasureId).Append("\n");
            sb.Append("  consumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  pastMonthsAmortizedAmount: ").Append(PastMonthsAmortizedAmount).Append("\n");
            sb.Append("  currentMonthAmortizedAmount: ").Append(CurrentMonthAmortizedAmount).Append("\n");
            sb.Append("  futureMonthsAmortizedAmount: ").Append(FutureMonthsAmortizedAmount).Append("\n");
            sb.Append("  amortizedCashAmount: ").Append(AmortizedCashAmount).Append("\n");
            sb.Append("  amortizedCreditAmount: ").Append(AmortizedCreditAmount).Append("\n");
            sb.Append("  amortizedCouponAmount: ").Append(AmortizedCouponAmount).Append("\n");
            sb.Append("  amortizedFlexipurchaseCouponAmount: ").Append(AmortizedFlexipurchaseCouponAmount).Append("\n");
            sb.Append("  amortizedStoredValueCardAmount: ").Append(AmortizedStoredValueCardAmount).Append("\n");
            sb.Append("  amortizedBonusAmount: ").Append(AmortizedBonusAmount).Append("\n");
            sb.Append("  subServiceTypeCode: ").Append(SubServiceTypeCode).Append("\n");
            sb.Append("  subServiceTypeName: ").Append(SubServiceTypeName).Append("\n");
            sb.Append("  subResourceTypeCode: ").Append(SubResourceTypeCode).Append("\n");
            sb.Append("  subResourceTypeName: ").Append(SubResourceTypeName).Append("\n");
            sb.Append("  subResourceId: ").Append(SubResourceId).Append("\n");
            sb.Append("  subResourceName: ").Append(SubResourceName).Append("\n");
            sb.Append("  effectiveTagPairs: ").Append(EffectiveTagPairs).Append("\n");
            sb.Append("  costUnitPairs: ").Append(CostUnitPairs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NvlCostAnalysedBillDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NvlCostAnalysedBillDetail input)
        {
            if (input == null) return false;
            if (this.SharedMonth != input.SharedMonth || (this.SharedMonth != null && !this.SharedMonth.Equals(input.SharedMonth))) return false;
            if (this.BillCycle != input.BillCycle || (this.BillCycle != null && !this.BillCycle.Equals(input.BillCycle))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceTag != input.ResourceTag || (this.ResourceTag != null && !this.ResourceTag.Equals(input.ResourceTag))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.UsageType != input.UsageType || (this.UsageType != null && !this.UsageType.Equals(input.UsageType))) return false;
            if (this.Usage != input.Usage || (this.Usage != null && !this.Usage.Equals(input.Usage))) return false;
            if (this.UsageMeasureId != input.UsageMeasureId || (this.UsageMeasureId != null && !this.UsageMeasureId.Equals(input.UsageMeasureId))) return false;
            if (this.FreeResourceUsage != input.FreeResourceUsage || (this.FreeResourceUsage != null && !this.FreeResourceUsage.Equals(input.FreeResourceUsage))) return false;
            if (this.FreeResourceMeasureId != input.FreeResourceMeasureId || (this.FreeResourceMeasureId != null && !this.FreeResourceMeasureId.Equals(input.FreeResourceMeasureId))) return false;
            if (this.RiUsage != input.RiUsage || (this.RiUsage != null && !this.RiUsage.Equals(input.RiUsage))) return false;
            if (this.RiUsageMeasureId != input.RiUsageMeasureId || (this.RiUsageMeasureId != null && !this.RiUsageMeasureId.Equals(input.RiUsageMeasureId))) return false;
            if (this.ConsumeAmount != input.ConsumeAmount || (this.ConsumeAmount != null && !this.ConsumeAmount.Equals(input.ConsumeAmount))) return false;
            if (this.PastMonthsAmortizedAmount != input.PastMonthsAmortizedAmount || (this.PastMonthsAmortizedAmount != null && !this.PastMonthsAmortizedAmount.Equals(input.PastMonthsAmortizedAmount))) return false;
            if (this.CurrentMonthAmortizedAmount != input.CurrentMonthAmortizedAmount || (this.CurrentMonthAmortizedAmount != null && !this.CurrentMonthAmortizedAmount.Equals(input.CurrentMonthAmortizedAmount))) return false;
            if (this.FutureMonthsAmortizedAmount != input.FutureMonthsAmortizedAmount || (this.FutureMonthsAmortizedAmount != null && !this.FutureMonthsAmortizedAmount.Equals(input.FutureMonthsAmortizedAmount))) return false;
            if (this.AmortizedCashAmount != input.AmortizedCashAmount || (this.AmortizedCashAmount != null && !this.AmortizedCashAmount.Equals(input.AmortizedCashAmount))) return false;
            if (this.AmortizedCreditAmount != input.AmortizedCreditAmount || (this.AmortizedCreditAmount != null && !this.AmortizedCreditAmount.Equals(input.AmortizedCreditAmount))) return false;
            if (this.AmortizedCouponAmount != input.AmortizedCouponAmount || (this.AmortizedCouponAmount != null && !this.AmortizedCouponAmount.Equals(input.AmortizedCouponAmount))) return false;
            if (this.AmortizedFlexipurchaseCouponAmount != input.AmortizedFlexipurchaseCouponAmount || (this.AmortizedFlexipurchaseCouponAmount != null && !this.AmortizedFlexipurchaseCouponAmount.Equals(input.AmortizedFlexipurchaseCouponAmount))) return false;
            if (this.AmortizedStoredValueCardAmount != input.AmortizedStoredValueCardAmount || (this.AmortizedStoredValueCardAmount != null && !this.AmortizedStoredValueCardAmount.Equals(input.AmortizedStoredValueCardAmount))) return false;
            if (this.AmortizedBonusAmount != input.AmortizedBonusAmount || (this.AmortizedBonusAmount != null && !this.AmortizedBonusAmount.Equals(input.AmortizedBonusAmount))) return false;
            if (this.SubServiceTypeCode != input.SubServiceTypeCode || (this.SubServiceTypeCode != null && !this.SubServiceTypeCode.Equals(input.SubServiceTypeCode))) return false;
            if (this.SubServiceTypeName != input.SubServiceTypeName || (this.SubServiceTypeName != null && !this.SubServiceTypeName.Equals(input.SubServiceTypeName))) return false;
            if (this.SubResourceTypeCode != input.SubResourceTypeCode || (this.SubResourceTypeCode != null && !this.SubResourceTypeCode.Equals(input.SubResourceTypeCode))) return false;
            if (this.SubResourceTypeName != input.SubResourceTypeName || (this.SubResourceTypeName != null && !this.SubResourceTypeName.Equals(input.SubResourceTypeName))) return false;
            if (this.SubResourceId != input.SubResourceId || (this.SubResourceId != null && !this.SubResourceId.Equals(input.SubResourceId))) return false;
            if (this.SubResourceName != input.SubResourceName || (this.SubResourceName != null && !this.SubResourceName.Equals(input.SubResourceName))) return false;
            if (this.EffectiveTagPairs != input.EffectiveTagPairs || (this.EffectiveTagPairs != null && input.EffectiveTagPairs != null && !this.EffectiveTagPairs.SequenceEqual(input.EffectiveTagPairs))) return false;
            if (this.CostUnitPairs != input.CostUnitPairs || (this.CostUnitPairs != null && input.CostUnitPairs != null && !this.CostUnitPairs.SequenceEqual(input.CostUnitPairs))) return false;

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
                if (this.SharedMonth != null) hashCode = hashCode * 59 + this.SharedMonth.GetHashCode();
                if (this.BillCycle != null) hashCode = hashCode * 59 + this.BillCycle.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceTag != null) hashCode = hashCode * 59 + this.ResourceTag.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.UsageType != null) hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.UsageMeasureId != null) hashCode = hashCode * 59 + this.UsageMeasureId.GetHashCode();
                if (this.FreeResourceUsage != null) hashCode = hashCode * 59 + this.FreeResourceUsage.GetHashCode();
                if (this.FreeResourceMeasureId != null) hashCode = hashCode * 59 + this.FreeResourceMeasureId.GetHashCode();
                if (this.RiUsage != null) hashCode = hashCode * 59 + this.RiUsage.GetHashCode();
                if (this.RiUsageMeasureId != null) hashCode = hashCode * 59 + this.RiUsageMeasureId.GetHashCode();
                if (this.ConsumeAmount != null) hashCode = hashCode * 59 + this.ConsumeAmount.GetHashCode();
                if (this.PastMonthsAmortizedAmount != null) hashCode = hashCode * 59 + this.PastMonthsAmortizedAmount.GetHashCode();
                if (this.CurrentMonthAmortizedAmount != null) hashCode = hashCode * 59 + this.CurrentMonthAmortizedAmount.GetHashCode();
                if (this.FutureMonthsAmortizedAmount != null) hashCode = hashCode * 59 + this.FutureMonthsAmortizedAmount.GetHashCode();
                if (this.AmortizedCashAmount != null) hashCode = hashCode * 59 + this.AmortizedCashAmount.GetHashCode();
                if (this.AmortizedCreditAmount != null) hashCode = hashCode * 59 + this.AmortizedCreditAmount.GetHashCode();
                if (this.AmortizedCouponAmount != null) hashCode = hashCode * 59 + this.AmortizedCouponAmount.GetHashCode();
                if (this.AmortizedFlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.AmortizedFlexipurchaseCouponAmount.GetHashCode();
                if (this.AmortizedStoredValueCardAmount != null) hashCode = hashCode * 59 + this.AmortizedStoredValueCardAmount.GetHashCode();
                if (this.AmortizedBonusAmount != null) hashCode = hashCode * 59 + this.AmortizedBonusAmount.GetHashCode();
                if (this.SubServiceTypeCode != null) hashCode = hashCode * 59 + this.SubServiceTypeCode.GetHashCode();
                if (this.SubServiceTypeName != null) hashCode = hashCode * 59 + this.SubServiceTypeName.GetHashCode();
                if (this.SubResourceTypeCode != null) hashCode = hashCode * 59 + this.SubResourceTypeCode.GetHashCode();
                if (this.SubResourceTypeName != null) hashCode = hashCode * 59 + this.SubResourceTypeName.GetHashCode();
                if (this.SubResourceId != null) hashCode = hashCode * 59 + this.SubResourceId.GetHashCode();
                if (this.SubResourceName != null) hashCode = hashCode * 59 + this.SubResourceName.GetHashCode();
                if (this.EffectiveTagPairs != null) hashCode = hashCode * 59 + this.EffectiveTagPairs.GetHashCode();
                if (this.CostUnitPairs != null) hashCode = hashCode * 59 + this.CostUnitPairs.GetHashCode();
                return hashCode;
            }
        }
    }
}
