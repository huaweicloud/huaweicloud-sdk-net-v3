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
    public class CbcUpdate 
    {

        /// <summary>
        /// 云服务ConsoleURL。订单支付完成后，客户可以通过此URL跳转到云服务Console页面查看信息
        /// </summary>
        [JsonProperty("cloudServiceConsoleURL", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceConsoleURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("productInfo", NullValueHandling = NullValueHandling.Ignore)]
        public CbcProductInfoUpdate ProductInfo { get; set; }

        /// <summary>
        /// 待变更的资源ID
        /// </summary>
        [JsonProperty("resourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

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
            sb.Append("class CbcUpdate {\n");
            sb.Append("  cloudServiceConsoleURL: ").Append(CloudServiceConsoleURL).Append("\n");
            sb.Append("  productInfo: ").Append(ProductInfo).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  promotionInfo: ").Append(PromotionInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CbcUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CbcUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudServiceConsoleURL == input.CloudServiceConsoleURL ||
                    (this.CloudServiceConsoleURL != null &&
                    this.CloudServiceConsoleURL.Equals(input.CloudServiceConsoleURL))
                ) && 
                (
                    this.ProductInfo == input.ProductInfo ||
                    (this.ProductInfo != null &&
                    this.ProductInfo.Equals(input.ProductInfo))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.PromotionInfo == input.PromotionInfo ||
                    (this.PromotionInfo != null &&
                    this.PromotionInfo.Equals(input.PromotionInfo))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CloudServiceConsoleURL != null)
                    hashCode = hashCode * 59 + this.CloudServiceConsoleURL.GetHashCode();
                if (this.ProductInfo != null)
                    hashCode = hashCode * 59 + this.ProductInfo.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.PromotionInfo != null)
                    hashCode = hashCode * 59 + this.PromotionInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
