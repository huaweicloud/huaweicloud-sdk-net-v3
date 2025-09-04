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
    public class OrderLineItemEntityV2 
    {

        /// <summary>
        /// 订单项ID。
        /// </summary>
        [JsonProperty("order_line_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderLineItemId { get; set; }

        /// <summary>
        /// 云服务类型编码。例如OBS的云服务类型编码为“hws.service.type.obs”。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品规格描述。
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }

        /// <summary>
        /// 周期类型。 0：天1：周2：月3：年4：小时5：一次性6：按需（预留）7：按用量报表使用（预留）
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodType { get; set; }

        /// <summary>
        /// 周期数量。  说明： 当订单为退订资源的订单时，参数取值为null。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 生效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 订购数量。
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }

        /// <summary>
        /// 订单优惠后金额（实付价格，不含券不含卡）。
        /// </summary>
        [JsonProperty("amount_after_discount", NullValueHandling = NullValueHandling.Ignore)]
        public double? AmountAfterDiscount { get; set; }

        /// <summary>
        /// 订单金额（官网价）。 退订订单中，该金额等于currencyAfterDiscount。
        /// </summary>
        [JsonProperty("official_amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? OfficialAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount_info", NullValueHandling = NullValueHandling.Ignore)]
        public AmountInfomationV2 AmountInfo { get; set; }

        /// <summary>
        /// 货币编码。
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// 产品目录编码。
        /// </summary>
        [JsonProperty("category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 产品归属的云服务类型编码。 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("product_owner_service", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductOwnerService { get; set; }

        /// <summary>
        /// 商务归属的资源类型编码。 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。
        /// </summary>
        [JsonProperty("commercial_resource", NullValueHandling = NullValueHandling.Ignore)]
        public string CommercialResource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_product_info", NullValueHandling = NullValueHandling.Ignore)]
        public ProductObject BaseProductInfo { get; set; }

        /// <summary>
        /// 订单ID。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderLineItemEntityV2 {\n");
            sb.Append("  orderLineItemId: ").Append(OrderLineItemId).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("  amountAfterDiscount: ").Append(AmountAfterDiscount).Append("\n");
            sb.Append("  officialAmount: ").Append(OfficialAmount).Append("\n");
            sb.Append("  amountInfo: ").Append(AmountInfo).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("  categoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  productOwnerService: ").Append(ProductOwnerService).Append("\n");
            sb.Append("  commercialResource: ").Append(CommercialResource).Append("\n");
            sb.Append("  baseProductInfo: ").Append(BaseProductInfo).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderLineItemEntityV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderLineItemEntityV2 input)
        {
            if (input == null) return false;
            if (this.OrderLineItemId != input.OrderLineItemId || (this.OrderLineItemId != null && !this.OrderLineItemId.Equals(input.OrderLineItemId))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;
            if (this.AmountAfterDiscount != input.AmountAfterDiscount || (this.AmountAfterDiscount != null && !this.AmountAfterDiscount.Equals(input.AmountAfterDiscount))) return false;
            if (this.OfficialAmount != input.OfficialAmount || (this.OfficialAmount != null && !this.OfficialAmount.Equals(input.OfficialAmount))) return false;
            if (this.AmountInfo != input.AmountInfo || (this.AmountInfo != null && !this.AmountInfo.Equals(input.AmountInfo))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;
            if (this.CategoryCode != input.CategoryCode || (this.CategoryCode != null && !this.CategoryCode.Equals(input.CategoryCode))) return false;
            if (this.ProductOwnerService != input.ProductOwnerService || (this.ProductOwnerService != null && !this.ProductOwnerService.Equals(input.ProductOwnerService))) return false;
            if (this.CommercialResource != input.CommercialResource || (this.CommercialResource != null && !this.CommercialResource.Equals(input.CommercialResource))) return false;
            if (this.BaseProductInfo != input.BaseProductInfo || (this.BaseProductInfo != null && !this.BaseProductInfo.Equals(input.BaseProductInfo))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;

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
                if (this.OrderLineItemId != null) hashCode = hashCode * 59 + this.OrderLineItemId.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                if (this.AmountAfterDiscount != null) hashCode = hashCode * 59 + this.AmountAfterDiscount.GetHashCode();
                if (this.OfficialAmount != null) hashCode = hashCode * 59 + this.OfficialAmount.GetHashCode();
                if (this.AmountInfo != null) hashCode = hashCode * 59 + this.AmountInfo.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CategoryCode != null) hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.ProductOwnerService != null) hashCode = hashCode * 59 + this.ProductOwnerService.GetHashCode();
                if (this.CommercialResource != null) hashCode = hashCode * 59 + this.CommercialResource.GetHashCode();
                if (this.BaseProductInfo != null) hashCode = hashCode * 59 + this.BaseProductInfo.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
