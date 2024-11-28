using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CbcOrderChange 
    {

        /// <summary>
        /// 云服务ConsoleURL。订单支付完成后，客户可以通过此URL跳转到云服务Console页面查看信息
        /// </summary>
        [JsonProperty("cloud_service_console_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceConsoleUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("product_info", NullValueHandling = NullValueHandling.Ignore)]
        public CbcProductInfoOrderChange ProductInfo { get; set; }

        /// <summary>
        /// 待变更的资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 是否自动支付，默认非自动支付：false
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }

        /// <summary>
        /// 购买折扣
        /// </summary>
        [JsonProperty("promotion_info", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbcOrderChange {\n");
            sb.Append("  cloudServiceConsoleUrl: ").Append(CloudServiceConsoleUrl).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  promotionInfo: ").Append(PromotionInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CbcOrderChange);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CbcOrderChange input)
        {
            if (input == null) return false;
            if (this.CloudServiceConsoleUrl != input.CloudServiceConsoleUrl || (this.CloudServiceConsoleUrl != null && !this.CloudServiceConsoleUrl.Equals(input.CloudServiceConsoleUrl))) return false;
            if (this.ProductInfo != input.ProductInfo || (this.ProductInfo != null && !this.ProductInfo.Equals(input.ProductInfo))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;
            if (this.PromotionInfo != input.PromotionInfo || (this.PromotionInfo != null && !this.PromotionInfo.Equals(input.PromotionInfo))) return false;

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
                if (this.CloudServiceConsoleUrl != null) hashCode = hashCode * 59 + this.CloudServiceConsoleUrl.GetHashCode();
                if (this.ProductInfo != null) hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.PromotionInfo != null) hashCode = hashCode * 59 + this.PromotionInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
