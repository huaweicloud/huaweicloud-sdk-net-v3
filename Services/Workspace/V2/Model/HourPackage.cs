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
    /// 小时包套餐详情。
    /// </summary>
    public class HourPackage 
    {

        /// <summary>
        /// 资源所属云服务类型编码。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 小时包的资源规格编码。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 小时包对应的按需桌面的资源规格编码。
        /// </summary>
        [JsonProperty("desktop_resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopResourceSpecCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public ResourcePackageDescription Descriptions { get; set; }

        /// <summary>
        /// 套餐可使用时长，单位：小时。
        /// </summary>
        [JsonProperty("package_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? PackageDuration { get; set; }

        /// <summary>
        /// 该产品套餐支持的专有域id（domainId）。
        /// </summary>
        [JsonProperty("domain_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DomainIds { get; set; }

        /// <summary>
        /// 产品状态，normal：正常、sellout：售空、abandon：下线。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HourPackage {\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  desktopResourceSpecCode: ").Append(DesktopResourceSpecCode).Append("\n");
            sb.Append("  descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  packageDuration: ").Append(PackageDuration).Append("\n");
            sb.Append("  domainIds: ").Append(DomainIds).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HourPackage);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HourPackage input)
        {
            if (input == null) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.DesktopResourceSpecCode != input.DesktopResourceSpecCode || (this.DesktopResourceSpecCode != null && !this.DesktopResourceSpecCode.Equals(input.DesktopResourceSpecCode))) return false;
            if (this.Descriptions != input.Descriptions || (this.Descriptions != null && !this.Descriptions.Equals(input.Descriptions))) return false;
            if (this.PackageDuration != input.PackageDuration || (this.PackageDuration != null && !this.PackageDuration.Equals(input.PackageDuration))) return false;
            if (this.DomainIds != input.DomainIds || (this.DomainIds != null && input.DomainIds != null && !this.DomainIds.SequenceEqual(input.DomainIds))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.DesktopResourceSpecCode != null) hashCode = hashCode * 59 + this.DesktopResourceSpecCode.GetHashCode();
                if (this.Descriptions != null) hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                if (this.PackageDuration != null) hashCode = hashCode * 59 + this.PackageDuration.GetHashCode();
                if (this.DomainIds != null) hashCode = hashCode * 59 + this.DomainIds.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
