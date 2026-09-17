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
    /// 产品报价项折扣信息
    /// </summary>
    public class ProductQuotingItem 
    {

        /// <summary>
        /// 报价项ID
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品规格名称
        /// </summary>
        [JsonProperty("product_spec_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecName { get; set; }

        /// <summary>
        /// 云服务编码
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("cloud_service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceTypeName { get; set; }

        /// <summary>
        /// 运营站点编码
        /// </summary>
        [JsonProperty("site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 产品关联的云服务区信息列表
        /// </summary>
        [JsonProperty("related_regions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RegionInfo> RelatedRegions { get; set; }

        /// <summary>
        /// 计费事件编码
        /// </summary>
        [JsonProperty("charge_event_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeEventCode { get; set; }

        /// <summary>
        /// 计费模式，ONDEMAND：按需、ONETIME：一次性、DAILY：包天、MONTHLY：包月、1_YEARLY：包1年、2_YEARLY：包2年、3_YEARLY：包3年、4_YEARLY：包4年、5_YEARLY：包5年、1_YEARLY_RI：包1年预留实例、3_YEARLY_RI：包3年预留实例
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 优惠分类：0：普通优惠，1：产品阶梯，2：分时优惠
        /// </summary>
        [JsonProperty("preferential_category", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreferentialCategory { get; set; }

        /// <summary>
        /// 优惠方式：0：产品折扣，1：固定单价
        /// </summary>
        [JsonProperty("preferential_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? PreferentialType { get; set; }

        /// <summary>
        /// 固定单价（preferential_type&#x3D;1固定单价时有值）
        /// </summary>
        [JsonProperty("sales_price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? SalesPrice { get; set; }

        /// <summary>
        /// 折扣率（preferential_type&#x3D;0产品折扣时有值）
        /// </summary>
        [JsonProperty("discount_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountRatio { get; set; }

        /// <summary>
        /// 计费单位
        /// </summary>
        [JsonProperty("pricing_basis", NullValueHandling = NullValueHandling.Ignore)]
        public string PricingBasis { get; set; }

        /// <summary>
        /// 报价项生效时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 报价项失效时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 产品报价项阶梯列表，产品阶梯或分时优惠时有值返回，否则返回空列表
        /// </summary>
        [JsonProperty("product_quoting_item_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductQuotingItemStep> ProductQuotingItemSteps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductQuotingItem {\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productSpecName: ").Append(ProductSpecName).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  siteCode: ").Append(SiteCode).Append("\n");
            sb.Append("  relatedRegions: ").Append(RelatedRegions).Append("\n");
            sb.Append("  chargeEventCode: ").Append(ChargeEventCode).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  preferentialCategory: ").Append(PreferentialCategory).Append("\n");
            sb.Append("  preferentialType: ").Append(PreferentialType).Append("\n");
            sb.Append("  salesPrice: ").Append(SalesPrice).Append("\n");
            sb.Append("  discountRatio: ").Append(DiscountRatio).Append("\n");
            sb.Append("  pricingBasis: ").Append(PricingBasis).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  productQuotingItemSteps: ").Append(ProductQuotingItemSteps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductQuotingItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductQuotingItem input)
        {
            if (input == null) return false;
            if (this.ItemId != input.ItemId || (this.ItemId != null && !this.ItemId.Equals(input.ItemId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductSpecName != input.ProductSpecName || (this.ProductSpecName != null && !this.ProductSpecName.Equals(input.ProductSpecName))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.SiteCode != input.SiteCode || (this.SiteCode != null && !this.SiteCode.Equals(input.SiteCode))) return false;
            if (this.RelatedRegions != input.RelatedRegions || (this.RelatedRegions != null && input.RelatedRegions != null && !this.RelatedRegions.SequenceEqual(input.RelatedRegions))) return false;
            if (this.ChargeEventCode != input.ChargeEventCode || (this.ChargeEventCode != null && !this.ChargeEventCode.Equals(input.ChargeEventCode))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.PreferentialCategory != input.PreferentialCategory || (this.PreferentialCategory != null && !this.PreferentialCategory.Equals(input.PreferentialCategory))) return false;
            if (this.PreferentialType != input.PreferentialType || (this.PreferentialType != null && !this.PreferentialType.Equals(input.PreferentialType))) return false;
            if (this.SalesPrice != input.SalesPrice || (this.SalesPrice != null && !this.SalesPrice.Equals(input.SalesPrice))) return false;
            if (this.DiscountRatio != input.DiscountRatio || (this.DiscountRatio != null && !this.DiscountRatio.Equals(input.DiscountRatio))) return false;
            if (this.PricingBasis != input.PricingBasis || (this.PricingBasis != null && !this.PricingBasis.Equals(input.PricingBasis))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ProductQuotingItemSteps != input.ProductQuotingItemSteps || (this.ProductQuotingItemSteps != null && input.ProductQuotingItemSteps != null && !this.ProductQuotingItemSteps.SequenceEqual(input.ProductQuotingItemSteps))) return false;

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
                if (this.ItemId != null) hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductSpecName != null) hashCode = hashCode * 59 + this.ProductSpecName.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.SiteCode != null) hashCode = hashCode * 59 + this.SiteCode.GetHashCode();
                if (this.RelatedRegions != null) hashCode = hashCode * 59 + this.RelatedRegions.GetHashCode();
                if (this.ChargeEventCode != null) hashCode = hashCode * 59 + this.ChargeEventCode.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.PreferentialCategory != null) hashCode = hashCode * 59 + this.PreferentialCategory.GetHashCode();
                if (this.PreferentialType != null) hashCode = hashCode * 59 + this.PreferentialType.GetHashCode();
                if (this.SalesPrice != null) hashCode = hashCode * 59 + this.SalesPrice.GetHashCode();
                if (this.DiscountRatio != null) hashCode = hashCode * 59 + this.DiscountRatio.GetHashCode();
                if (this.PricingBasis != null) hashCode = hashCode * 59 + this.PricingBasis.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ProductQuotingItemSteps != null) hashCode = hashCode * 59 + this.ProductQuotingItemSteps.GetHashCode();
                return hashCode;
            }
        }
    }
}
