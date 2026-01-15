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
    public class ListProductsRequest 
    {

        /// <summary>
        /// 产品ID。指定该参数会返回支持变更规格的套餐信息。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 可用分区。
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 产品套餐的操作系统类型，当前支持：Windows、Linux。
        /// </summary>
        [SDKProperty("os_type", IsQuery = true)]
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 周期套餐标识。0表示包周期，1表示按需。
        /// </summary>
        [SDKProperty("charge_mode", IsQuery = true)]
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 架构类型，当前支持：arm、x86。
        /// </summary>
        [SDKProperty("architecture", IsQuery = true)]
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 套餐系列。
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
            sb.Append("class ListProductsRequest {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
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
            return this.Equals(input as ListProductsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProductsRequest input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.OsType != input.OsType || (this.OsType != null && !this.OsType.Equals(input.OsType))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.Architecture != input.Architecture || (this.Architecture != null && !this.Architecture.Equals(input.Architecture))) return false;
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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.OsType != null) hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Architecture != null) hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
