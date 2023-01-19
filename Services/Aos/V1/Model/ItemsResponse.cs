using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// items response
    /// </summary>
    public class ItemsResponse 
    {

        /// <summary>
        /// 执行计划中的资源类型，如：huaweicloud_evs_volume
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 执行计划中的用户定义的资源的名字，如：my_volume
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 使用count构建的资源时资源对应的index
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// 执行计划中的资源是否支持询价
        /// </summary>
        [JsonProperty("supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supported { get; set; }

        /// <summary>
        /// 执行计划中的每个资源部署后的总的询价信息，如果该资源询价结果包含不同的period_type，则询价结果根据period_type类型展示总价。 包周期计费和按需计费返回，免费和不支持询价的资源不返回
        /// </summary>
        [JsonProperty("resource_price", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourcePriceResponse> ResourcePrice { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemsResponse {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  supported: ").Append(Supported).Append("\n");
            sb.Append("  resourcePrice: ").Append(ResourcePrice).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Supported == input.Supported ||
                    (this.Supported != null &&
                    this.Supported.Equals(input.Supported))
                ) && 
                (
                    this.ResourcePrice == input.ResourcePrice ||
                    this.ResourcePrice != null &&
                    input.ResourcePrice != null &&
                    this.ResourcePrice.SequenceEqual(input.ResourcePrice)
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
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Supported != null)
                    hashCode = hashCode * 59 + this.Supported.GetHashCode();
                if (this.ResourcePrice != null)
                    hashCode = hashCode * 59 + this.ResourcePrice.GetHashCode();
                return hashCode;
            }
        }
    }
}
