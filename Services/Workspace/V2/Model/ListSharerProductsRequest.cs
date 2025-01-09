using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSharerProductsRequest 
    {

        /// <summary>
        /// 产品ID。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 协同方数。该套餐支持的最大协同人数。
        /// </summary>
        [SDKProperty("share_space_size", IsQuery = true)]
        [JsonProperty("share_space_size", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareSpaceSize { get; set; }

        /// <summary>
        /// 周期套餐标识。0表示包周期，1表示按需, 6表示一次性计费。
        /// </summary>
        [SDKProperty("charge_mode", IsQuery = true)]
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 是否是GPU套餐。1表示GPU套餐，0表示非GPU套餐，默认null查询所有类型
        /// </summary>
        [SDKProperty("is_gpu", IsQuery = true)]
        [JsonProperty("is_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsGpu { get; set; }

        /// <summary>
        /// 套餐系列。user_sharer表示用户协同套餐，desktop_sharer表示桌面协同套餐
        /// </summary>
        [SDKProperty("package_type", IsQuery = true)]
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 每页数量，范围0-100，默认100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，默认0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSharerProductsRequest {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  shareSpaceSize: ").Append(ShareSpaceSize).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  isGpu: ").Append(IsGpu).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSharerProductsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSharerProductsRequest input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ShareSpaceSize != input.ShareSpaceSize || (this.ShareSpaceSize != null && !this.ShareSpaceSize.Equals(input.ShareSpaceSize))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.IsGpu != input.IsGpu || (this.IsGpu != null && !this.IsGpu.Equals(input.IsGpu))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ShareSpaceSize != null) hashCode = hashCode * 59 + this.ShareSpaceSize.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.IsGpu != null) hashCode = hashCode * 59 + this.IsGpu.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
