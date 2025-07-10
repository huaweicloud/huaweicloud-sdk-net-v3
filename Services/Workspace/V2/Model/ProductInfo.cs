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
    public class ProductInfo 
    {

        /// <summary>
        /// 产品ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品规格ID。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 产品类型。  - BASE：表示产品基础套餐，套餐镜像中不包括除操作系统之外的其他商业软件，私有镜像场景只能使用此类套餐。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// CPU。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存。
        /// </summary>
        [JsonProperty("memory", NullValueHandling = NullValueHandling.Ignore)]
        public string Memory { get; set; }

        /// <summary>
        /// 产品描述。
        /// </summary>
        [JsonProperty("descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public string Descriptions { get; set; }

        /// <summary>
        /// 周期套餐标识，0表示包周期，1表示按需。
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 产品架构。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 是否是GPU类型的规格。
        /// </summary>
        [JsonProperty("is_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGpu { get; set; }

        /// <summary>
        /// 套餐类型。 - ultimate：尊享版 - enterprise：企业版 - general: 通用办公版 - workstation: 云工作站 - dedicated: 专属办公版 - solver: 解算版 - agile: 敏捷办公版
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// 系统盘类型。
        /// </summary>
        [JsonProperty("system_disk_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemDiskType { get; set; }

        /// <summary>
        /// 系统盘大小。
        /// </summary>
        [JsonProperty("system_disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemDiskSize { get; set; }

        /// <summary>
        /// 套餐计费是否包含了数据盘,off-不包含。
        /// </summary>
        [JsonProperty("contain_data_disk", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainDataDisk { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务类型。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 磁盘产品类型。
        /// </summary>
        [JsonProperty("volume_product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeProductType { get; set; }

        /// <summary>
        /// 默认在售状态，normal代表正常，sellout代表售空，abandon代表下线。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductInfo {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  memory: ").Append(Memory).Append("\n");
            sb.Append("  descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  isGpu: ").Append(IsGpu).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  systemDiskType: ").Append(SystemDiskType).Append("\n");
            sb.Append("  systemDiskSize: ").Append(SystemDiskSize).Append("\n");
            sb.Append("  containDataDisk: ").Append(ContainDataDisk).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  volumeProductType: ").Append(VolumeProductType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductInfo input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Memory != input.Memory || (this.Memory != null && !this.Memory.Equals(input.Memory))) return false;
            if (this.Descriptions != input.Descriptions || (this.Descriptions != null && !this.Descriptions.Equals(input.Descriptions))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.Architecture != input.Architecture || (this.Architecture != null && !this.Architecture.Equals(input.Architecture))) return false;
            if (this.IsGpu != input.IsGpu || (this.IsGpu != null && !this.IsGpu.Equals(input.IsGpu))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.SystemDiskType != input.SystemDiskType || (this.SystemDiskType != null && !this.SystemDiskType.Equals(input.SystemDiskType))) return false;
            if (this.SystemDiskSize != input.SystemDiskSize || (this.SystemDiskSize != null && !this.SystemDiskSize.Equals(input.SystemDiskSize))) return false;
            if (this.ContainDataDisk != input.ContainDataDisk || (this.ContainDataDisk != null && !this.ContainDataDisk.Equals(input.ContainDataDisk))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.VolumeProductType != input.VolumeProductType || (this.VolumeProductType != null && !this.VolumeProductType.Equals(input.VolumeProductType))) return false;
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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Memory != null) hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Descriptions != null) hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Architecture != null) hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.IsGpu != null) hashCode = hashCode * 59 + this.IsGpu.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.SystemDiskType != null) hashCode = hashCode * 59 + this.SystemDiskType.GetHashCode();
                if (this.SystemDiskSize != null) hashCode = hashCode * 59 + this.SystemDiskSize.GetHashCode();
                if (this.ContainDataDisk != null) hashCode = hashCode * 59 + this.ContainDataDisk.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.VolumeProductType != null) hashCode = hashCode * 59 + this.VolumeProductType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
