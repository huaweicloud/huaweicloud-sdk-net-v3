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
    /// 
    /// </summary>
    public class SharerProductInfo 
    {

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 是否是GPU类型的规格。
        /// </summary>
        [JsonProperty("is_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGpu { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string Descriptions { get; set; }

        /// <summary>
        /// 周期套餐标识。0表示包周期，1表示按需, 6表示一次性计费。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 资源规格。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务编码。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 套餐类型。 - user_sharer：用户协同套餐 - desktop_sharer: 桌面协同套餐
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 产品名称&lt;语言，各语言对应的产品名&gt;。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Name { get; set; }

        /// <summary>
        /// 协同方数。该套餐支持的最大协同人数。
        /// </summary>
        [JsonProperty("share_space_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShareSpaceSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharerProductInfo {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  isGpu: ").Append(IsGpu).Append("\n");
            sb.Append("  descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shareSpaceSize: ").Append(ShareSpaceSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SharerProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SharerProductInfo input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.IsGpu != input.IsGpu || (this.IsGpu != null && !this.IsGpu.Equals(input.IsGpu))) return false;
            if (this.Descriptions != input.Descriptions || (this.Descriptions != null && !this.Descriptions.Equals(input.Descriptions))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.ShareSpaceSize != input.ShareSpaceSize || (this.ShareSpaceSize != null && !this.ShareSpaceSize.Equals(input.ShareSpaceSize))) return false;

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
                if (this.IsGpu != null) hashCode = hashCode * 59 + this.IsGpu.GetHashCode();
                if (this.Descriptions != null) hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShareSpaceSize != null) hashCode = hashCode * 59 + this.ShareSpaceSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
