using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MarketplaceEngineProduct 
    {

        /// <summary>
        /// 引擎ID。
        /// </summary>
        [JsonProperty("engine_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineId { get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 云市场规格ID。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 云市场商品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 服务商名称。
        /// </summary>
        [JsonProperty("bp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BpName { get; set; }

        /// <summary>
        /// 服务商ID。
        /// </summary>
        [JsonProperty("bp_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BpDomainId { get; set; }

        /// <summary>
        /// 支持的实例类型。  - Single: 单机实例 - Ha: 主备实例 - Replica: 只读实例 - All: 以上类型都支持
        /// </summary>
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 用户许可。
        /// </summary>
        [JsonProperty("user_license_agreement", NullValueHandling = NullValueHandling.Ignore)]
        public string UserLicenseAgreement { get; set; }

        /// <summary>
        /// 许可详情列表。
        /// </summary>
        [JsonProperty("agreements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Agreement> Agreements { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarketplaceEngineProduct {\n");
            sb.Append("  engineId: ").Append(EngineId).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  bpName: ").Append(BpName).Append("\n");
            sb.Append("  bpDomainId: ").Append(BpDomainId).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  userLicenseAgreement: ").Append(UserLicenseAgreement).Append("\n");
            sb.Append("  agreements: ").Append(Agreements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MarketplaceEngineProduct);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MarketplaceEngineProduct input)
        {
            if (input == null) return false;
            if (this.EngineId != input.EngineId || (this.EngineId != null && !this.EngineId.Equals(input.EngineId))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.SpecCode != input.SpecCode || (this.SpecCode != null && !this.SpecCode.Equals(input.SpecCode))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.BpName != input.BpName || (this.BpName != null && !this.BpName.Equals(input.BpName))) return false;
            if (this.BpDomainId != input.BpDomainId || (this.BpDomainId != null && !this.BpDomainId.Equals(input.BpDomainId))) return false;
            if (this.InstanceMode != input.InstanceMode || (this.InstanceMode != null && !this.InstanceMode.Equals(input.InstanceMode))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.UserLicenseAgreement != input.UserLicenseAgreement || (this.UserLicenseAgreement != null && !this.UserLicenseAgreement.Equals(input.UserLicenseAgreement))) return false;
            if (this.Agreements != input.Agreements || (this.Agreements != null && input.Agreements != null && !this.Agreements.SequenceEqual(input.Agreements))) return false;

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
                if (this.EngineId != null) hashCode = hashCode * 59 + this.EngineId.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.SpecCode != null) hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.BpName != null) hashCode = hashCode * 59 + this.BpName.GetHashCode();
                if (this.BpDomainId != null) hashCode = hashCode * 59 + this.BpDomainId.GetHashCode();
                if (this.InstanceMode != null) hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.UserLicenseAgreement != null) hashCode = hashCode * 59 + this.UserLicenseAgreement.GetHashCode();
                if (this.Agreements != null) hashCode = hashCode * 59 + this.Agreements.GetHashCode();
                return hashCode;
            }
        }
    }
}
