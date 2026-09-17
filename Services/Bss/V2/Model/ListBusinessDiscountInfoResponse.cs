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
    /// Response Object
    /// </summary>
    public class ListBusinessDiscountInfoResponse : SdkResponse
    {

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 商务ID
        /// </summary>
        [JsonProperty("commerce_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommerceId { get; set; }

        /// <summary>
        /// 商务编号
        /// </summary>
        [JsonProperty("commerce_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CommerceCode { get; set; }

        /// <summary>
        /// 商务生效时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 商务失效时间，UTC时间，格式：yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 产品报价项列表（quoting_item_type&#x3D;PRODUCT_ITEM时有值返回，否则返回空列表）
        /// </summary>
        [JsonProperty("product_quoting_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProductQuotingItem> ProductQuotingItems { get; set; }

        /// <summary>
        /// 分类报价项列表（quoting_item_type&#x3D;CATEGORY_ITEM时有值返回，否则返回空列表）
        /// </summary>
        [JsonProperty("category_quoting_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryQuotingItem> CategoryQuotingItems { get; set; }

        /// <summary>
        /// 分类报价项阶梯列表（quoting_item_type&#x3D;CATEGORY_ITEM时有值返回，否则返回空列表）
        /// </summary>
        [JsonProperty("category_quoting_item_steps", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryQuotingItemStep> CategoryQuotingItemSteps { get; set; }

        /// <summary>
        /// 阶梯累计周期类型，category_quoting_item_steps有值返回时返回
        /// </summary>
        [JsonProperty("accumulation_cycle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AccumulationCycleType { get; set; }

        /// <summary>
        /// 运营站点列表
        /// </summary>
        [JsonProperty("sites", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteInfo> Sites { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBusinessDiscountInfoResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  commerceId: ").Append(CommerceId).Append("\n");
            sb.Append("  commerceCode: ").Append(CommerceCode).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  productQuotingItems: ").Append(ProductQuotingItems).Append("\n");
            sb.Append("  categoryQuotingItems: ").Append(CategoryQuotingItems).Append("\n");
            sb.Append("  categoryQuotingItemSteps: ").Append(CategoryQuotingItemSteps).Append("\n");
            sb.Append("  accumulationCycleType: ").Append(AccumulationCycleType).Append("\n");
            sb.Append("  sites: ").Append(Sites).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBusinessDiscountInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBusinessDiscountInfoResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.CommerceId != input.CommerceId || (this.CommerceId != null && !this.CommerceId.Equals(input.CommerceId))) return false;
            if (this.CommerceCode != input.CommerceCode || (this.CommerceCode != null && !this.CommerceCode.Equals(input.CommerceCode))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.ProductQuotingItems != input.ProductQuotingItems || (this.ProductQuotingItems != null && input.ProductQuotingItems != null && !this.ProductQuotingItems.SequenceEqual(input.ProductQuotingItems))) return false;
            if (this.CategoryQuotingItems != input.CategoryQuotingItems || (this.CategoryQuotingItems != null && input.CategoryQuotingItems != null && !this.CategoryQuotingItems.SequenceEqual(input.CategoryQuotingItems))) return false;
            if (this.CategoryQuotingItemSteps != input.CategoryQuotingItemSteps || (this.CategoryQuotingItemSteps != null && input.CategoryQuotingItemSteps != null && !this.CategoryQuotingItemSteps.SequenceEqual(input.CategoryQuotingItemSteps))) return false;
            if (this.AccumulationCycleType != input.AccumulationCycleType || (this.AccumulationCycleType != null && !this.AccumulationCycleType.Equals(input.AccumulationCycleType))) return false;
            if (this.Sites != input.Sites || (this.Sites != null && input.Sites != null && !this.Sites.SequenceEqual(input.Sites))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.CommerceId != null) hashCode = hashCode * 59 + this.CommerceId.GetHashCode();
                if (this.CommerceCode != null) hashCode = hashCode * 59 + this.CommerceCode.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.ProductQuotingItems != null) hashCode = hashCode * 59 + this.ProductQuotingItems.GetHashCode();
                if (this.CategoryQuotingItems != null) hashCode = hashCode * 59 + this.CategoryQuotingItems.GetHashCode();
                if (this.CategoryQuotingItemSteps != null) hashCode = hashCode * 59 + this.CategoryQuotingItemSteps.GetHashCode();
                if (this.AccumulationCycleType != null) hashCode = hashCode * 59 + this.AccumulationCycleType.GetHashCode();
                if (this.Sites != null) hashCode = hashCode * 59 + this.Sites.GetHashCode();
                return hashCode;
            }
        }
    }
}
