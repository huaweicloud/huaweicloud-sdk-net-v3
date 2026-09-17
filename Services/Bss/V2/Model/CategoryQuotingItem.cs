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
    /// 分类报价项折扣信息
    /// </summary>
    public class CategoryQuotingItem 
    {

        /// <summary>
        /// 报价项ID
        /// </summary>
        [JsonProperty("item_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ItemId { get; set; }

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
        /// 商务资源类型
        /// </summary>
        [JsonProperty("commercial_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CommercialResourceType { get; set; }

        /// <summary>
        /// 资源类型编码
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 资源类型名称
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// SKU族编码
        /// </summary>
        [JsonProperty("sku_family_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuFamilyCode { get; set; }

        /// <summary>
        /// SKU族名称
        /// </summary>
        [JsonProperty("sku_family_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SkuFamilyName { get; set; }

        /// <summary>
        /// 归属站点编码
        /// </summary>
        [JsonProperty("site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// 可用区AZ编码
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 可用区AZ名称
        /// </summary>
        [JsonProperty("az_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AzName { get; set; }

        /// <summary>
        /// 阶梯编号
        /// </summary>
        [JsonProperty("step_no", NullValueHandling = NullValueHandling.Ignore)]
        public string StepNo { get; set; }

        /// <summary>
        /// 计费模式，ONDEMAND：按需、ONETIME：一次性、DAILY：包天、MONTHLY：包月、1_YEARLY：包1年、2_YEARLY：包2年、3_YEARLY：包3年、4_YEARLY：包4年、5_YEARLY：包5年、1_YEARLY_RI：包1年预留实例、3_YEARLY_RI：包3年预留实例
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingMode { get; set; }

        /// <summary>
        /// 折扣率
        /// </summary>
        [JsonProperty("discount_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DiscountRatio { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryQuotingItem {\n");
            sb.Append("  itemId: ").Append(ItemId).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  cloudServiceTypeName: ").Append(CloudServiceTypeName).Append("\n");
            sb.Append("  commercialResourceType: ").Append(CommercialResourceType).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  skuFamilyCode: ").Append(SkuFamilyCode).Append("\n");
            sb.Append("  skuFamilyName: ").Append(SkuFamilyName).Append("\n");
            sb.Append("  siteCode: ").Append(SiteCode).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  azName: ").Append(AzName).Append("\n");
            sb.Append("  stepNo: ").Append(StepNo).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  discountRatio: ").Append(DiscountRatio).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CategoryQuotingItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CategoryQuotingItem input)
        {
            if (input == null) return false;
            if (this.ItemId != input.ItemId || (this.ItemId != null && !this.ItemId.Equals(input.ItemId))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.CloudServiceTypeName != input.CloudServiceTypeName || (this.CloudServiceTypeName != null && !this.CloudServiceTypeName.Equals(input.CloudServiceTypeName))) return false;
            if (this.CommercialResourceType != input.CommercialResourceType || (this.CommercialResourceType != null && !this.CommercialResourceType.Equals(input.CommercialResourceType))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.SkuFamilyCode != input.SkuFamilyCode || (this.SkuFamilyCode != null && !this.SkuFamilyCode.Equals(input.SkuFamilyCode))) return false;
            if (this.SkuFamilyName != input.SkuFamilyName || (this.SkuFamilyName != null && !this.SkuFamilyName.Equals(input.SkuFamilyName))) return false;
            if (this.SiteCode != input.SiteCode || (this.SiteCode != null && !this.SiteCode.Equals(input.SiteCode))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.AzCode != input.AzCode || (this.AzCode != null && !this.AzCode.Equals(input.AzCode))) return false;
            if (this.AzName != input.AzName || (this.AzName != null && !this.AzName.Equals(input.AzName))) return false;
            if (this.StepNo != input.StepNo || (this.StepNo != null && !this.StepNo.Equals(input.StepNo))) return false;
            if (this.ChargingMode != input.ChargingMode || (this.ChargingMode != null && !this.ChargingMode.Equals(input.ChargingMode))) return false;
            if (this.DiscountRatio != input.DiscountRatio || (this.DiscountRatio != null && !this.DiscountRatio.Equals(input.DiscountRatio))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.CloudServiceTypeName != null) hashCode = hashCode * 59 + this.CloudServiceTypeName.GetHashCode();
                if (this.CommercialResourceType != null) hashCode = hashCode * 59 + this.CommercialResourceType.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.SkuFamilyCode != null) hashCode = hashCode * 59 + this.SkuFamilyCode.GetHashCode();
                if (this.SkuFamilyName != null) hashCode = hashCode * 59 + this.SkuFamilyName.GetHashCode();
                if (this.SiteCode != null) hashCode = hashCode * 59 + this.SiteCode.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.AzCode != null) hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.AzName != null) hashCode = hashCode * 59 + this.AzName.GetHashCode();
                if (this.StepNo != null) hashCode = hashCode * 59 + this.StepNo.GetHashCode();
                if (this.ChargingMode != null) hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.DiscountRatio != null) hashCode = hashCode * 59 + this.DiscountRatio.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
