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
    public class ResFeeRecordV2 
    {

        /// <summary>
        /// 资源消费记录的日期。 格式：YYYY-MM-DD。按照东八区截取。
        /// </summary>
        [JsonProperty("bill_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型。 1：消费-新购2：消费-续订3：消费-变更4：退款-退订5：消费-使用8：消费-自动续订9：调账-补偿14：消费-服务支持计划月末扣费15：消费-税金16：调账-扣费17：消费-保底差额 说明： 保底差额&#x3D;客户签约保底合同后，如果没有达到保底消费，客户需要补交的费用，仅限于直销或者伙伴顾问销售类子客户，且为后付费用户。18：消费-按月付费 20：退款-变更23：消费-节省计划抵扣24：退款-包年/包月转按需 100：退款-退订税金101：调账-补偿税金102：调账-扣费税金|
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 消费的客户账号ID。 如果是普通客户或者企业子查询消费记录，只能查询到自身的消费记录，则这个地方显示的是自身的客户ID如果是企业主查询消费记录，可以查询到自身以及企业子的消费记录，这个地方是消费的实际客户ID，如果是企业主自身消费，为企业主ID，如果这条消费记录是某个企业子客户的消费，这个地方的ID是企业子账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“ap-southeast-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 云服务区名称，例如：“中国-香港”。具体请参见地区和终端节点对应云服务的“区域名称”列的值。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("cloud_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeName { get; set; }

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
        /// 产品的规格描述。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }

        /// <summary>
        /// SKU编码，在账单中唯一标识一个资源的规格。
        /// </summary>
        [JsonProperty("sku_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuCode { get; set; }

        /// <summary>
        /// 产品的实例大小，仅线性产品有效。  说明： 线性产品是指订购时需要指定大小的产品。例如硬盘在订购时需选择10G、20G等不同大小规格。
        /// </summary>
        [JsonProperty("spec_size", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SpecSize { get; set; }

        /// <summary>
        /// 产品实例大小的单位，仅线性产品有该字段。 您可以调用查询度量单位列表接口获取。
        /// </summary>
        [JsonProperty("spec_size_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpecSizeMeasureId { get; set; }

        /// <summary>
        /// 订单ID或交易ID，扣费维度的唯一标识。
        /// </summary>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// |参数名称：唯一标识。|
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 交易时间。
        /// </summary>
        [JsonProperty("trade_time", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeTime { get; set; }

        /// <summary>
        /// 企业项目标识（企业项目ID）。 default项目对应ID：0未归集（表示该云服务不支持企业项目管理能力）项目对应ID：null
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目的名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 计费模式。 1：包年/包月3：按需10：预留实例
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 订单ID。  说明： 包年/包月资源的使用记录才有该字段，按需资源则为空。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 周期类型： 19：年20：月24：天25：小时5：一次性
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

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
        /// 产品的单价。 按需产品的单价，只有简单定价，不分档的场景会返回。 包周期产品的单价，只有包周期的如下场景会返回：包周期订购/续订/降配/升配/扩容简单定价，不分档 预留实例的单价，只有如下场景下会返回：订购/续订/降配/升配/扩容/按时计费简单定价，不分档
        /// </summary>
        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// 产品的单价单位。 线性产品的单价单位为“元/{线性单位}/月”或“元/{线性单位}/小时”等。非线性产品的单价单位为“元/月”或“元/小时”等。  说明： “线性单位”为线性产品（即订购时需要指定大小的产品）的大小的单位，比如硬盘的线性单位为GB，带宽的线性单位为Mbps。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 官网价，华为云商品在官网上未叠加应用商务折扣、促销折扣等优惠的销售价格。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialAmount { get; set; }

        /// <summary>
        /// 优惠金额，用户使用云服务享受折扣优惠如商务折扣、伙伴授予折扣以及促销优惠等减免的金额。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 应付金额，用户使用云服务享受折扣优惠后需要支付的费用金额，包括代金券金额，精确到小数点后8位。  说明： amount的值等于cash_amount，credit_amount，coupon_amount，flexipurchase_coupon_amount，stored_card_amount，bonus_amount，debt_amount，adjustment_amount的总和。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

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
        [JsonProperty("stored_card_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? StoredCardAmount { get; set; }

        /// <summary>
        /// 奖励金支付金额（用于现网客户未使用完的奖励金）。
        /// </summary>
        [JsonProperty("bonus_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BonusAmount { get; set; }

        /// <summary>
        /// 欠费金额。
        /// </summary>
        [JsonProperty("debt_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DebtAmount { get; set; }

        /// <summary>
        /// 欠费核销金额。
        /// </summary>
        [JsonProperty("adjustment_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AdjustmentAmount { get; set; }

        /// <summary>
        /// 金额单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 实付金额计算公式。当前只包含如下场景： 按需简单定价 按需线性定价 包年包月新购和续费的简单定价 包年包月新购和续费的线性定价  说明： 实付金额计算公式得到的金额值等于amount - coupon_amount的差值。
        /// </summary>
        [JsonProperty("formula", NullValueHandling = NullValueHandling.Ignore)]
        public string Formula { get; set; }

        /// <summary>
        /// 该字段为预留字段。
        /// </summary>
        [JsonProperty("sub_service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubServiceTypeCode { get; set; }

        /// <summary>
        /// 该字段为预留字段。
        /// </summary>
        [JsonProperty("sub_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubServiceTypeName { get; set; }

        /// <summary>
        /// 该字段为预留字段。
        /// </summary>
        [JsonProperty("sub_resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceTypeCode { get; set; }

        /// <summary>
        /// 该字段为预留字段。
        /// </summary>
        [JsonProperty("sub_resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceTypeName { get; set; }

        /// <summary>
        /// 该字段为预留字段。
        /// </summary>
        [JsonProperty("sub_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceId { get; set; }

        /// <summary>
        /// 该字段为预留字段。
        /// </summary>
        [JsonProperty("sub_resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceName { get; set; }

        /// <summary>
        /// |参数名称：消费时间| |参数约束及描述：消费时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ。包周期、预留实例预付为交易时间，按需、预留实例按时计费为话单生失效时间。 说明：当statistic_type&#x3D;3时有效。|
        /// </summary>
        [JsonProperty("consume_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// |参数名称：客户订单关联的订单ID| |参数约束及描述：客户订单关联的订单ID，包年/包月资源的使用记录该字段才有值，按需资源则为空。当order_id为组合交易订单时，该字段才有值，当查询为普通订单时，此字段返回为空。|
        /// </summary>
        [JsonProperty("relative_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RelativeOrderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResFeeRecordV2 {\n");
            sb.Append("  billDate: ").Append(BillDate).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceTag: ").Append(ResourceTag).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("  skuCode: ").Append(SkuCode).Append("\n");
            sb.Append("  specSize: ").Append(SpecSize).Append("\n");
            sb.Append("  specSizeMeasureId: ").Append(SpecSizeMeasureId).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tradeTime: ").Append(TradeTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  usageType: ").Append(UsageType).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  usageMeasureId: ").Append(UsageMeasureId).Append("\n");
            sb.Append("  freeResourceUsage: ").Append(FreeResourceUsage).Append("\n");
            sb.Append("  freeResourceMeasureId: ").Append(FreeResourceMeasureId).Append("\n");
            sb.Append("  riUsage: ").Append(RiUsage).Append("\n");
            sb.Append("  riUsageMeasureId: ").Append(RiUsageMeasureId).Append("\n");
            sb.Append("  unitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  cashAmount: ").Append(CashAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  storedCardAmount: ").Append(StoredCardAmount).Append("\n");
            sb.Append("  bonusAmount: ").Append(BonusAmount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  adjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  formula: ").Append(Formula).Append("\n");
            sb.Append("  subServiceTypeCode: ").Append(SubServiceTypeCode).Append("\n");
            sb.Append("  subServiceTypeName: ").Append(SubServiceTypeName).Append("\n");
            sb.Append("  subResourceTypeCode: ").Append(SubResourceTypeCode).Append("\n");
            sb.Append("  subResourceTypeName: ").Append(SubResourceTypeName).Append("\n");
            sb.Append("  subResourceId: ").Append(SubResourceId).Append("\n");
            sb.Append("  subResourceName: ").Append(SubResourceName).Append("\n");
            sb.Append("  consumeTime: ").Append(ConsumeTime).Append("\n");
            sb.Append("  relativeOrderId: ").Append(RelativeOrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResFeeRecordV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResFeeRecordV2 input)
        {
            if (input == null) return false;
            if (this.BillDate != input.BillDate || (this.BillDate != null && !this.BillDate.Equals(input.BillDate))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceTag != input.ResourceTag || (this.ResourceTag != null && !this.ResourceTag.Equals(input.ResourceTag))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;
            if (this.SkuCode != input.SkuCode || (this.SkuCode != null && !this.SkuCode.Equals(input.SkuCode))) return false;
            if (this.SpecSize != input.SpecSize || (this.SpecSize != null && !this.SpecSize.Equals(input.SpecSize))) return false;
            if (this.SpecSizeMeasureId != input.SpecSizeMeasureId || (this.SpecSizeMeasureId != null && !this.SpecSizeMeasureId.Equals(input.SpecSizeMeasureId))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TradeTime != input.TradeTime || (this.TradeTime != null && !this.TradeTime.Equals(input.TradeTime))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.UsageType != input.UsageType || (this.UsageType != null && !this.UsageType.Equals(input.UsageType))) return false;
            if (this.Usage != input.Usage || (this.Usage != null && !this.Usage.Equals(input.Usage))) return false;
            if (this.UsageMeasureId != input.UsageMeasureId || (this.UsageMeasureId != null && !this.UsageMeasureId.Equals(input.UsageMeasureId))) return false;
            if (this.FreeResourceUsage != input.FreeResourceUsage || (this.FreeResourceUsage != null && !this.FreeResourceUsage.Equals(input.FreeResourceUsage))) return false;
            if (this.FreeResourceMeasureId != input.FreeResourceMeasureId || (this.FreeResourceMeasureId != null && !this.FreeResourceMeasureId.Equals(input.FreeResourceMeasureId))) return false;
            if (this.RiUsage != input.RiUsage || (this.RiUsage != null && !this.RiUsage.Equals(input.RiUsage))) return false;
            if (this.RiUsageMeasureId != input.RiUsageMeasureId || (this.RiUsageMeasureId != null && !this.RiUsageMeasureId.Equals(input.RiUsageMeasureId))) return false;
            if (this.UnitPrice != input.UnitPrice || (this.UnitPrice != null && !this.UnitPrice.Equals(input.UnitPrice))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.CashAmount != input.CashAmount || (this.CashAmount != null && !this.CashAmount.Equals(input.CashAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.StoredCardAmount != input.StoredCardAmount || (this.StoredCardAmount != null && !this.StoredCardAmount.Equals(input.StoredCardAmount))) return false;
            if (this.BonusAmount != input.BonusAmount || (this.BonusAmount != null && !this.BonusAmount.Equals(input.BonusAmount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.AdjustmentAmount != input.AdjustmentAmount || (this.AdjustmentAmount != null && !this.AdjustmentAmount.Equals(input.AdjustmentAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.Formula != input.Formula || (this.Formula != null && !this.Formula.Equals(input.Formula))) return false;
            if (this.SubServiceTypeCode != input.SubServiceTypeCode || (this.SubServiceTypeCode != null && !this.SubServiceTypeCode.Equals(input.SubServiceTypeCode))) return false;
            if (this.SubServiceTypeName != input.SubServiceTypeName || (this.SubServiceTypeName != null && !this.SubServiceTypeName.Equals(input.SubServiceTypeName))) return false;
            if (this.SubResourceTypeCode != input.SubResourceTypeCode || (this.SubResourceTypeCode != null && !this.SubResourceTypeCode.Equals(input.SubResourceTypeCode))) return false;
            if (this.SubResourceTypeName != input.SubResourceTypeName || (this.SubResourceTypeName != null && !this.SubResourceTypeName.Equals(input.SubResourceTypeName))) return false;
            if (this.SubResourceId != input.SubResourceId || (this.SubResourceId != null && !this.SubResourceId.Equals(input.SubResourceId))) return false;
            if (this.SubResourceName != input.SubResourceName || (this.SubResourceName != null && !this.SubResourceName.Equals(input.SubResourceName))) return false;
            if (this.ConsumeTime != input.ConsumeTime || (this.ConsumeTime != null && !this.ConsumeTime.Equals(input.ConsumeTime))) return false;
            if (this.RelativeOrderId != input.RelativeOrderId || (this.RelativeOrderId != null && !this.RelativeOrderId.Equals(input.RelativeOrderId))) return false;

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
                if (this.BillDate != null) hashCode = hashCode * 59 + this.BillDate.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceTag != null) hashCode = hashCode * 59 + this.ResourceTag.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                if (this.SkuCode != null) hashCode = hashCode * 59 + this.SkuCode.GetHashCode();
                if (this.SpecSize != null) hashCode = hashCode * 59 + this.SpecSize.GetHashCode();
                if (this.SpecSizeMeasureId != null) hashCode = hashCode * 59 + this.SpecSizeMeasureId.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TradeTime != null) hashCode = hashCode * 59 + this.TradeTime.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.UsageType != null) hashCode = hashCode * 59 + this.UsageType.GetHashCode();
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.UsageMeasureId != null) hashCode = hashCode * 59 + this.UsageMeasureId.GetHashCode();
                if (this.FreeResourceUsage != null) hashCode = hashCode * 59 + this.FreeResourceUsage.GetHashCode();
                if (this.FreeResourceMeasureId != null) hashCode = hashCode * 59 + this.FreeResourceMeasureId.GetHashCode();
                if (this.RiUsage != null) hashCode = hashCode * 59 + this.RiUsage.GetHashCode();
                if (this.RiUsageMeasureId != null) hashCode = hashCode * 59 + this.RiUsageMeasureId.GetHashCode();
                if (this.UnitPrice != null) hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.CashAmount != null) hashCode = hashCode * 59 + this.CashAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.StoredCardAmount != null) hashCode = hashCode * 59 + this.StoredCardAmount.GetHashCode();
                if (this.BonusAmount != null) hashCode = hashCode * 59 + this.BonusAmount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.AdjustmentAmount != null) hashCode = hashCode * 59 + this.AdjustmentAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.Formula != null) hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.SubServiceTypeCode != null) hashCode = hashCode * 59 + this.SubServiceTypeCode.GetHashCode();
                if (this.SubServiceTypeName != null) hashCode = hashCode * 59 + this.SubServiceTypeName.GetHashCode();
                if (this.SubResourceTypeCode != null) hashCode = hashCode * 59 + this.SubResourceTypeCode.GetHashCode();
                if (this.SubResourceTypeName != null) hashCode = hashCode * 59 + this.SubResourceTypeName.GetHashCode();
                if (this.SubResourceId != null) hashCode = hashCode * 59 + this.SubResourceId.GetHashCode();
                if (this.SubResourceName != null) hashCode = hashCode * 59 + this.SubResourceName.GetHashCode();
                if (this.ConsumeTime != null) hashCode = hashCode * 59 + this.ConsumeTime.GetHashCode();
                if (this.RelativeOrderId != null) hashCode = hashCode * 59 + this.RelativeOrderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
