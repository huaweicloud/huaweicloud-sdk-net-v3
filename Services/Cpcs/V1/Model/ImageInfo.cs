using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageInfo 
    {

        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像所属的服务
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceType { get; set; }

        /// <summary>
        /// 镜像的系统架构： - **X86_64** : X86 - **ARRCH** : ARM
        /// </summary>
        [JsonProperty("arch_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ArchType { get; set; }

        /// <summary>
        /// 规格ID
        /// </summary>
        [JsonProperty("specification_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecificationId { get; set; }

        /// <summary>
        /// 镜像的录入时间，UNIX时间戳，单位毫秒
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 版本类型
        /// </summary>
        [JsonProperty("version_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionType { get; set; }

        /// <summary>
        /// domain白名单列表，多个之间用逗号分隔
        /// </summary>
        [JsonProperty("trust_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomain { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [JsonProperty("vendor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorName { get; set; }

        /// <summary>
        /// 厂商版本号
        /// </summary>
        [JsonProperty("vendor_image_version", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorImageVersion { get; set; }

        /// <summary>
        /// 密码服务依赖的(厂商)平台版本号
        /// </summary>
        [JsonProperty("ccsp_version_need", NullValueHandling = NullValueHandling.Ignore)]
        public string CcspVersionNeed { get; set; }

        /// <summary>
        /// 华为版本号
        /// </summary>
        [JsonProperty("hw_image_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HwImageVersion { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageInfo {\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  archType: ").Append(ArchType).Append("\n");
            sb.Append("  specificationId: ").Append(SpecificationId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  versionType: ").Append(VersionType).Append("\n");
            sb.Append("  trustDomain: ").Append(TrustDomain).Append("\n");
            sb.Append("  vendorName: ").Append(VendorName).Append("\n");
            sb.Append("  vendorImageVersion: ").Append(VendorImageVersion).Append("\n");
            sb.Append("  ccspVersionNeed: ").Append(CcspVersionNeed).Append("\n");
            sb.Append("  hwImageVersion: ").Append(HwImageVersion).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageInfo input)
        {
            if (input == null) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageName != input.ImageName || (this.ImageName != null && !this.ImageName.Equals(input.ImageName))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.ArchType != input.ArchType || (this.ArchType != null && !this.ArchType.Equals(input.ArchType))) return false;
            if (this.SpecificationId != input.SpecificationId || (this.SpecificationId != null && !this.SpecificationId.Equals(input.SpecificationId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.VersionType != input.VersionType || (this.VersionType != null && !this.VersionType.Equals(input.VersionType))) return false;
            if (this.TrustDomain != input.TrustDomain || (this.TrustDomain != null && !this.TrustDomain.Equals(input.TrustDomain))) return false;
            if (this.VendorName != input.VendorName || (this.VendorName != null && !this.VendorName.Equals(input.VendorName))) return false;
            if (this.VendorImageVersion != input.VendorImageVersion || (this.VendorImageVersion != null && !this.VendorImageVersion.Equals(input.VendorImageVersion))) return false;
            if (this.CcspVersionNeed != input.CcspVersionNeed || (this.CcspVersionNeed != null && !this.CcspVersionNeed.Equals(input.CcspVersionNeed))) return false;
            if (this.HwImageVersion != input.HwImageVersion || (this.HwImageVersion != null && !this.HwImageVersion.Equals(input.HwImageVersion))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageName != null) hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.ArchType != null) hashCode = hashCode * 59 + this.ArchType.GetHashCode();
                if (this.SpecificationId != null) hashCode = hashCode * 59 + this.SpecificationId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.VersionType != null) hashCode = hashCode * 59 + this.VersionType.GetHashCode();
                if (this.TrustDomain != null) hashCode = hashCode * 59 + this.TrustDomain.GetHashCode();
                if (this.VendorName != null) hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                if (this.VendorImageVersion != null) hashCode = hashCode * 59 + this.VendorImageVersion.GetHashCode();
                if (this.CcspVersionNeed != null) hashCode = hashCode * 59 + this.CcspVersionNeed.GetHashCode();
                if (this.HwImageVersion != null) hashCode = hashCode * 59 + this.HwImageVersion.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
