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
    public class MonthlyBillRes 
    {

        /// <summary>
        /// 资源详单数据所在账期，东八区时间，格式为YYYY-MM。 例如2020-01。
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public string Cycle { get; set; }

        /// <summary>
        /// 消费日期，东八区时间，格式为YYYY-MM-DD。  说明： 当statistic_type&#x3D;2时该字段才有值，否则返回null。
        /// </summary>
        [JsonProperty("bill_date", NullValueHandling = NullValueHandling.Ignore)]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型。1：消费-新购 2：消费-续订 3：消费-变更 4：退款-退订 5：消费-使用 8：消费-自动续订 9：调账-补偿 14：消费-服务支持计划月末扣费 16：调账-扣费 18：消费-按月付费 20：退款-变更 23：消费-节省计划抵扣 24：退款-包年/包月转按需 25：消费-抹零补扣 103：消费-按年付费
        /// </summary>
        [JsonProperty("bill_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillType { get; set; }

        /// <summary>
        /// 消费的客户账号ID。 如果是普通客户或者企业子客户查询消费记录，只能查询到客户自己的消费记录，且此处显示的是客户自己的客户ID。如果是企业主查询消费记录，可以查询到企业主以及企业子客户的消费记录，此处为消费的实际客户ID。如果是企业主自己的消费记录，则为企业主ID；如果是某个企业子客户的消费记录，则此处为企业子账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 云服务区名称，例如：“华北-北京一”。具体请参见地区和终端节点对应云服务的“区域名称”列的值。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。
        /// </summary>
        [JsonProperty("resource_Type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

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
        /// 资源实例ID。
        /// </summary>
        [JsonProperty("res_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResInstanceId { get; set; }

        /// <summary>
        /// 资源名称。客户在创建资源的时候，可以输入资源名称，有些资源也可以在管理资源时，修改资源名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源标签。客户在管理资源的时候，可以设置资源标签。
        /// </summary>
        [JsonProperty("resource_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTag { get; set; }

        /// <summary>
        /// SKU编码，在账单中唯一标识一个资源的规格。
        /// </summary>
        [JsonProperty("sku_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuCode { get; set; }

        /// <summary>
        /// 企业项目标识（企业项目ID）。 default项目对应ID：0未归集（表示该云服务不支持企业项目管理能力）项目对应ID：null其余项目对应ID获取方法请参见[如何获取企业项目ID](https://support.huaweicloud.com/usermanual-em/zh-cn_topic_0126101490.html)。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 计费模式。 1 : 包年/包月3：按需10：预留实例11：节省计划
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeMode { get; set; }

        /// <summary>
        /// 客户购买云服务类型的消费金额，包含代金券、现金券，精确到小数点后2位。  说明： consume_amount的值等于cash_amount，credit_amount，coupon_amount，flexipurchase_coupon_amount，stored_card_amount，bonus_amount，debt_amount，adjustment_amount的总和。
        /// </summary>
        [JsonProperty("consume_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? ConsumeAmount { get; set; }

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
        /// 官网价。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? OfficialAmount { get; set; }

        /// <summary>
        /// 对应官网价折扣金额。
        /// </summary>
        [JsonProperty("discount_amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// 金额单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 周期类型： 19：年20：月24：天25：小时5：一次性
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 根资源标识。
        /// </summary>
        [JsonProperty("root_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootResourceId { get; set; }

        /// <summary>
        /// 父资源标识。
        /// </summary>
        [JsonProperty("parent_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentResourceId { get; set; }

        /// <summary>
        /// 订单ID 或 交易ID。 账单类型为1，2，3，4，8时为订单ID；其它场景下为： 交易ID(非月末扣费：应收ID；月末扣费：账单ID)。
        /// </summary>
        [JsonProperty("trade_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TradeId { get; set; }

        /// <summary>
        /// 唯一标识。 该字段为预留字段。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 产品的规格描述。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }

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
        /// 原订单ID 。
        /// </summary>
        [JsonProperty("pre_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 可用区信息列表。具体请参见表 AzCodeInfo。
        /// </summary>
        [JsonProperty("az_code_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AzCodeInfo> AzCodeInfos { get; set; }

        /// <summary>
        /// |参数名称：支付账号ID。| |参数的约束及描述：如果是普通客户或者财务独立企业子客户或者企业主客户查询消费记录，此处为客户自己的客户ID。如果是财务托管企业子查询消费记录，此处为企业主客户ID或自己的客户ID。|
        /// </summary>
        [JsonProperty("payer_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerAccountId { get; set; }

        /// <summary>
        /// |参数名称：费用对应的资源使用的开始时间| |参数的约束及描述：费用对应的资源使用的开始时间，statistic_type&#x3D;3有效，statistic_type&#x3D;1或者2该字段保留。|
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// |参数名称：费用对应的资源使用的结束时间| |参数的约束及描述：费用对应的资源使用的结束时间，statistic_type&#x3D;3有效，statistic_type&#x3D;1或者2该字段保留。|
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// |参数名称：消费时间| |参数约束及描述：消费时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ。包周期、预留实例预付为交易时间，按需、预留实例按时计费为话单生失效时间。 说明：当statistic_type&#x3D;3时有效。|
        /// </summary>
        [JsonProperty("consume_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumeTime { get; set; }

        /// <summary>
        /// |参数名称：华为云运营实体ID。| |参数约束及描述：华为云运营实体ID。|
        /// </summary>
        [JsonProperty("be_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extend_params", NullValueHandling = NullValueHandling.Ignore)]
        public ResRelation ExtendParams { get; set; }

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
            sb.Append("class MonthlyBillRes {\n");
            sb.Append("  cycle: ").Append(Cycle).Append("\n");
            sb.Append("  billDate: ").Append(BillDate).Append("\n");
            sb.Append("  billType: ").Append(BillType).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  resInstanceId: ").Append(ResInstanceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceTag: ").Append(ResourceTag).Append("\n");
            sb.Append("  skuCode: ").Append(SkuCode).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  consumeAmount: ").Append(ConsumeAmount).Append("\n");
            sb.Append("  cashAmount: ").Append(CashAmount).Append("\n");
            sb.Append("  creditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  couponAmount: ").Append(CouponAmount).Append("\n");
            sb.Append("  flexipurchaseCouponAmount: ").Append(FlexipurchaseCouponAmount).Append("\n");
            sb.Append("  storedCardAmount: ").Append(StoredCardAmount).Append("\n");
            sb.Append("  bonusAmount: ").Append(BonusAmount).Append("\n");
            sb.Append("  debtAmount: ").Append(DebtAmount).Append("\n");
            sb.Append("  adjustmentAmount: ").Append(AdjustmentAmount).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  discountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  rootResourceId: ").Append(RootResourceId).Append("\n");
            sb.Append("  parentResourceId: ").Append(ParentResourceId).Append("\n");
            sb.Append("  tradeId: ").Append(TradeId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("  subServiceTypeCode: ").Append(SubServiceTypeCode).Append("\n");
            sb.Append("  subServiceTypeName: ").Append(SubServiceTypeName).Append("\n");
            sb.Append("  subResourceTypeCode: ").Append(SubResourceTypeCode).Append("\n");
            sb.Append("  subResourceTypeName: ").Append(SubResourceTypeName).Append("\n");
            sb.Append("  subResourceId: ").Append(SubResourceId).Append("\n");
            sb.Append("  subResourceName: ").Append(SubResourceName).Append("\n");
            sb.Append("  preOrderId: ").Append(PreOrderId).Append("\n");
            sb.Append("  azCodeInfos: ").Append(AzCodeInfos).Append("\n");
            sb.Append("  payerAccountId: ").Append(PayerAccountId).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  consumeTime: ").Append(ConsumeTime).Append("\n");
            sb.Append("  beId: ").Append(BeId).Append("\n");
            sb.Append("  extendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MonthlyBillRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MonthlyBillRes input)
        {
            if (input == null) return false;
            if (this.Cycle != input.Cycle || (this.Cycle != null && !this.Cycle.Equals(input.Cycle))) return false;
            if (this.BillDate != input.BillDate || (this.BillDate != null && !this.BillDate.Equals(input.BillDate))) return false;
            if (this.BillType != input.BillType || (this.BillType != null && !this.BillType.Equals(input.BillType))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ResInstanceId != input.ResInstanceId || (this.ResInstanceId != null && !this.ResInstanceId.Equals(input.ResInstanceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceTag != input.ResourceTag || (this.ResourceTag != null && !this.ResourceTag.Equals(input.ResourceTag))) return false;
            if (this.SkuCode != input.SkuCode || (this.SkuCode != null && !this.SkuCode.Equals(input.SkuCode))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ConsumeAmount != input.ConsumeAmount || (this.ConsumeAmount != null && !this.ConsumeAmount.Equals(input.ConsumeAmount))) return false;
            if (this.CashAmount != input.CashAmount || (this.CashAmount != null && !this.CashAmount.Equals(input.CashAmount))) return false;
            if (this.CreditAmount != input.CreditAmount || (this.CreditAmount != null && !this.CreditAmount.Equals(input.CreditAmount))) return false;
            if (this.CouponAmount != input.CouponAmount || (this.CouponAmount != null && !this.CouponAmount.Equals(input.CouponAmount))) return false;
            if (this.FlexipurchaseCouponAmount != input.FlexipurchaseCouponAmount || (this.FlexipurchaseCouponAmount != null && !this.FlexipurchaseCouponAmount.Equals(input.FlexipurchaseCouponAmount))) return false;
            if (this.StoredCardAmount != input.StoredCardAmount || (this.StoredCardAmount != null && !this.StoredCardAmount.Equals(input.StoredCardAmount))) return false;
            if (this.BonusAmount != input.BonusAmount || (this.BonusAmount != null && !this.BonusAmount.Equals(input.BonusAmount))) return false;
            if (this.DebtAmount != input.DebtAmount || (this.DebtAmount != null && !this.DebtAmount.Equals(input.DebtAmount))) return false;
            if (this.AdjustmentAmount != input.AdjustmentAmount || (this.AdjustmentAmount != null && !this.AdjustmentAmount.Equals(input.AdjustmentAmount))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.DiscountAmount != input.DiscountAmount || (this.DiscountAmount != null && !this.DiscountAmount.Equals(input.DiscountAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.RootResourceId != input.RootResourceId || (this.RootResourceId != null && !this.RootResourceId.Equals(input.RootResourceId))) return false;
            if (this.ParentResourceId != input.ParentResourceId || (this.ParentResourceId != null && !this.ParentResourceId.Equals(input.ParentResourceId))) return false;
            if (this.TradeId != input.TradeId || (this.TradeId != null && !this.TradeId.Equals(input.TradeId))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;
            if (this.SubServiceTypeCode != input.SubServiceTypeCode || (this.SubServiceTypeCode != null && !this.SubServiceTypeCode.Equals(input.SubServiceTypeCode))) return false;
            if (this.SubServiceTypeName != input.SubServiceTypeName || (this.SubServiceTypeName != null && !this.SubServiceTypeName.Equals(input.SubServiceTypeName))) return false;
            if (this.SubResourceTypeCode != input.SubResourceTypeCode || (this.SubResourceTypeCode != null && !this.SubResourceTypeCode.Equals(input.SubResourceTypeCode))) return false;
            if (this.SubResourceTypeName != input.SubResourceTypeName || (this.SubResourceTypeName != null && !this.SubResourceTypeName.Equals(input.SubResourceTypeName))) return false;
            if (this.SubResourceId != input.SubResourceId || (this.SubResourceId != null && !this.SubResourceId.Equals(input.SubResourceId))) return false;
            if (this.SubResourceName != input.SubResourceName || (this.SubResourceName != null && !this.SubResourceName.Equals(input.SubResourceName))) return false;
            if (this.PreOrderId != input.PreOrderId || (this.PreOrderId != null && !this.PreOrderId.Equals(input.PreOrderId))) return false;
            if (this.AzCodeInfos != input.AzCodeInfos || (this.AzCodeInfos != null && input.AzCodeInfos != null && !this.AzCodeInfos.SequenceEqual(input.AzCodeInfos))) return false;
            if (this.PayerAccountId != input.PayerAccountId || (this.PayerAccountId != null && !this.PayerAccountId.Equals(input.PayerAccountId))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ConsumeTime != input.ConsumeTime || (this.ConsumeTime != null && !this.ConsumeTime.Equals(input.ConsumeTime))) return false;
            if (this.BeId != input.BeId || (this.BeId != null && !this.BeId.Equals(input.BeId))) return false;
            if (this.ExtendParams != input.ExtendParams || (this.ExtendParams != null && !this.ExtendParams.Equals(input.ExtendParams))) return false;
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
                if (this.Cycle != null) hashCode = hashCode * 59 + this.Cycle.GetHashCode();
                if (this.BillDate != null) hashCode = hashCode * 59 + this.BillDate.GetHashCode();
                if (this.BillType != null) hashCode = hashCode * 59 + this.BillType.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ResInstanceId != null) hashCode = hashCode * 59 + this.ResInstanceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceTag != null) hashCode = hashCode * 59 + this.ResourceTag.GetHashCode();
                if (this.SkuCode != null) hashCode = hashCode * 59 + this.SkuCode.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ConsumeAmount != null) hashCode = hashCode * 59 + this.ConsumeAmount.GetHashCode();
                if (this.CashAmount != null) hashCode = hashCode * 59 + this.CashAmount.GetHashCode();
                if (this.CreditAmount != null) hashCode = hashCode * 59 + this.CreditAmount.GetHashCode();
                if (this.CouponAmount != null) hashCode = hashCode * 59 + this.CouponAmount.GetHashCode();
                if (this.FlexipurchaseCouponAmount != null) hashCode = hashCode * 59 + this.FlexipurchaseCouponAmount.GetHashCode();
                if (this.StoredCardAmount != null) hashCode = hashCode * 59 + this.StoredCardAmount.GetHashCode();
                if (this.BonusAmount != null) hashCode = hashCode * 59 + this.BonusAmount.GetHashCode();
                if (this.DebtAmount != null) hashCode = hashCode * 59 + this.DebtAmount.GetHashCode();
                if (this.AdjustmentAmount != null) hashCode = hashCode * 59 + this.AdjustmentAmount.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.DiscountAmount != null) hashCode = hashCode * 59 + this.DiscountAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.RootResourceId != null) hashCode = hashCode * 59 + this.RootResourceId.GetHashCode();
                if (this.ParentResourceId != null) hashCode = hashCode * 59 + this.ParentResourceId.GetHashCode();
                if (this.TradeId != null) hashCode = hashCode * 59 + this.TradeId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                if (this.SubServiceTypeCode != null) hashCode = hashCode * 59 + this.SubServiceTypeCode.GetHashCode();
                if (this.SubServiceTypeName != null) hashCode = hashCode * 59 + this.SubServiceTypeName.GetHashCode();
                if (this.SubResourceTypeCode != null) hashCode = hashCode * 59 + this.SubResourceTypeCode.GetHashCode();
                if (this.SubResourceTypeName != null) hashCode = hashCode * 59 + this.SubResourceTypeName.GetHashCode();
                if (this.SubResourceId != null) hashCode = hashCode * 59 + this.SubResourceId.GetHashCode();
                if (this.SubResourceName != null) hashCode = hashCode * 59 + this.SubResourceName.GetHashCode();
                if (this.PreOrderId != null) hashCode = hashCode * 59 + this.PreOrderId.GetHashCode();
                if (this.AzCodeInfos != null) hashCode = hashCode * 59 + this.AzCodeInfos.GetHashCode();
                if (this.PayerAccountId != null) hashCode = hashCode * 59 + this.PayerAccountId.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ConsumeTime != null) hashCode = hashCode * 59 + this.ConsumeTime.GetHashCode();
                if (this.BeId != null) hashCode = hashCode * 59 + this.BeId.GetHashCode();
                if (this.ExtendParams != null) hashCode = hashCode * 59 + this.ExtendParams.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
